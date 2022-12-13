using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositorySalary : Repository
	{
		public Result<List<Models.EmployeeSalary>> GetEmployeeSalaries(DateOnly? monthAndYear)
		{
			DateOnly date = monthAndYear ?? DateOnly.FromDateTime(DateTime.Now);

			var endOfThisMonth = $"(make_date({date.Year}, {date.Month}, 1) + interval '1 month - 1 day')";
			var totalCoefficient = $"(emp.coefficient_allowance + rank.coefficient + 0.33 * TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone))";

			var query = Context.EmployeeSalaries.FromSqlRaw(@$"
				SELECT 
					make_date({date.Year}, {date.Month}, 1) AS date,
					emp.id AS employee_id,
					emp.name AS employee_name,
					unit.id AS unit_id,
					unit.name AS unit_name,
					TRUNC({totalCoefficient}::numeric, 2) AS total_coefficient,
					emp.coefficient_allowance AS employee_allowance_coefficient,
					pos.base_salary AS base_salary,
					coalesce(total_qualification_allowance.total, 0) AS total_qualification_allowance,
					TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone) AS rank_level,
					TRUNC(rank.coefficient::numeric, 2) AS rank_coefficient,
					rank.name AS rank_name,
					ROUND(coalesce(total_qualification_allowance.total, 0) + pos.base_salary * {totalCoefficient})::numeric AS salary 
				FROM (
					SELECT DISTINCT ON (employee_id) employee_id, unit_id, start_date, end_date
					FROM unit_histories
					WHERE start_date < {endOfThisMonth} 
						AND (end_date IS NULL OR end_date >= {endOfThisMonth})
				) AS uh 
					INNER JOIN position_histories AS ph 
						ON ph.employee_id = uh.employee_id 
						AND ph.start_date < {endOfThisMonth}
						AND (ph.end_date IS NULL OR ph.end_date >= {endOfThisMonth})
					INNER JOIN employees AS emp 
						ON emp.id = uh.employee_id
					LEFT JOIN (
						SELECT SUM(lastest_qua_allowance.allowance) AS total, emp.id AS employee_id
						FROM qualifications AS qa
							INNER JOIN employee_qualifications AS emp_qa 
								ON qa.id = emp_qa.qualification_id
							INNER JOIN employees AS emp 
								ON emp.id = emp_qa.employee_id
							INNER JOIN (
								SELECT id,
								(SELECT allowance FROM qualification_allowance_histories AS qah 
									WHERE year <= {date.Year} AND qah.qualification_id = qualifications.id
									ORDER BY year DESC
									LIMIT 1
								) AS allowance
								FROM qualifications 
							) AS lastest_qua_allowance
								ON lastest_qua_allowance.id = qa.id
						WHERE emp_qa.employee_id = emp.id
						GROUP BY emp.id
					) AS total_qualification_allowance
						ON total_qualification_allowance.employee_id = emp.id
					INNER JOIN units AS unit 
						ON unit.id = uh.unit_id
					INNER JOIN positions AS pos 
						ON pos.id = ph.position_id
					INNER JOIN ranks AS rank 
						ON rank.id = pos.rank_id
			");

			return new() { Success = true, Payload = query.ToList() };
		}
		public Result<List<Models.EmployeeSalary>> GetEmployeeSalariesAtUnit(string unitId, DateOnly? monthAndYear)
		{
			DateOnly date = monthAndYear ?? DateOnly.FromDateTime(DateTime.Now);

			if (!new RepositoryUnit().CheckUnitExists(unitId))
			{
				return new() { Success = false, ErrorMessage = "Unit of this id does not exists" };
			}

			var endOfThisMonth = $"(make_date({date.Year}, {date.Month}, 1) + interval '1 month - 1 day')";
			var totalCoefficient = $"(emp.coefficient_allowance + rank.coefficient + 0.33 * TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone))";

			var query = Context.EmployeeSalaries.FromSqlRaw(@$"
				SELECT 
					make_date({date.Year}, {date.Month}, 1) AS date,
					emp.id AS employee_id,
					emp.name AS employee_name,
					unit.id AS unit_id,
					unit.name AS unit_name,
					TRUNC({totalCoefficient}::numeric, 2) AS total_coefficient,
					emp.coefficient_allowance AS employee_allowance_coefficient,
					pos.base_salary AS base_salary,
					coalesce(total_qualification_allowance.total, 0) AS total_qualification_allowance,
					TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone) AS rank_level,
					TRUNC(rank.coefficient::numeric, 2) AS rank_coefficient,
					rank.name AS rank_name,
					ROUND(coalesce(total_qualification_allowance.total, 0) + pos.base_salary * {totalCoefficient})::numeric AS salary 
				FROM (
					SELECT DISTINCT ON (employee_id) employee_id, unit_id, start_date, end_date
					FROM unit_histories
					WHERE unit_id = '{unitId}'
						AND start_date < {endOfThisMonth} 
						AND (end_date IS NULL OR end_date >= {endOfThisMonth})
				) AS uh 
					INNER JOIN position_histories AS ph 
						ON ph.employee_id = uh.employee_id 
						AND ph.start_date < {endOfThisMonth}
						AND (ph.end_date IS NULL OR ph.end_date >= {endOfThisMonth})
					INNER JOIN employees AS emp 
						ON emp.id = uh.employee_id
					LEFT JOIN (
						SELECT SUM(lastest_qua_allowance.allowance) AS total, emp.id AS employee_id
						FROM qualifications AS qa
							INNER JOIN employee_qualifications AS emp_qa 
								ON qa.id = emp_qa.qualification_id
							INNER JOIN employees AS emp 
								ON emp.id = emp_qa.employee_id
							INNER JOIN (
								SELECT id,
								(SELECT allowance FROM qualification_allowance_histories AS qah 
									WHERE year <= {date.Year} AND qah.qualification_id = qualifications.id
									ORDER BY year DESC
									LIMIT 1
								) AS allowance
								FROM qualifications 
							) AS lastest_qua_allowance
								ON lastest_qua_allowance.id = qa.id
						WHERE emp_qa.employee_id = emp.id
						GROUP BY emp.id
					) AS total_qualification_allowance
						ON total_qualification_allowance.employee_id = emp.id
					INNER JOIN units AS unit 
						ON unit.id = uh.unit_id
					INNER JOIN positions AS pos 
						ON pos.id = ph.position_id
					INNER JOIN ranks AS rank 
						ON rank.id = pos.rank_id
			");

			return new() { Success = true, Payload = query.ToList() };
		}

		public Result<Models.EmployeeSalary> GetEmployeeSalary(string employeeId, DateOnly? monthAndYear = null)
		{
			DateOnly date = monthAndYear ?? DateOnly.FromDateTime(DateTime.Now);

			if (!new RepositoryEmployee().CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exists" };
			}

			var endOfThisMonth = $"(make_date({date.Year}, {date.Month}, 1) + interval '1 month - 1 day')";
			var totalCoefficient = $"(emp.coefficient_allowance + rank.coefficient + 0.33 * TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone))";

			var query = Context.EmployeeSalaries.FromSqlRaw(@$"
				SELECT 
					make_date({date.Year}, {date.Month}, 1) AS date,
					emp.id AS employee_id,
					emp.name AS employee_name,
					unit.id AS unit_id,
					unit.name AS unit_name,
					TRUNC({totalCoefficient}::numeric, 2) AS total_coefficient,
					pos.base_salary AS base_salary,
					emp.coefficient_allowance AS employee_allowance_coefficient,
					coalesce(total_qualification_allowance.total, 0) AS total_qualification_allowance,
					TRUNC(1 + ({date.Year} - EXTRACT(YEAR FROM emp.start_date)) / rank.milestone) AS rank_level,
					TRUNC(rank.coefficient::numeric, 2) AS rank_coefficient,
					rank.name AS rank_name,
					ROUND(coalesce(total_qualification_allowance.total, 0) + pos.base_salary * {totalCoefficient})::numeric AS salary 
				FROM (
					SELECT DISTINCT ON (employee_id) employee_id, unit_id, start_date, end_date
					FROM unit_histories
					WHERE employee_id = '{employeeId}'
						AND start_date < {endOfThisMonth} 
						AND (end_date IS NULL OR end_date >= {endOfThisMonth})
				) AS uh 
					INNER JOIN position_histories AS ph 
						ON ph.employee_id = uh.employee_id 
						AND ph.start_date < {endOfThisMonth}
						AND (ph.end_date IS NULL OR ph.end_date >= {endOfThisMonth})
					INNER JOIN employees AS emp 
						ON emp.id = uh.employee_id
					LEFT JOIN (
						SELECT SUM(lastest_qua_allowance.allowance) AS total, emp.id AS employee_id
						FROM qualifications AS qa
							INNER JOIN employee_qualifications AS emp_qa 
								ON qa.id = emp_qa.qualification_id
							INNER JOIN employees AS emp 
								ON emp.id = emp_qa.employee_id
							INNER JOIN (
								SELECT id,
								(SELECT allowance FROM qualification_allowance_histories AS qah 
									WHERE year <= {date.Year} AND qah.qualification_id = qualifications.id
									ORDER BY year DESC
									LIMIT 1
								) AS allowance
								FROM qualifications 
							) AS lastest_qua_allowance
								ON lastest_qua_allowance.id = qa.id
						WHERE emp_qa.employee_id = emp.id
						GROUP BY emp.id
					) AS total_qualification_allowance
						ON total_qualification_allowance.employee_id = emp.id
					INNER JOIN units AS unit 
						ON unit.id = uh.unit_id
					INNER JOIN positions AS pos 
						ON pos.id = ph.position_id
					INNER JOIN ranks AS rank 
						ON rank.id = pos.rank_id
			");

			var payload = query.FirstOrDefault();
			if (payload == null)
			{
				return new() { Success = false, ErrorMessage = "This Employee is currently not in any Unit or Position" };
			}

			return new() { Success = true, Payload = payload };
		}
		public Result<List<Models.EmployeeSalary>> GetEmployeeSalaryAtYear(string employeeId, int? year = null)
		{
			if (!new RepositoryEmployee().CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exists" };
			}

			var payload = new List<Models.EmployeeSalary>();

			for (int i = 1; i <= 12; i++)
			{
				var res = GetEmployeeSalary(employeeId, new DateOnly(year ?? DateTime.Now.Year, i, 1));
				if (res.Success)
				{
					payload.Add(res.Payload!);
				}
			}

			return new() { Success = true, Payload = payload };
		}

	}
}

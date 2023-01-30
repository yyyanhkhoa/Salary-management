using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using Salary_management.Infrastructure.Entities.Enums;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryEmployee : Repository
	{
		public bool CheckIdCardExist(string identityCardNumber)
			=> Context.Employees.Any(a => a.IdentityCardNumber == identityCardNumber);


		public bool CheckEmployeeExists(string id)
			=> Context.Employees.Any(a => a.Id == id);


		public Result<Models.Employee> InsertEmployee(EmployeeInput input)
		{
			if (CheckIdCardExist(input.IdentityCardNumber))
				return new Result<Models.Employee> { Success = false, ErrorMessage = "Employee with this ID card already exists." };

			var employee = MapToEntity(input);
			Context.Employees.Add(employee);
			Context.SaveChanges();

			return new Result<Models.Employee> { Success = true, Payload = MapToModel(employee) };

		}

		/// <summary>
		/// Lấy thông tin các nhân viên theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả nhân viên mới nhất
		/// </summary>
		/// <param name="searchString"></param>
		/// <returns></returns>
		public List<Models.Employee> GetEmployees(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Employees.Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Employees.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
					.Select(e => MapToModel(e)).ToList();
			}
		}

		public Result<Models.EmployeeDetail> FixEmployee(string id, EmployeeInput input)
		{
			var employee = MapToEntity(input);
			employee.Id = id;
			Context.Employees.Update(employee);
			Context.SaveChanges();

			return new() { Success = true, Payload = MapToModelEmployeeDetail(employee) };
		}

		public void DeleteEmployee(string id)
		{
			var employee = new Employee { Id = id };
			Context.Employees.Attach(employee);
			Context.Employees.Remove(employee);
			Context.SaveChanges();
		}


		public Models.EmployeeDetail GetEmployeeDetail(string id)
		{
			return MapToModelEmployeeDetail(Context.Employees.Where(e => e.Id == id).First()!);
		}

		public Result<List<Models.UnionHistory>> GetEmployeeUnionHistory(string employeeId)
		{
			if (!CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}


			var query = Context.UnionHistories.Where(uh => uh.EmployeeId == employeeId)
							   .Include(uh => uh.Union);
			return new()
			{
				Success = true,
				Payload = Helper.GetTimelineByDateRange(query, null, null)
								.Select(uh => MapToModel(uh))
								.ToList()
			};
		}

		public Result<List<Models.UnitHistory>> GetEmployeeUnitHistory(string employeeId)
		{
			if (!CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}

			var query = Context.UnitHistories.Where(uh => uh.EmployeeId == employeeId)
							   .Include(uh => uh.Unit);
			return new()
			{
				Success = true,
				Payload = Helper.GetTimelineByDateRange(query, null, null)
								.Select(uh => MapToModel(uh))
								.ToList()
			};
		}

		public Result<List<Models.PositionHistory>> GetEmployeePositionHistory(string employeeId)
		{
			if (!CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}

			var query = Context.PositionHistories.Where(uh => uh.EmployeeId == employeeId)
							   .Include(uh => uh.Position);
			return new()
			{
				Success = true,
				Payload = Helper.GetTimelineByDateRange(query, null, null)
								.Select(uh => MapToModel(uh))
								.ToList()
			};
		}

		/// <summary>
		/// Lấy thân nhân của nhân viên
		/// </summary>
		/// <param name="employeeId">id nhân viên</param>
		/// <param name="relativeType">loại thân nhân muốn lấy, nếu để null thì sẽ lấy hết tất cả loại thân nhân</param>
		/// <returns></returns>
		public Result<List<Models.Family>> GetEmployeeFamilies(string employeeId, RelativeType? relativeType = null)
		{
			if (!CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}

			var query = Context.Families.Include(f => f.Employee)
								.Where(f => f.EmployeeId == employeeId);

			if (relativeType != null)
			{
				query = query.Where(f => f.RelativeType == relativeType);
			}

			return new()
			{
				Success = true,
				Payload = query.Select(uh => MapToModel(uh))
							   .ToList()
			};
		}

		public Result<List<Models.EmployeeQualification>> GetEmployeeQualifications(string employeeId)
		{
			if (!CheckEmployeeExists(employeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}

			return new()
			{
				Success = true,
				Payload = Context.EmployeeQualifications
							.Where(eq => eq.EmployeeId == employeeId)
							.Include(eq => eq.Employee)
							.Include(eq => eq.Qualification)
							.Select(eq => MapToModel(eq))
							.ToList()
			};
		}

		private static Models.EmployeeQualification MapToModel(EmployeeQualification eq)
		{
			return new Models.EmployeeQualification
			{
				Id = eq.Id,
				Score = eq.Score,
				IssueDate = eq.IssueDate,
				PlaceOfIssue = eq.PlaceOfIssue,
				QualificationId = eq.QualificationId,
				QualificationName = eq.Qualification.Name,
				EmployeeId = eq.EmployeeId,
				EmployeeName = eq.Employee.Name
			};
		}

		public DateOnly GetLatestDateAtUnit(string employeeId)
		{
			return GetLatestDate(Context.UnitHistories, employeeId);
		}

		public DateOnly GetLatestDateAtUnion(string employeeId)
		{
			return GetLatestDate(Context.UnionHistories, employeeId);
		}

		public DateOnly GetLatestDateAtPosition(string employeeId)
		{
			return GetLatestDate(Context.PositionHistories, employeeId);
		}

		private DateOnly GetLatestDate<T>(DbSet<T> dbSet, string employeeId) where T : History
		{
			var lastestUh = dbSet.Where(uh => uh.EmployeeId == employeeId)
						  .OrderByDescending(uh => uh.StartDate)
						  .OrderByDescending(uh => uh.EndDate)
						  .FirstOrDefault();

			return lastestUh != null ? (lastestUh.EndDate ?? lastestUh.StartDate) : DateOnly.FromDateTime(DateTime.Now);
		}

		public Result<List<Models.EmployeeOfUnitOfUnion>> GetEmployeeOfUnitAndUnion(string unitId, string unionId)
		{
			if (!new RepositoryUnit().CheckUnitExists(unitId))
			{
				return new() { Success = false, ErrorMessage = "This Unit id does not exists." };
			}

			if (!new RepositoryUnion().CheckUnionExist(unionId))
			{
				return new() { Success = false, ErrorMessage = "This Union id does not exists." };
			}

			var unit = Context.Units.Single(u => u.Id == unitId);

			var query = from unitHis in Context.UnitHistories.Where(uh => uh.UnitId == unitId && uh.EndDate == null)
						from unionHis in Context.UnionHistories.Where(uh => uh.EmployeeId == unitHis.EmployeeId && uh.UnionId == unionId && uh.EndDate == null)
						from employee in Context.Employees.Where(e => e.Id == unitHis.EmployeeId)
						from union in Context.Unions.Where(u => u.Id == unionHis.UnionId)
						select new Models.EmployeeOfUnitOfUnion() {
							EmployeeId = unionHis.EmployeeId,
							EmployeeName = employee.Name,
							UnionName = union.Name,
							UnionStartDate = unionHis.StartDate,
						};

			return new() { Success = true, Payload = query.ToList() };
		}

		public List<Models.Employee> GetRetiredEmployeesAt(DateOnly date)
		{
			string dateStr = date.ToString("yyyy-MM-dd");
			var males = Context.Employees.FromSqlInterpolated($"SELECT * FROM employees WHERE gender='male' AND DATE_PART('year', AGE({dateStr}::timestamptz, date_of_birth)) >= 60");
			var females = Context.Employees.FromSqlInterpolated($"SELECT * FROM employees WHERE gender='female' AND DATE_PART('year', AGE({dateStr}::timestamptz, date_of_birth)) >= 55");

			return males.Concat(females).OrderByDescending(e => e.DateCreated).Select(e => MapToModel(e)).ToList();
		}

		private static Models.Employee MapToModel(Employee input)
		{
			return new Models.Employee
			{
				Id = input.Id,
				Name = input.Name,
				DateOfBirth = input.DateOfBirth,
				IdentityCardNumber = input.IdentityCardNumber,
				CoefficientAllowance = input.CoefficientAllowance
			};
		}

		private static Employee MapToEntity(EmployeeInput entity)
		{
			return new Employee
			{
				Id = entity.Id,
				Name = entity.Name,
				Gender = entity.Gender,
				DateOfBirth = entity.DateOfBirth,
				Ethnic = entity.Ethnic,
				StartDate = entity.StartDate,
				Address = entity.Address,
				IdentityCardNumber = entity.IdentityCardNumber,
				Image = entity.Image,
				CoefficientAllowance = entity.CoefficientAllowance
			};
		}

		private static Models.EmployeeDetail MapToModelEmployeeDetail(Employee entity)
		{
			return new Models.EmployeeDetail
			{
				Name = entity.Name,
				Gender = entity.Gender,
				DateOfBirth = entity.DateOfBirth,
				Ethnic = entity.Ethnic,
				StartDate = entity.StartDate,
				Address = entity.Address,
				IdentityCardNumber = entity.IdentityCardNumber,
				Image = entity.Image,
				CoefficientAllowance = entity.CoefficientAllowance
			};
		}
	
		private static Models.UnitHistory MapToModel(UnitHistory entity)
		{
			return new Models.UnitHistory
			{
				Id = entity.Id,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				EmployeeId = entity.EmployeeId,
				UnitId = entity.UnitId,
				UnitName = entity.Unit.Name
			};
		}

		private static Models.PositionHistory MapToModel(PositionHistory entity)
		{
			return new Models.PositionHistory
			{
				Id = entity.Id,
				PositionId = entity.PositionId,
				PositionName = entity.Position.Name,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				EmployeeId = entity.EmployeeId
			};
		}

		private static Models.UnionHistory MapToModel(UnionHistory history)
		{
			return new Models.UnionHistory
			{
				Id = history.Id,
				UnionId = history.UnionId,
				UnionName = history.Union.Name,
				StartDate = history.StartDate,
				EndDate = history.EndDate,
				EmployeeId = history.EmployeeId
			};
		}

		private static Models.Family MapToModel(Family uh)
		{
			return new Models.Family
			{
				Id = uh.Id,
				EmployeeId = uh.EmployeeId,
				EmployeeName = uh.Employee.Name,
				Name = uh.Name,
				DateOfBirth = uh.DateOfBirth,
				Occupation = uh.Occupation,
				RelativeType = uh.RelativeType
			};
		}

	}
}



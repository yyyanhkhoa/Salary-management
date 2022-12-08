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
		public Result<Models.EmployeeSalary> GetEmployeeSalariesAtUnit(string unitId, DateOnly date)
		{
			throw new NotImplementedException();
			//var query = from unitHistory in Context.UnitHistories.DistinctBy(uh => uh.EmployeeId)
			//									   .Where(uh => uh.UnitId == unitId && uh.StartDate >= date)
			//			from positionHistory in Context.PositionHistories.DistinctBy(uh => uh.EmployeeId)
			//									   .Where(ph => ph.EmployeeId == unitHistory.EmployeeId && ph.EndDate == null)
			//			from employee in Context.Employees.Where(e => e.Id == unitHistory.EmployeeId)
			//			from unit in Context.Units.Where(e => e.Id == unitHistory.UnitId)
			//			from position in Context.Positions.Where(p => p.Id == positionHistory.PositionId)
			//			from rank in Context.Ranks.Where(r => r.Id == position.RankId)
			//			select new Models.EmployeeSalary
			//			{
			//				EmployeeId = employee.Id,
			//				EmployeeName = employee.Name,
			//				UnitId = unitHistory.UnitId,
			//				UnitName = unit.Name,
			//				Salary = rank.Coefficient * (employee rank.Milestone)
			//			};

			//return query.ToList();
		}

}
}

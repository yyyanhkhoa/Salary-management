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

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryEmployee : Repository
	{
		public bool CheckIdCardExist(string identityCardNumber)
			=> Context.Employees.Any(a => a.IdentityCardNumber == identityCardNumber);


		public bool CheckEmployeeExists(string id)
			=> Context.Employees.Any(a => a.Id	== id);


		public Result<Models.Employee> InsertEmployee(EmployeeInput input)
		{
			if (CheckIdCardExist(input.IdentityCardNumber))
				return new Result<Models.Employee> { Success = false, ErrorMessage = "Employee with this ID card already exists." };

			var employee = MapToEntity(input);
			var newestEmployee = Context.Employees.OrderByDescending(e => e.DateCreated).FirstOrDefault();

			if (newestEmployee == null)
			{
				employee.Id = "EM_1";
			}
			else
			{
				employee.Id = $"EM_{int.Parse(newestEmployee.Id[3..^0]) + 1}";
			} 

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

		public Result<Models.UnitHistory> InsertUnitHistory(InputUnitHistory input)
		{
			var result = DoCommonHistoryValidation<UnitHistory, Models.UnitHistory>("Union", input, Context.UnitHistories);
			if (!result.Success)
			{
				return result;
			}

			var unitExists = new RepositoryUnit().CheckUnitExists(input.UnitId);
			if (!unitExists)
			{
				return new() { Success = false, ErrorMessage = "Unit with this id do not exist." };
			}

			var history = MapToEntity(input);
			Context.UnitHistories.Add(history);
			Context.SaveChanges();

			history = Context.UnitHistories.Include(uh => uh.Unit)
							 .Where(uh => uh.Id == history.Id)
							 .First();

			return new() { Success = true, Payload = MapToModel(history) };
		}

		public Result<Models.PositionHistory> InsertPositionHistory(InputPositionHistory input)
		{
			var result = DoCommonHistoryValidation<PositionHistory, Models.PositionHistory>("Position", input, Context.PositionHistories);
			if (!result.Success)
			{
				return result;
			}

			var positionExists = new RepositoryPosition().CheckPositionExist(input.PositionId);
			if (!positionExists)
			{
				return new() { Success = false, ErrorMessage = "Position with this id do not exist." };
			}

			var history = MapToEntity(input);
			Context.PositionHistories.Add(history);
			Context.SaveChanges();

			history = Context.PositionHistories.Include(ph => ph.Position)
							 .Where(ph => ph.Id == history.Id)
							 .First();

			return new() { Success = true, Payload = MapToModel(history) };
		}

		private Result<ModelT> DoCommonHistoryValidation<EntityT, ModelT>(string name, History input, DbSet<EntityT> dbset) where EntityT : History
		{
			if (input.EndDate != null && input.EndDate < input.StartDate)
			{
				return new() { Success = false, ErrorMessage = "End date can not be smaller than start day." };
			}

			if (!CheckEmployeeExists(input.EmployeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee with this id do not exist." };
			}

			if (dbset.Any(uh => uh.EndDate == null))
			{
				return new() { Success = false, ErrorMessage = $"Please add previous {name} end date before adding new {name} history." };
			}

			var invalidStartDate = dbset.Any(
				uh => input.EmployeeId == uh.EmployeeId
				   && input.StartDate < uh.EndDate
			);
			if (invalidStartDate)
			{
				return new() { Success = false, ErrorMessage = "Start date can not be earlier than previous Unit end date." };
			}

			return new() { Success = true };
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
	
		private static UnitHistory MapToEntity (InputUnitHistory input)
		{
			return new UnitHistory
			{
				StartDate = input.StartDate,
				EndDate = input.EndDate,
				EmployeeId = input.EmployeeId,
				UnitId = input.UnitId
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

		private static PositionHistory MapToEntity(InputPositionHistory input)
		{
			return new PositionHistory
			{
				PositionId = input.PositionId,
				StartDate = input.StartDate,
				EndDate = input.EndDate,
				EmployeeId = input.EmployeeId
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
	}
}



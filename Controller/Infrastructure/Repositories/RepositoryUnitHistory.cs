using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using Models = Salary_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salary_management.Infrastructure.Entities;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryUnitHistory : Repository
	{
		public Models.UnitHistory GetUnitHistory(int id)
		{
			return MapToModel(
					Context.UnitHistories
						.Where(eq => eq.Id == id)
						.Include(eq => eq.Unit)
						.First()
					);
		}

		public Result<Models.UnitHistory> InsertUnitHistory(InputUnitHistory input)
		{
			var result = Helper.DoCommonHistoryValidation<UnitHistory, Models.UnitHistory>
				("Unit", input, Context.UnitHistories);
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

			return new() { Success = true, Payload = GetUnitHistory(history.Id) };
		}


		public Result<Models.UnitHistory> FixUnitHistory(int id, InputUnitHistory input)
		{
			var eq = MapToEntity(input);
			eq.Id = id;
			Context.UnitHistories.Update(eq);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetUnitHistory(id) };
		}

		public void DeleteUnitHistory(int id)
		{
			var employee = new UnitHistory { Id = id };
			Context.UnitHistories.Attach(employee);
			Context.UnitHistories.Remove(employee);
			Context.SaveChanges();
		}

		private static Models.UnitHistory MapToModel(UnitHistory eq)
		{
			return new Models.UnitHistory
			{
				Id = eq.Id,
				UnitId = eq.UnitId,
				UnitName = eq.Unit.Name,
				StartDate = eq.StartDate,
				EndDate = eq.EndDate,
				EmployeeId = eq.EmployeeId
			};
		}

		private static UnitHistory MapToEntity(InputUnitHistory input)
		{
			return new UnitHistory
			{
				UnitId = input.UnitId,
				StartDate = input.StartDate,
				EndDate = input.EndDate,
				EmployeeId = input.EmployeeId
			};
		}
	}
}

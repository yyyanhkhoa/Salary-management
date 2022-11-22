using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryPositionHistory : Repository
	{
		public Models.PositionHistory GetPositionHistory(int id)
		{
			return MapToModel(
					Context.PositionHistories
						.Where(eq => eq.Id == id)
						.First()
					);
		}

		public Result<Models.PositionHistory> InsertPositionHistory(InputPositionHistory input)
		{
			var result = Helper.DoCommonHistoryValidation<PositionHistory, Models.PositionHistory>
				("Position", input, Context.PositionHistories);
			if (!result.Success)
			{
				return result;
			}

			var unitExists = new RepositoryPosition().CheckPositionExist(input.PositionId);
			if (!unitExists)
			{
				return new() { Success = false, ErrorMessage = "Unit with this id do not exist." };
			}

			var history = MapToEntity(input);
			Context.PositionHistories.Add(history);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetPositionHistory(history.Id) };
		}


		public Result<Models.PositionHistory> FixPositionHistory(int id, InputPositionHistory input)
		{
			var eq = MapToEntity(input);
			eq.Id = id;
			Context.PositionHistories.Update(eq);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetPositionHistory(id) };
		}

		public void DeletePositionHistory(int id)
		{
			var employee = new PositionHistory { Id = id };
			Context.PositionHistories.Attach(employee);
			Context.PositionHistories.Remove(employee);
			Context.SaveChanges();
		}

		private static Models.PositionHistory MapToModel(PositionHistory eq)
		{
			return new Models.PositionHistory
			{
				Id = eq.Id,
				PositionId = eq.PositionId,
				StartDate = eq.StartDate,
				EndDate = eq.EndDate,
				EmployeeId = eq.EmployeeId
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
	}
}

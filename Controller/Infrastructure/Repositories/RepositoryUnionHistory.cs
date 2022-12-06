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
using System.Xml.Linq;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryUnionHistory : Repository
	{
		public Models.UnionHistory GetUnionHistory(int id)
		{
			return MapToModel(
					Context.UnionHistories
						.Where(eq => eq.Id == id)
						.Include(eq => eq.Union)
						.First()
					);
		}

		public Result<Models.UnionHistory> InsertUnionHistory(InputUnionHistory input)
		{
			if (input.EndDate != null && input.EndDate < input.StartDate)
			{
				return new() { Success = false, ErrorMessage = "End date can not be smaller than start day." };
			}

			if (!new RepositoryEmployee().CheckEmployeeExists(input.EmployeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee with this id do not exist." };
			}

			if (Context.UnionHistories.Any(uh => uh.EndDate == null && uh.UnionId == input.UnionId && uh.EmployeeId == input.EmployeeId))
			{
				return new() { Success = false, ErrorMessage = $"Please add previous Union end date before adding new Union history of that same Union." };
			}

			var invalidStartDate = Context.UnionHistories.Any(
				uh => input.EmployeeId == uh.EmployeeId
				   && input.UnionId == uh.UnionId
				   && input.StartDate < uh.EndDate
			);
			if (invalidStartDate)
			{
				return new() { Success = false, ErrorMessage = "Start date can not be earlier than previous Unit end date." };
			}

			var unitExists = new RepositoryUnion().CheckUnionExist(input.UnionId);
			if (!unitExists)
			{
				return new() { Success = false, ErrorMessage = "Union with this id do not exist." };
			}

			var history = MapToEntity(input);
			Context.UnionHistories.Add(history);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetUnionHistory(history.Id) };
		}


		public Result<Models.UnionHistory> FixUnionHistory(int id, InputUnionHistory input)
		{
			var eq = MapToEntity(input);
			eq.Id = id;
			Context.UnionHistories.Update(eq);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetUnionHistory(id) };
		}

		public void DeleteUnionHistory(int id)
		{
			var employee = new UnionHistory { Id = id };
			Context.UnionHistories.Attach(employee);
			Context.UnionHistories.Remove(employee);
			Context.SaveChanges();
		}

		private static Models.UnionHistory MapToModel(UnionHistory eq)
		{
			return new Models.UnionHistory
			{
				Id = eq.Id,
				UnionId = eq.UnionId,
				UnionName = eq.Union.Name,
				StartDate = eq.StartDate,
				EndDate = eq.EndDate,
				EmployeeId = eq.EmployeeId
			};
		}

		private static UnionHistory MapToEntity(InputUnionHistory input)
		{
			return new UnionHistory
			{
				UnionId = input.UnionId,
				StartDate = input.StartDate,
				EndDate = input.EndDate,
				EmployeeId = input.EmployeeId
			};
		}
	}
}

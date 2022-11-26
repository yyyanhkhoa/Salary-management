﻿using Microsoft.EntityFrameworkCore;
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
			var result = Helper.DoCommonHistoryValidation<UnionHistory, Models.UnionHistory>
				("Union", input, Context.UnionHistories);
			if (!result.Success)
			{
				return result;
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
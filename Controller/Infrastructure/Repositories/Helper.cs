using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class Helper
	{
		public static IQueryable<T> GetTimelineByDateRange<T>(IQueryable<T> query, DateOnly? from, DateOnly? to) where T : History
		{
			if (from != null && to != null)
			{
				query = query.Where(h => h.StartDate >= from && h.EndDate <= to);
			}
			else if (from != null)
			{
				query = query.Where(h => h.StartDate >= from);
			}
			else if (to != null)
			{
				query = query.Where(h => h.EndDate <= to);
			}

			return query.OrderByDescending(h => h.StartDate)
						.OrderByDescending(h => h.EndDate);

		}

		public static Result<ModelT> DoCommonHistoryValidation<EntityT, ModelT>(string name, History input, DbSet<EntityT> dbset) where EntityT : History
		{
			if (input.EndDate != null && input.EndDate < input.StartDate)
			{
				return new() { Success = false, ErrorMessage = "End date can not be smaller than start day." };
			}

			if (!new RepositoryEmployee().CheckEmployeeExists(input.EmployeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee with this id do not exist." };
			}

			if (dbset.Any(uh => uh.EndDate == null && uh.EmployeeId == input.EmployeeId))
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


	}
}

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
		public static IQueryable<T> GetTimelineByDate<T>(IQueryable<T> query, DateOnly? from, DateOnly? to) where T : History
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

			return query.OrderBy(h => h.StartDate);

		}

	}
}

using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryQualificationAllowanceHistory : Repository
	{
		public Models.QualificationAllowanceHistory GetQualificationAllowanceHistory(int id)
		{
			return MapToModel(
					Context.QualificationAllowanceHistories
						.Where(eq => eq.Id == id)
						.Include(eq => eq.Qualification)
						.First()
					);
		}

		public Result<Models.QualificationAllowanceHistory> InsertQualificationAllowanceHistory(InputQualificationAllowanceHistory input)
		{
			if (!new RepositoryQualification().CheckQualificationExist(input.QualificationId))
			{
				return new() { Success = false, ErrorMessage = "Qualification with this id do not exist." };
			}

			var invalidYear = Context.QualificationAllowanceHistories.Any(
				uh => input.QualificationId == uh.QualificationId
				&& input.Year < uh.Year
			);

			if (invalidYear)
			{
				return new() { Success = false, ErrorMessage = "Year can not be earlier than previous history Year." };
			}

			var history = MapToEntity(input);
			Context.QualificationAllowanceHistories.Add(history);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetQualificationAllowanceHistory(history.Id) };
		}

		public Result<Models.QualificationAllowanceHistory> FixQualificationAllowanceHistory(int id, InputQualificationAllowanceHistory input)
		{
			var eq = MapToEntity(input);
			eq.Id = id;
			Context.QualificationAllowanceHistories.Update(eq);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetQualificationAllowanceHistory(id) };
		}

		public void DeleteQualificationAllowanceHistory(int id)
		{
			var employee = new QualificationAllowanceHistory { Id = id };
			Context.QualificationAllowanceHistories.Attach(employee);
			Context.QualificationAllowanceHistories.Remove(employee);
			Context.SaveChanges();
		}

		private static Models.QualificationAllowanceHistory MapToModel(QualificationAllowanceHistory eq)
		{
			return new Models.QualificationAllowanceHistory
			{
				Id = eq.Id,
				Year = eq.Year,
				Allowance = eq.Allowance,
				QualificationId = eq.QualificationId,
				QualificationName = eq.Qualification.Name
			};
		}

		private static QualificationAllowanceHistory MapToEntity(InputQualificationAllowanceHistory input)
		{
			return new QualificationAllowanceHistory
			{
				Year = input.Year,
				Allowance = input.Allowance,
				QualificationId = input.QualificationId
			};
		}
	}
}

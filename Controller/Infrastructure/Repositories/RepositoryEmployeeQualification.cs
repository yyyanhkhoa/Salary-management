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
	public class RepositoryEmployeeQualification : Repository
	{
		public Models.EmployeeQualification GetEmployeeQualification(int id)
		{
			return MapToModel(
					Context.EmployeeQualifications
						.Where(eq => eq.Id == id)
						.Include(eq => eq.Employee)
						.Include(eq => eq.Qualification)
						.First()
					);
		}

		public Result<Models.EmployeeQualification> InsertEmployeeQualification(InputEmployeeQualification input)
		{
			if (!new RepositoryQualification().CheckQualificationExist(input.QualificationId))
			{
				return new() { Success = false, ErrorMessage = "Qualification with this id does not exist." };
			}

			if (!new RepositoryEmployee().CheckEmployeeExists(input.EmployeeId))
			{
				return new() { Success = false, ErrorMessage = "Employee of this id does not exist." };
			}

			var eq = MapToEntity(input);
			Context.EmployeeQualifications.Add(eq);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetEmployeeQualification(eq.Id) };
		}

		public Result<Models.EmployeeQualification> FixEmployeeQualification(int id, InputEmployeeQualification input)
		{
			var eq = MapToEntity(input);
			eq.Id = id;
			Context.EmployeeQualifications.Update(eq);
			Context.SaveChanges();

			return new () { Success = true, Payload = GetEmployeeQualification(id) };
		}

		public void DeleteEmployeeQualification(int id)
		{
			var employee = new EmployeeQualification { Id = id };
			Context.EmployeeQualifications.Attach(employee);
			Context.EmployeeQualifications.Remove(employee);
			Context.SaveChanges();
		}

		public Result<List<Models.EmployeeQualification>> GetEmployeesAboveScoreOf(int qualificationId, float score)
		{
			if (!new RepositoryQualification().CheckQualificationExist(qualificationId))
			{
				return new() { Success = false, ErrorMessage = "Qualification with this id does not exist." };
			}

			var emps = Context.EmployeeQualifications.Where(eq => eq.QualificationId == qualificationId && eq.Score > score)
				.Include(eq => eq.Employee)
				.Include(eq => eq.Qualification);

			return new()
			{
				Success = true,
				Payload = emps.ToList().DistinctBy(e => e.EmployeeId).Select(e => MapToModel(e)).ToList()
			};
		}


		private static Models.EmployeeQualification MapToModel(EmployeeQualification eq)
		{
			return new Models.EmployeeQualification
			{
				Score = eq.Score,
				IssueDate = eq.IssueDate,
				PlaceOfIssue = eq.PlaceOfIssue,
				QualificationId = eq.QualificationId,
				QualificationName = eq.Qualification.Name,
				EmployeeId = eq.EmployeeId,
				EmployeeName = eq.Employee.Name
			};
		}

		private static EmployeeQualification MapToEntity(InputEmployeeQualification input)
		{
			return new EmployeeQualification
			{
				Score = input.Score,
				IssueDate = input.IssueDate,
				PlaceOfIssue = input.PlaceOfIssue,
				QualificationId = input.QualificationId,
				EmployeeId = input.EmployeeId
			};
		}

	}
}

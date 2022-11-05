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
	public class RepositoryFamily : Repository
	{
		public bool CheckEmployeeExist(string id)
			=> Context.Employees.Any(e => e.Id == id);

		public Result<Models.Family> InsertFamily(InputFamily inputFamily)
		{
			if (!CheckEmployeeExist(inputFamily.EmployeeId))
				return new Result<Models.Family> { Success = false, ErrorMessage = "Employee with this id do not exist." };

			Family family = MapToEntity(inputFamily);
			Context.Families.Add(family);
			Context.SaveChanges();
			return new Result<Models.Family> { Success = true, Payload = MapToModel(family) };
		}

		public List<Models.Family> GetFamilies()
		{
			return Context.Families.Select(f => MapToModel(f)).ToList();
		}

		public Result<Models.Family> FixFamily(int FamilyId, InputFamily inputFamily)
		{
			var Family = MapToEntity(inputFamily);
			Family.Id = FamilyId;
			Context.Families.Update(Family);
			Context.SaveChanges();

			return new Result<Models.Family> { Success = true, Payload = MapToModel(Family) };
		}

		public Result<Models.Family> DeleteFamily(int FamilyId)
		{
			var Family = new Family { Id = FamilyId };
			Context.Families.Attach(Family);
			Context.Families.Remove(Family);
			Context.SaveChanges();

			return new Result<Models.Family> { Success = true, Payload = null };
		}

		private static Family MapToEntity(InputFamily inputFamily)
		{
			return new Family
			{
				Name = inputFamily.Name,
				DateOfBirth = inputFamily.DateOfBirth,
				Occupation = inputFamily.Occupation,
				RelativeType = inputFamily.RelativeType,
				EmployeeId = inputFamily.EmployeeId
			};
		}

		private Models.Family MapToModel(Family family)
		{
			return new Models.Family
			{
				Id = family.Id,
				EmployeeId = family.EmployeeId,
				Name = family.Name,
				DateOfBirth = family.DateOfBirth,
				Occupation = family.Occupation,
				RelativeType = family.RelativeType
			};
		}

	}
}

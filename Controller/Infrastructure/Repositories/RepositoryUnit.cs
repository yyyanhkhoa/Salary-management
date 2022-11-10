using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Infrastructure.Entities;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	internal class RepositoryUnit : Repository
	{
		public bool CheckUnitExists(string name)
			=> Context.Units.Any(u => u.Name == name);

		public Result<Models.Unit> InsertUnit(InputUnit input)
		{
			if (CheckUnitExists(input.Name))
				return new() { Success = false, ErrorMessage = "This unit already exists" };

			var unit = MapToEntity(input);
			Context.Units.Add(unit);
			Context.SaveChanges();

			return new Result<Models.Unit> { Success = true, Payload = MapToModel(unit) };
		}

		/// <summary>
		/// Lấy thông tin các unit theo từ khóa, nếu từ khóa trống thì lấy thông tin của 20 unit mới nhất
		/// </summary>
		/// <param name="searchString"></param>
		/// <returns></returns>
		public List<Models.Unit> GetUnits(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Units.Take(20).Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Units.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
				.Select(e => MapToModel(e)).ToList();
			}
		}

		private static Models.Unit MapToModel(Unit input)
		{
			return new Models.Unit
			{
				Id = input.Id,
				Name = input.Name,
				Address = input.Address,
				PhoneNumber = input.PhoneNumber,
				DateFounded = input.DateFounded
			};
		}

		private static Unit MapToEntity(InputUnit input)
		{
			return new Unit
			{
				Name = input.Name,
				Address = input.Address,
				PhoneNumber = input.PhoneNumber,
				DateFounded = input.DateFounded
			};
		}
	}
}

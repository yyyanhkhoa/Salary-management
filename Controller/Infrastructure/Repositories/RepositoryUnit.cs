using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Infrastructure.Entities;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	internal class RepositoryUnit : Repository
	{
		public bool CheckNameExists(string name)
			=> Context.Units.Any(u => u.Name == name);

		public bool CheckUnitExists(string id)
			=> Context.Units.Any(u => u.Id == id);

		public Result<Models.Unit> InsertUnit(InputUnit input)
		{
			if (CheckNameExists(input.Name))
				return new() { Success = false, ErrorMessage = "This unit already exists" };

			var unit = MapToEntity(input);
			Context.Units.Add(unit);
			Context.SaveChanges();

			return new Result<Models.Unit> { Success = true, Payload = MapToModel(unit) };
		}

		public Models.UnitDetail GetUnitDetail(string unitId)
		{
			var detail = MapToUnitDetailModel(Context.Units.Where(u => u.Id == unitId).First());
			detail.Timeline = GetTimeline(unitId).Payload!;
			return detail;
		}

		public Result<Models.UnitDetail> FixUnit(string id, InputUnit input)
		{
			var unit = MapToEntity(input);
			unit.Id = id;
			Context.Units.Update(unit);
			Context.SaveChanges();

			return new Result<Models.UnitDetail> { Success = true, Payload = MapToUnitDetailModel(unit) };
		}

		public void DeleteUnit(string id)
		{
			var unit = new Unit { Id = id };
			Context.Units.Attach(unit);
			Context.Units.Remove(unit);
			Context.SaveChanges();
		}


		public Result<List<Models.UnitTimeline>> GetTimeline(string unitId, DateOnly? from = null, DateOnly? to = null)
		{
			var query = Context.UnitHistories.Where(uh => uh.UnitId == unitId);
			query = Helper.GetTimelineByDateRange(query, from, to);

			return new()
			{
				Success = true,
				Payload = query.Include(uh => uh.Employee)
							   .Select(uh => MapToTimelineModel(uh))
							   .ToList()
			};
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
				.Select(e => MapToModel(e))
				.ToList();
			}
		}

		private static Models.Unit MapToModel(Unit entity)
		{
			return new Models.Unit
			{
				Id = entity.Id,
				Name = entity.Name,
				Address = entity.Address,
				PhoneNumber = entity.PhoneNumber,
				DateFounded = entity.DateFounded
			};
		}
		private static Models.UnitDetail MapToUnitDetailModel(Unit entity)
		{
			return new Models.UnitDetail
			{
				Id = entity.Id,
				Name = entity.Name,
				Address = entity.Address,
				PhoneNumber = entity.PhoneNumber,
				DateFounded = entity.DateFounded
			};
		}

		private static Unit MapToEntity(InputUnit input)
		{
			return new Unit
			{
				Id = input.Id,
				Name = input.Name,
				Address = input.Address,
				PhoneNumber = input.PhoneNumber,
				DateFounded = input.DateFounded
			};
		}

		private static Models.UnitTimeline MapToTimelineModel(UnitHistory entity)
		{
			return new Models.UnitTimeline
			{
				Id = entity.Id,
				EmployeeName = entity.Employee.Name,
				UnitId = entity.UnitId,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				EmployeeId = entity.EmployeeId
			};
		}
	}
}

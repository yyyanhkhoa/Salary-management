﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Infrastructure.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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

		public Result<List<Models.UnitTimeline>> GetTimeline(DateOnly? from = null, DateOnly? to = null)
		{
			IQueryable<UnitHistory> query;

			if (from != null && to != null)
			{
				query = Context.UnitHistories.Where(uh => uh.StartDate >= from && uh.EndDate <= to);
			}
			else if (from != null)
			{
				query = Context.UnitHistories.Where(uh => uh.StartDate >= from);
			}
			else
			{
				query = Context.UnitHistories.Where(uh => uh.EndDate <= to);
			}

			return new()
			{
				Success = true,
				Payload = query.OrderBy(uh => uh.StartDate)
							   .Select(uh => MapToModel(uh))
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
	
		private Models.UnitTimeline MapToModel(UnitHistory entity)
		{
			return new Models.UnitTimeline
			{
				EmployeeName = Context.Employees.Where(e => e.Id == entity.EmployeeId).First().Name,
				UnitId = entity.UnitId,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				EmployeeId = entity.EmployeeId
			};
		}
	}
}

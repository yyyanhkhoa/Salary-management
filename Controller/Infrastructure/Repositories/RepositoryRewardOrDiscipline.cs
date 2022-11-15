﻿using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryRewardOrDiscipline : Repository
	{
		public bool CheckIdCardExist(string identityCardNumber)
			=> Context.Employees.Any(a => a.IdentityCardNumber == identityCardNumber);

		public Result<Models.RewardOrDiscipline> InsertRewardOrDiscipline(InputRewardOrDiscipline input)
		{
			var rod = MapToEntity(input);
			Context.RewardOrDisciplines.Add(rod);
			Context.SaveChanges();
			return new Result<Models.RewardOrDiscipline> { Success = true, Payload = MapToModel(rod) };
		}


		/// <summary>
		/// Lấy thông tin các khen thưởng theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả khen thưởng
		/// </summary>
		/// <param name="id"></param>
		/// <param name="searchString">dùng để tìm kiếm nội dung khen thưởng hoặc mã nhân viên</param>
		/// <returns></returns>
		public List<Models.RewardOrDiscipline> GetRewards(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.RewardOrDisciplines.Where(r => r.IsReward)
							  .Include(e => e.Employee)
							  .Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.RewardOrDisciplines.Where(
					e => EF.Functions.ILike(e.Content, $"%{keyword}%") ||
						 EF.Functions.ILike(e.EmployeeId, $"%{keyword}%")
					)
					.Include(e => e.Employee)
					.Select(e => MapToModel(e)).ToList();
			}
		}

		/// <summary>
		/// Lấy thông tin các kỷ luật theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả kỷ luật
		/// </summary>
		/// <param name="id"></param>
		/// <param name="searchString">dùng để tìm kiếm nội dung kỷ luật hoặc mã nhân viên</param>
		/// <returns></returns>
		public List<Models.RewardOrDiscipline> GetDisciplines(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.RewardOrDisciplines.Where(r => !r.IsReward)
							.Include(e => e.Employee)
							.Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.RewardOrDisciplines.Where(
					e => EF.Functions.ILike(e.Content, $"%{keyword}%") ||
						 EF.Functions.ILike(e.EmployeeId, $"%{keyword}%")
					)
					.Include(e => e.Employee)
					.Select(e => MapToModel(e)).ToList();
			}
		}


		/// <summary>
		/// Lấy thông tin các kỷ luật theo năm, nếu năm trống thì lấy thông tin của tất cả kỷ luật
		/// </summary>
		/// <param name="id"></param>
		/// <param name="searchString">dùng để tìm kiếm nội dung khen thưởng hoặc mã nhân viên</param>
		/// <returns></returns>
		public List<Models.RewardOrDiscipline> GetRewards(int? year)
		{
			if (year == null)
			{
				return Context.RewardOrDisciplines.Where(r => r.IsReward)
							  .Include(e => e.Employee)
							  .Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.RewardOrDisciplines.Where(r => r.IsReward && r.Date.Year == year)
							  .Include(e => e.Employee)
							  .Select(e => MapToModel(e)).ToList();
			}
		}

		/// <summary>
		/// Lấy thông tin các kỷ luật theo năm, nếu năm trống thì lấy thông tin của tất cả kỷ luật
		/// </summary>
		/// <param name="id"></param>
		/// <param name="searchString">dùng để tìm kiếm nội dung khen thưởng hoặc mã nhân viên</param>
		/// <returns></returns>
		public List<Models.RewardOrDiscipline> GetDisciplines(int? year)
		{
			if (year == null)
			{
				return Context.RewardOrDisciplines.Where(r => !r.IsReward)
						      .Include(e => e.Employee)
							  .Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.RewardOrDisciplines.Where(r => !r.IsReward && r.Date.Year == year)
							  .Include(e => e.Employee)
							  .Select(e => MapToModel(e)).ToList();
			}
		}

		public static RewardOrDiscipline MapToEntity(InputRewardOrDiscipline input)
		{
			return new RewardOrDiscipline
			{
				IsReward = input.IsReward,
				Level = input.Level,
				Date = input.Date,
				Content = input.Content,
				EmployeeId = input.EmployeeId
			};
		}

		public static Models.RewardOrDiscipline MapToModel(RewardOrDiscipline entity)
		{
			return new Models.RewardOrDiscipline
			{
				Id = entity.Id,
				Level = entity.Level,
				Date = entity.Date,
				Content = entity.Content,
				EmployeeId = entity.EmployeeId,
				EmployeeName = entity.Employee.Name
			};
		}
	}
}


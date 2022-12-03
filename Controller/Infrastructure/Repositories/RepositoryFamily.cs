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

		/// <summary>
		/// Lấy thông tin các đoàn thể theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả đoàn thể
		/// </summary>
		/// <param name="searchString">tên thân nhân hoặc mã nhân viên mà thân nhân đó thuộc</param>
		/// <returns></returns>
	
		public List<Models.Family> GetFamilies(string keyword)
		{

			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Families.Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Families.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.EmployeeId, $"%{keyword}%")
				)
				.Select(e => MapToModel(e)).ToList();
			}
		}
		public List<Models.Family> GetFamiliesByEmployee(string EmployeeId)
    {
         return Context.Families.ToList().Select(f => MapToModel(f)).Where(e => e.EmployeeId == EmployeeId).ToList();
    }
   
    public Models.Family GetFamilyDetail(int id)
    {
       return MapToModel(Context.Families.Where(e => e.Id == id).First()!);
    }

    public Result<Models.Family> FixFamily(int FamilyId, InputFamily inputFamily)
		{
			var Family = MapToEntity(inputFamily);
			Family.Id = FamilyId;
			Context.Families.Update(Family);
			Context.SaveChanges();

			return new Result<Models.Family> { Success = true, Payload = MapToModel(Family) };
		}


		public void DeleteFamily(int id)
		{
			var family = new Family { Id = id };
			Context.Families.Attach(family);
			Context.Families.Remove(family);
			Context.SaveChanges();
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

		private static Models.Family MapToModel(Family family)
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

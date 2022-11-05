using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryEmployee : Repository
	{
		public bool CheckIdCardExist(string identityCardNumber)
			=> Context.Employees.Any(a => a.IdentityCardNumber == identityCardNumber);

		public Result<Models.Employee> InsertEmployee(EmployeeInput input)
		{
			if (CheckIdCardExist(input.IdentityCardNumber))
				return new Result<Models.Employee> { Success = false, ErrorMessage = "Employee with this ID card already exists." };

			var employee = MapToEntity(input);
			var newestEmployee = Context.Employees.OrderByDescending(e => e.DateCreated).FirstOrDefault();

			if (newestEmployee == null)
			{
				employee.Id = "EM_1";
			}
			else
			{
				employee.Id = $"EM_{int.Parse(newestEmployee.Id[3..^0]) + 1}";
			} 

			Context.Employees.Add(employee);
			Context.SaveChanges();
			return new Result<Models.Employee> { Success = true, Payload = MapToModel(employee) };
		}


		/// <summary>
		/// Lấy thông tin các nhân viên theo từ khóa, nếu từ khóa trống thì lấy thông tin của 20 nhân viên mới nhất
		/// </summary>
		/// <param name="searchString"></param>
		/// <returns></returns>
		public List<Models.Employee> GetEmployees(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Employees.Take(20).Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Employees.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
					.Select(e => MapToModel(e)).ToList();
			}
		}

		public Models.EmployeeDetail GetEmployeeDetail(string id)
		{
			return MapToModelEmployeeDetail(Context.Employees.Where(e => e.Id == id).FirstOrDefault()!);
		}

		public static Models.Employee MapToModel(Employee input)
		{
			return new Models.Employee
			{
				Id = input.Id,
				Name = input.Name,
				DateOfBirth = input.DateOfBirth,
				IdentityCardNumber = input.IdentityCardNumber,
				CoefficientAllowance = input.CoefficientAllowance
			};
		}

		public static Employee MapToEntity(EmployeeInput entity)
		{
			return new Employee
			{
				Name = entity.Name,
				Gender = entity.Gender,
				DateOfBirth = entity.DateOfBirth,
				Ethnic = entity.Ethnic,
				StartDate = entity.StartDate,
				Address = entity.Address,
				IdentityCardNumber = entity.IdentityCardNumber,
				Image = entity.Image,
				CoefficientAllowance = entity.CoefficientAllowance
			};
		}

		public static Models.EmployeeDetail MapToModelEmployeeDetail(Employee entity)
		{
			return new Models.EmployeeDetail
			{
				Name = entity.Name,
				Gender = entity.Gender,
				DateOfBirth = entity.DateOfBirth,
				Ethnic = entity.Ethnic,
				StartDate = entity.StartDate,
				Address = entity.Address,
				IdentityCardNumber = entity.IdentityCardNumber,
				Image = entity.Image,
				CoefficientAllowance = entity.CoefficientAllowance
			};
		}
	}
}



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

			var employee = Map(input);
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
			return new Result<Models.Employee> { Success = true, Payload = employee };
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
				return Context.Employees.Take(20).Select(e => Map(e)).ToList();
			}
			else
			{
				return Context.Employees.Where(
					e => EF.Functions.Like(e.Name, $"%{keyword}%") ||
						 EF.Functions.Like(e.Id, $"%{keyword}%")
				)
					.Select(e => Map(e)).ToList();
			}
		}

		public static Models.Employee Map(EmployeeInput input)
		{
			return new Models.Employee
			{
				Name = input.Name,
				Gender = input.Gender,
				DateOfBirth = input.DateOfBirth,
				Ethnic = input.Ethnic,
				StartDate = input.StartDate,
				Address = input.Address,
				IdentityCardNumber = input.IdentityCardNumber,
				Image = input.Image,
				CoefficientAllowance = input.CoefficientAllowance
			};
		}

		public static Models.Employee Map(Employee entity)
		{
			return new Models.Employee
			{
				Id = entity.Id,
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



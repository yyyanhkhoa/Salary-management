using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryEmployee : Repository
	{
		public bool CheckEmployeeExist(string identityCardNumber)
			=> Context.Employees.Any(a => a.IdentityCardNumber == identityCardNumber);

		public Result<Models.Employee> InsertEmployee(EmployeeInput input)
		{
			if (CheckEmployeeExist(input.Name))
				return new Result<Models.Employee> { Success = false, ErrorMessage = "Employee with this ID card already exists." };

			var Employee = Map(input);
			Context.Employees.Add(Employee);
			Context.SaveChanges();
			return new Result<Models.Employee> { Success = true, Payload = Employee };
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
	}
}



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
	public class RepositoryStaff : Repository
	{
		public bool CheckStaffExist(string identityCardNumber)
			=> Context.Staffs.Any(a => a.IdentityCardNumber == identityCardNumber);

		public Result<Models.Staff> InsertStaff(StaffInput input)
		{
			if (CheckStaffExist(input.Name))
				return new Result<Models.Staff> { Success = false, ErrorMessage = "Staff with this ID card already exists." };

			var staff = Map(input);
			Context.Staffs.Add(staff);
			Context.SaveChanges();
			return new Result<Models.Staff> { Success = true, Payload = staff };
		}

		public static Models.Staff Map(StaffInput input)
		{
			return new Models.Staff
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

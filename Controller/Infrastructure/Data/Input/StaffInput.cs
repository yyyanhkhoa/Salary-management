using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class StaffInput
	{
		public string Name { get; set; } = null!;

		public Gender Gender { get; set; }
		public DateOnly DateOfBirth { get; set; }

		public string Ethnic { get; set; } = null!;

		public DateOnly StartDate { get; set; }

		public string Address { get; set; } = null!;

		public string IdentityCardNumber { get; set; } = null!;

		public string Image { get; set; } = null!;

		public float CoefficientAllowance { get; set; }
	}
}

using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class Employee 
	{
		public string Id { get; set; } = null!;

		public string Name { get; set; } = null!;

		public DateOnly DateOfBirth { get; set; }

		public string IdentityCardNumber { get; set; } = null!;

		public float CoefficientAllowance { get; set; }
	}
}

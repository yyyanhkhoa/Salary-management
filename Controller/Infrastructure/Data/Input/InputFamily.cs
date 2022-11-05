using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputFamily
	{
		public string Name { get; set; } = null!;
		public DateOnly DateOfBirth { get; set; }
		public string Occupation { get; set; } = null!;
		public RelativeType RelativeType { get; set; }
		public string EmployeeId { get; set; } = null!;
	}
}

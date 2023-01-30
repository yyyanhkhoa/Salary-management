using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.Attributes;
using Salary_management.Infrastructure.Entities.Enums;

namespace Salary_management.Infrastructure.Entities
{
	public class Family
	{
		public int Id { get; set; }

		[MaxLength(255)]
		public string Name { get; set; } = null!;
		public DateOnly DateOfBirth { get; set; }

		[MaxLength(255)]
		public string Occupation { get; set; } = null!;

		public RelativeType RelativeType { get; set; }

		public string EmployeeId { get; set; } = null!;

		[EpplusIgnore]
		public Employee Employee { get; set; } = null!;
	}
}

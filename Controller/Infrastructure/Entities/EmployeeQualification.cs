using OfficeOpenXml.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure.Entities
{
	public class EmployeeQualification
	{
		public int Id { get; set; }
		public float Score { get; set; }

		public DateOnly IssueDate { get; set; }

		[MaxLength(255)]
		public string PlaceOfIssue { get; set; } = null!;

		public int QualificationId { get; set; }
		[EpplusIgnore]
		public Qualification Qualification { get; set; } = null!;

		public string EmployeeId { get; set; } = null!;
		[EpplusIgnore]
		public Employee Employee { get; set; } = null!;
	}
}

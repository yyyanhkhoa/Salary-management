using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class EmployeeQualification
	{
		public int Id { get; set; }
		public float Score { get; set; }
		public DateOnly IssueDate { get; set; }
		public string PlaceOfIssue { get; set; } = null!;
		public int QualificationId { get; set; }
		public string QualificationName { get; set; } = null!;
		public string EmployeeId { get; set; } = null!;
		public string EmployeeName { get; set; } = null!;
	}
}

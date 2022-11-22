using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputEmployeeQualification
	{
		public float Score { get; set; }
		public DateOnly IssueDate { get; set; }
		public string PlaceOfIssue { get; set; } = null!;
		public int QualificationId { get; set; }
		public string EmployeeId { get; set; } = null!;
	}
}

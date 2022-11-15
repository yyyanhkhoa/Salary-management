using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class RewardOrDiscipline
	{
		public int Id { get; set; }
		public string Level { get; set; } = null!;
		public DateOnly Date { get; set; }
		public string Content { get; set; } = null!;
		public string EmployeeId { get; set; } = null!;
		public string EmployeeName { get; set; } = null!;
	}
}

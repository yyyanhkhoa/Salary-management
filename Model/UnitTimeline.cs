using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class UnitTimeline
	{
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }

		public string EmployeeId { get; set; } = null!;
		public string EmployeeName { get; set; } = null!;
	}
}

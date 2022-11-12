using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure.Entities
{
	public class PositionHistory
	{
		public int Id { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }

		public string EmployeeId { get; set; } = null!;
		public Employee Employee { get; set; } = null!;

		public string PositionId { get; set; } = null!;
		public Position Position { get; set; } = null!;
	}
}

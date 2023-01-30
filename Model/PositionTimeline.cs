using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
    public class PositionTimeline : History
	{
		public int Id { get; set; }
		public string EmployeeName { get; set; } = null!;

		public string PositionId { get; set; } = null!;
	}
}

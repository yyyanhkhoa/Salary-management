using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class PositionHistory : History
	{
		public int Id { get; set; }
		public string PositionId { get; set; } = null!;
		public string PositionName { get; set; } = null!;
	}
}

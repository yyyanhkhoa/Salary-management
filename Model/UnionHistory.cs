using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class UnionHistory : History
	{
		public int Id { get; set; }
		public string UnionId { get; set; } = null!;
		public string UnionName { get; set; } = null!;
	}
}

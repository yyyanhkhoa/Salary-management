using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class EmployeeOfUnitOfUnion
	{
		public string EmployeeId { get; set; } = null!;

		public string EmployeeName { get; set; } = null!;

		public string UnionName { get; set; } = null!;

		public DateOnly UnionStartDate { get; set; }
	}
}

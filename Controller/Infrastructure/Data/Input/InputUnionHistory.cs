using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputUnionHistory : History
	{
		public string UnionId { get; set; } = null!;
	}
}

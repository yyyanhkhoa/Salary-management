using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputQualificationAllowanceHistory
	{
		public int Year { get; set; }
		public int Allowance { get; set; }
		public int QualificationId { get; set; }
	}
}

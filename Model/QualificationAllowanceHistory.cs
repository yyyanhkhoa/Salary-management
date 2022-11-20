using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class QualificationAllowanceHistory
	{
		public int Id { get; set; }
		public int Year { get; set; }
		public int Allowance { get; set; }

		public int QualificationId { get; set; }
		public string QualificationName { get; set; }
	}
}

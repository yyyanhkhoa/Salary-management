using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class TotalEmployeeSalary
	{
		public List<EmployeeSalary> EmployeeSalaries { get; set; }
		public double TotalSalary { get; set; }
	}
}

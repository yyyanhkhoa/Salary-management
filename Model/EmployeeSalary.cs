﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class EmployeeSalary
	{
		public string EmployeeId { get; set; } = null!;
		public string EmployeeName { get; set; } = null!;
		public string UnitId { get; set; } = null!;
		public string UnitName { get; set; } = null!;
		public int Salary { get; set; }
	}
}

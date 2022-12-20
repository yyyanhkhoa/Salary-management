using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class EmployeeSalary
	{
		public DateOnly Date { get; set; }
		public string EmployeeId { get; set; } = null!;
		public string EmployeeName { get; set; } = null!;
		public string UnitId { get; set; } = null!;
		public string UnitName { get; set; } = null!;
		public string RankName { get; set; } = null!;
		public double RankCoefficient { get; set; } // he so ngach
        public double EmployeeAllowanceCoefficient { get; set; }// he so phu cap
        public int RankLevel { get; set; } // ngach
        public int TotalQualificationAllowance { get; set; } // luong trinh do (tong)
		public int BaseSalary { get; set; }// luong co ban
        public double TotalCoefficient { get; set; }// tong he so
        public long Salary { get; set; }// tong luong
    }
}

using OfficeOpenXml.Attributes;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure.Entities
{
	public class UnitHistory : History
	{
		public int Id { get; set; }
		[EpplusIgnore]
		public Employee Employee { get; set; } = null!;

		public string UnitId { get; set; } = null!;
		[EpplusIgnore]
		public Unit Unit { get; set; } = null!;
	}
}

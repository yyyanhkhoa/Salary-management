using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputRewardOrDiscipline
	{
		public bool IsReward { get; set; }
		public string Level { get; set; } = null!;
		public DateOnly Date { get; set; }
		public string Content { get; set; } = null!;
		public string EmployeeId { get; set; } = null!;
	}
}

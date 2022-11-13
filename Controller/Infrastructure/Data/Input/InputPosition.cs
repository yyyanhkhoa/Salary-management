using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputPosition
	{
		public string Id { get; set; } = null!;

		public string Name { get; set; } = null!;

		public int BaseSalary { get; set; }

		public string? Description { get; set; }
		public int RankId { get; set; }
	}
}

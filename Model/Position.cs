using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	internal class Position
	{
		public string Id { get; set; } = null!;

		public string Name { get; set; } = null!;

		public int BaseSalary { get; set; }

		public string RankName { get; set; } = null!;
	}
}

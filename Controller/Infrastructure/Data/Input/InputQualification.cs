using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputQualification
	{
		public string Name { get; set; } = null!;
		public int ExpertiseId { get; set; }
	}
}

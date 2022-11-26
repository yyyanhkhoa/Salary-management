using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class Qualification
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
        public string NameCall { get; set; } = null!;
        public int ExpertiseId { get; set; }
		public Expertise Expertise { get; set; } = null!;
	}
}

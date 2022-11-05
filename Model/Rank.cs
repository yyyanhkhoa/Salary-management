using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class Rank 
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int Milestone { get; set; }
		public float Coefficient { get; set; }
	}
}

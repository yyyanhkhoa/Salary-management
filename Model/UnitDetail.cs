using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class UnitDetail
	{
		public string Id { get; set; } = null!;
		public string Name { get; set; } = null!;
		public string Address { get; set; } = null!;
		public string PhoneNumber { get; set; } = null!;
		public DateOnly DateFounded { get; set; }

		public List<UnitTimeline> Timeline { get; set; } = null!;
	}
}

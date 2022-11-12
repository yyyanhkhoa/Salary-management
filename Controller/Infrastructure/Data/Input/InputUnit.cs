using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data.Input
{
	public class InputUnit 
	{

		public string Id { get; set; } = null!;
		public string Name { get; set; } = null!;

		public string Address { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public DateOnly DateFounded { get; set; }
	}
}

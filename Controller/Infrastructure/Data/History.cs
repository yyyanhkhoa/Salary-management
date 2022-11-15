using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Data
{
    public abstract class History
    {
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string EmployeeId { get; set; } = null!;
	}
}

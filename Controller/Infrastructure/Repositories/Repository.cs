using Salary_management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public abstract class Repository
	{
		protected SalaryManContext Context { get; private set; }

		protected Repository()
		{
			Context = new SalaryManContext();
		}
	}
}

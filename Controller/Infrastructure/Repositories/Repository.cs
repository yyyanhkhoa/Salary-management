using Salary_management.Infrastructure;
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

using Salary_management.Controller.Infrastructure.Repositories;

namespace Salary_management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//var resAll = new RepositorySalary().GetEmployeeSalaries(new DateOnly(2022, 12, 1));
			//var resOmor = new RepositorySalary().GetEmployeeSalariesAtUnit("U_DAMN", new DateOnly(2022, 12, 1));
			//var res = new RepositorySalary().GetEmployeeSalaryAtYear("EM_5", 2022);
		
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			ApplicationConfiguration.Initialize();
            Application.Run(new Management(Controller.Infrastructure.Entities.Enums.Role.Admin));
            
        }
    }
}
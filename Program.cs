using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View;

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
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            //Application.Run(new Management(Controller.Infrastructure.Entities.Enums.Role.Admin));
            Application.Run(new LoginForm());

        }
    }
}
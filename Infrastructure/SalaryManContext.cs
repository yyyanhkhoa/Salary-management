using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure
{
	public class SalaryManContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseNpgsql("Host=localhost;Database=SalaryMan;Username=postgres;Password=postgres")
							 .UseSnakeCaseNamingConvention();
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//TODO: seeding some shit
		}
	}
}

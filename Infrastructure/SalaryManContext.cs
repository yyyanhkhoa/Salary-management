using Microsoft.EntityFrameworkCore;
using Npgsql;
using Salary_management.Infrastructure.Entities;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure
{
	public class SalaryManContext : DbContext
	{
		public DbSet<Staff> Staffs { get; set; } = null!;
		public DbSet<UnitHistory> UnitHistories { get; set; } = null!;
		public DbSet<Position> Positions { get; set; } = null!;
		public DbSet<PositionHistory> PositionHistories { get; set; } = null!;
		public DbSet<Relative> Relatives { get; set; } = null!;
		public DbSet<Qualification> Qualifications { get; set; } = null!;


		static SalaryManContext()
			=> NpgsqlConnection.GlobalTypeMapper.MapEnum<Gender>()
												.MapEnum<RelativeType>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseNpgsql("Host=localhost;Database=SalaryMan;Username=postgres;Password=postgres")
							 .UseSnakeCaseNamingConvention();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasPostgresEnum<Gender>()
						.HasPostgresEnum<RelativeType>();

			// config composite keys
			modelBuilder.Entity<PositionHistory>()
						.HasKey(c => new{ c.StaffId, c.PositionId });

			modelBuilder.Entity<UnitHistory>()
						.HasKey(c => new{ c.StaffId, c.UnitId });

			modelBuilder.Entity<UnionHistory>()
						.HasKey(c => new { c.StaffId, c.UnionId });

		}
	}
}

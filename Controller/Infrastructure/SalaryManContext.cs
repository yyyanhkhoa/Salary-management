﻿using Microsoft.EntityFrameworkCore;
using Npgsql;
using Salary_management.Controller.Infrastructure.Entities.Enums;
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
		public DbSet<RewardOrDiscipline> RewardOrDisciplines { get; set; } = null!;
		public DbSet<Auth> Auths { get; set; } = null!;
		public DbSet<Employee> Employees { get; set; } = null!;
		public DbSet<Rank> Ranks { get; set; } = null!;
		public DbSet<Unit> Units { get; set; } = null!;
		public DbSet<UnitHistory> UnitHistories { get; set; } = null!;
		public DbSet<Union> Unions { get; set; } = null!;
		public DbSet<Position> Positions { get; set; } = null!;
		public DbSet<PositionHistory> PositionHistories { get; set; } = null!;
		public DbSet<Relative> Relatives { get; set; } = null!;
		public DbSet<Qualification> Qualifications { get; set; } = null!;
		public DbSet<EmployeeQualification> EmployeeQualifications { get; set; } = null!;
		public DbSet<QualificationAllowanceHistory> QualificationAllowanceHistories { get; set; } = null!;


		static SalaryManContext()
			=> NpgsqlConnection.GlobalTypeMapper.MapEnum<Gender>()
												.MapEnum<RelativeType>()
												.MapEnum<Role>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = File.Exists("connection-string.txt") ? 
				File.ReadLines("connection-string.txt").First() :
				"Host=localhost;Database=SalaryMan;Username=postgres;Password=postgres";
			
			optionsBuilder.UseNpgsql(connectionString)
							 .UseSnakeCaseNamingConvention();

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasPostgresEnum<Gender>()
						.HasPostgresEnum<RelativeType>()
						.HasPostgresEnum<Role>();

			// config
			modelBuilder.Entity<Auth>().HasAlternateKey(e => e.Username);

			modelBuilder.Entity<PositionHistory>()
						.HasKey(e => new{ e.EmployeeId, e.PositionId });

			modelBuilder.Entity<UnitHistory>()
						.HasKey(e => new{ e.EmployeeId, e.UnitId });

			modelBuilder.Entity<UnionHistory>()
						.HasKey(e => new { e.EmployeeId, e.UnionId });

			modelBuilder.Entity<EmployeeQualification>()
						.HasKey(e => new { e.EmployeeId, e.QualificationId });

			modelBuilder.Entity<QualificationAllowanceHistory>()
						.HasKey(e => new { e.QualificationId, e.Year } );

			modelBuilder.Entity<Employee>()
						.Property(e => e.DateCreated)
						.HasDefaultValueSql("now()");

			// seed DB
			modelBuilder.Entity<Auth>()
						.HasData(new Auth { Id = 1, Username = "admin", Password = "admin" });
		}
	}
}

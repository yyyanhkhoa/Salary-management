using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class EmployeeImageBytea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("alter table employees alter column image TYPE bytea USING image::bytea;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("alter table employees alter column image TYPE text USING image::text;");
		}
	}
}

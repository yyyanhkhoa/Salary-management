using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class Unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "ak_auths_username",
                table: "auths");

            migrationBuilder.CreateTable(
                name: "employee_salaries",
                columns: table => new
                {
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    employee_id = table.Column<string>(type: "text", nullable: false),
                    employee_name = table.Column<string>(type: "text", nullable: false),
                    unit_id = table.Column<string>(type: "text", nullable: false),
                    unit_name = table.Column<string>(type: "text", nullable: false),
                    rank_name = table.Column<string>(type: "text", nullable: false),
                    rank_coefficient = table.Column<double>(type: "double precision", nullable: false),
                    employee_allowance_coefficient = table.Column<double>(type: "double precision", nullable: false),
                    rank_level = table.Column<int>(type: "integer", nullable: false),
                    total_qualification_allowance = table.Column<int>(type: "integer", nullable: false),
                    base_salary = table.Column<int>(type: "integer", nullable: false),
                    total_coefficient = table.Column<double>(type: "double precision", nullable: false),
                    salary = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "ix_auths_username",
                table: "auths",
                column: "username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_salaries");

            migrationBuilder.DropIndex(
                name: "ix_auths_username",
                table: "auths");

            migrationBuilder.AddUniqueConstraint(
                name: "ak_auths_username",
                table: "auths",
                column: "username");
        }
    }
}

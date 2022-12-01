using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class RemoveAlternateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "ak_employee_qualifications_employee_id_qualification_id",
                table: "employee_qualifications");

            migrationBuilder.CreateIndex(
                name: "ix_employee_qualifications_employee_id",
                table: "employee_qualifications",
                column: "employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_employee_qualifications_employee_id",
                table: "employee_qualifications");

            migrationBuilder.AddUniqueConstraint(
                name: "ak_employee_qualifications_employee_id_qualification_id",
                table: "employee_qualifications",
                columns: new[] { "employee_id", "qualification_id" });
        }
    }
}

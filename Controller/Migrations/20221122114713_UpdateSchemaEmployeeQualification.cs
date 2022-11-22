using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Salary_management.Controller.Infrastructure.Entities.Enums;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class UpdateSchemaEmployeeQualification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_employee_qualifications",
                table: "employee_qualifications");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "employee_qualifications",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddUniqueConstraint(
                name: "ak_employee_qualifications_employee_id_qualification_id",
                table: "employee_qualifications",
                columns: new[] { "employee_id", "qualification_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_employee_qualifications",
                table: "employee_qualifications",
                column: "id");

            migrationBuilder.UpdateData(
                table: "auths",
                keyColumn: "id",
                keyValue: 1,
                column: "role",
                value: Role.Admin);

            migrationBuilder.InsertData(
                table: "auths",
                columns: new[] { "id", "password", "role", "username" },
                values: new object[,]
                {
                    { 2, "accountant", Role.Accountant, "accountant" },
                    { 3, "viewer", Role.Viewer, "viewer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "ak_employee_qualifications_employee_id_qualification_id",
                table: "employee_qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employee_qualifications",
                table: "employee_qualifications");

            migrationBuilder.DeleteData(
                table: "auths",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "auths",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "id",
                table: "employee_qualifications");

            migrationBuilder.AddPrimaryKey(
                name: "pk_employee_qualifications",
                table: "employee_qualifications",
                columns: new[] { "employee_id", "qualification_id" });

            migrationBuilder.UpdateData(
                table: "auths",
                keyColumn: "id",
                keyValue: 1,
                column: "role",
                value: Role.Accountant);
        }
    }
}

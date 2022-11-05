using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Salary_management.Infrastructure.Entities.Enums;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class RenameRelativeToFamily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "relatives");

            migrationBuilder.CreateTable(
                name: "families",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    occupation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    relative_type = table.Column<RelativeType>(type: "relative_type", nullable: false),
                    employee_id = table.Column<string>(type: "character varying(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_families", x => x.id);
                    table.ForeignKey(
                        name: "fk_families_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_families_employee_id",
                table: "families",
                column: "employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "families");

            migrationBuilder.CreateTable(
                name: "relatives",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_id = table.Column<string>(type: "character varying(255)", nullable: false),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    occupation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    relative_type = table.Column<RelativeType>(type: "relative_type", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_relatives", x => x.id);
                    table.ForeignKey(
                        name: "fk_relatives_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_relatives_employee_id",
                table: "relatives",
                column: "employee_id");
        }
    }
}

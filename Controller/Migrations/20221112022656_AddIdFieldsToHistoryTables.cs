using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class AddIdFieldsToHistoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_union_history_employees_employee_id",
                table: "union_history");

            migrationBuilder.DropForeignKey(
                name: "fk_union_history_unions_union_id",
                table: "union_history");

            migrationBuilder.DropPrimaryKey(
                name: "pk_unit_histories",
                table: "unit_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_qualification_allowance_histories",
                table: "qualification_allowance_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_position_histories",
                table: "position_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_union_history",
                table: "union_history");

            migrationBuilder.RenameTable(
                name: "union_history",
                newName: "union_histories");

            migrationBuilder.RenameIndex(
                name: "ix_union_history_union_id",
                table: "union_histories",
                newName: "ix_union_histories_union_id");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "unit_histories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "qualification_allowance_histories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "position_histories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "union_histories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_unit_histories",
                table: "unit_histories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_qualification_allowance_histories",
                table: "qualification_allowance_histories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_position_histories",
                table: "position_histories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_union_histories",
                table: "union_histories",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "ix_unit_histories_employee_id",
                table: "unit_histories",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_qualification_allowance_histories_qualification_id",
                table: "qualification_allowance_histories",
                column: "qualification_id");

            migrationBuilder.CreateIndex(
                name: "ix_position_histories_employee_id",
                table: "position_histories",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_union_histories_employee_id",
                table: "union_histories",
                column: "employee_id");

            migrationBuilder.AddForeignKey(
                name: "fk_union_histories_employees_employee_id",
                table: "union_histories",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_union_histories_unions_union_id",
                table: "union_histories",
                column: "union_id",
                principalTable: "unions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_union_histories_employees_employee_id",
                table: "union_histories");

            migrationBuilder.DropForeignKey(
                name: "fk_union_histories_unions_union_id",
                table: "union_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_unit_histories",
                table: "unit_histories");

            migrationBuilder.DropIndex(
                name: "ix_unit_histories_employee_id",
                table: "unit_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_qualification_allowance_histories",
                table: "qualification_allowance_histories");

            migrationBuilder.DropIndex(
                name: "ix_qualification_allowance_histories_qualification_id",
                table: "qualification_allowance_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_position_histories",
                table: "position_histories");

            migrationBuilder.DropIndex(
                name: "ix_position_histories_employee_id",
                table: "position_histories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_union_histories",
                table: "union_histories");

            migrationBuilder.DropIndex(
                name: "ix_union_histories_employee_id",
                table: "union_histories");

            migrationBuilder.DropColumn(
                name: "id",
                table: "unit_histories");

            migrationBuilder.DropColumn(
                name: "id",
                table: "qualification_allowance_histories");

            migrationBuilder.DropColumn(
                name: "description",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "id",
                table: "position_histories");

            migrationBuilder.DropColumn(
                name: "id",
                table: "union_histories");

            migrationBuilder.RenameTable(
                name: "union_histories",
                newName: "union_history");

            migrationBuilder.RenameIndex(
                name: "ix_union_histories_union_id",
                table: "union_history",
                newName: "ix_union_history_union_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_unit_histories",
                table: "unit_histories",
                columns: new[] { "employee_id", "unit_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_qualification_allowance_histories",
                table: "qualification_allowance_histories",
                columns: new[] { "qualification_id", "year" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_position_histories",
                table: "position_histories",
                columns: new[] { "employee_id", "position_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_union_history",
                table: "union_history",
                columns: new[] { "employee_id", "union_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_union_history_employees_employee_id",
                table: "union_history",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_union_history_unions_union_id",
                table: "union_history",
                column: "union_id",
                principalTable: "unions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Infrastructure.Entities.Enums;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class RenameStaffToEmployeeAndUpdateAuth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_position_histories_staffs_staff_id",
                table: "position_histories");

            migrationBuilder.DropForeignKey(
                name: "fk_relatives_staffs_staff_id",
                table: "relatives");

            migrationBuilder.DropForeignKey(
                name: "fk_reward_or_disciplines_staffs_staff_id",
                table: "reward_or_disciplines");

            migrationBuilder.DropForeignKey(
                name: "fk_union_history_staffs_staff_id",
                table: "union_history");

            migrationBuilder.DropForeignKey(
                name: "fk_union_history_union_union_id",
                table: "union_history");

            migrationBuilder.DropForeignKey(
                name: "fk_unit_histories_staffs_staff_id",
                table: "unit_histories");

            migrationBuilder.DropForeignKey(
                name: "fk_unit_histories_unit_unit_id",
                table: "unit_histories");

            migrationBuilder.DropTable(
                name: "staff_qualifications");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropPrimaryKey(
                name: "pk_unit",
                table: "unit");

            migrationBuilder.DropPrimaryKey(
                name: "pk_union",
                table: "union");

            migrationBuilder.RenameTable(
                name: "unit",
                newName: "units");

            migrationBuilder.RenameTable(
                name: "union",
                newName: "unions");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "unit_histories",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "union_history",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "reward_or_disciplines",
                newName: "employee_id");

            migrationBuilder.RenameIndex(
                name: "ix_reward_or_disciplines_staff_id",
                table: "reward_or_disciplines",
                newName: "ix_reward_or_disciplines_employee_id");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "relatives",
                newName: "employee_id");

            migrationBuilder.RenameIndex(
                name: "ix_relatives_staff_id",
                table: "relatives",
                newName: "ix_relatives_employee_id");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "position_histories",
                newName: "employee_id");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:gender", "male,female,other")
                .Annotation("Npgsql:Enum:relative_type", "wife,husband,child")
                .Annotation("Npgsql:Enum:role", "accountant,viewer,admin")
                .OldAnnotation("Npgsql:Enum:gender", "male,female,other")
                .OldAnnotation("Npgsql:Enum:relative_type", "wife,husband,child");

            migrationBuilder.AddColumn<Role>(
                name: "role",
                table: "auths",
                type: "role",
                nullable: false,
                defaultValue: Role.Accountant);

            migrationBuilder.AddPrimaryKey(
                name: "pk_units",
                table: "units",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_unions",
                table: "unions",
                column: "id");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    gender = table.Column<Gender>(type: "gender", nullable: false),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    ethnic = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    identity_card_number = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    image = table.Column<string>(type: "text", nullable: false),
                    coefficient_allowance = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employee_qualifications",
                columns: table => new
                {
                    qualification_id = table.Column<int>(type: "integer", nullable: false),
                    employee_id = table.Column<string>(type: "character varying(255)", nullable: false),
                    score = table.Column<float>(type: "real", nullable: false),
                    issue_date = table.Column<DateOnly>(type: "date", nullable: false),
                    place_of_issue = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_qualifications", x => new { x.employee_id, x.qualification_id });
                    table.ForeignKey(
                        name: "fk_employee_qualifications_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_qualifications_qualifications_qualification_id",
                        column: x => x.qualification_id,
                        principalTable: "qualifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_employee_qualifications_qualification_id",
                table: "employee_qualifications",
                column: "qualification_id");

            migrationBuilder.AddForeignKey(
                name: "fk_position_histories_employees_employee_id",
                table: "position_histories",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_relatives_employees_employee_id",
                table: "relatives",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_reward_or_disciplines_employees_employee_id",
                table: "reward_or_disciplines",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "fk_unit_histories_employees_employee_id",
                table: "unit_histories",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_unit_histories_units_unit_id",
                table: "unit_histories",
                column: "unit_id",
                principalTable: "units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_position_histories_employees_employee_id",
                table: "position_histories");

            migrationBuilder.DropForeignKey(
                name: "fk_relatives_employees_employee_id",
                table: "relatives");

            migrationBuilder.DropForeignKey(
                name: "fk_reward_or_disciplines_employees_employee_id",
                table: "reward_or_disciplines");

            migrationBuilder.DropForeignKey(
                name: "fk_union_history_employees_employee_id",
                table: "union_history");

            migrationBuilder.DropForeignKey(
                name: "fk_union_history_unions_union_id",
                table: "union_history");

            migrationBuilder.DropForeignKey(
                name: "fk_unit_histories_employees_employee_id",
                table: "unit_histories");

            migrationBuilder.DropForeignKey(
                name: "fk_unit_histories_units_unit_id",
                table: "unit_histories");

            migrationBuilder.DropTable(
                name: "employee_qualifications");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "pk_units",
                table: "units");

            migrationBuilder.DropPrimaryKey(
                name: "pk_unions",
                table: "unions");

            migrationBuilder.DropColumn(
                name: "role",
                table: "auths");

            migrationBuilder.RenameTable(
                name: "units",
                newName: "unit");

            migrationBuilder.RenameTable(
                name: "unions",
                newName: "union");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "unit_histories",
                newName: "staff_id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "union_history",
                newName: "staff_id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "reward_or_disciplines",
                newName: "staff_id");

            migrationBuilder.RenameIndex(
                name: "ix_reward_or_disciplines_employee_id",
                table: "reward_or_disciplines",
                newName: "ix_reward_or_disciplines_staff_id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "relatives",
                newName: "staff_id");

            migrationBuilder.RenameIndex(
                name: "ix_relatives_employee_id",
                table: "relatives",
                newName: "ix_relatives_staff_id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "position_histories",
                newName: "staff_id");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:gender", "male,female,other")
                .Annotation("Npgsql:Enum:relative_type", "wife,husband,child")
                .OldAnnotation("Npgsql:Enum:gender", "male,female,other")
                .OldAnnotation("Npgsql:Enum:relative_type", "wife,husband,child")
                .OldAnnotation("Npgsql:Enum:role", "accountant,viewer,admin");

            migrationBuilder.AddPrimaryKey(
                name: "pk_unit",
                table: "unit",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_union",
                table: "union",
                column: "id");

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    coefficient_allowance = table.Column<float>(type: "real", nullable: false),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    ethnic = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    gender = table.Column<Gender>(type: "gender", nullable: false),
                    identity_card_number = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    image = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_staffs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "staff_qualifications",
                columns: table => new
                {
                    staff_id = table.Column<string>(type: "character varying(255)", nullable: false),
                    qualification_id = table.Column<int>(type: "integer", nullable: false),
                    issue_date = table.Column<DateOnly>(type: "date", nullable: false),
                    place_of_issue = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_staff_qualifications", x => new { x.staff_id, x.qualification_id });
                    table.ForeignKey(
                        name: "fk_staff_qualifications_qualifications_qualification_id",
                        column: x => x.qualification_id,
                        principalTable: "qualifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_staff_qualifications_staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "staffs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_staff_qualifications_qualification_id",
                table: "staff_qualifications",
                column: "qualification_id");

            migrationBuilder.AddForeignKey(
                name: "fk_position_histories_staffs_staff_id",
                table: "position_histories",
                column: "staff_id",
                principalTable: "staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_relatives_staffs_staff_id",
                table: "relatives",
                column: "staff_id",
                principalTable: "staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_reward_or_disciplines_staffs_staff_id",
                table: "reward_or_disciplines",
                column: "staff_id",
                principalTable: "staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_union_history_staffs_staff_id",
                table: "union_history",
                column: "staff_id",
                principalTable: "staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_union_history_union_union_id",
                table: "union_history",
                column: "union_id",
                principalTable: "union",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_unit_histories_staffs_staff_id",
                table: "unit_histories",
                column: "staff_id",
                principalTable: "staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_unit_histories_unit_unit_id",
                table: "unit_histories",
                column: "unit_id",
                principalTable: "unit",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

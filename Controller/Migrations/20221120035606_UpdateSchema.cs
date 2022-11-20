using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class UpdateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_qualifications_expertise_expertise_id",
                table: "qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "pk_expertise",
                table: "expertise");

            migrationBuilder.RenameTable(
                name: "expertise",
                newName: "expertises");

            migrationBuilder.AddPrimaryKey(
                name: "pk_expertises",
                table: "expertises",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_qualifications_expertises_expertise_id",
                table: "qualifications",
                column: "expertise_id",
                principalTable: "expertises",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_qualifications_expertises_expertise_id",
                table: "qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "pk_expertises",
                table: "expertises");

            migrationBuilder.RenameTable(
                name: "expertises",
                newName: "expertise");

            migrationBuilder.AddPrimaryKey(
                name: "pk_expertise",
                table: "expertise",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_qualifications_expertise_expertise_id",
                table: "qualifications",
                column: "expertise_id",
                principalTable: "expertise",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

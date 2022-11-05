using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class ahihi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "positions",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "positions");
        }
    }
}

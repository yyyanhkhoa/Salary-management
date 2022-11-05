using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary_management.Migrations
{
    public partial class AddDateCreatedOnEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_positions_rank_rank_id",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rank",
                table: "rank");

            migrationBuilder.RenameTable(
                name: "rank",
                newName: "ranks");

            migrationBuilder.AddColumn<DateTime>(
                name: "date_created",
                table: "employees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ranks",
                table: "ranks",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_positions_ranks_rank_id",
                table: "positions",
                column: "rank_id",
                principalTable: "ranks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_positions_ranks_rank_id",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ranks",
                table: "ranks");

            migrationBuilder.DropColumn(
                name: "date_created",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "ranks",
                newName: "rank");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rank",
                table: "rank",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_positions_rank_rank_id",
                table: "positions",
                column: "rank_id",
                principalTable: "rank",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

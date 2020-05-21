using Microsoft.EntityFrameworkCore.Migrations;

namespace LIbraryNetCore.Migrations
{
    public partial class UpdateRatingNameUpdateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

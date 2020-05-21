using Microsoft.EntityFrameworkCore.Migrations;

namespace LIbraryNetCore.Migrations
{
    public partial class UpdateRatingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

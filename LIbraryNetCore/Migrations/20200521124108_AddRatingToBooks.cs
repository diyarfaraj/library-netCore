using Microsoft.EntityFrameworkCore.Migrations;

namespace LIbraryNetCore.Migrations
{
    public partial class AddRatingToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Book");
        }
    }
}

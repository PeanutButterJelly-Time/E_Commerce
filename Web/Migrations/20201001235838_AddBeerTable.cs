using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class AddBeerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Abv",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeerStyle",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ibu",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abv",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BeerStyle",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ibu",
                table: "Products");
        }
    }
}

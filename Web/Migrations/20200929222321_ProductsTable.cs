using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class ProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Calories = table.Column<double>(nullable: true),
                    Protein = table.Column<double>(nullable: true),
                    Fat = table.Column<double>(nullable: true),
                    Sodium = table.Column<double>(nullable: true),
                    Fiber = table.Column<double>(nullable: true),
                    Carbo = table.Column<double>(nullable: true),
                    Sugars = table.Column<double>(nullable: true),
                    Potassium = table.Column<double>(nullable: true),
                    Vitamins = table.Column<int>(nullable: true),
                    Shelf = table.Column<int>(nullable: true),
                    Weight = table.Column<double>(nullable: true),
                    Cups = table.Column<double>(nullable: true),
                    Style = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

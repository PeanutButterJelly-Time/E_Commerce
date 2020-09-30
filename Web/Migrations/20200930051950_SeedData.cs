using Microsoft.EntityFrameworkCore.Migrations;


namespace Web.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discriminator", "Manufacturer", "Name", "Rating", "Style" },
                values: new object[] { -1, "Shoe", "Jordan", "AJ1", 0.0, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discriminator", "Manufacturer", "Name", "Rating", "Style" },
                values: new object[] { -2, "Shoe", "Jordan", "AJ5", 0.0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discriminator", "Manufacturer", "Name", "Rating", "Style" },
                values: new object[] { -3, "Shoe", "Jordan", "AJ13", 0.0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}

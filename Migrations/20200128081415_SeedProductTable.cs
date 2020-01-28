using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUri", "Name", "Price" },
                values: new object[] { 1, "Do you want to be the one to stand out in a crowd? This skirt will fit for any occasion", "/img/product_01.jpg", "Crazy skirt", 499.89999999999998 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUri", "Name", "Price" },
                values: new object[] { 2, "These pants will certainly get you the attention you deserve. Be brave, be free, be wild", "/img/product_02.jpg", "Wild pants", 899.89999999999998 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUri", "Name", "Price" },
                values: new object[] { 3, "This jacket will keep you both warm and dazzling. It comes in many vibrant colours. What is your furry?", "/img/product_03.jpg", "Furry coatee", 1299.9000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

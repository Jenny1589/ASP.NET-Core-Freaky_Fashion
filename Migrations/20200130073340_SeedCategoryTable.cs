using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImageUri", "IsHighlighted", "Name" },
                values: new object[,]
                {
                    { 1, "/img/campaign.jpg", true, "Campaign" },
                    { 2, "/img/news.jpg", true, "News" },
                    { 3, "/img/spring.jpg", true, "Spring" },
                    { 4, "/img/shirt_01.jpg", false, "Shirts" },
                    { 5, "/img/blouse_01.jpg", false, "Blouses" },
                    { 6, "/img/jeans_01.jpg", false, "Jeans" },
                    { 7, "/img/dress_01.jpg", false, "Dresses" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

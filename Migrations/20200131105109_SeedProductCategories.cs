using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedProductCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 11, 2 },
                    { 10, 4 },
                    { 10, 2 },
                    { 9, 6 },
                    { 9, 2 },
                    { 8, 7 },
                    { 8, 1 },
                    { 7, 4 },
                    { 7, 3 },
                    { 11, 3 },
                    { 6, 6 },
                    { 5, 3 },
                    { 4, 5 },
                    { 4, 1 },
                    { 3, 5 },
                    { 3, 2 },
                    { 2, 6 },
                    { 2, 2 },
                    { 1, 6 },
                    { 1, 3 },
                    { 5, 7 },
                    { 11, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 11, 7 });
        }
    }
}

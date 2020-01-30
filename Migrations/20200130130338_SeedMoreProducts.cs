using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUri", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "You will be the center of all attention, 100% guarantee!Gorgeous will bring out your freaky. Get ready to party!", "/img/blouse_01.jpg", "Gorgeous blouse", 349.94999999999999 },
                    { 5, "This is deffinately THE dress.You will see shapes you didn't know you had.", "/img/dress_01.jpg", "Green flower dress", 3599.9000000000001 },
                    { 6, "Too cool for school? Get theese jeans today!", "/img/jeans_01.jpg", "Cool jeans", 699.0 },
                    { 7, "You feel bad? No you are just freaky!Show the real you.", "/img/shirt_01.jpg", "Bad girl shirt", 295.0 },
                    { 8, "Own the beach this summer? Of course you wantWhat are you waiting for?", "/img/dress_02.jpg", "Freaky beach dress", 595.0 },
                    { 9, "Casual, comfortable, enjoyable!No need to get stiff in theese pants", "/img/jeans_02.jpg", "Get dirty jeans", 899.0 },
                    { 10, "Are you a Pepsi fan? Show it to the world!", "/img/shirt_02.jpg", "Pepsi Cola shirt", 99.0 },
                    { 11, "Elegant, beautiful, yes just gorgeous - Or as we say: Smokin'", "/img/dress_03.jpg", "Smokin' dress", 1999.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}

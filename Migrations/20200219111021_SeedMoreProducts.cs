using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "6f821901-e7b0-4e16-b009-447738576bbe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f821901-e7b0-4e16-b009-447738576bbe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1a8b483-a388-41bf-9551-8db71964935c", "84acef83-fc3f-4bd1-b029-617090ea0a0f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ff4a86d-fb05-4704-b127-ec8255277f41", "AQAAAAEAACcQAAAAELaqNDFS2frJWt0+nF/b4+uhl2HaMW8EzYqBKqwNVjKTwLoNgtI+3QU8rjir7eRIfg==", "ae745def-a517-4c8a-b617-dcef5bdd14cd" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ArticleNumber", "Description", "ImageUri", "Name", "Price", "UrlSlug" },
                values: new object[,]
                {
                    { 2, "9876-5432", "This is Freaky Fashion isn't it? Of course it is. Bring out your Freaky!", "/img/jeans_03.jpg", "Freaky Jeans", 245.0, "freaky-jeans-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 3, "8765-4321", "You are a bad girl aren't you? Of course you are. Dare you to show it off!", "/img/shirt_01.jpg", "Bad Girl Shirt", 895.0, "bad-girl-shirt-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 4, "2345-6789", "Really elegant and posh. Fits for the everyday stand out look or for the next party", "/img/dress_03.jpg", "Smokin Dress", 999.0, "smokin-dress-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 5, "3456-7890", "Every freaky girl must have a pair of jeans in their closet.", "/img/jeans_01.jpg", "Pretty Freaky Jeans", 799.0, "pretty-freaky-jeans-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 6, "4321-8765", "Own the beach this summer? Of course you want! Pro tip: Buy this dress and work it along the shore", "/img/dress_02.jpg", "Beach Dress", 390.0, "beach-dress-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 7, "1234-5678", "Do you feel like an animal? This freaky blouse comes in many vibrant colours. Pick your furry!", "/img/blouse_03.jpg", "Furry Blouse", 469.0, "furry-blouse-6d544e5c-a32b-4130-877f-94b13040ff92" },
                    { 8, "1234-5678", "Are you a Pepsi fan like us? Then you just can't be without this shirt...", "/img/shirt_02.jpg", "Pepsi Shirt", 89.0, "pepsi-shirt-6d544e5c-a32b-4130-877f-94b13040ff92" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "b1a8b483-a388-41bf-9551-8db71964935c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "b1a8b483-a388-41bf-9551-8db71964935c" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1a8b483-a388-41bf-9551-8db71964935c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f821901-e7b0-4e16-b009-447738576bbe", "ef4cd219-2161-4427-bc39-57759b805aee", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f12f65-ae31-460c-b69f-d3e24e6bfd92", "AQAAAAEAACcQAAAAEFolPmVtLTCYMq6qKhIcAo3k5t+cYyix5Yv0Y2TlCdnVLjZF2QdoKhIoAOJe3fErww==", "6c1676a3-7dbd-4925-978b-dde74cab9e64" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "6f821901-e7b0-4e16-b009-447738576bbe" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedDataInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "9ba68d48-1b3b-484b-81e3-652e0ddfb7ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ba68d48-1b3b-484b-81e3-652e0ddfb7ce");

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "campaign-d87fd666-0bc1-49c4-9aae-7378aa3476ef");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "news-d8ceb934-a053-4528-be14-62270f6555bd");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "spring-8fa53587-3f40-4431-a267-93202954cecb");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "shirts-18b27c8b-10d0-4bc6-81cf-6345bc215868");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "blouses-6ef1ae86-f4c0-42b8-b183-db5831181cf7");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "jeans-c038d230-d071-48d8-a005-644070e4b2e5");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "dresses-197fb20e-14e5-4a06-8fba-f0ddd97d47df");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ArticleNumber", "Description", "ImageUri", "Name", "Price", "UrlSlug" },
                values: new object[] { 1, "1234-5678", "Something must exist in this freaky business! Buy it... NOW!", "/img/blouse_01.jpg", "Campaign Blouse", 895.0, "campaign-blouse-6d544e5c-a32b-4130-877f-94b13040ff92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "6f821901-e7b0-4e16-b009-447738576bbe" });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 1, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "6f821901-e7b0-4e16-b009-447738576bbe" });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f821901-e7b0-4e16-b009-447738576bbe");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ba68d48-1b3b-484b-81e3-652e0ddfb7ce", "39cc84a0-84fd-4faf-ada2-2df92e70f494", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fcaff3-da1a-4dfc-ae77-1da5cacb0db3", "AQAAAAEAACcQAAAAEGhXl4NHwmHIN35XkIeA05Ww+QD1asXo468UCEMRu68y+oqJjn5nO/fGTkvshLw1lw==", "e3a35cf6-cf86-43e2-af92-888de1809d44" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "campaign-aca44cb8-0680-4145-8588-87d7893e87ea");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "news-72581154-4bae-42c0-b97c-049c50a3cdca");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "spring-db7ed543-ae00-4ba9-9145-2884b1c702ff");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "shirts-514a5cb7-97b5-4888-93ab-4645717da573");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "blouses-1920a5b2-ee4a-466e-a12c-a856c79f4a17");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "jeans-f9ba1eea-1081-41cf-82bf-e938347a6b6b");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "dresses-16d2fb8e-98d3-4302-9898-ee2b9519f2cf");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "9ba68d48-1b3b-484b-81e3-652e0ddfb7ce" });
        }
    }
}

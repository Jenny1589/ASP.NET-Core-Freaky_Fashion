using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b803634-477f-4460-9f63-807fe350bde7", "eed65a50-8ff7-4a83-9ad5-f8c65a56e9cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "feec6ea3-97fb-4aca-8001-27a12f226daf", "admin@nomail.com", true, false, null, "ADMIN@NOMAIL.COM", "ADMIN@NOMAIL.COM", "AQAAAAEAACcQAAAAEFgvBb6WDddc3d0HmM0SdTZ5w48QSTPSIIPkJ5R9VkTb0ZzW2wfP4KTukJv9p7Zt2Q==", "0707-12345", false, "35b965ba-cd4d-4ed5-a8a7-eaa08057f9d0", false, "admin@nomail.com" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "campaign-19f6dde9-c744-45f3-906c-615d47033574");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "news-b4304a8a-3e20-4cd6-a73d-2e9a81a55f94");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "spring-5a30dc7b-8903-4537-91ef-90e6c8e08e6e");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "shirts-ff7dcfcc-caff-4c5b-a7d0-e86100485829");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "blouses-fda6d09e-eb6d-459c-9e44-5fd914ca5faf");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "jeans-7f81f8ec-4af9-4c1e-8099-dba5724fc420");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "dresses-dff6a830-11a1-4022-90cd-328ffa6f9d0f");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "crazy-skirt-d82cd45f-b21b-47e7-a1f3-a089bf9e07b0");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "wild-pants-efdd6976-df3c-4e46-b019-784ce3258e33");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "furry-coatee-3abd0c2f-f587-4569-84d6-14de5aba2d57");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "gorgeous-blouse-9a9eb725-deb6-4037-9aff-08069886fc81");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "green-flower-dress-7dca5087-b74d-45e2-bf4b-ef5f0fddfdf4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "cool-jeans-8fb007b2-1d28-46b1-94d6-6ca2cc326292");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "bad-girl-shirt-4567063a-3370-4a89-a9ac-7b0a595f132d");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "UrlSlug",
                value: "freaky-beach-dress-b8890761-25d3-4340-967e-6d85d6ccd86f");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "UrlSlug",
                value: "get-dirty-jeans-e0dd4cfa-b8f1-4f81-b473-7122ce195b4b");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "UrlSlug",
                value: "pepsi-cola-shirt-f156809a-4e21-48cc-88d3-6881e8b0759d");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "UrlSlug",
                value: "smokin'-dress-6dd291e6-efb2-4546-8a00-65f787a2513c");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "9b803634-477f-4460-9f63-807fe350bde7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "9b803634-477f-4460-9f63-807fe350bde7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b803634-477f-4460-9f63-807fe350bde7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "campaign-a0b6b076-7bca-4188-8de3-fc0601127740");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "news-edc31a9f-7378-473e-aa60-c7ab802fe16b");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "spring-a54697a3-905b-4139-95dd-3e2fbf542747");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "shirts-5a78e209-b2d3-4bc8-a7d3-fbbbd22b60c1");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "blouses-586bea5d-736c-4b0b-b3bc-620069eec8bd");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "jeans-b050abdc-2fbb-4a0a-bb9d-8a23db29b7de");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "dresses-72c9b09e-8e47-4c75-a89d-da436bc83684");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "crazy-skirt-54a4e744-8a8a-47ca-bdd2-206e375bd41f");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "wild-pants-1b90fc8e-d4ac-47a3-8fbf-9e395eccaa64");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "furry-coatee-dacdd260-4210-404a-afdc-15c9fb368dbc");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "gorgeous-blouse-958cb71a-9f83-4819-9518-732f1a68eab1");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "green-flower-dress-dc4cbdbd-9420-4183-b2b9-19fb55a2a8b9");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "cool-jeans-dea0734e-8f0a-4025-b5c0-60f741b2e319");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "bad-girl-shirt-2c9a9f6e-3a27-4623-8383-e5c77f3d4bee");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "UrlSlug",
                value: "freaky-beach-dress-b324ed9b-3bf6-4121-8e14-f6e76def7e43");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "UrlSlug",
                value: "get-dirty-jeans-f0364c70-1b45-429f-a10a-03a581ee4891");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "UrlSlug",
                value: "pepsi-cola-shirt-2eb5f5ac-7436-4d30-9b84-633e6722f222");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "UrlSlug",
                value: "smokin'-dress-e69f5213-872f-45be-95c9-ded5b2e407c6");
        }
    }
}

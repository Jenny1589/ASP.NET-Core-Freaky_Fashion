using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class CompleteUserInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f735bc9b-f5de-40ec-b161-a5ed7fd46491", "408b7bfc-60be-4fcd-a91d-eae870509b64", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SocialSecurityNumber", "Street", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "Helsingborg", "28e217b2-a64c-4b7c-9264-78a9555ad89b", "admin@nomail.com", true, "Jenny", "Kallerup", false, null, "ADMIN@NOMAIL.COM", "ADMIN@NOMAIL.COM", "AQAAAAEAACcQAAAAEGgemMn+CGWZ63Lrl9K/SZcsFrpnWib/WJlvt9Gxy87feC20HkqltONHjMdTFWSAyQ==", "0707-12345", false, "de8a5072-d447-4023-9f33-38cc3116bd23", "123456-7890", "Gråbondegatan 25", false, "admin@nomail.com", "256 71" });
            
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "f735bc9b-f5de-40ec-b161-a5ed7fd46491" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "f735bc9b-f5de-40ec-b161-a5ed7fd46491" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f735bc9b-f5de-40ec-b161-a5ed7fd46491");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c208428b-f4c8-4eaa-9c79-880e1ecd238f", "2f33b95c-db23-4889-8184-f013fa2abc99", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "9eab3ed1-4919-489a-a663-6a42f1fc990a", "admin@nomail.com", true, false, null, "ADMIN@NOMAIL.COM", "ADMIN@NOMAIL.COM", "AQAAAAEAACcQAAAAEG4PTE8ubcj/2xW02xURP6QHTalNSKLim3D7FP9rJfDoI4eqXbbRVYVL9z+6nUwUcw==", "0707-12345", false, "4946082c-c7dc-4310-bcaf-a5a36013cc32", false, "admin@nomail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "c208428b-f4c8-4eaa-9c79-880e1ecd238f" });
        }
    }
}

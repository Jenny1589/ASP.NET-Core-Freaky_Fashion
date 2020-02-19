using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class SeedUserWithStaticData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "dbe96091-47f5-453a-a624-e26083964bc0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbe96091-47f5-453a-a624-e26083964bc0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4", "cd126720-fbb4-48ce-8a0a-0723698204fe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d534da3-2104-4408-86bf-3466dc123b4f", "AQAAAAEAACcQAAAAEKjJfJ1Aypux5g4ZNByuXCW4cLz1SmNzi9AcrwTpGxghUTGgIdJ9XipE5yNuIspCpA==", "d68a7f2c-8a8f-4fcd-9e2a-4ad54d48c5fa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbe96091-47f5-453a-a624-e26083964bc0", "a977db43-3436-4600-a5a3-9b8e9d2c558f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0ec696-aba3-4691-929f-8651c29981f7", "AQAAAAEAACcQAAAAEKEaHbTHmXX5O7HWYw9FMhmvOZnCx0KFfoKqdvpzkiX0Cue5wzu5/Dr0Ag7bCYK0Kw==", "0a6155aa-6c28-4535-9225-66b7d2a6a558" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "dbe96091-47f5-453a-a624-e26083964bc0" });
        }
    }
}

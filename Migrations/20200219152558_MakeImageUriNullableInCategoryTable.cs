using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class MakeImageUriNullableInCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUri",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4",
                column: "ConcurrencyStamp",
                value: "a35218b5-9760-4760-aefc-54cc5fe42835");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114c4ea8-01ef-4043-81d0-6de25fcb12d9", "AQAAAAEAACcQAAAAEG388jqlANj7deThlWWSyqnAjS2WOUYruW46xgmG/rGddnkJoTE694mRvMRJPArPzA==", "ed29a2eb-9fea-410b-aa5a-3417a5e185f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUri",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ccb6a35-5917-42a4-a4bf-2da5fbdb8fa4",
                column: "ConcurrencyStamp",
                value: "cd126720-fbb4-48ce-8a0a-0723698204fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d534da3-2104-4408-86bf-3466dc123b4f", "AQAAAAEAACcQAAAAEKjJfJ1Aypux5g4ZNByuXCW4cLz1SmNzi9AcrwTpGxghUTGgIdJ9XipE5yNuIspCpA==", "d68a7f2c-8a8f-4fcd-9e2a-4ad54d48c5fa" });
        }
    }
}

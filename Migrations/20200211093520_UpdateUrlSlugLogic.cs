using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Migrations
{
    public partial class UpdateUrlSlugLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Category",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "crazy-skirt-1");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "wild-pants-2");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "furry-coatee-3");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "gorgeous-blouse-4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "green-flower-dress-5");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "cool-jeans-6");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "UrlSlug",
                value: "bad-girl-shirt-7");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "UrlSlug",
                value: "freaky-beach-dress-8");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "UrlSlug",
                value: "get-dirty-jeans-9");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "UrlSlug",
                value: "pepsi-cola-shirt-10");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "UrlSlug",
                value: "smokin'-dress-11");
        }
    }
}

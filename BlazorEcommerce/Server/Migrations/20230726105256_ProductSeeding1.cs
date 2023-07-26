using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/51JTJUe0-+L._SX343_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "https://m.media-amazon.com/images/I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg", "Freedom at Midnight by Dominique Lapierre and Larry Collins" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/I/51ylP4+2y2L._SX327_BO1,204,203,200_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/51JTJUe0-  +L._SX343_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "	https://m.media-amazon.com/images/      I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg", "Freedom at Midnight by Dominique Lapierre and Larry      Collins" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/      I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/      I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "	https://m.media-amazon.com/images/I/51ylP4      +2y2L._SX327_BO1,204,203,200_.jpg");
        }
    }
}

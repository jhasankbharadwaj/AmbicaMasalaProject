using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambica.Services.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class bydefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Availability", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1113, true, "Dhania Powder", 50m, 100 },
                    { 1114, true, "Masala Kharam", 180m, 500 },
                    { 1115, true, "Haldi Powder", 180m, 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1115);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodPriceComparison.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlatformPrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlatformPrices",
                columns: new[] { "Id", "DishName", "PlatformName", "Price" },
                values: new object[,]
                {
                    { 1, "Margherita Pizza", "Zomato", 250m },
                    { 2, "Margherita Pizza", "Swiggy", 270m },
                    { 3, "Margherita Pizza", "UberEats", 260m },
                    { 4, "Veg Burger", "Zomato", 120m },
                    { 5, "Veg Burger", "Swiggy", 110m },
                    { 6, "Veg Burger", "UberEats", 115m },
                    { 7, "Pasta Alfredo", "Zomato", 180m },
                    { 8, "Pasta Alfredo", "Swiggy", 175m },
                    { 9, "Pasta Alfredo", "UberEats", 185m },
                    { 10, "French Fries", "Zomato", 90m },
                    { 11, "French Fries", "Swiggy", 85m },
                    { 12, "French Fries", "UberEats", 95m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PlatformPrices",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}

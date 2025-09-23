using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodPriceComparison.Migrations
{
    /// <inheritdoc />
    public partial class AddPlatformPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SwiggyPrice",
                table: "PlatformPrices");

            migrationBuilder.DropColumn(
                name: "UberEatsPrice",
                table: "PlatformPrices");

            migrationBuilder.RenameColumn(
                name: "ZomatoPrice",
                table: "PlatformPrices",
                newName: "Price");

            migrationBuilder.AlterColumn<string>(
                name: "DishName",
                table: "PlatformPrices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PlatformName",
                table: "PlatformPrices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlatformName",
                table: "PlatformPrices");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PlatformPrices",
                newName: "ZomatoPrice");

            migrationBuilder.AlterColumn<string>(
                name: "DishName",
                table: "PlatformPrices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<decimal>(
                name: "SwiggyPrice",
                table: "PlatformPrices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UberEatsPrice",
                table: "PlatformPrices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "PlatformPrices",
                columns: new[] { "Id", "DishName", "SwiggyPrice", "UberEatsPrice", "ZomatoPrice" },
                values: new object[,]
                {
                    { 1, "Margherita Pizza", 270m, 260m, 250m },
                    { 2, "Veg Burger", 110m, 115m, 120m },
                    { 3, "Pasta Alfredo", 175m, 185m, 180m }
                });
        }
    }
}

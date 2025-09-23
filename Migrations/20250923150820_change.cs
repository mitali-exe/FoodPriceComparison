using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodPriceComparison.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatformPrices_Dishes_DishId",
                table: "PlatformPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatformPrices_Platforms_PlatformId",
                table: "PlatformPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatformPrices_Restaurants_RestaurantId",
                table: "PlatformPrices");

            migrationBuilder.DropIndex(
                name: "IX_PlatformPrices_DishId",
                table: "PlatformPrices");

            migrationBuilder.DropIndex(
                name: "IX_PlatformPrices_PlatformId",
                table: "PlatformPrices");

            migrationBuilder.DropIndex(
                name: "IX_PlatformPrices_RestaurantId",
                table: "PlatformPrices");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "PlatformPrices");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "PlatformPrices");

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "PlatformPrices");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "PlatformPrices");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PlatformPrices",
                newName: "ZomatoPrice");

            migrationBuilder.RenameColumn(
                name: "OrderLink",
                table: "PlatformPrices",
                newName: "DishName");

            migrationBuilder.RenameColumn(
                name: "PriceId",
                table: "PlatformPrices",
                newName: "Id");

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

            migrationBuilder.RenameColumn(
                name: "DishName",
                table: "PlatformPrices",
                newName: "OrderLink");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlatformPrices",
                newName: "PriceId");

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "PlatformPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "PlatformPrices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "PlatformPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "PlatformPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlatformPrices_DishId",
                table: "PlatformPrices",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformPrices_PlatformId",
                table: "PlatformPrices",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformPrices_RestaurantId",
                table: "PlatformPrices",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformPrices_Dishes_DishId",
                table: "PlatformPrices",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformPrices_Platforms_PlatformId",
                table: "PlatformPrices",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformPrices_Restaurants_RestaurantId",
                table: "PlatformPrices",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

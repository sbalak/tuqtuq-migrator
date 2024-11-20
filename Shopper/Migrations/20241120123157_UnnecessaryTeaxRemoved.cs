using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopper.Migrations
{
    /// <inheritdoc />
    public partial class UnnecessaryTeaxRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "PrimaryTax",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "PrimaryTax",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "SecondaryTax",
                table: "FoodItems");

            migrationBuilder.RenameColumn(
                name: "SecondaryTax",
                table: "OrderItems",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrderItems",
                newName: "SecondaryTax");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "OrderItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrimaryTax",
                table: "OrderItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrimaryTax",
                table: "FoodItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondaryTax",
                table: "FoodItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}

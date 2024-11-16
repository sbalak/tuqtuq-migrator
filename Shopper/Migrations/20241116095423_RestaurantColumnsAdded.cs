using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopper.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantColumnsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "FoodItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "FoodItems");
        }
    }
}

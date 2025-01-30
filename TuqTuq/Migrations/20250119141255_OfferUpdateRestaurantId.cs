using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuqTuq.Migrations
{
    /// <inheritdoc />
    public partial class OfferUpdateRestaurantId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Offers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Offers");
        }
    }
}

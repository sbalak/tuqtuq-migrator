using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuqTuq.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCartWithOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OfferId",
                table: "Carts",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Offers_OfferId",
                table: "Carts",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Offers_OfferId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_OfferId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Carts");
        }
    }
}

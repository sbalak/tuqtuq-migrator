using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Takku.Migrations
{
    /// <inheritdoc />
    public partial class OrderUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCancelled",
                table: "Orders",
                newName: "DateRejected");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DateRejected",
                table: "Orders",
                newName: "DateCancelled");
        }
    }
}

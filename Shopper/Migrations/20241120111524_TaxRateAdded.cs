using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopper.Migrations
{
    /// <inheritdoc />
    public partial class TaxRateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrimaryTaxRate",
                table: "Restaurants",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondaryTaxRate",
                table: "Restaurants",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrimaryTaxAmount",
                table: "Orders",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondaryTaxAmount",
                table: "Orders",
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
                name: "SecondaryTax",
                table: "OrderItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDisabled",
                table: "FoodItems",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryTaxRate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SecondaryTaxRate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PrimaryTaxAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SecondaryTaxAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PrimaryTax",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "SecondaryTax",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "DateDisabled",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "PrimaryTax",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "SecondaryTax",
                table: "FoodItems");
        }
    }
}

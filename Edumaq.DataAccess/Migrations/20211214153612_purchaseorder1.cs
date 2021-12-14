using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class purchaseorder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "PurchaseOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "PurchaseOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "PurchaseOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPayable",
                table: "PurchaseOrders",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "TotalPayable",
                table: "PurchaseOrders");
        }
    }
}

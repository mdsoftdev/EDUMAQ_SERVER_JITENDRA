using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class GrnPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SupplierId",
                table: "PurchaseOrders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GrnPurchases",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    PONumber = table.Column<int>(nullable: false),
                    SupplierInvoiceNo = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    GRNNumber = table.Column<int>(nullable: false),
                    GRNDate = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    InternalNote = table.Column<string>(nullable: true),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    AdditionalCharges = table.Column<decimal>(nullable: false),
                    TotalPayable = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrnPurchases_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrnPurchaseItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: false),
                    GrnPurchaseId = table.Column<long>(nullable: false),
                    ItemId = table.Column<long>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    Quatity = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnPurchaseItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrnPurchaseItems_GrnPurchases_GrnPurchaseId",
                        column: x => x.GrnPurchaseId,
                        principalTable: "GrnPurchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrnPurchaseItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnPurchaseItems_GrnPurchaseId",
                table: "GrnPurchaseItems",
                column: "GrnPurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnPurchaseItems_ItemId",
                table: "GrnPurchaseItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnPurchases_SupplierId",
                table: "GrnPurchases",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Suppliers_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Suppliers_SupplierId",
                table: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "GrnPurchaseItems");

            migrationBuilder.DropTable(
                name: "GrnPurchases");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierId",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}

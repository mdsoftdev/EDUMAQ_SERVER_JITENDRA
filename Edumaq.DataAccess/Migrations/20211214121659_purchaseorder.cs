using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class purchaseorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_ProductBundles_Items_BundleId",
            ////    table: "ProductBundles");

            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_ProductBundles_Items_ItemId",
            ////    table: "ProductBundles");

            ////migrationBuilder.AlterColumn<long>(
            ////    name: "ItemId",
            ////    table: "ProductBundles",
            ////    nullable: false,
            ////    oldClrType: typeof(long),
            ////    oldType: "bigint",
            ////    oldNullable: true);

            ////migrationBuilder.AlterColumn<long>(
            ////    name: "BundleId",
            ////    table: "ProductBundles",
            ////    nullable: false,
            ////    oldClrType: typeof(long),
            ////    oldType: "bigint",
            ////    oldNullable: true);

            //migrationBuilder.CreateTable(
            //    name: "PurchaseOrders",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BranchId = table.Column<long>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(nullable: false),
            //        CreatedBy = table.Column<long>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(nullable: false),
            //        ModifiedBy = table.Column<long>(nullable: false),
            //        SupplierId = table.Column<string>(nullable: true),
            //        QuotationNo = table.Column<int>(nullable: false),
            //        QuotationDate = table.Column<DateTime>(nullable: false),
            //        PurchaseOrderNumber = table.Column<int>(nullable: false),
            //        PurchaseOrderDate = table.Column<DateTime>(nullable: false),
            //        Remark = table.Column<string>(nullable: true),
            //        InternalNote = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PurchaseOrderItems",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BranchId = table.Column<long>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(nullable: false),
            //        CreatedBy = table.Column<long>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(nullable: false),
            //        ModifiedBy = table.Column<long>(nullable: false),
            //        PurchaseOrderId = table.Column<long>(nullable: false),
            //        ItemId = table.Column<long>(nullable: false),
            //        ItemName = table.Column<string>(nullable: true),
            //        ItemCode = table.Column<string>(nullable: true),
            //        Quatity = table.Column<int>(nullable: false),
            //        Rate = table.Column<decimal>(nullable: false),
            //        Discount = table.Column<decimal>(nullable: false),
            //        Tax = table.Column<decimal>(nullable: false),
            //        Total = table.Column<decimal>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PurchaseOrderItems", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderItems_Items_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Items",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderId",
            //            column: x => x.PurchaseOrderId,
            //            principalTable: "PurchaseOrders",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderItems_ItemId",
            //    table: "PurchaseOrderItems",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseOrderItems_PurchaseOrderId",
            //    table: "PurchaseOrderItems",
            //    column: "PurchaseOrderId");

            ////migrationBuilder.AddForeignKey(
            ////    name: "FK_ProductBundles_Items_BundleId",
            ////    table: "ProductBundles",
            ////    column: "BundleId",
            ////    principalTable: "Items",
            ////    principalColumn: "Id",
            ////    onDelete: ReferentialAction.Cascade);

            ////migrationBuilder.AddForeignKey(
            ////    name: "FK_ProductBundles_Items_ItemId",
            ////    table: "ProductBundles",
            ////    column: "ItemId",
            ////    principalTable: "Items",
            ////    principalColumn: "Id",
            ////    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_ProductBundles_Items_BundleId",
            ////    table: "ProductBundles");

            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_ProductBundles_Items_ItemId",
            ////    table: "ProductBundles");

            //migrationBuilder.DropTable(
            //    name: "PurchaseOrderItems");

            //migrationBuilder.DropTable(
            //    name: "PurchaseOrders");

            ////migrationBuilder.AlterColumn<long>(
            ////    name: "ItemId",
            ////    table: "ProductBundles",
            ////    type: "bigint",
            ////    nullable: true,
            ////    oldClrType: typeof(long));

            ////migrationBuilder.AlterColumn<long>(
            ////    name: "BundleId",
            ////    table: "ProductBundles",
            ////    type: "bigint",
            ////    nullable: true,
            ////    oldClrType: typeof(long));

            ////migrationBuilder.AddForeignKey(
            ////    name: "FK_ProductBundles_Items_BundleId",
            ////    table: "ProductBundles",
            ////    column: "BundleId",
            ////    principalTable: "Items",
            ////    principalColumn: "Id",
            ////    onDelete: ReferentialAction.Restrict);

            ////migrationBuilder.AddForeignKey(
            ////    name: "FK_ProductBundles_Items_ItemId",
            ////    table: "ProductBundles",
            ////    column: "ItemId",
            ////    principalTable: "Items",
            ////    principalColumn: "Id",
            ////    onDelete: ReferentialAction.Restrict);
        }
    }
}

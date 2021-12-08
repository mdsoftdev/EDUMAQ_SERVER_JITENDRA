using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class item_bundle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBundledProject",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "Items");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Code",
            //    table: "Suppliers",
            //    nullable: true,
            //    oldClrType: typeof(long),
            //    oldType: "bigint");

            migrationBuilder.AddColumn<bool>(
                name: "IsBundledProduct",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ItemType",
                table: "Items",
                nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "Countries",
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
            //        CountryName = table.Column<string>(nullable: true),
            //        CountryCode = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Countries", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "ProductBundles",
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
                    Code = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    BundleId = table.Column<long>(nullable: true),
                    ItemId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBundles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBundles_Items_BundleId",
                        column: x => x.BundleId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductBundles_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateTable(
            //    name: "States",
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
            //        StateName = table.Column<string>(nullable: true),
            //        CountryId = table.Column<long>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_States", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_States_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cities",
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
            //        CityName = table.Column<string>(nullable: true),
            //        StateId = table.Column<long>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cities", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Cities_States_StateId",
            //            column: x => x.StateId,
            //            principalTable: "States",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Suppliers_CityId",
            //    table: "Suppliers",
            //    column: "CityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Suppliers_CountryId",
            //    table: "Suppliers",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Suppliers_StateId",
            //    table: "Suppliers",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_StateId",
            //    table: "Cities",
            //    column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBundles_BundleId",
                table: "ProductBundles",
                column: "BundleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBundles_ItemId",
                table: "ProductBundles",
                column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_States_CountryId",
            //    table: "States",
            //    column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Taxes_TaxId",
                table: "Items",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Suppliers_Cities_CityId",
            //    table: "Suppliers",
            //    column: "CityId",
            //    principalTable: "Cities",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Suppliers_Countries_CountryId",
            //    table: "Suppliers",
            //    column: "CountryId",
            //    principalTable: "Countries",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Suppliers_States_StateId",
            //    table: "Suppliers",
            //    column: "StateId",
            //    principalTable: "States",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Taxes_TaxId",
                table: "Items");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Suppliers_Cities_CityId",
            //    table: "Suppliers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Suppliers_Countries_CountryId",
            //    table: "Suppliers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Suppliers_States_StateId",
            //    table: "Suppliers");

            //migrationBuilder.DropTable(
            //    name: "Cities");

            migrationBuilder.DropTable(
                name: "ProductBundles");

            //migrationBuilder.DropTable(
            //    name: "States");

            //migrationBuilder.DropTable(
            //    name: "Countries");

            //migrationBuilder.DropIndex(
            //    name: "IX_Suppliers_CityId",
            //    table: "Suppliers");

            //migrationBuilder.DropIndex(
            //    name: "IX_Suppliers_CountryId",
            //    table: "Suppliers");

            //migrationBuilder.DropIndex(
            //    name: "IX_Suppliers_StateId",
            //    table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "IsBundledProduct",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Items");

            //migrationBuilder.AlterColumn<long>(
            //    name: "Code",
            //    table: "Suppliers",
            //    type: "bigint",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBundledProject",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

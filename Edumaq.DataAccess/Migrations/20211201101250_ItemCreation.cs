using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class ItemCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
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
                    Value = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            

            migrationBuilder.CreateTable(
                name: "Units",
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
                    Value = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
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
                    ItemName = table.Column<string>(nullable: true),
                    ItemCategoryId = table.Column<long>(nullable: false),
                    ItemGroupId = table.Column<long>(nullable: false),
                    ItemCode = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    UnitId = table.Column<long>(nullable: false),
                    ItemTypeId = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    ColorId = table.Column<long>(nullable: false),
                    OpeningStock = table.Column<int>(nullable: false),
                    TaxId = table.Column<long>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    SaleRate = table.Column<int>(nullable: false),
                    LowQtyAlert = table.Column<int>(nullable: false),
                    IsBundledProject = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_Items_Taxes_TaxId",
                    //    column: x => x.TaxId,
                    //    principalTable: "Taxes",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            
            migrationBuilder.CreateIndex(
                name: "IX_Items_ColorId",
                table: "Items",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitId",
                table: "Items",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Units");

        }
    }
}

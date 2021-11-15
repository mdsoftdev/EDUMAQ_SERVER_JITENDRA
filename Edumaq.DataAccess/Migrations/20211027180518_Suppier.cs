using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class Suppier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
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
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierTypeId = table.Column<long>(nullable: false),
                    Code = table.Column<long>(nullable: false),
                    PanNo = table.Column<string>(nullable: true),
                    TanNo = table.Column<string>(nullable: true),
                    GstNo = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    CountryId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    IfscCode = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    AcademicYearId = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_AcademicYears_AcademicYearId",
                        column: x => x.AcademicYearId,
                        principalTable: "AcademicYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupplierTypes_SupplierTypeId",
                        column: x => x.SupplierTypeId,
                        principalTable: "SupplierTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AcademicYearId",
                table: "Suppliers",
                column: "AcademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SupplierTypeId",
                table: "Suppliers",
                column: "SupplierTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}

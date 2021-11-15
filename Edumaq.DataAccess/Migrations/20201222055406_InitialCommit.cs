using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class InitialCommit : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
    //protected override void Up(MigrationBuilder migrationBuilder)
    //{
    //    migrationBuilder.CreateTable(
    //        name: "ItemGroups",
    //        columns: table => new
    //        {
    //            Id = table.Column<long>(nullable: false)
    //                .Annotation("SqlServer:Identity", "1, 1"),
    //            BranchId = table.Column<long>(nullable: false),
    //            Status = table.Column<bool>(nullable: false),
    //            CreatedDate = table.Column<DateTime>(nullable: false),
    //            CreatedBy = table.Column<long>(nullable: false),
    //            ModifiedDate = table.Column<DateTime>(nullable: false),
    //            ModifiedBy = table.Column<long>(nullable: false),
    //            Name = table.Column<string>(nullable: true),
    //            Description = table.Column<string>(nullable: true),
    //            AcademicYearId = table.Column<long>(nullable: false),
    //            IsDeleted = table.Column<bool>(nullable: false),
    //            DeletedDate = table.Column<DateTime>(nullable: false),
    //            DeletedBy = table.Column<long>(nullable: false)
    //        },
    //        constraints: table =>
    //        {
    //            table.PrimaryKey("PK_ItemGroups", x => x.Id);
    //            table.ForeignKey(
    //                name: "FK_ItemGroups_AcademicYears_AcademicYearId",
    //                column: x => x.AcademicYearId,
    //                principalTable: "AcademicYears",
    //                principalColumn: "Id",
    //                onDelete: ReferentialAction.Cascade);
    //        });

    //    migrationBuilder.CreateIndex(
    //        name: "IX_ItemGroups_AcademicYearId",
    //        table: "ItemGroups",
    //        column: "AcademicYearId");
    //}

    //protected override void Down(MigrationBuilder migrationBuilder)
    //{
    //    migrationBuilder.DropTable(
    //        name: "ItemGroups");
    //}
    //OG InitialCommit - START
    //protected override void Up(MigrationBuilder migrationBuilder)
    //{
    //    migrationBuilder.CreateTable(
    //        name: "AcademicYears",
    //        columns: table => new
    //        {
    //            Id = table.Column<long>(nullable: false)
    //                .Annotation("SqlServer:Identity", "1, 1"),
    //            BranchId = table.Column<long>(nullable: false),
    //            Status = table.Column<bool>(nullable: false),
    //            CreatedDate = table.Column<DateTime>(nullable: false),
    //            CreatedBy = table.Column<long>(nullable: false),
    //            ModifiedDate = table.Column<DateTime>(nullable: false),
    //            ModifiedBy = table.Column<long>(nullable: false),
    //            Name = table.Column<string>(nullable: true),
    //            StartDate = table.Column<DateTime>(nullable: false),
    //            EndDate = table.Column<DateTime>(nullable: false),
    //            IsCurrentAcademicYear = table.Column<bool>(nullable: false)
    //        },
    //        constraints: table =>
    //        {
    //            table.PrimaryKey("PK_AcademicYears", x => x.Id);
    //        });
    //}

    //protected override void Down(MigrationBuilder migrationBuilder)
    //{
    //    migrationBuilder.DropTable(
    //        name: "AcademicYears");
    //}
    //OG InitialCommit - END
//}
}

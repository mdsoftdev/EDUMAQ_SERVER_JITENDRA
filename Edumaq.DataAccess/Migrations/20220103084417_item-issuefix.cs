using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edumaq.DataAccess.Migrations
{
    public partial class itemissuefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Items_Colors_ColorId",
            //    table: "Items");

            //migrationBuilder.AlterColumn<long>(
            //    name: "ColorId",
            //    table: "Items",
            //    nullable: true,
            //    oldClrType: typeof(long),
            //    oldType: "bigint");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Items_Colors_ColorId",
            //    table: "Items",
            //    column: "ColorId",
            //    principalTable: "Colors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddColumn<long>(
            //    name: "DeletedBy",
            //    table: "Items",
            //    nullable: false,
            //    defaultValue: 0L);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "DeletedDate",
            //    table: "Items",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsDeleted",
            //    table: "Items",
            //    nullable: false,
            //    defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Items_Colors_ColorId",
            //    table: "Items");

            //migrationBuilder.AlterColumn<long>(
            //    name: "ColorId",
            //    table: "Items",
            //    type: "bigint",
            //    nullable: false,
            //    oldClrType: typeof(long),
            //    oldNullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Items_Colors_ColorId",
            //    table: "Items",
            //    column: "ColorId",
            //    principalTable: "Colors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.DropColumn(
            //   name: "DeletedBy",
            //   table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "DeletedDate",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "IsDeleted",
            //    table: "Items");
        }
    }
}

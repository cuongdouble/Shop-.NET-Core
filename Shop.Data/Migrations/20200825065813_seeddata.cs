using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 25, 13, 58, 12, 754, DateTimeKind.Local).AddTicks(7414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 25, 11, 50, 24, 848, DateTimeKind.Local).AddTicks(1539));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 25, 11, 50, 24, 848, DateTimeKind.Local).AddTicks(1539),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 25, 13, 58, 12, 754, DateTimeKind.Local).AddTicks(7414));
        }
    }
}

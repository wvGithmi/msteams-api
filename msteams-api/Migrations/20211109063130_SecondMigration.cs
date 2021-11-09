using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace msteams_api.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Posts",
                type: "datetime2",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Posts",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true,
                oldNullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170"),
                column: "ConcurrencyStamp",
                value: "8f81a65c-aeef-4079-91cc-695b7a10c75b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0aaf6f12-2a5e-49c2-b872-ce1c8cc72854", "AQAAAAEAACcQAAAAEHkNsJ2WrSDXJM+4sWhEPadNfWKIgsFHC6arPvJpGtdcAEl6E3clpSk0vCdXelwKtw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 3, 10, 19, 31, 908, DateTimeKind.Local).AddTicks(1864));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170"),
                column: "ConcurrencyStamp",
                value: "26f7074c-8179-45d4-aec1-3f4efe0c253e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b76ed0dc-8b17-4009-9c75-0a07c7de402d", "AQAAAAEAACcQAAAAECmvYixyU7hO10ca/pj5mjZmJ0kH8ABJPn4Wzp8aw+qMS4zz7Adq7FGWjl/9NcGhzA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 2, 17, 57, 48, 273, DateTimeKind.Local).AddTicks(7353));
        }
    }
}

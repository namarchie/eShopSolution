using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 2, 13, 23, 24, 342, DateTimeKind.Local).AddTicks(1668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 2, 11, 37, 13, 630, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170"), "378abdd8-805d-4d9a-b1a9-061c9e03c750", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"), new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"), 0, "de240c75-c63f-4a7d-960b-42fd74b98886", new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhv@gemvietnam.com", true, "Nam", "Hoang", false, null, "namhv@gmail.com", "admin", "AQAAAAEAACcQAAAAEBX4En6xxB0VZnevtjssKED+cDO9ilUxP8eoO6bpJjnExILAKTeMAPWvA67pmqvJBA==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 7, 2, 13, 23, 24, 361, DateTimeKind.Local).AddTicks(6474));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"), new Guid("a9f2da85-2e4b-46f4-acfc-c810d1eec170") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba798131-d1a8-4a51-acfb-4e4c7cc2c8fa"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 2, 11, 37, 13, 630, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 2, 13, 23, 24, 342, DateTimeKind.Local).AddTicks(1668));

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
                value: new DateTime(2020, 7, 2, 11, 37, 13, 655, DateTimeKind.Local).AddTicks(6821));
        }
    }
}

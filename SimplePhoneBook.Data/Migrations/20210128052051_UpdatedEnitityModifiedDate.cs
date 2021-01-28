using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplePhoneBook.Data.Migrations
{
    public partial class UpdatedEnitityModifiedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 28, 7, 20, 51, 68, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 28, 7, 20, 51, 70, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 28, 7, 20, 51, 70, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 28, 7, 20, 51, 70, DateTimeKind.Local).AddTicks(1434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 27, 22, 48, 54, 259, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 27, 22, 48, 54, 260, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 27, 22, 48, 54, 260, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "PhoneNumberType",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 1, 27, 22, 48, 54, 260, DateTimeKind.Local).AddTicks(4702));
        }
    }
}

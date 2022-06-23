using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class barcodes_database_update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prefix",
                table: "Barcodes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postfix",
                table: "Barcodes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 181, 59, 242, 138, 196, 172, 76, 71, 112, 91, 254, 194, 167, 201, 24, 4, 176, 59, 243, 122, 228, 233, 42, 161, 13, 36, 139, 1, 35, 13, 210, 141, 206, 111, 220, 35, 250, 56, 132, 143, 74, 37, 175, 235, 148, 148, 57, 255, 3, 147, 155, 251, 205, 3, 120, 101, 34, 70, 207, 235, 16, 109, 77, 35 }, new byte[] { 243, 212, 107, 161, 7, 132, 245, 18, 0, 100, 172, 125, 186, 208, 188, 185, 28, 51, 172, 12, 86, 175, 190, 113, 234, 73, 248, 202, 111, 119, 207, 159, 172, 107, 131, 82, 45, 238, 165, 227, 71, 129, 84, 39, 218, 222, 140, 251, 33, 21, 200, 194, 100, 144, 175, 194, 117, 204, 235, 69, 160, 27, 211, 225, 75, 69, 167, 17, 185, 223, 47, 99, 23, 165, 163, 218, 53, 215, 120, 235, 0, 171, 67, 67, 232, 217, 162, 9, 9, 180, 210, 241, 80, 131, 80, 195, 213, 159, 76, 240, 246, 22, 218, 96, 26, 112, 21, 49, 197, 167, 79, 181, 183, 181, 0, 220, 223, 195, 83, 239, 83, 235, 196, 226, 119, 245, 10, 22 } });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 1,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5979), new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 2,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5981), new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 3,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5983), new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 1,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 2,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 6, 58, 47, 399, DateTimeKind.Local).AddTicks(6090));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Prefix",
                table: "Barcodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Postfix",
                table: "Barcodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 60, 130, 195, 71, 188, 190, 227, 1, 121, 169, 227, 50, 126, 102, 152, 221, 196, 143, 230, 244, 195, 30, 222, 162, 205, 93, 88, 141, 184, 111, 91, 171, 150, 245, 169, 90, 160, 255, 63, 186, 92, 122, 171, 125, 10, 60, 1, 138, 107, 62, 180, 36, 23, 230, 173, 135, 10, 67, 251, 190, 53, 205, 172 }, new byte[] { 230, 254, 118, 100, 156, 255, 76, 51, 213, 216, 18, 22, 1, 242, 71, 133, 135, 205, 190, 26, 106, 173, 150, 183, 122, 183, 28, 155, 144, 95, 212, 97, 233, 236, 12, 37, 3, 238, 32, 220, 137, 38, 226, 93, 74, 215, 75, 185, 242, 178, 224, 7, 101, 116, 73, 146, 67, 31, 194, 105, 78, 103, 29, 230, 226, 202, 178, 7, 39, 177, 104, 3, 3, 127, 157, 23, 132, 165, 64, 39, 221, 245, 40, 81, 72, 95, 82, 53, 236, 243, 54, 99, 200, 67, 165, 136, 37, 11, 245, 61, 196, 97, 40, 17, 213, 60, 0, 81, 170, 85, 131, 60, 77, 64, 77, 242, 82, 96, 114, 46, 140, 31, 230, 72, 187, 80, 216, 23 } });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 1,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2346), new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 2,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2348), new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 3,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2349), new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 1,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 2,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 6, 34, 33, 499, DateTimeKind.Local).AddTicks(2458));
        }
    }
}

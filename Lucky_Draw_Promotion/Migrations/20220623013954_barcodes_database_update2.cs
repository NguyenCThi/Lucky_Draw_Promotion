using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class barcodes_database_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeCount",
                table: "Barcodes");

            migrationBuilder.RenameColumn(
                name: "QRCode",
                table: "Barcodes",
                newName: "CodeGenerated");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 30, 6, 146, 133, 57, 174, 98, 239, 231, 30, 59, 103, 224, 230, 101, 253, 230, 21, 141, 207, 253, 227, 164, 123, 90, 116, 138, 207, 100, 221, 146, 198, 114, 254, 138, 33, 245, 29, 131, 76, 252, 219, 126, 106, 151, 73, 23, 204, 72, 192, 123, 208, 142, 55, 39, 208, 107, 89, 61, 219, 42, 152, 237 }, new byte[] { 224, 148, 83, 204, 205, 38, 226, 70, 195, 209, 21, 149, 85, 152, 151, 212, 6, 146, 89, 21, 150, 25, 43, 224, 87, 168, 49, 70, 0, 81, 14, 81, 190, 122, 105, 212, 248, 51, 92, 201, 43, 204, 216, 200, 156, 193, 125, 109, 91, 189, 127, 36, 82, 174, 224, 26, 73, 234, 155, 161, 159, 43, 236, 253, 34, 130, 232, 205, 229, 155, 98, 143, 95, 175, 30, 9, 188, 16, 218, 185, 38, 233, 174, 92, 23, 170, 108, 68, 176, 185, 150, 170, 127, 24, 247, 175, 244, 193, 15, 249, 207, 37, 75, 248, 168, 204, 105, 38, 121, 74, 171, 61, 159, 191, 10, 111, 101, 174, 193, 136, 72, 218, 247, 33, 222, 243, 50, 93 } });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 1,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3356), new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 2,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3358), new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 3,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 1,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 2,
                column: "WinDate",
                value: new DateTime(2022, 6, 23, 8, 39, 53, 621, DateTimeKind.Local).AddTicks(3536));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodeGenerated",
                table: "Barcodes",
                newName: "QRCode");

            migrationBuilder.AddColumn<int>(
                name: "CodeCount",
                table: "Barcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}

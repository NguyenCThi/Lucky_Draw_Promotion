using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class barcodes_database_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfBusinesses_TOBId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BarcodePic",
                table: "Barcodes");

            migrationBuilder.RenameColumn(
                name: "QRCodePic",
                table: "Barcodes",
                newName: "QRCode");

            migrationBuilder.AlterColumn<int>(
                name: "TOBId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "CharsetId",
                table: "Barcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_CharsetId",
                table: "Barcodes",
                column: "CharsetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barcodes_Charsets_CharsetId",
                table: "Barcodes",
                column: "CharsetId",
                principalTable: "Charsets",
                principalColumn: "CharsetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfBusinesses_TOBId",
                table: "Customers",
                column: "TOBId",
                principalTable: "TypeOfBusinesses",
                principalColumn: "TOBId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barcodes_Charsets_CharsetId",
                table: "Barcodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfBusinesses_TOBId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Barcodes_CharsetId",
                table: "Barcodes");

            migrationBuilder.DropColumn(
                name: "CharsetId",
                table: "Barcodes");

            migrationBuilder.RenameColumn(
                name: "QRCode",
                table: "Barcodes",
                newName: "QRCodePic");

            migrationBuilder.AlterColumn<int>(
                name: "TOBId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BarcodePic",
                table: "Barcodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 137, 70, 33, 115, 198, 86, 96, 26, 40, 13, 12, 123, 40, 71, 12, 119, 124, 40, 231, 201, 247, 150, 5, 233, 223, 83, 81, 229, 239, 225, 253, 130, 147, 222, 171, 218, 183, 94, 31, 134, 8, 40, 16, 208, 19, 39, 102, 8, 247, 157, 132, 34, 84, 247, 146, 69, 77, 95, 81, 15, 27, 5, 170, 228 }, new byte[] { 110, 221, 110, 80, 104, 36, 41, 61, 86, 95, 165, 29, 92, 167, 166, 157, 159, 224, 77, 246, 240, 152, 225, 58, 10, 12, 225, 4, 31, 56, 227, 34, 129, 95, 160, 94, 107, 249, 54, 109, 185, 77, 15, 228, 58, 185, 97, 23, 237, 199, 59, 75, 86, 56, 104, 138, 59, 117, 208, 123, 213, 240, 185, 175, 148, 204, 101, 106, 150, 170, 177, 40, 190, 174, 53, 208, 112, 189, 82, 146, 239, 18, 183, 238, 233, 159, 20, 245, 127, 130, 64, 19, 106, 160, 242, 75, 147, 64, 90, 230, 138, 165, 215, 76, 234, 246, 155, 170, 223, 32, 141, 89, 244, 58, 216, 241, 50, 44, 109, 150, 144, 193, 28, 48, 250, 108, 14, 190 } });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 1,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(472), new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 2,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(474), new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 3,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(475), new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 1,
                column: "WinDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 2,
                column: "WinDate",
                value: new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfBusinesses_TOBId",
                table: "Customers",
                column: "TOBId",
                principalTable: "TypeOfBusinesses",
                principalColumn: "TOBId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

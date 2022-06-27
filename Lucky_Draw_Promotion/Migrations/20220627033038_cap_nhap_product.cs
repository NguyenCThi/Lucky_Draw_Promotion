using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class cap_nhap_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 57, 169, 145, 241, 18, 42, 109, 255, 38, 82, 200, 90, 122, 119, 143, 232, 119, 104, 18, 173, 39, 83, 90, 168, 110, 108, 178, 73, 48, 37, 194, 240, 140, 36, 208, 90, 210, 177, 194, 13, 181, 52, 103, 86, 221, 160, 231, 128, 207, 102, 128, 238, 175, 68, 131, 13, 241, 126, 18, 56, 252, 15, 129 }, new byte[] { 71, 87, 152, 109, 50, 99, 176, 93, 159, 67, 182, 40, 217, 22, 142, 116, 193, 195, 126, 120, 120, 17, 107, 136, 39, 157, 76, 145, 26, 57, 230, 242, 149, 193, 48, 157, 135, 41, 86, 248, 50, 124, 138, 151, 31, 149, 18, 35, 133, 174, 9, 154, 153, 109, 182, 187, 184, 48, 127, 3, 116, 0, 141, 29, 13, 99, 250, 54, 239, 216, 205, 61, 26, 85, 7, 248, 97, 65, 32, 159, 151, 85, 60, 251, 107, 161, 3, 131, 232, 51, 214, 204, 243, 131, 56, 43, 227, 1, 23, 178, 152, 102, 89, 6, 60, 208, 244, 51, 94, 95, 56, 152, 172, 108, 56, 206, 215, 158, 127, 101, 71, 197, 111, 185, 128, 89, 246, 253 } });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 1,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8231), new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 2,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8233), new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 3,
                columns: new[] { "ActiveDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8234), new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "GiftCodes",
                keyColumn: "GiftCodeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Gifts",
                keyColumn: "GiftId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 1,
                column: "WinDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Winners",
                keyColumn: "WinnerId",
                keyValue: 2,
                column: "WinDate",
                value: new DateTime(2022, 6, 27, 10, 30, 38, 89, DateTimeKind.Local).AddTicks(8343));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}

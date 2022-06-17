using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class khoi_tao_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordChangeString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Charsets",
                columns: table => new
                {
                    CharsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharsetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharsetValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charsets", x => x.CharsetId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProgramSizes",
                columns: table => new
                {
                    PSId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramSizes", x => x.PSId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfBusinesses",
                columns: table => new
                {
                    TOBId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOBName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfBusinesses", x => x.TOBId);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodeCount = table.Column<int>(type: "int", nullable: false),
                    CodeUsageLimit = table.Column<int>(type: "int", nullable: false),
                    CodeLength = table.Column<int>(type: "int", nullable: false),
                    Unlimited = table.Column<bool>(type: "bit", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postfix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoUpdate = table.Column<bool>(type: "bit", nullable: false),
                    OnlyJoinOne = table.Column<bool>(type: "bit", nullable: false),
                    ApplyForAllCampaign = table.Column<bool>(type: "bit", nullable: false),
                    CharsetId = table.Column<int>(type: "int", nullable: false),
                    ProgramSizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaigns_Charsets_CharsetId",
                        column: x => x.CharsetId,
                        principalTable: "Charsets",
                        principalColumn: "CharsetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaigns_ProgramSizes_ProgramSizeId",
                        column: x => x.ProgramSizeId,
                        principalTable: "ProgramSizes",
                        principalColumn: "PSId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block = table.Column<bool>(type: "bit", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    TOBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_TypeOfBusinesses_TOBId",
                        column: x => x.TOBId,
                        principalTable: "TypeOfBusinesses",
                        principalColumn: "TOBId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    BarcodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeRedemptionLimit = table.Column<int>(type: "int", nullable: false),
                    Unlimited = table.Column<bool>(type: "bit", nullable: false),
                    CodeCount = table.Column<int>(type: "int", nullable: false),
                    CodeLength = table.Column<int>(type: "int", nullable: false),
                    Prefix = table.Column<int>(type: "int", nullable: true),
                    Postfix = table.Column<int>(type: "int", nullable: true),
                    BarcodePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCodePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Scanned = table.Column<bool>(type: "bit", nullable: false),
                    UsedForSpin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScannedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.BarcodeId);
                    table.ForeignKey(
                        name: "FK_Barcodes_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    GiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.GiftId);
                    table.ForeignKey(
                        name: "FK_Gifts_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gifts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBarcodes",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BarcodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBarcodes", x => new { x.CustomerId, x.BarcodeId });
                    table.ForeignKey(
                        name: "FK_CustomerBarcodes_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "BarcodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBarcodes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiftCodes",
                columns: table => new
                {
                    GiftCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiftId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCodes", x => x.GiftCodeId);
                    table.ForeignKey(
                        name: "FK_GiftCodes_Gifts_GiftId",
                        column: x => x.GiftId,
                        principalTable: "Gifts",
                        principalColumn: "GiftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuleGifts",
                columns: table => new
                {
                    RuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftId = table.Column<int>(type: "int", nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiftAmount = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    Probability = table.Column<int>(type: "int", nullable: true),
                    MonthlyOnDay = table.Column<bool>(type: "bit", nullable: true),
                    SelectDayForMonthlyOnDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeeklyOn = table.Column<bool>(type: "bit", nullable: true),
                    ChooseDayForWeeklyOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepeatDaily = table.Column<bool>(type: "bit", nullable: true),
                    StartDateRD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDateRD = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleGifts", x => x.RuleId);
                    table.ForeignKey(
                        name: "FK_RuleGifts_Gifts_GiftId",
                        column: x => x.GiftId,
                        principalTable: "Gifts",
                        principalColumn: "GiftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Winners",
                columns: table => new
                {
                    WinnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendGift = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    GiftCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winners", x => x.WinnerId);
                    table.ForeignKey(
                        name: "FK_Winners_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Winners_GiftCodes_GiftCodeId",
                        column: x => x.GiftCodeId,
                        principalTable: "GiftCodes",
                        principalColumn: "GiftCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Email", "FullName", "PasswordChangeString", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "cooledm123@gmail.com", "Nguyen Chinh Thi", null, new byte[] { 137, 70, 33, 115, 198, 86, 96, 26, 40, 13, 12, 123, 40, 71, 12, 119, 124, 40, 231, 201, 247, 150, 5, 233, 223, 83, 81, 229, 239, 225, 253, 130, 147, 222, 171, 218, 183, 94, 31, 134, 8, 40, 16, 208, 19, 39, 102, 8, 247, 157, 132, 34, 84, 247, 146, 69, 77, 95, 81, 15, 27, 5, 170, 228 }, new byte[] { 110, 221, 110, 80, 104, 36, 41, 61, 86, 95, 165, 29, 92, 167, 166, 157, 159, 224, 77, 246, 240, 152, 225, 58, 10, 12, 225, 4, 31, 56, 227, 34, 129, 95, 160, 94, 107, 249, 54, 109, 185, 77, 15, 228, 58, 185, 97, 23, 237, 199, 59, 75, 86, 56, 104, 138, 59, 117, 208, 123, 213, 240, 185, 175, 148, 204, 101, 106, 150, 170, 177, 40, 190, 174, 53, 208, 112, 189, 82, 146, 239, 18, 183, 238, 233, 159, 20, 245, 127, 130, 64, 19, 106, 160, 242, 75, 147, 64, 90, 230, 138, 165, 215, 76, 234, 246, 155, 170, 223, 32, 141, 89, 244, 58, 216, 241, 50, 44, 109, 150, 144, 193, 28, 48, 250, 108, 14, 190 } });

            migrationBuilder.InsertData(
                table: "Charsets",
                columns: new[] { "CharsetId", "CharsetName", "CharsetValue" },
                values: new object[] { 1, "Numbers", "123456789" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "PositionName" },
                values: new object[,]
                {
                    { 1, "Chủ" },
                    { 2, "Quản lý" },
                    { 3, "Bếp" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, "Hạt nêm Knorr Chay Nấm Hương 400g", "Hạt nêm Knorr Chay Nấm Hương 400g" },
                    { 2, "Hạt nêm Knorr Từ Thịt Thăn, Xương Ống & Tủy 600gr", "Hạt nêm Knorr Từ Thịt Thăn, Xương Ống & Tủy 600gr" },
                    { 3, "Gia vị Hoàn Chỉnh Knorr Canh Chua 30g", "Gia vị Hoàn Chỉnh Knorr Canh Chua 30g" },
                    { 4, "Xốt Nêm Knorr Đậm Đặc Từ Thịt Vị Heo 240g", "Xốt Nêm Knorr Đậm Đặc Từ Thịt Vị Heo 240g" },
                    { 5, "Hạt Nêm Knorr Đậm Đặc Từ Thịt Thăn, Xương Ống & Tủy 900gr", "Hạt Nêm Knorr Đậm Đặc Từ Thịt Thăn, Xương Ống & Tủy 900gr" },
                    { 6, "Knorr Natural Bột Nêm Tự Nhiên Vị Rau Củ 150g", "Knorr Natural Bột Nêm Tự Nhiên Vị Rau Củ 150g" }
                });

            migrationBuilder.InsertData(
                table: "ProgramSizes",
                columns: new[] { "PSId", "PSDescription", "PSName" },
                values: new object[,]
                {
                    { 1, "up to thousands of random discount codes designed for single use by a limited group customers (e.g., \"ACME - 5P13E\" gives $25 off for the first 3 purchases, new customers from Warsaw only).", "Bulk codes" },
                    { 2, "A fixed-code discount designed for multiple uses (e.g., 10% off with \"blackfriday\" code).", "Standalone code" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfBusinesses",
                columns: new[] { "TOBId", "TOBName" },
                values: new object[,]
                {
                    { 1, "Khách sạn" },
                    { 2, "Nhà hàng" },
                    { 3, "Quán ăn" },
                    { 4, "Bán sỉ" },
                    { 5, "Resort" }
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignId", "ApplyForAllCampaign", "AutoUpdate", "CampaignName", "CharsetId", "CodeCount", "CodeLength", "CodeUsageLimit", "Description", "EndDate", "OnlyJoinOne", "Postfix", "Prefix", "ProgramSizeId", "StartDate", "Unlimited" },
                values: new object[,]
                {
                    { 1, false, false, "Lucky Draw 1", 1, 1, 10, 1, "This is for test", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "ALTA", 1, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, true, false, "Lucky Draw 2", 1, 1, 10, 1, "This is the second test", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "ALTA", 2, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Block", "DateOfBirth", "Fullname", "Location", "PhoneNumber", "PositionId", "TOBId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Hữu Huân", "Quận 6, TPHCM", "0901456781", 1, 1 },
                    { 2, true, new DateTime(1974, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Trọng Hữu", "Quận 5, TPHCM", "0907852781", 2, 2 },
                    { 3, true, new DateTime(1975, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Hùng Phát", "Quận 7, TPHCM", "0901485381", 3, 3 },
                    { 4, true, new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lê Ngọc Anh", "Bến Lức, Long An", "0901451981", 1, 4 },
                    { 5, true, new DateTime(1977, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lê Phan", "Biên Hòa, Đồng Nai", "0901742681", 2, 3 },
                    { 6, false, new DateTime(1978, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Thị Ngọc Hương", "Bến Lức, Long An", "0904803457", 1, 3 },
                    { 7, false, new DateTime(1979, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Văn Tình", "Cai Lậy, Tiền Giang", "0947514514", 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "GiftId", "CampaignId", "CreatedDate", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(441), 1 },
                    { 2, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(450), 2 },
                    { 3, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(451), 3 },
                    { 4, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(452), 4 },
                    { 5, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(453), 5 },
                    { 6, 1, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(453), 6 }
                });

            migrationBuilder.InsertData(
                table: "GiftCodes",
                columns: new[] { "GiftCodeId", "Active", "ActiveDate", "Code", "CreatedDate", "GiftId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(472), "ALTA231453", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(471), 1 },
                    { 2, true, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(474), "ALTA546375", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(474), 1 },
                    { 3, true, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(475), "ALTA111212", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(475), 1 },
                    { 4, false, null, "ALTA215223", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(476), 1 },
                    { 5, false, null, "ALTA512311", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(480), 1 },
                    { 6, false, null, "ALTA734521", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(481), 1 },
                    { 7, false, null, "ALTA346222", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(482), 1 },
                    { 8, false, null, "ALTA890231", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(482), 1 },
                    { 9, false, null, "ALTA888769", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(483), 1 },
                    { 10, false, null, "ALTA909878", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(484), 1 },
                    { 11, false, null, "ALTA999231", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(484), 1 },
                    { 12, false, null, "ALTA118908", new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(485), 1 }
                });

            migrationBuilder.InsertData(
                table: "Winners",
                columns: new[] { "WinnerId", "CustomerId", "GiftCodeId", "SendGift", "WinDate" },
                values: new object[] { 1, 1, 3, true, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.InsertData(
                table: "Winners",
                columns: new[] { "WinnerId", "CustomerId", "GiftCodeId", "SendGift", "WinDate" },
                values: new object[] { 2, 2, 4, false, new DateTime(2022, 6, 17, 7, 40, 0, 269, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Email",
                table: "Admins",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_CampaignId",
                table: "Barcodes",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_CharsetId",
                table: "Campaigns",
                column: "CharsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ProgramSizeId",
                table: "Campaigns",
                column: "ProgramSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBarcodes_BarcodeId",
                table: "CustomerBarcodes",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PositionId",
                table: "Customers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TOBId",
                table: "Customers",
                column: "TOBId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftCodes_GiftId",
                table: "GiftCodes",
                column: "GiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Gifts_CampaignId",
                table: "Gifts",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Gifts_ProductId",
                table: "Gifts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RuleGifts_GiftId",
                table: "RuleGifts",
                column: "GiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Winners_CustomerId",
                table: "Winners",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Winners_GiftCodeId",
                table: "Winners",
                column: "GiftCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CustomerBarcodes");

            migrationBuilder.DropTable(
                name: "RuleGifts");

            migrationBuilder.DropTable(
                name: "Winners");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "GiftCodes");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "TypeOfBusinesses");

            migrationBuilder.DropTable(
                name: "Gifts");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Charsets");

            migrationBuilder.DropTable(
                name: "ProgramSizes");
        }
    }
}

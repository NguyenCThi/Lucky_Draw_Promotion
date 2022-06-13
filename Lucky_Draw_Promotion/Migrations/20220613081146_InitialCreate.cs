using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucky_Draw_Promotion.Migrations
{
    public partial class InitialCreate : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeCount = table.Column<int>(type: "int", nullable: false),
                    CodeUsageLimit = table.Column<int>(type: "int", nullable: false),
                    CodeLength = table.Column<int>(type: "int", nullable: false),
                    Unlimited = table.Column<int>(type: "int", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postfix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoUpdate = table.Column<int>(type: "int", nullable: false),
                    ApplyForAllCampaign = table.Column<int>(type: "int", nullable: false),
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
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block = table.Column<int>(type: "int", nullable: false),
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
                    Unlimited = table.Column<int>(type: "int", nullable: false),
                    CodeCount = table.Column<int>(type: "int", nullable: false),
                    CodeLength = table.Column<int>(type: "int", nullable: false),
                    Prefix = table.Column<int>(type: "int", nullable: false),
                    Postfix = table.Column<int>(type: "int", nullable: false),
                    BarcodePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCodePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Scanned = table.Column<int>(type: "int", nullable: false),
                    UsedForSpin = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<int>(type: "int", nullable: false),
                    ExpiredDate = table.Column<int>(type: "int", nullable: false),
                    ScannedDate = table.Column<int>(type: "int", nullable: false),
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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
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
                name: "Winners",
                columns: table => new
                {
                    WinnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendGift = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { 1, "cooledm123@gmail.com", "Nguyen Chinh Thi", null, new byte[] { 102, 80, 9, 246, 25, 19, 202, 254, 214, 181, 56, 222, 85, 48, 232, 14, 199, 147, 77, 64, 15, 214, 151, 237, 254, 185, 105, 207, 151, 93, 107, 74, 142, 167, 92, 109, 19, 115, 34, 253, 221, 125, 73, 150, 78, 4, 94, 96, 56, 76, 85, 87, 143, 171, 16, 21, 46, 34, 140, 168, 127, 65, 228, 51 }, new byte[] { 96, 140, 43, 70, 66, 220, 140, 56, 194, 61, 144, 155, 84, 136, 226, 120, 247, 34, 202, 202, 18, 99, 57, 150, 115, 8, 16, 209, 70, 86, 117, 187, 127, 164, 207, 151, 36, 168, 3, 20, 211, 16, 169, 97, 246, 152, 96, 61, 91, 57, 200, 35, 244, 144, 11, 85, 182, 84, 55, 80, 95, 0, 34, 139, 182, 16, 234, 239, 180, 134, 169, 61, 189, 66, 117, 177, 65, 50, 97, 187, 67, 133, 192, 21, 145, 108, 198, 64, 98, 27, 115, 25, 211, 248, 33, 92, 136, 135, 113, 29, 54, 123, 248, 24, 42, 127, 118, 184, 98, 125, 154, 34, 34, 126, 72, 164, 86, 180, 206, 5, 195, 194, 78, 116, 5, 253, 184, 157 } });

            migrationBuilder.InsertData(
                table: "Charsets",
                columns: new[] { "CharsetId", "CharsetName", "CharsetValue" },
                values: new object[] { 1, "Numbers", "123456789" });

            migrationBuilder.InsertData(
                table: "ProgramSizes",
                columns: new[] { "PSId", "PSDescription", "PSName" },
                values: new object[,]
                {
                    { 1, "up to thousands of random discount codes designed for single use by a limited group customers (e.g., \"ACME - 5P13E\" gives $25 off for the first 3 purchases, new customers from Warsaw only).", "Bulk codes" },
                    { 2, "A fixed-code discount designed for multiple uses (e.g., 10% off with \"blackfriday\" code).", "Standalone code" }
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignId", "ApplyForAllCampaign", "AutoUpdate", "CampaignName", "CharsetId", "CodeCount", "CodeLength", "CodeUsageLimit", "Description", "EndDate", "Postfix", "Prefix", "ProgramSizeId", "StartDate", "Unlimited" },
                values: new object[] { 1, 1, 1, "Lucky Draw 1", 1, 1, 10, 1, "This is for test", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ALTA", 1, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignId", "ApplyForAllCampaign", "AutoUpdate", "CampaignName", "CharsetId", "CodeCount", "CodeLength", "CodeUsageLimit", "Description", "EndDate", "Postfix", "Prefix", "ProgramSizeId", "StartDate", "Unlimited" },
                values: new object[] { 2, 2, 1, "Lucky Draw 2", 1, 1, 10, 1, "This is the second test", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ALTA", 2, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

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

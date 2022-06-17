

global using Lucky_Draw_Promotion.Models;

using Lucky_Draw_Promotion.DTO;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Lucky_Draw_Promotion.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Charset> Charsets { get; set; }
        public DbSet<ProgramSize> ProgramSizes { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBarcode> CustomerBarcodes { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<GiftCode> GiftCodes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeOfBusiness> TypeOfBusinesses { get; set; }
        public DbSet<Winner> Winners { get; set; }
        public DbSet<RuleGift> RuleGifts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerBarcode>()
                .HasKey(x => new { x.CustomerId, x.BarcodeId });
            modelBuilder.Entity<CustomerBarcode>()
                .HasOne(x => x.Customer)
                .WithMany(b => b.CustomerBarcodes)
                .HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<CustomerBarcode>()
                .HasOne(x => x.Barcode)
                .WithMany(c => c.CustomerBarcodes)
                .HasForeignKey(x => x.BarcodeId);
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>(db =>
            {
                CreatePasswordHash("123456", out byte[] passwordHash, out byte[] passwordSalt);

                db.HasIndex(e => e.Email).IsUnique();
                db.HasData(
                    new {
                        AdminId = 1, Email = "cooledm123@gmail.com", PasswordHash = passwordHash, 
                        PasswordSalt = passwordSalt, FullName = "Nguyen Chinh Thi" }                    
                    );
            });
            modelBuilder.Entity<Charset>(db =>
            {
                db.HasData(new
                    {
                        CharsetId = 1,
                        CharsetName = "Numbers",
                        CharsetValue = "123456789",
                    });
            });
            modelBuilder.Entity<ProgramSize>(db =>
            {
                db.HasData(new
                {
                    PSId = 1,
                    PSName = "Bulk codes",
                    PSDescription = "up to thousands of random discount codes designed for single use by a limited group customers (e.g., \"ACME - 5P13E\" gives $25 off for the first 3 purchases, new customers from Warsaw only).",
                },
                new
                {
                    PSId = 2,
                    PSName = "Standalone code",
                    PSDescription = "A fixed-code discount designed for multiple uses (e.g., 10% off with \"blackfriday\" code).",
                }
                );
            });
            modelBuilder.Entity<Campaign>(db =>
            {
                db.HasData(new
                {
                    CampaignId = 1,
                    CampaignName = "Lucky Draw 1",
                    Description = "This is for test",
                    StartDate = DateTime.Parse("2022-06-10"),
                    EndDate = DateTime.Parse("2022-06-20"),
                    CodeCount = 1,
                    CodeUsageLimit = 1,
                    CodeLength = 10,
                    Unlimited = false,
                    Prefix = "ALTA",
                    AutoUpdate = false,
                    OnlyJoinOne = false,
                    ApplyForAllCampaign = false,
                    CharsetId = 1,
                    ProgramSizeId = 1,
                });
            });
            modelBuilder.Entity<Campaign>(db =>
            {
                db.HasData(new
                {
                    CampaignId = 2,
                    CampaignName = "Lucky Draw 2",
                    Description = "This is the second test",
                    StartDate = DateTime.Parse("2022-06-10"),
                    EndDate = DateTime.Parse("2022-06-20"),
                    CodeCount = 1,
                    CodeUsageLimit = 1,
                    CodeLength = 10,
                    Unlimited = false,
                    Prefix = "ALTA",
                    AutoUpdate = false,
                    OnlyJoinOne = false,
                    ApplyForAllCampaign = true,
                    CharsetId = 1,
                    ProgramSizeId = 2,
                });
            });
            modelBuilder.Entity<Product>(db =>
            {
                db.HasData(new
                {
                    ProductId = 1,
                    ProductName = "Hạt nêm Knorr Chay Nấm Hương 400g",
                    ProductDescription = "Hạt nêm Knorr Chay Nấm Hương 400g"
                }, new
                {
                    ProductId = 2,
                    ProductName = "Hạt nêm Knorr Từ Thịt Thăn, Xương Ống & Tủy 600gr",
                    ProductDescription = "Hạt nêm Knorr Từ Thịt Thăn, Xương Ống & Tủy 600gr"
                }, new
                {
                    ProductId = 3,
                    ProductName = "Gia vị Hoàn Chỉnh Knorr Canh Chua 30g",
                    ProductDescription = "Gia vị Hoàn Chỉnh Knorr Canh Chua 30g"
                }, new
                {
                    ProductId = 4,
                    ProductName = "Xốt Nêm Knorr Đậm Đặc Từ Thịt Vị Heo 240g",
                    ProductDescription = "Xốt Nêm Knorr Đậm Đặc Từ Thịt Vị Heo 240g"
                }, new
                {
                    ProductId = 5,
                    ProductName = "Hạt Nêm Knorr Đậm Đặc Từ Thịt Thăn, Xương Ống & Tủy 900gr",
                    ProductDescription = "Hạt Nêm Knorr Đậm Đặc Từ Thịt Thăn, Xương Ống & Tủy 900gr"
                }, new
                {
                    ProductId = 6,
                    ProductName = "Knorr Natural Bột Nêm Tự Nhiên Vị Rau Củ 150g",
                    ProductDescription = "Knorr Natural Bột Nêm Tự Nhiên Vị Rau Củ 150g"
                });
            });
            modelBuilder.Entity<Gift>(db =>
            {
                db.HasData(new
                {
                    GiftId = 1,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 1
                }, new
                {
                    GiftId = 2,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 2
                }, new
                {
                    GiftId = 3,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 3
                }, new
                {
                    GiftId = 4,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 4
                }, new
                {
                    GiftId = 5,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 5
                }, new
                {
                    GiftId = 6,
                    CreatedDate = DateTime.Now,
                    CampaignId = 1,
                    ProductId = 6
                });
            });
            modelBuilder.Entity<GiftCode>(db =>
            {
                db.HasData(new
                {
                    GiftCodeId = 1,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA231453",
                    Active = true,
                    ActiveDate = DateTime.Now,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 2,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA546375",
                    Active = true,
                    ActiveDate = DateTime.Now,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 3,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA111212",
                    Active = true,
                    ActiveDate = DateTime.Now,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 4,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA215223",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 5,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA512311",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 6,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA734521",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 7,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA346222",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 8,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA890231",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 9,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA888769",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 10,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA909878",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 11,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA999231",
                    Active = false,
                    GiftId = 1
                }, new
                {
                    GiftCodeId = 12,
                    CreatedDate = DateTime.Now,
                    Code = "ALTA118908",
                    Active = false,
                    GiftId = 1
                });
            });
            modelBuilder.Entity<Position>(db =>
            {
                db.HasData(new
                {
                    PositionId = 1,
                    PositionName = "Chủ",
                }, new
                {
                    PositionId = 2,
                    PositionName = "Quản lý",
                }, new
                {
                    PositionId = 3,
                    PositionName = "Bếp",
                }
                );
            });
            modelBuilder.Entity<TypeOfBusiness>(db =>
            {
                db.HasData(new
                {
                    TOBId = 1,
                    TOBName = "Khách sạn"
                },new
                {
                    TOBId = 2,
                    TOBName = "Nhà hàng"
                }, new
                {
                    TOBId = 3,
                    TOBName = "Quán ăn"
                }, new
                {
                    TOBId = 4,
                    TOBName = "Bán sỉ"
                }, new
                {
                    TOBId = 5,
                    TOBName = "Resort"
                });
            });
            modelBuilder.Entity<Customer>(db =>
            {
                db.HasData(new
                {
                    CustomerId = 1,
                    Fullname = "Nguyễn Hữu Huân",
                    PhoneNumber = "0901456781",
                    DateOfBirth = DateTime.Parse("1973-03-01"),
                    Location = "Quận 6, TPHCM",
                    Block = true,
                    PositionId = 1,
                    TOBId = 1
                }, new
                {
                    CustomerId = 2,
                    Fullname = "Nguyễn Trọng Hữu",
                    PhoneNumber = "0907852781",
                    DateOfBirth = DateTime.Parse("1974-04-01"),
                    Location = "Quận 5, TPHCM",
                    Block = true,
                    PositionId = 2,
                    TOBId = 2
                }, new
                {
                    CustomerId = 3,
                    Fullname = "Trần Hùng Phát",
                    PhoneNumber = "0901485381",
                    DateOfBirth = DateTime.Parse("1975-05-01"),
                    Location = "Quận 7, TPHCM",
                    Block = true,
                    PositionId = 3,
                    TOBId = 3
                }, new
                {
                    CustomerId = 4,
                    Fullname = "Lê Ngọc Anh",
                    PhoneNumber = "0901451981",
                    DateOfBirth = DateTime.Parse("1976-06-01"),
                    Location = "Bến Lức, Long An",
                    Block = true,
                    PositionId = 1,
                    TOBId = 4
                }, new
                {
                    CustomerId = 5,
                    Fullname = "Lê Phan",
                    PhoneNumber = "0901742681",
                    DateOfBirth = DateTime.Parse("1977-07-01"),
                    Location = "Biên Hòa, Đồng Nai",
                    Block = true,
                    PositionId = 2,
                    TOBId = 3
                }, new
                {
                    CustomerId = 6,
                    Fullname = "Nguyễn Thị Ngọc Hương",
                    PhoneNumber = "0904803457",
                    DateOfBirth = DateTime.Parse("1978-08-01"),
                    Location = "Bến Lức, Long An",
                    Block = false,
                    PositionId = 1,
                    TOBId = 3
                }, new
                {
                    CustomerId = 7,
                    Fullname = "Trần Văn Tình",
                    PhoneNumber = "0947514514",
                    DateOfBirth = DateTime.Parse("1979-09-01"),
                    Location = "Cai Lậy, Tiền Giang",
                    Block = false,
                    PositionId = 1,
                    TOBId = 5
                });
            });
            modelBuilder.Entity<Winner>(db =>
            {
                db.HasData(new
                {
                    WinnerId = 1,
                    WinDate = DateTime.Now,
                    SendGift = true,
                    CustomerId = 1,
                    GiftCodeId = 3,
                }, new
                {
                    WinnerId = 2,
                    WinDate = DateTime.Now,
                    SendGift = false,
                    CustomerId = 2,
                    GiftCodeId = 4,
                });
            });
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
    
}

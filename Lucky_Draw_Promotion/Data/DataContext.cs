

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
                    Unlimited = 1,
                    Prefix = "ALTA",
                    AutoUpdate = 1,
                    ApplyForAllCampaign = 1,
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
                    Unlimited = 1,
                    Prefix = "ALTA",
                    AutoUpdate = 1,
                    ApplyForAllCampaign = 2,
                    CharsetId = 1,
                    ProgramSizeId = 2,
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

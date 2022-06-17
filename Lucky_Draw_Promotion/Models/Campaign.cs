using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Campaign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CodeCount { get; set; } = 1;
        public int CodeUsageLimit { get; set; } = 1;
        public int CodeLength { get; set; } = 10;
        public bool Unlimited { get; set; }
        public string? Prefix { get; set; } = null!;
        public string? Postfix { get; set; }
        public bool AutoUpdate { get; set; }
        public bool OnlyJoinOne { get; set; }
        public bool ApplyForAllCampaign { get; set; }
        [ForeignKey("CharsetId")]
        public Charset Charset { get; set; } = null!;
        public int CharsetId { get; set; }
        [ForeignKey("ProgramSizeId")]
        public ProgramSize ProgramSize { get; set; } = null!;
        public int ProgramSizeId { get; set; }



        public ICollection<Gift> Gifts { get; set; }
        public ICollection<Barcode> Barcodes { get; set; }


    }
}

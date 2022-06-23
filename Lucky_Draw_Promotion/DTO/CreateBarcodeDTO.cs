using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class CreateBarcodeDTO
    {
        public int CodeRedemptionLimit { get; set; }
        public bool Unlimited { get; set; }
        [Required]
        public int CodeCount { get; set; }
        [Required]
        public int CampaignId { get; set; }
        [Required]
        public int CharsetId { get; set; }
        [Required]
        public int CodeLength { get; set; }
        public string? Prefix { get; set; }
        public string? Postfix { get; set; }

    }
}

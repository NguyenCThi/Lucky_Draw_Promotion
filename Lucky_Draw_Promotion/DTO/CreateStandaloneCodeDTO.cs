using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.Models
{
    public class CreateStandaloneCodeDTO
    {
        [Required]
        public string CampaignName { get; set; }
        public bool ApplyForAllCampaign { get; set; }
        public string? Description { get; set; }
        public int CodeUsageLimit { get; set; } = 1;
        public bool Unlimited { get; set; }
        [Required]
        public int CharsetId { get; set; }
        public int CodeLength { get; set; } = 10;
        public string? Prefix { get; set; }
        public string? Postfix { get; set; }
    }
}

namespace Lucky_Draw_Promotion.Models
{
    public class UpdateCampaignDTO
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CodeUsageLimit { get; set; }
    }
}

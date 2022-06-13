namespace Lucky_Draw_Promotion.Models
{
    public class UpdateCampaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CodeUsageLimit { get; set; }
    }
}

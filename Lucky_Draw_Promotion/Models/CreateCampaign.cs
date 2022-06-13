namespace Lucky_Draw_Promotion.Models
{
    public class CreateCampaign
    {
        public string CampaignName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CodeCount { get; set; }
        public int CodeUsageLimit { get; set; }
        public int CodeLength { get; set; }
        public int Unlimited { get; set; }
        public string Prefix { get; set; } = null!;
        public string? Postfix { get; set; }
        public int AutoUpdate { get; set; }
        public int ApplyForAllCampaign { get; set; }
        public int CharsetId { get; set; }
        public int ProgramSizeId { get; set; }
    }
}

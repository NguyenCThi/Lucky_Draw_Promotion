namespace Lucky_Draw_Promotion.DTO
{
    public class CreateRuleForGiftDTO
    {
        public string RuleName { get; set; }
        public int GiftId { get; set; }
        public int GiftAmount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool AllDay { get; set; }
        public int Probability { get; set; }
        public bool? MonthlyOnDay { get; set; }
        public string? SelectDayMOD { get; set; }
        public bool? WeeklyOn { get; set; }
        public bool? MonWO { get; set; }
        public bool? TueWO { get; set; }
        public bool? WedWO { get; set; }
        public bool? ThuWO { get; set; }
        public bool? FriWO { get; set; }
        public bool? SatWO { get; set; }
        public bool? SunWO { get; set; }
        public bool? RepeatDaily { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

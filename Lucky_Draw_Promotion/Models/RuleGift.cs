using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class RuleGift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RuleId { get; set; }
        [ForeignKey("GiftId")]
        public Gift Gift { get; set; }
        public int GiftId { get; set; }
        public string RuleName { get; set; }
        public int GiftAmount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool AllDay { get; set; } = false;
        public int? Probability { get; set; } = 0;
        public bool? MonthlyOnDay { get; set; } = false;
        public string? SelectDayForMonthlyOnDay { get; set; }
        public bool? WeeklyOn { get; set; } = false;
        public string? ChooseDayForWeeklyOn { get; set; }
        public bool? RepeatDaily { get; set; } = false;
        public DateTime? StartDateRD { get; set; }
        public DateTime? EndDateRD { get; set; }

        
    }
}

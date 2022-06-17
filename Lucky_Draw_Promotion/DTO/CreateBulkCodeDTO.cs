using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.Models
{
    public class CreateBulkCodeDTO
    {
        [Required]
        public string ProgramName { get; set; }
        public bool AutoUpdate { get; set; }
        public bool OnlyJoinOne { get; set; }
        public string? Description { get; set; }
        public int CodeUsageLimit { get; set; } = 1;
        public bool Unlimited { get; set; }
        [Required]
        public int CodeCount { get; set; } = 1;
        [Required]
        public int CharsetId { get; set; }
        public int CodeLength { get; set; } = 10;
        public string? Prefix { get; set; }
        public string? Postfix { get; set; }
        

    }
}

using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.Models
{
    public class SetTimeFrameDTO
    {
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EnterTimeSD { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DateTime EnterTimeED { get; set; }
    }
}

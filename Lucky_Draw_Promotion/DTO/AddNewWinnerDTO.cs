using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class AddNewWinnerDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int GiftCodeId { get; set; }
    }
}

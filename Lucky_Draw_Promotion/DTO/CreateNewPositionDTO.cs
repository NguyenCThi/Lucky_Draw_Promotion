using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class CreateNewPositionDTO
    {
        [Required]
        public string PositionName { get; set; }
    }
}

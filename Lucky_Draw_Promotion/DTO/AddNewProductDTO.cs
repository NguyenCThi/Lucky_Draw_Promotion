using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class AddNewProductDTO
    {
        [Required]
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class EditProductDTO
    {
        [Required]
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
    }
}

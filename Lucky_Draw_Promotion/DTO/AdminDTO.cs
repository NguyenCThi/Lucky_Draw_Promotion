using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class AdminDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;

    }
}

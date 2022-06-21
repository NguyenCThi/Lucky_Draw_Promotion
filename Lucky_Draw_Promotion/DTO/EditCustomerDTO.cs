using System.ComponentModel.DataAnnotations;

namespace Lucky_Draw_Promotion.DTO
{
    public class EditCustomerDTO
    {
        [Required]
        public string? Fullname { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public int? PositionId { get; set; }
        [Required]
        public int? TOBId { get; set; }
    }
}

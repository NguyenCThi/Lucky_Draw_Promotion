using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.DTO
{
    public class CreateCustomerDTO
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public string Location { get; set; }
        public bool Block { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public int TypeOfBusinessId { get; set; }
    }
}

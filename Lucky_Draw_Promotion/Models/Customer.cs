using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Customer
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        public string? Location { get; set; }
        public bool Block { get; set; }
        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        [ForeignKey("TOBId")]
        public TypeOfBusiness TypeOfBusiness { get; set; }
        public int? TOBId { get; set; }




        public ICollection<Winner> Winners { get; set; }



        public ICollection<CustomerBarcode> CustomerBarcodes { get; set; }
    }
}

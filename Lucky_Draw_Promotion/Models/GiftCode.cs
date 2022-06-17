using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class GiftCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GiftCodeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Code { get; set; }
        public bool Active { get; set; }
        public DateTime? ActiveDate { get; set; }
        [ForeignKey("GiftId")]
        public Gift? Gift { get; set; }
        public int GiftId { get; set; }


        public ICollection<Winner>? Winners { get; set; }
    }
}

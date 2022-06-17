using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Winner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WinnerId { get; set; }
        public DateTime WinDate { get; set; }
        public bool SendGift { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("GiftCodeId")]
        public GiftCode? GiftCode { get; set; }
        public int GiftCodeId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Gift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GiftId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }


        public ICollection<GiftCode> GiftCodes { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Barcode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarcodeId { get; set; }
        public int CodeRedemptionLimit { get; set; }
        public bool Unlimited { get; set; }
        public int CodeLength { get; set; }
        public string? Prefix { get; set; }
        public string? Postfix { get; set; }
        public string CodeGenerated { get; set; }
        public bool Active { get; set; }
        public bool Scanned { get; set; }
        public bool UsedForSpin { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime ScannedDate { get; set; }
        [ForeignKey("CampaignId")]
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }
        [ForeignKey("CharsetId")]
        public Charset Charset { get; set; }
        public int? CharsetId { get; set; }






        public ICollection<CustomerBarcode> CustomerBarcodes { get; set; }
    }
}

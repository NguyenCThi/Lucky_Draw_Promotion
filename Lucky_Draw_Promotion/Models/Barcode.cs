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
        public int CodeCount { get; set; }
        public int CodeLength { get; set; }
        public int? Prefix { get; set; }
        public int? Postfix { get; set; }
        public string BarcodePic { get; set; }
        public string QRCodePic { get; set; }
        public bool Active { get; set; }
        public bool Scanned { get; set; }
        public bool UsedForSpin { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime ScannedDate { get; set; }
        [ForeignKey("CampaignId")]
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }






        public ICollection<CustomerBarcode> CustomerBarcodes { get; set; }
    }
}

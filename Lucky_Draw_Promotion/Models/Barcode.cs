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
        public int Unlimited { get; set; }
        public int CodeCount { get; set; }
        public int CodeLength { get; set; }
        public int Prefix { get; set; }
        public int Postfix { get; set; }
        public string BarcodePic { get; set; }
        public string QRCodePic { get; set; }
        public int Active { get; set; }
        public int Scanned { get; set; }
        public int UsedForSpin { get; set; }
        public int CreatedDate { get; set; }
        public int ExpiredDate { get; set; }
        public int ScannedDate { get; set; }
        [ForeignKey("CampaignId")]
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }






        public ICollection<CustomerBarcode> CustomerBarcodes { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class Charset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharsetId { get; set; }
        public string CharsetName { get; set; }
        public string CharsetValue { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
        public ICollection<Barcode> Barcodes { get; set; }
    }
}

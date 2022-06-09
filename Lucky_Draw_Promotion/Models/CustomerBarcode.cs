using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class CustomerBarcode
    {
        [Key]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Key]
        [ForeignKey("Barcode")]
        public int BarcodeId { get; set; }
        public Barcode Barcode { get; set; }
    }
}

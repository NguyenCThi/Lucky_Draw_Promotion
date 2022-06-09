using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class TypeOfBusiness
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TOBId { get; set; }
        public string TOBName { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}

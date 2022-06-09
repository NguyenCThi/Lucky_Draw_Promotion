using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucky_Draw_Promotion.Models
{
    public class ProgramSize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PSId { get; set; }
        public string PSName { get; set; }
        public string PSDescription { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
    }
}

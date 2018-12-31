using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        [Required]
        public int KitapID { get; set; }
        [StringLength(50)]
        public string KitapAdi { get; set; }
        public decimal Adet { get; set; } = 0;
        public int YazarID { get; set; }

        [ForeignKey("YazarID")]

        public virtual Yazar Yazar { get; set; }

        public virtual ICollection<KiralamaBilgisi> Kiralamalar { get; set; } = new HashSet<KiralamaBilgisi>();
    }
}

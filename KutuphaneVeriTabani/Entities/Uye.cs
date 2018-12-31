using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.Entities
{ [Table("Uyeler")]
    public class Uye
    {
        [Key]
        public int UyeID { get; set; }
        [Required]
        public string UyeAdi { get; set; }
        [Required]
        public string UyeSoyadi { get; set; }
        [Required]
        [StringLength(11)]
        public string UyeTCKN { get; set; }
        [StringLength(11)]
        [Required]
        public string UyeTel { get; set; }
        
        public bool KitabıVarMi { get; set; } = false;
        public virtual ICollection<KiralamaBilgisi> Kiralamalar { get; set; } = new HashSet<KiralamaBilgisi>();
    }
}

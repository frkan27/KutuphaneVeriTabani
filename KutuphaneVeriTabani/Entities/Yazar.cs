using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.Entities
{[Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        [Required]
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public virtual List<Kitap> Kitaplar{get;set;} 

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.Entities
{
    [Table("KiralamaDetay")]
   public  class KiralamaBilgisi
    {
        [Key]
        [Column(Order =1)]
        public int KitapID { get; set; }
        [Key]
        [Column(Order =2)]
        public int UyeID { get; set; }
        [Column("KiralandıgıTarih", TypeName = "date")]
        public DateTime KiralandigiTarih { get; set; } = DateTime.Now;
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }
        [ForeignKey("UyeID")]
        public virtual Uye Uye { get; set; }
    }
}

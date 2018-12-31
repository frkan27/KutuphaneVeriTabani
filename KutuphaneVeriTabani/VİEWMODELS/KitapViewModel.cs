using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.VİEWMODELS
{
   public class KitapViewModel
    {
        public int KitapID { get; set; }
       
        public string KitapAdi { get; set; }
        public decimal Adet { get; set; } = 0;
        public int YazarID { get; set; }
       
        public override string ToString() => $"{KitapAdi} + Adet({Adet})";
        
    }
}

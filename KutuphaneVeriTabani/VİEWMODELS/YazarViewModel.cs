using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.VİEWMODELS
{
    public class YazarViewModel
    {
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
     

        public override string ToString() => $"{YazarAd} {YazarSoyad}";
        
    }
}

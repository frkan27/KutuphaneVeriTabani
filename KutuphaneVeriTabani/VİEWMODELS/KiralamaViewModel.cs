using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.VİEWMODELS
{
    public class KiralamaViewModel
    {
        public int UyeID { get; set; }
        
        public int YazarID { get; set; }
        public int KitapID { get; set; }
        public decimal Adet { get; set; }
        public bool KitapVarMi { get; set; }
        public DateTime  KiralandigiTarih { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }


    }
}

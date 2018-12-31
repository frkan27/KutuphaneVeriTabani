using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.VİEWMODELS
{
   public class UyeViewModel
    {
        public int UyeID { get; set; }
        
        public string UyeAdi { get; set; }
       
        public string UyeSoyadi { get; set; }
       
       
        public string UyeTCKN { get; set; }
      
       
        public string UyeTel { get; set; }

        public override string ToString() => $"{UyeAdi} {UyeSoyadi}";
      
    }
}

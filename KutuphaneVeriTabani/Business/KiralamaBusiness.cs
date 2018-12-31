using KutuphaneVeriTabani.Entities;
using KutuphaneVeriTabani.VİEWMODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneVeriTabani.Business
{
    public  class KiralamaBusiness
    {
        public  int Kiralama(KiralamaViewModel KiralaModel)
        {
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var kirala = new KiralamaBilgisi()
                    {
                        UyeID = KiralaModel.UyeID,
                        KitapID = KiralaModel.KitapID,
                        KiralandigiTarih = KiralaModel.KiralandigiTarih,
                         
                    };
                   var uye= db.Uyeler.Find(KiralaModel.UyeID);
                    uye.KitabıVarMi = true;
                    var kitap = db.Kitaplar.Find(KiralaModel.KitapID);
                    kitap.Adet--;
                    db.Kiralamalar.Add(kirala);
                    db.SaveChanges();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            return 1;

           
        }

    }
}

using KutuphaneVeriTabani.Entities;
using KutuphaneVeriTabani.VİEWMODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneVeriTabani
{
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var uye = new Uye()
                {
                    UyeAdi = txtUyeAdi.Text,
                    UyeSoyadi = txtUyeSoyadı.Text,
                    UyeTCKN = txtUyeTCKN.Text,
                    UyeTel = txtUyeTel.Text
                    
                };
                db.Uyeler.Add(uye);
                db.SaveChanges();
                MessageBox.Show("kayıt basarılı");
                FormuTemizle(this.pnlUye);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var yazar = new Yazar()
                {
                    YazarAd = txtYazarADi.Text,
                    YazarSoyad = txtYazarSoyadi.Text

                };
                db.Yazarlar.Add(yazar);
                db.SaveChanges();
                MessageBox.Show("kayıt basarılı");
                FormuTemizle(this.pnlYazarKaydet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var kitap = new Kitap()
                {
                    KitapAdi = txtKitapAdi.Text,
                    Adet = Convert.ToDecimal(txtKitapAdeti.Text),
                    YazarID = (cmbYazarSec.SelectedItem as YazarViewModel).YazarID



                };
                db.Kitaplar.Add(kitap);
                db.SaveChanges();
                MessageBox.Show("kayıt basarılı");
                FormuTemizle(this.pnlKitap);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void KayıtFormu_Load(object sender, EventArgs e)
        {
            
            MyContext db = new MyContext();
            cmbYazarSec.DataSource = db.Yazarlar
                .OrderBy(x => x.YazarAd)
               .ThenBy(x => x.YazarSoyad)
                .Select(x => new YazarViewModel
                {
                    YazarID = x.YazarID,
                    YazarAd = x.YazarAd,
                    YazarSoyad = x.YazarSoyad
                })
               .ToList();
        }

        private void FormuTemizle(Control Parent)
        {
            foreach (Control  control in Parent.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is ListBox lst)
                    lst.Items.Clear();
                //if (control is ComboBox cmb)
                //    cmb.Items.Clear();
            }
        }







          
        
    }
}

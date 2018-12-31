﻿using KutuphaneVeriTabani.VİEWMODELS;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void kayıtİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KayıtFormu getir = new KayıtFormu();
            getir.ShowDialog();
        }

        private void btnUyeleriListe_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Uyeler
                .OrderBy(x => x.UyeAdi)
                .ThenBy(x => x.UyeSoyadi)
                .Where(x => x.KitabıVarMi == false)
                .Select(x => new UyeViewModel
                {
                    UyeAdi = x.UyeAdi,
                    UyeSoyadi = x.UyeSoyadi,
                    UyeID = x.UyeID,
                    UyeTCKN = x.UyeTCKN,
                    UyeTel = x.UyeTel
                })
                .ToList();
        }

        private void btnYazarlarıListele_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstYazarlar.DataSource = db.Yazarlar
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

        private void btnKitaplarıListele_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstKitaplar.DataSource = db.Kitaplar
               .OrderBy(x => x.KitapAdi)
               .Select(x => new KitapViewModel
               {
                   KitapAdi = x.KitapAdi,
                   KitapID = x.KitapID,
                   Adet = x.Adet
               })
               .ToList();
        }
        YazarViewModel seciliYazar;
        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            MyContext db = new MyContext();

            if (lstYazarlar.SelectedItem == null) return;
            seciliYazar = lstYazarlar.SelectedItem as YazarViewModel;
                lstKitaplar.DataSource = db.Kitaplar
                        .Where(x => x.YazarID == seciliYazar.YazarID)
                        .OrderBy(x => x.KitapAdi)
                        .Select(x => new KitapViewModel
                        {
                            KitapAdi = x.KitapAdi,
                            Adet = x.Adet
                        }).ToList();



        }
    }
}

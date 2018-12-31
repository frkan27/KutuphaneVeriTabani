namespace KutuphaneVeriTabani
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUyeleriListe = new System.Windows.Forms.Button();
            this.btnYazarlarıListele = new System.Windows.Forms.Button();
            this.btnKitaplarıListele = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            this.lstKiralmabilgisi = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.Location = new System.Drawing.Point(29, 76);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(145, 199);
            this.lstUyeler.TabIndex = 0;
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(187, 76);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(145, 199);
            this.lstYazarlar.TabIndex = 1;
            this.lstYazarlar.SelectedIndexChanged += new System.EventHandler(this.lstYazarlar_SelectedIndexChanged);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(346, 76);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(145, 199);
            this.lstKitaplar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtİşlemleriToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtİşlemleriToolStripMenuItem1
            // 
            this.kayıtİşlemleriToolStripMenuItem1.Name = "kayıtİşlemleriToolStripMenuItem1";
            this.kayıtİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.kayıtİşlemleriToolStripMenuItem1.Text = "Kayıtİşlemleri";
            this.kayıtİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.kayıtİşlemleriToolStripMenuItem1_Click);
            // 
            // btnUyeleriListe
            // 
            this.btnUyeleriListe.Location = new System.Drawing.Point(29, 47);
            this.btnUyeleriListe.Name = "btnUyeleriListe";
            this.btnUyeleriListe.Size = new System.Drawing.Size(145, 23);
            this.btnUyeleriListe.TabIndex = 6;
            this.btnUyeleriListe.Text = "Üyeleri Listele";
            this.btnUyeleriListe.UseVisualStyleBackColor = true;
            this.btnUyeleriListe.Click += new System.EventHandler(this.btnUyeleriListe_Click);
            // 
            // btnYazarlarıListele
            // 
            this.btnYazarlarıListele.Location = new System.Drawing.Point(187, 47);
            this.btnYazarlarıListele.Name = "btnYazarlarıListele";
            this.btnYazarlarıListele.Size = new System.Drawing.Size(145, 23);
            this.btnYazarlarıListele.TabIndex = 7;
            this.btnYazarlarıListele.Text = "Yazarları Listele";
            this.btnYazarlarıListele.UseVisualStyleBackColor = true;
            this.btnYazarlarıListele.Click += new System.EventHandler(this.btnYazarlarıListele_Click);
            // 
            // btnKitaplarıListele
            // 
            this.btnKitaplarıListele.Location = new System.Drawing.Point(346, 47);
            this.btnKitaplarıListele.Name = "btnKitaplarıListele";
            this.btnKitaplarıListele.Size = new System.Drawing.Size(145, 23);
            this.btnKitaplarıListele.TabIndex = 8;
            this.btnKitaplarıListele.Text = "Kitapları Listele";
            this.btnKitaplarıListele.UseVisualStyleBackColor = true;
            this.btnKitaplarıListele.Click += new System.EventHandler(this.btnKitaplarıListele_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(535, 76);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(104, 44);
            this.btnKirala.TabIndex = 9;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // lstKiralmabilgisi
            // 
            this.lstKiralmabilgisi.FormattingEnabled = true;
            this.lstKiralmabilgisi.Location = new System.Drawing.Point(152, 329);
            this.lstKiralmabilgisi.Name = "lstKiralmabilgisi";
            this.lstKiralmabilgisi.Size = new System.Drawing.Size(512, 95);
            this.lstKiralmabilgisi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 496);
            this.Controls.Add(this.lstKiralmabilgisi);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.btnKitaplarıListele);
            this.Controls.Add(this.btnYazarlarıListele);
            this.Controls.Add(this.btnUyeleriListe);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.lstUyeler);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.Button btnUyeleriListe;
        private System.Windows.Forms.Button btnYazarlarıListele;
        private System.Windows.Forms.Button btnKitaplarıListele;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ListBox lstKiralmabilgisi;
    }
}


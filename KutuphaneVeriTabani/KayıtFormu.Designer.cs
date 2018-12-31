namespace KutuphaneVeriTabani
{
    partial class KayıtFormu
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
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.txtUyeSoyadı = new System.Windows.Forms.TextBox();
            this.txtUyeTCKN = new System.Windows.Forms.TextBox();
            this.txtUyeTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlUye = new System.Windows.Forms.Panel();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.txtYazarADi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYazarKaydet = new System.Windows.Forms.Button();
            this.pnlYazarKaydet = new System.Windows.Forms.Panel();
            this.txtKitapAdeti = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbYazarSec = new System.Windows.Forms.ComboBox();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.pnlUye.SuspendLayout();
            this.pnlYazarKaydet.SuspendLayout();
            this.pnlKitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(113, 14);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(115, 20);
            this.txtUyeAdi.TabIndex = 0;
            // 
            // txtUyeSoyadı
            // 
            this.txtUyeSoyadı.Location = new System.Drawing.Point(113, 62);
            this.txtUyeSoyadı.Name = "txtUyeSoyadı";
            this.txtUyeSoyadı.Size = new System.Drawing.Size(115, 20);
            this.txtUyeSoyadı.TabIndex = 1;
            // 
            // txtUyeTCKN
            // 
            this.txtUyeTCKN.Location = new System.Drawing.Point(113, 105);
            this.txtUyeTCKN.Name = "txtUyeTCKN";
            this.txtUyeTCKN.Size = new System.Drawing.Size(115, 20);
            this.txtUyeTCKN.TabIndex = 2;
            // 
            // txtUyeTel
            // 
            this.txtUyeTel.Location = new System.Drawing.Point(113, 150);
            this.txtUyeTel.Name = "txtUyeTel";
            this.txtUyeTel.Size = new System.Drawing.Size(115, 20);
            this.txtUyeTel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "TCKN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(128, 190);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Üye Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pnlUye
            // 
            this.pnlUye.Controls.Add(this.txtUyeSoyadı);
            this.pnlUye.Controls.Add(this.btnKaydet);
            this.pnlUye.Controls.Add(this.txtUyeAdi);
            this.pnlUye.Controls.Add(this.label4);
            this.pnlUye.Controls.Add(this.txtUyeTCKN);
            this.pnlUye.Controls.Add(this.label3);
            this.pnlUye.Controls.Add(this.txtUyeTel);
            this.pnlUye.Controls.Add(this.label2);
            this.pnlUye.Controls.Add(this.label1);
            this.pnlUye.Location = new System.Drawing.Point(12, 12);
            this.pnlUye.Name = "pnlUye";
            this.pnlUye.Size = new System.Drawing.Size(235, 247);
            this.pnlUye.TabIndex = 9;
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(88, 62);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtYazarSoyadi.TabIndex = 11;
            // 
            // txtYazarADi
            // 
            this.txtYazarADi.Location = new System.Drawing.Point(88, 19);
            this.txtYazarADi.Name = "txtYazarADi";
            this.txtYazarADi.Size = new System.Drawing.Size(100, 20);
            this.txtYazarADi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adı:";
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.Location = new System.Drawing.Point(88, 94);
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.Size = new System.Drawing.Size(100, 57);
            this.btnYazarKaydet.TabIndex = 14;
            this.btnYazarKaydet.Text = "Yazar Kaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = true;
            this.btnYazarKaydet.Click += new System.EventHandler(this.btnYazarKaydet_Click);
            // 
            // pnlYazarKaydet
            // 
            this.pnlYazarKaydet.Controls.Add(this.txtYazarSoyadi);
            this.pnlYazarKaydet.Controls.Add(this.btnYazarKaydet);
            this.pnlYazarKaydet.Controls.Add(this.label6);
            this.pnlYazarKaydet.Controls.Add(this.label5);
            this.pnlYazarKaydet.Controls.Add(this.txtYazarADi);
            this.pnlYazarKaydet.Location = new System.Drawing.Point(264, 12);
            this.pnlYazarKaydet.Name = "pnlYazarKaydet";
            this.pnlYazarKaydet.Size = new System.Drawing.Size(200, 174);
            this.pnlYazarKaydet.TabIndex = 15;
            // 
            // txtKitapAdeti
            // 
            this.txtKitapAdeti.Location = new System.Drawing.Point(136, 64);
            this.txtKitapAdeti.Name = "txtKitapAdeti";
            this.txtKitapAdeti.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdeti.TabIndex = 17;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(136, 16);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kitap Adeti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kitap Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Yazar:";
            // 
            // cmbYazarSec
            // 
            this.cmbYazarSec.FormattingEnabled = true;
            this.cmbYazarSec.Location = new System.Drawing.Point(136, 104);
            this.cmbYazarSec.Name = "cmbYazarSec";
            this.cmbYazarSec.Size = new System.Drawing.Size(121, 21);
            this.cmbYazarSec.TabIndex = 21;
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(136, 144);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(121, 40);
            this.btnKitapKaydet.TabIndex = 22;
            this.btnKitapKaydet.Text = "Kitap Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            this.btnKitapKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlKitap
            // 
            this.pnlKitap.Controls.Add(this.label7);
            this.pnlKitap.Controls.Add(this.btnKitapKaydet);
            this.pnlKitap.Controls.Add(this.label8);
            this.pnlKitap.Controls.Add(this.cmbYazarSec);
            this.pnlKitap.Controls.Add(this.txtKitapAdi);
            this.pnlKitap.Controls.Add(this.label9);
            this.pnlKitap.Controls.Add(this.txtKitapAdeti);
            this.pnlKitap.Location = new System.Drawing.Point(481, 12);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(266, 201);
            this.pnlKitap.TabIndex = 23;
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlKitap);
            this.Controls.Add(this.pnlYazarKaydet);
            this.Controls.Add(this.pnlUye);
            this.Name = "KayıtFormu";
            this.Text = "KayıtFormu";
            this.Load += new System.EventHandler(this.KayıtFormu_Load);
            this.pnlUye.ResumeLayout(false);
            this.pnlUye.PerformLayout();
            this.pnlYazarKaydet.ResumeLayout(false);
            this.pnlYazarKaydet.PerformLayout();
            this.pnlKitap.ResumeLayout(false);
            this.pnlKitap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.TextBox txtUyeSoyadı;
        private System.Windows.Forms.TextBox txtUyeTCKN;
        private System.Windows.Forms.TextBox txtUyeTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlUye;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.TextBox txtYazarADi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnYazarKaydet;
        private System.Windows.Forms.Panel pnlYazarKaydet;
        private System.Windows.Forms.TextBox txtKitapAdeti;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbYazarSec;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.Panel pnlKitap;
    }
}
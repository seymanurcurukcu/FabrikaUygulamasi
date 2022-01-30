namespace FabrikaUygulamaSenaryosu
{
    partial class FrmPersonel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.grpPersonelBilgisi = new System.Windows.Forms.GroupBox();
            this.pctCikart = new System.Windows.Forms.PictureBox();
            this.btnCikart = new System.Windows.Forms.Button();
            this.pctListele = new System.Windows.Forms.PictureBox();
            this.pctEkle = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.mskTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lstListele = new System.Windows.Forms.ListBox();
            this.txtFabrikaAdı = new System.Windows.Forms.TextBox();
            this.txtFabrikaAdresi = new System.Windows.Forms.TextBox();
            this.lblFabrikaAdı = new System.Windows.Forms.Label();
            this.lblFabrikaAdres = new System.Windows.Forms.Label();
            this.grpPersonelBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCikart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonelBilgisi
            // 
            this.grpPersonelBilgisi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpPersonelBilgisi.Controls.Add(this.lblFabrikaAdres);
            this.grpPersonelBilgisi.Controls.Add(this.lblFabrikaAdı);
            this.grpPersonelBilgisi.Controls.Add(this.txtFabrikaAdresi);
            this.grpPersonelBilgisi.Controls.Add(this.txtFabrikaAdı);
            this.grpPersonelBilgisi.Controls.Add(this.lstListele);
            this.grpPersonelBilgisi.Controls.Add(this.pctCikart);
            this.grpPersonelBilgisi.Controls.Add(this.btnCikart);
            this.grpPersonelBilgisi.Controls.Add(this.pctListele);
            this.grpPersonelBilgisi.Controls.Add(this.pctEkle);
            this.grpPersonelBilgisi.Controls.Add(this.btnEkle);
            this.grpPersonelBilgisi.Controls.Add(this.btnListele);
            this.grpPersonelBilgisi.Controls.Add(this.txtBirim);
            this.grpPersonelBilgisi.Controls.Add(this.lblBirim);
            this.grpPersonelBilgisi.Controls.Add(this.mskTcKimlik);
            this.grpPersonelBilgisi.Controls.Add(this.lblTcKimlikNo);
            this.grpPersonelBilgisi.Controls.Add(this.txtSoyad);
            this.grpPersonelBilgisi.Controls.Add(this.lblSoyad);
            this.grpPersonelBilgisi.Controls.Add(this.txtAd);
            this.grpPersonelBilgisi.Controls.Add(this.lblAd);
            this.grpPersonelBilgisi.Controls.Add(this.txtPersonelNo);
            this.grpPersonelBilgisi.Controls.Add(this.lblPersonelNo);
            this.grpPersonelBilgisi.Location = new System.Drawing.Point(12, 33);
            this.grpPersonelBilgisi.Name = "grpPersonelBilgisi";
            this.grpPersonelBilgisi.Size = new System.Drawing.Size(596, 394);
            this.grpPersonelBilgisi.TabIndex = 0;
            this.grpPersonelBilgisi.TabStop = false;
            this.grpPersonelBilgisi.Text = "Fabrika Personel Bilgileri";
            // 
            // pctCikart
            // 
            this.pctCikart.Image = ((System.Drawing.Image)(resources.GetObject("pctCikart.Image")));
            this.pctCikart.Location = new System.Drawing.Point(339, 139);
            this.pctCikart.Name = "pctCikart";
            this.pctCikart.Size = new System.Drawing.Size(41, 30);
            this.pctCikart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCikart.TabIndex = 18;
            this.pctCikart.TabStop = false;
            // 
            // btnCikart
            // 
            this.btnCikart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCikart.Location = new System.Drawing.Point(386, 139);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(138, 30);
            this.btnCikart.TabIndex = 13;
            this.btnCikart.Text = "Personel Çıkart";
            this.btnCikart.UseVisualStyleBackColor = false;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // pctListele
            // 
            this.pctListele.Image = ((System.Drawing.Image)(resources.GetObject("pctListele.Image")));
            this.pctListele.Location = new System.Drawing.Point(339, 91);
            this.pctListele.Name = "pctListele";
            this.pctListele.Size = new System.Drawing.Size(41, 30);
            this.pctListele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctListele.TabIndex = 17;
            this.pctListele.TabStop = false;
            // 
            // pctEkle
            // 
            this.pctEkle.Image = ((System.Drawing.Image)(resources.GetObject("pctEkle.Image")));
            this.pctEkle.Location = new System.Drawing.Point(339, 41);
            this.pctEkle.Name = "pctEkle";
            this.pctEkle.Size = new System.Drawing.Size(41, 30);
            this.pctEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEkle.TabIndex = 15;
            this.pctEkle.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(386, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 30);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListele.Location = new System.Drawing.Point(386, 91);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(138, 30);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Personel Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(159, 149);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(127, 20);
            this.txtBirim.TabIndex = 9;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(119, 156);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(34, 13);
            this.lblBirim.TabIndex = 8;
            this.lblBirim.Text = "Birimi:";
            // 
            // mskTcKimlik
            // 
            this.mskTcKimlik.Location = new System.Drawing.Point(159, 123);
            this.mskTcKimlik.Mask = "00000000000";
            this.mskTcKimlik.Name = "mskTcKimlik";
            this.mskTcKimlik.Size = new System.Drawing.Size(127, 20);
            this.mskTcKimlik.TabIndex = 7;
            this.mskTcKimlik.ValidatingType = typeof(int);
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(55, 126);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(101, 13);
            this.lblTcKimlikNo.TabIndex = 6;
            this.lblTcKimlikNo.Text = "TC Kimlik Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(159, 93);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(127, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(113, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(159, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(127, 20);
            this.txtAd.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(130, 74);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(159, 41);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(127, 20);
            this.txtPersonelNo.TabIndex = 1;
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(55, 48);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(98, 13);
            this.lblPersonelNo.TabIndex = 0;
            this.lblPersonelNo.Text = "Personel Numarası:";
            // 
            // lstListele
            // 
            this.lstListele.FormattingEnabled = true;
            this.lstListele.Location = new System.Drawing.Point(36, 242);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(509, 95);
            this.lstListele.TabIndex = 19;
            // 
            // txtFabrikaAdı
            // 
            this.txtFabrikaAdı.Enabled = false;
            this.txtFabrikaAdı.Location = new System.Drawing.Point(102, 216);
            this.txtFabrikaAdı.Name = "txtFabrikaAdı";
            this.txtFabrikaAdı.Size = new System.Drawing.Size(164, 20);
            this.txtFabrikaAdı.TabIndex = 20;
            // 
            // txtFabrikaAdresi
            // 
            this.txtFabrikaAdresi.Enabled = false;
            this.txtFabrikaAdresi.Location = new System.Drawing.Point(381, 216);
            this.txtFabrikaAdresi.Name = "txtFabrikaAdresi";
            this.txtFabrikaAdresi.Size = new System.Drawing.Size(164, 20);
            this.txtFabrikaAdresi.TabIndex = 21;
            // 
            // lblFabrikaAdı
            // 
            this.lblFabrikaAdı.AutoSize = true;
            this.lblFabrikaAdı.Location = new System.Drawing.Point(33, 219);
            this.lblFabrikaAdı.Name = "lblFabrikaAdı";
            this.lblFabrikaAdı.Size = new System.Drawing.Size(63, 13);
            this.lblFabrikaAdı.TabIndex = 22;
            this.lblFabrikaAdı.Text = "Fabrika Adı:";
            // 
            // lblFabrikaAdres
            // 
            this.lblFabrikaAdres.AutoSize = true;
            this.lblFabrikaAdres.Location = new System.Drawing.Point(298, 219);
            this.lblFabrikaAdres.Name = "lblFabrikaAdres";
            this.lblFabrikaAdres.Size = new System.Drawing.Size(77, 13);
            this.lblFabrikaAdres.TabIndex = 23;
            this.lblFabrikaAdres.Text = "Fabrika Adresi:";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 491);
            this.Controls.Add(this.grpPersonelBilgisi);
            this.Name = "FrmPersonel";
            this.Text = "Personel Bilgileri";
            this.grpPersonelBilgisi.ResumeLayout(false);
            this.grpPersonelBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCikart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonelBilgisi;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.PictureBox pctCikart;
        private System.Windows.Forms.PictureBox pctListele;
        private System.Windows.Forms.PictureBox pctEkle;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.MaskedTextBox mskTcKimlik;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.ListBox lstListele;
        private System.Windows.Forms.Label lblFabrikaAdres;
        private System.Windows.Forms.Label lblFabrikaAdı;
        private System.Windows.Forms.TextBox txtFabrikaAdresi;
        private System.Windows.Forms.TextBox txtFabrikaAdı;
    }
}


namespace BankaUygulamasi
{
    partial class MusteriAnaMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelMusteriNo = new System.Windows.Forms.Label();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.buttonHesaplarim = new System.Windows.Forms.Button();
            this.buttonHesapArasi = new System.Windows.Forms.Button();
            this.buttonHavale = new System.Windows.Forms.Button();
            this.buttonKredi = new System.Windows.Forms.Button();
            this.buttonSonuc = new System.Windows.Forms.Button();
            this.buttonGecmis = new System.Windows.Forms.Button();
            this.buttonKur = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(459, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.ForeColor = System.Drawing.Color.White;
            this.labelKullanici.Location = new System.Drawing.Point(12, 46);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(97, 25);
            this.labelKullanici.TabIndex = 8;
            this.labelKullanici.Text = "Kullanıcı: ";
            // 
            // labelMusteriNo
            // 
            this.labelMusteriNo.AutoSize = true;
            this.labelMusteriNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.labelMusteriNo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriNo.ForeColor = System.Drawing.Color.White;
            this.labelMusteriNo.Location = new System.Drawing.Point(12, 82);
            this.labelMusteriNo.Name = "labelMusteriNo";
            this.labelMusteriNo.Size = new System.Drawing.Size(171, 25);
            this.labelMusteriNo.TabIndex = 9;
            this.labelMusteriNo.Text = "Müşteri Numarası: ";
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonOlustur.Location = new System.Drawing.Point(340, 150);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(180, 90);
            this.buttonOlustur.TabIndex = 15;
            this.buttonOlustur.Text = "Hesap Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // buttonHesaplarim
            // 
            this.buttonHesaplarim.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHesaplarim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonHesaplarim.Location = new System.Drawing.Point(77, 150);
            this.buttonHesaplarim.Name = "buttonHesaplarim";
            this.buttonHesaplarim.Size = new System.Drawing.Size(180, 90);
            this.buttonHesaplarim.TabIndex = 12;
            this.buttonHesaplarim.Text = "Hesaplarım";
            this.buttonHesaplarim.UseVisualStyleBackColor = true;
            this.buttonHesaplarim.Click += new System.EventHandler(this.buttonHesaplarim_Click);
            // 
            // buttonHesapArasi
            // 
            this.buttonHesapArasi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonHesapArasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonHesapArasi.Location = new System.Drawing.Point(77, 280);
            this.buttonHesapArasi.Name = "buttonHesapArasi";
            this.buttonHesapArasi.Size = new System.Drawing.Size(180, 90);
            this.buttonHesapArasi.TabIndex = 17;
            this.buttonHesapArasi.Text = "Hesaplarım Arası Para Transferi";
            this.buttonHesapArasi.UseVisualStyleBackColor = true;
            this.buttonHesapArasi.Click += new System.EventHandler(this.buttonHesapArasi_Click);
            // 
            // buttonHavale
            // 
            this.buttonHavale.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonHavale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonHavale.Location = new System.Drawing.Point(340, 280);
            this.buttonHavale.Name = "buttonHavale";
            this.buttonHavale.Size = new System.Drawing.Size(180, 90);
            this.buttonHavale.TabIndex = 20;
            this.buttonHavale.Text = "Havale/EFT/SWIFT";
            this.buttonHavale.UseVisualStyleBackColor = true;
            this.buttonHavale.Click += new System.EventHandler(this.buttonHavale_Click);
            // 
            // buttonKredi
            // 
            this.buttonKredi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonKredi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonKredi.Location = new System.Drawing.Point(77, 410);
            this.buttonKredi.Name = "buttonKredi";
            this.buttonKredi.Size = new System.Drawing.Size(180, 90);
            this.buttonKredi.TabIndex = 24;
            this.buttonKredi.Text = "Kredi Başvurusu";
            this.buttonKredi.UseVisualStyleBackColor = true;
            this.buttonKredi.Click += new System.EventHandler(this.buttonKredi_Click);
            // 
            // buttonSonuc
            // 
            this.buttonSonuc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonSonuc.Location = new System.Drawing.Point(340, 410);
            this.buttonSonuc.Name = "buttonSonuc";
            this.buttonSonuc.Size = new System.Drawing.Size(180, 90);
            this.buttonSonuc.TabIndex = 25;
            this.buttonSonuc.Text = "Kredilerim";
            this.buttonSonuc.UseVisualStyleBackColor = true;
            this.buttonSonuc.Click += new System.EventHandler(this.buttonSonuc_Click);
            // 
            // buttonGecmis
            // 
            this.buttonGecmis.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonGecmis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonGecmis.Location = new System.Drawing.Point(77, 540);
            this.buttonGecmis.Name = "buttonGecmis";
            this.buttonGecmis.Size = new System.Drawing.Size(180, 90);
            this.buttonGecmis.TabIndex = 28;
            this.buttonGecmis.Text = "Geçmiş İşlemler";
            this.buttonGecmis.UseVisualStyleBackColor = true;
            this.buttonGecmis.Click += new System.EventHandler(this.buttonGecmis_Click);
            // 
            // buttonKur
            // 
            this.buttonKur.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonKur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonKur.Location = new System.Drawing.Point(340, 540);
            this.buttonKur.Name = "buttonKur";
            this.buttonKur.Size = new System.Drawing.Size(180, 90);
            this.buttonKur.TabIndex = 30;
            this.buttonKur.Text = "Güncel Kur";
            this.buttonKur.UseVisualStyleBackColor = true;
            this.buttonKur.Click += new System.EventHandler(this.buttonKur_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(604, 651);
            this.Controls.Add(this.buttonGecmis);
            this.Controls.Add(this.buttonKur);
            this.Controls.Add(this.buttonKredi);
            this.Controls.Add(this.buttonSonuc);
            this.Controls.Add(this.buttonHesapArasi);
            this.Controls.Add(this.buttonHavale);
            this.Controls.Add(this.buttonHesaplarim);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.labelMusteriNo);
            this.Controls.Add(this.labelKullanici);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK İŞLEM MENÜSÜ";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelMusteriNo;
        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.Button buttonHesaplarim;
        private System.Windows.Forms.Button buttonHesapArasi;
        private System.Windows.Forms.Button buttonHavale;
        private System.Windows.Forms.Button buttonKredi;
        private System.Windows.Forms.Button buttonSonuc;
        private System.Windows.Forms.Button buttonGecmis;
        private System.Windows.Forms.Button buttonKur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}
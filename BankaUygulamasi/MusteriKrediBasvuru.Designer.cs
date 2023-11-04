namespace BankaUygulamasi
{
    partial class MusteriKrediBasvuru
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.comboBoxVade = new System.Windows.Forms.ComboBox();
            this.labelTutar = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.labelVade = new System.Windows.Forms.Label();
            this.labelFaiz = new System.Windows.Forms.Label();
            this.labelOdenecek = new System.Windows.Forms.Label();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.labelGunluk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kredi Tutarı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vade:";
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.textBoxTutar.Location = new System.Drawing.Point(126, 163);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(155, 29);
            this.textBoxTutar.TabIndex = 11;
            this.textBoxTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTutar_KeyPress);
            // 
            // comboBoxVade
            // 
            this.comboBoxVade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.comboBoxVade.FormattingEnabled = true;
            this.comboBoxVade.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "18",
            "24"});
            this.comboBoxVade.Location = new System.Drawing.Point(365, 163);
            this.comboBoxVade.Name = "comboBoxVade";
            this.comboBoxVade.Size = new System.Drawing.Size(84, 30);
            this.comboBoxVade.TabIndex = 12;
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.ForeColor = System.Drawing.Color.White;
            this.labelTutar.Location = new System.Drawing.Point(122, 265);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(113, 22);
            this.labelTutar.TabIndex = 13;
            this.labelTutar.Text = "Kredi Tutarı:";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonHesapla.Location = new System.Drawing.Point(156, 208);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(160, 41);
            this.buttonHesapla.TabIndex = 14;
            this.buttonHesapla.Text = "Kredi Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // labelVade
            // 
            this.labelVade.AutoSize = true;
            this.labelVade.ForeColor = System.Drawing.Color.White;
            this.labelVade.Location = new System.Drawing.Point(176, 306);
            this.labelVade.Name = "labelVade";
            this.labelVade.Size = new System.Drawing.Size(59, 22);
            this.labelVade.TabIndex = 15;
            this.labelVade.Text = "Vade:";
            // 
            // labelFaiz
            // 
            this.labelFaiz.AutoSize = true;
            this.labelFaiz.ForeColor = System.Drawing.Color.White;
            this.labelFaiz.Location = new System.Drawing.Point(185, 346);
            this.labelFaiz.Name = "labelFaiz";
            this.labelFaiz.Size = new System.Drawing.Size(50, 22);
            this.labelFaiz.TabIndex = 16;
            this.labelFaiz.Text = "Faiz:";
            // 
            // labelOdenecek
            // 
            this.labelOdenecek.AutoSize = true;
            this.labelOdenecek.ForeColor = System.Drawing.Color.White;
            this.labelOdenecek.Location = new System.Drawing.Point(85, 383);
            this.labelOdenecek.Name = "labelOdenecek";
            this.labelOdenecek.Size = new System.Drawing.Size(150, 22);
            this.labelOdenecek.TabIndex = 17;
            this.labelOdenecek.Text = "Ödenecek Tutar:";
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonOnayla.Location = new System.Drawing.Point(156, 456);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(160, 41);
            this.buttonOnayla.TabIndex = 18;
            this.buttonOnayla.Text = "ONAYLA";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // labelGunluk
            // 
            this.labelGunluk.AutoSize = true;
            this.labelGunluk.ForeColor = System.Drawing.Color.White;
            this.labelGunluk.Location = new System.Drawing.Point(39, 418);
            this.labelGunluk.Name = "labelGunluk";
            this.labelGunluk.Size = new System.Drawing.Size(196, 22);
            this.labelGunluk.TabIndex = 19;
            this.labelGunluk.Text = "Aylık Ödenecek Tutar:";
            // 
            // KrediBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(473, 509);
            this.Controls.Add(this.labelGunluk);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.labelOdenecek);
            this.Controls.Add(this.labelFaiz);
            this.Controls.Add(this.labelVade);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.comboBoxVade);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KrediBasvuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK KREDİ BAŞVURUSU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.ComboBox comboBoxVade;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Label labelVade;
        private System.Windows.Forms.Label labelFaiz;
        private System.Windows.Forms.Label labelOdenecek;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.Label labelGunluk;
    }
}
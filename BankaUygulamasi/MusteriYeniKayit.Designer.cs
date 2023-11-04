namespace BankaUygulamasi
{
    partial class MusteriYeniKayit
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
            this.button1 = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.tekrar_text = new System.Windows.Forms.TextBox();
            this.parola_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.babaad_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tckn_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ad_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.soyad_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(250, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 999;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarih
            // 
            this.tarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.tarih.Location = new System.Drawing.Point(453, 240);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(174, 29);
            this.tarih.TabIndex = 27;
            this.tarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tekrar_text
            // 
            this.tekrar_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.tekrar_text.Location = new System.Drawing.Point(453, 327);
            this.tekrar_text.MaxLength = 6;
            this.tekrar_text.Name = "tekrar_text";
            this.tekrar_text.PasswordChar = '*';
            this.tekrar_text.Size = new System.Drawing.Size(174, 29);
            this.tekrar_text.TabIndex = 113;
            this.tekrar_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tekrar_text_KeyPress);
            // 
            // parola_text
            // 
            this.parola_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.parola_text.Location = new System.Drawing.Point(137, 327);
            this.parola_text.MaxLength = 6;
            this.parola_text.Name = "parola_text";
            this.parola_text.PasswordChar = '*';
            this.parola_text.Size = new System.Drawing.Size(174, 29);
            this.parola_text.TabIndex = 112;
            this.parola_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parola_text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "PAROLA TEKRAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "YENI PAROLA:";
            // 
            // babaad_text
            // 
            this.babaad_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.babaad_text.Location = new System.Drawing.Point(137, 240);
            this.babaad_text.Name = "babaad_text";
            this.babaad_text.Size = new System.Drawing.Size(174, 29);
            this.babaad_text.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "BABA AD:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(277, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tckn_text
            // 
            this.tckn_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.tckn_text.Location = new System.Drawing.Point(137, 194);
            this.tckn_text.MaxLength = 11;
            this.tckn_text.Name = "tckn_text";
            this.tckn_text.Size = new System.Drawing.Size(174, 29);
            this.tckn_text.TabIndex = 21;
            this.tckn_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tckn_text_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "DOĞUM TARİHİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "TCKN:";
            // 
            // ad_text
            // 
            this.ad_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ad_text.Location = new System.Drawing.Point(137, 146);
            this.ad_text.Name = "ad_text";
            this.ad_text.Size = new System.Drawing.Size(174, 29);
            this.ad_text.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "AD:";
            // 
            // soyad_text
            // 
            this.soyad_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.soyad_text.Location = new System.Drawing.Point(453, 146);
            this.soyad_text.Name = "soyad_text";
            this.soyad_text.Size = new System.Drawing.Size(174, 29);
            this.soyad_text.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "SOYAD:";
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(454, 197);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(76, 26);
            this.radioButtonErkek.TabIndex = 22;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(549, 197);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(78, 26);
            this.radioButtonKadin.TabIndex = 23;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(360, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "CİNSİYET:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 103;
            this.label9.Text = "KAYITLI İL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(331, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 104;
            this.label10.Text = "KAYITLI İLÇE:";
            // 
            // comboBoxil
            // 
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(138, 284);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(173, 30);
            this.comboBoxil.TabIndex = 105;
            this.comboBoxil.SelectedIndexChanged += new System.EventHandler(this.comboBoxil_SelectedIndexChanged);
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(454, 284);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(173, 30);
            this.comboBoxilce.TabIndex = 106;
            this.comboBoxilce.SelectedIndexChanged += new System.EventHandler(this.comboBoxilce_SelectedIndexChanged);
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(656, 462);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.comboBoxil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonKadin);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.soyad_text);
            this.Controls.Add(this.ad_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.tekrar_text);
            this.Controls.Add(this.parola_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.babaad_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tckn_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK MÜŞTERİ KAYIT EKRANI";
            this.Load += new System.EventHandler(this.MusteriKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox tekrar_text;
        private System.Windows.Forms.TextBox parola_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox babaad_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tckn_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ad_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soyad_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxil;
        private System.Windows.Forms.ComboBox comboBoxilce;
    }
}
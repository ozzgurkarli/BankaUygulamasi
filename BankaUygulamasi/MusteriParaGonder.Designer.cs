namespace BankaUygulamasi
{
    partial class MusteriParaGonder
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
            this.checkBoxEFT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHesap = new System.Windows.Forms.ComboBox();
            this.textBoxAlici = new System.Windows.Forms.TextBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxEFT
            // 
            this.checkBoxEFT.AutoSize = true;
            this.checkBoxEFT.ForeColor = System.Drawing.Color.White;
            this.checkBoxEFT.Location = new System.Drawing.Point(523, 191);
            this.checkBoxEFT.Name = "checkBoxEFT";
            this.checkBoxEFT.Size = new System.Drawing.Size(66, 26);
            this.checkBoxEFT.TabIndex = 14;
            this.checkBoxEFT.Text = "EFT";
            this.checkBoxEFT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alıcı Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "İşlem Yapacağınız Hesap:";
            // 
            // comboBoxHesap
            // 
            this.comboBoxHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.comboBoxHesap.FormattingEnabled = true;
            this.comboBoxHesap.Location = new System.Drawing.Point(249, 140);
            this.comboBoxHesap.Name = "comboBoxHesap";
            this.comboBoxHesap.Size = new System.Drawing.Size(340, 30);
            this.comboBoxHesap.TabIndex = 12;
            // 
            // textBoxAlici
            // 
            this.textBoxAlici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.textBoxAlici.Location = new System.Drawing.Point(249, 189);
            this.textBoxAlici.Name = "textBoxAlici";
            this.textBoxAlici.Size = new System.Drawing.Size(255, 29);
            this.textBoxAlici.TabIndex = 13;
            this.textBoxAlici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonGonder
            // 
            this.buttonGonder.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonGonder.Location = new System.Drawing.Point(461, 243);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(128, 29);
            this.buttonGonder.TabIndex = 19;
            this.buttonGonder.Text = "GÖNDER";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Miktar:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.textBoxMiktar.Location = new System.Drawing.Point(249, 243);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(190, 29);
            this.textBoxMiktar.TabIndex = 16;
            this.textBoxMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiktar_KeyPress);
            // 
            // MusteriParaGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(601, 310);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.textBoxAlici);
            this.Controls.Add(this.comboBoxHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxEFT);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MusteriParaGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK HAVALE/EFT/SWIFT";
            this.Load += new System.EventHandler(this.ParaGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxEFT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHesap;
        private System.Windows.Forms.TextBox textBoxAlici;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMiktar;
    }
}
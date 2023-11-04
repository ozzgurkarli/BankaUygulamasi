namespace BankaUygulamasi
{
    partial class MusteriHesaplarimArasi
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
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.comboBoxCikis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxGiris = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.textBoxMiktar.Location = new System.Drawing.Point(406, 252);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(207, 29);
            this.textBoxMiktar.TabIndex = 25;
            this.textBoxMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiktar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Miktar(Gönderici Hesap Cinsinden):";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonGonder.Location = new System.Drawing.Point(244, 309);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(128, 29);
            this.buttonGonder.TabIndex = 23;
            this.buttonGonder.Text = "GÖNDER";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // comboBoxCikis
            // 
            this.comboBoxCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.comboBoxCikis.FormattingEnabled = true;
            this.comboBoxCikis.Location = new System.Drawing.Point(168, 140);
            this.comboBoxCikis.Name = "comboBoxCikis";
            this.comboBoxCikis.Size = new System.Drawing.Size(445, 30);
            this.comboBoxCikis.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gönderici Hesap:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alıcı Hesap:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(244, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxGiris
            // 
            this.comboBoxGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.comboBoxGiris.FormattingEnabled = true;
            this.comboBoxGiris.Location = new System.Drawing.Point(168, 197);
            this.comboBoxGiris.Name = "comboBoxGiris";
            this.comboBoxGiris.Size = new System.Drawing.Size(445, 30);
            this.comboBoxGiris.TabIndex = 26;
            // 
            // MusteriHesaplarimArasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(629, 350);
            this.Controls.Add(this.comboBoxGiris);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.comboBoxCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MusteriHesaplarimArasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK HESAPLARIM ARASI TRANSFER";
            this.Load += new System.EventHandler(this.HesaplarimArasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.ComboBox comboBoxCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxGiris;
    }
}
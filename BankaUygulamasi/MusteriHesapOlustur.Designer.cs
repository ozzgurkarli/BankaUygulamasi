namespace BankaUygulamasi
{
    partial class MusteriHesapOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.buttonOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Birimi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Items.AddRange(new object[] {
            "TRY",
            "EUR",
            "USD",
            "RUB",
            "JPY",
            "GBP",
            "CHF",
            "CAD",
            "CWD"});
            this.comboBoxBirim.Location = new System.Drawing.Point(156, 158);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(152, 31);
            this.comboBoxBirim.TabIndex = 9;
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.buttonOlustur.Location = new System.Drawing.Point(118, 221);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(128, 38);
            this.buttonOlustur.TabIndex = 10;
            this.buttonOlustur.Text = "Hesap Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // HesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(364, 293);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.comboBoxBirim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HesapOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK HESAP OLUŞTUR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.Button buttonOlustur;
    }
}
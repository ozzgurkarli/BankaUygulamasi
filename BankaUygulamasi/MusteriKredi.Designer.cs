namespace BankaUygulamasi
{
    partial class MusteriKredi
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
            this.comboBoxKredi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTutar = new System.Windows.Forms.Label();
            this.labelVade = new System.Windows.Forms.Label();
            this.labelAylik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKredi
            // 
            this.comboBoxKredi.FormattingEnabled = true;
            this.comboBoxKredi.Location = new System.Drawing.Point(149, 148);
            this.comboBoxKredi.Name = "comboBoxKredi";
            this.comboBoxKredi.Size = new System.Drawing.Size(247, 30);
            this.comboBoxKredi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kredilerim: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(139, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "SEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Location = new System.Drawing.Point(67, 204);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(114, 22);
            this.labelTutar.TabIndex = 12;
            this.labelTutar.Text = "Kalan Tutar: ";
            // 
            // labelVade
            // 
            this.labelVade.AutoSize = true;
            this.labelVade.Location = new System.Drawing.Point(65, 262);
            this.labelVade.Name = "labelVade";
            this.labelVade.Size = new System.Drawing.Size(116, 22);
            this.labelVade.TabIndex = 13;
            this.labelVade.Text = "Kalan Vade: ";
            // 
            // labelAylik
            // 
            this.labelAylik.AutoSize = true;
            this.labelAylik.Location = new System.Drawing.Point(51, 320);
            this.labelAylik.Name = "labelAylik";
            this.labelAylik.Size = new System.Drawing.Size(130, 22);
            this.labelAylik.TabIndex = 14;
            this.labelAylik.Text = "Aylık Ödeme: ";
            // 
            // Kredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(408, 435);
            this.Controls.Add(this.labelAylik);
            this.Controls.Add(this.labelVade);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKredi);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Kredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredi";
            this.Load += new System.EventHandler(this.Kredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label labelVade;
        private System.Windows.Forms.Label labelAylik;
    }
}
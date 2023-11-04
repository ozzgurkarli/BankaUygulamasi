namespace BankaUygulamasi
{
    partial class YoneticiCekYatirIslemleri
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
            this.radioButtonCek = new System.Windows.Forms.RadioButton();
            this.radioButtonYatir = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonCek
            // 
            this.radioButtonCek.AutoSize = true;
            this.radioButtonCek.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonCek.Location = new System.Drawing.Point(45, 35);
            this.radioButtonCek.Name = "radioButtonCek";
            this.radioButtonCek.Size = new System.Drawing.Size(104, 27);
            this.radioButtonCek.TabIndex = 0;
            this.radioButtonCek.TabStop = true;
            this.radioButtonCek.Text = "PARA ÇEK";
            this.radioButtonCek.UseVisualStyleBackColor = true;
            // 
            // radioButtonYatir
            // 
            this.radioButtonYatir.AutoSize = true;
            this.radioButtonYatir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonYatir.Location = new System.Drawing.Point(174, 35);
            this.radioButtonYatir.Name = "radioButtonYatir";
            this.radioButtonYatir.Size = new System.Drawing.Size(115, 27);
            this.radioButtonYatir.TabIndex = 1;
            this.radioButtonYatir.TabStop = true;
            this.radioButtonYatir.Text = "PARA YATIR";
            this.radioButtonYatir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MİKTAR:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMiktar.Location = new System.Drawing.Point(117, 99);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(172, 29);
            this.textBoxMiktar.TabIndex = 3;
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnayla.Location = new System.Drawing.Point(86, 156);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(147, 36);
            this.buttonOnayla.TabIndex = 4;
            this.buttonOnayla.Text = "ONAYLA";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // YoneticiCekYatirIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 230);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonYatir);
            this.Controls.Add(this.radioButtonCek);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YoneticiCekYatirIslemleri";
            this.Text = "VAKIFBANK HESAP İŞLEM";
            this.Load += new System.EventHandler(this.YoneticiCekYatirIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCek;
        private System.Windows.Forms.RadioButton radioButtonYatir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Button buttonOnayla;
    }
}
namespace BankaUygulamasi
{
    partial class YoneticiHesapOlustur
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
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOlustur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOlustur.Location = new System.Drawing.Point(127, 145);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(128, 38);
            this.buttonOlustur.TabIndex = 13;
            this.buttonOlustur.Text = "Hesap Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
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
            this.comboBoxBirim.Location = new System.Drawing.Point(173, 83);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(152, 30);
            this.comboBoxBirim.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Para Birimi:";
            // 
            // YoneticiHesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 219);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.comboBoxBirim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YoneticiHesapOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiHesapOlustur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.Label label1;
    }
}
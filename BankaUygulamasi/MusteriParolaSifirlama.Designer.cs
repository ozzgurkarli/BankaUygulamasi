namespace BankaUygulamasi
{
    partial class MusteriParolaSifirlama
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
            this.tckn_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.babaad_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parola_text = new System.Windows.Forms.TextBox();
            this.tekrar_text = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN:";
            // 
            // tckn_text
            // 
            this.tckn_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.tckn_text.Location = new System.Drawing.Point(171, 135);
            this.tckn_text.MaxLength = 11;
            this.tckn_text.Name = "tckn_text";
            this.tckn_text.Size = new System.Drawing.Size(174, 29);
            this.tckn_text.TabIndex = 1;
            this.tckn_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tckn_text_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Users\\ozzgur\\source\\repos\\BankaUygulamasi\\vakifbank.png";
            this.pictureBox1.Location = new System.Drawing.Point(162, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOĞUM TARİHİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "BABA AD:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // babaad_text
            // 
            this.babaad_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.babaad_text.Location = new System.Drawing.Point(171, 181);
            this.babaad_text.Name = "babaad_text";
            this.babaad_text.Size = new System.Drawing.Size(174, 29);
            this.babaad_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "YENI PAROLA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "PAROLA TEKRAR:";
            // 
            // parola_text
            // 
            this.parola_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.parola_text.Location = new System.Drawing.Point(171, 268);
            this.parola_text.MaxLength = 6;
            this.parola_text.Name = "parola_text";
            this.parola_text.PasswordChar = '*';
            this.parola_text.Size = new System.Drawing.Size(174, 29);
            this.parola_text.TabIndex = 16;
            this.parola_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parola_text_KeyPress);
            // 
            // tekrar_text
            // 
            this.tekrar_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.tekrar_text.Location = new System.Drawing.Point(171, 307);
            this.tekrar_text.MaxLength = 6;
            this.tekrar_text.Name = "tekrar_text";
            this.tekrar_text.PasswordChar = '*';
            this.tekrar_text.Size = new System.Drawing.Size(174, 29);
            this.tekrar_text.TabIndex = 17;
            this.tekrar_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tekrar_text_KeyPress);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(171, 223);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(174, 29);
            this.tarih.TabIndex = 14;
            this.tarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(121, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Parola Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParolaSifirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(408, 435);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParolaSifirlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAKIFBANK PAROLA SIFIRLAMA EKRANI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tckn_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox babaad_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parola_text;
        private System.Windows.Forms.TextBox tekrar_text;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button button1;
    }
}
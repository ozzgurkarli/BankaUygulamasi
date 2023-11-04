namespace BankaUygulamasi
{
    partial class YoneticiFaturaKayit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFaturaTipi = new System.Windows.Forms.ComboBox();
            this.aboneNo_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hESAPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesaplartablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaMusteriDataSet2 = new BankaUygulamasi.BankaMusteriDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.hesapNo_text = new System.Windows.Forms.TextBox();
            this.checkBoxOtomatik = new System.Windows.Forms.CheckBox();
            this.buttonKayet = new System.Windows.Forms.Button();
            this.hesaplar_tablosuTableAdapter = new BankaUygulamasi.BankaMusteriDataSet2TableAdapters.hesaplar_tablosuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesaplartablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Tipi:";
            // 
            // comboBoxFaturaTipi
            // 
            this.comboBoxFaturaTipi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxFaturaTipi.FormattingEnabled = true;
            this.comboBoxFaturaTipi.Location = new System.Drawing.Point(190, 258);
            this.comboBoxFaturaTipi.Name = "comboBoxFaturaTipi";
            this.comboBoxFaturaTipi.Size = new System.Drawing.Size(171, 31);
            this.comboBoxFaturaTipi.TabIndex = 2;
            // 
            // aboneNo_text
            // 
            this.aboneNo_text.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboneNo_text.Location = new System.Drawing.Point(190, 306);
            this.aboneNo_text.MaxLength = 10;
            this.aboneNo_text.Name = "aboneNo_text";
            this.aboneNo_text.Size = new System.Drawing.Size(171, 29);
            this.aboneNo_text.TabIndex = 3;
            this.aboneNo_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faturaNo_text_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abone No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hESAPNODataGridViewTextBoxColumn,
            this.mIKTARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hesaplartablosuBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(394, 177);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // hESAPNODataGridViewTextBoxColumn
            // 
            this.hESAPNODataGridViewTextBoxColumn.DataPropertyName = "HESAP_NO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.hESAPNODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hESAPNODataGridViewTextBoxColumn.HeaderText = "HESAP NO";
            this.hESAPNODataGridViewTextBoxColumn.Name = "hESAPNODataGridViewTextBoxColumn";
            this.hESAPNODataGridViewTextBoxColumn.ReadOnly = true;
            this.hESAPNODataGridViewTextBoxColumn.Width = 175;
            // 
            // mIKTARDataGridViewTextBoxColumn
            // 
            this.mIKTARDataGridViewTextBoxColumn.DataPropertyName = "MIKTAR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.mIKTARDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mIKTARDataGridViewTextBoxColumn.HeaderText = "BAKİYE";
            this.mIKTARDataGridViewTextBoxColumn.Name = "mIKTARDataGridViewTextBoxColumn";
            this.mIKTARDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIKTARDataGridViewTextBoxColumn.Width = 175;
            // 
            // hesaplartablosuBindingSource
            // 
            this.hesaplartablosuBindingSource.DataMember = "hesaplar_tablosu";
            this.hesaplartablosuBindingSource.DataSource = this.bankaMusteriDataSet2;
            // 
            // bankaMusteriDataSet2
            // 
            this.bankaMusteriDataSet2.DataSetName = "BankaMusteriDataSet2";
            this.bankaMusteriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödenecek Hesap:";
            // 
            // hesapNo_text
            // 
            this.hesapNo_text.Enabled = false;
            this.hesapNo_text.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapNo_text.Location = new System.Drawing.Point(190, 208);
            this.hesapNo_text.MaxLength = 8;
            this.hesapNo_text.Name = "hesapNo_text";
            this.hesapNo_text.Size = new System.Drawing.Size(171, 29);
            this.hesapNo_text.TabIndex = 1;
            this.hesapNo_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hesapNo_text_KeyPress);
            // 
            // checkBoxOtomatik
            // 
            this.checkBoxOtomatik.AutoSize = true;
            this.checkBoxOtomatik.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOtomatik.Location = new System.Drawing.Point(131, 352);
            this.checkBoxOtomatik.Name = "checkBoxOtomatik";
            this.checkBoxOtomatik.Size = new System.Drawing.Size(145, 27);
            this.checkBoxOtomatik.TabIndex = 7;
            this.checkBoxOtomatik.Text = "Otomatik Ödeme";
            this.checkBoxOtomatik.UseVisualStyleBackColor = true;
            // 
            // buttonKayet
            // 
            this.buttonKayet.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayet.Location = new System.Drawing.Point(117, 385);
            this.buttonKayet.Name = "buttonKayet";
            this.buttonKayet.Size = new System.Drawing.Size(168, 47);
            this.buttonKayet.TabIndex = 8;
            this.buttonKayet.Text = "FATURA KAYDET";
            this.buttonKayet.UseVisualStyleBackColor = true;
            this.buttonKayet.Click += new System.EventHandler(this.buttonKayet_Click);
            // 
            // hesaplar_tablosuTableAdapter
            // 
            this.hesaplar_tablosuTableAdapter.ClearBeforeFill = true;
            // 
            // YoneticiFaturaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 452);
            this.Controls.Add(this.buttonKayet);
            this.Controls.Add(this.checkBoxOtomatik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hesapNo_text);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aboneNo_text);
            this.Controls.Add(this.comboBoxFaturaTipi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YoneticiFaturaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA KAYIT";
            this.Load += new System.EventHandler(this.YoneticiFaturaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesaplartablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFaturaTipi;
        private System.Windows.Forms.TextBox aboneNo_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaMusteriDataSet2 bankaMusteriDataSet2;
        private System.Windows.Forms.BindingSource hesaplartablosuBindingSource;
        private BankaMusteriDataSet2TableAdapters.hesaplar_tablosuTableAdapter hesaplar_tablosuTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hesapNo_text;
        private System.Windows.Forms.CheckBox checkBoxOtomatik;
        private System.Windows.Forms.Button buttonKayet;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESAPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn;
    }
}
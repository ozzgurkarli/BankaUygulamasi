namespace BankaUygulamasi
{
    partial class YoneticiFaturalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mUSTERINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hESAPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fATURAKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fATURANODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONODEMETARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMKODUDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaMusteriDataSet5 = new BankaUygulamasi.BankaMusteriDataSet5();
            this.faturalarTableAdapter = new BankaUygulamasi.BankaMusteriDataSet5TableAdapters.faturalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(524, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mUSTERINODataGridViewTextBoxColumn,
            this.hESAPNODataGridViewTextBoxColumn,
            this.fATURAKODDataGridViewTextBoxColumn,
            this.fATURANODataGridViewTextBoxColumn,
            this.tUTARDataGridViewTextBoxColumn,
            this.sONODEMETARIHIDataGridViewTextBoxColumn,
            this.dURUMKODUDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.faturalarBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 394);
            this.dataGridView1.TabIndex = 4;
            // 
            // mUSTERINODataGridViewTextBoxColumn
            // 
            this.mUSTERINODataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_NO";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mUSTERINODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.mUSTERINODataGridViewTextBoxColumn.HeaderText = "MUSTERI NO";
            this.mUSTERINODataGridViewTextBoxColumn.Name = "mUSTERINODataGridViewTextBoxColumn";
            this.mUSTERINODataGridViewTextBoxColumn.ReadOnly = true;
            this.mUSTERINODataGridViewTextBoxColumn.Width = 180;
            // 
            // hESAPNODataGridViewTextBoxColumn
            // 
            this.hESAPNODataGridViewTextBoxColumn.DataPropertyName = "HESAP_NO";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.hESAPNODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.hESAPNODataGridViewTextBoxColumn.HeaderText = "HESAP NO";
            this.hESAPNODataGridViewTextBoxColumn.Name = "hESAPNODataGridViewTextBoxColumn";
            this.hESAPNODataGridViewTextBoxColumn.ReadOnly = true;
            this.hESAPNODataGridViewTextBoxColumn.Width = 140;
            // 
            // fATURAKODDataGridViewTextBoxColumn
            // 
            this.fATURAKODDataGridViewTextBoxColumn.DataPropertyName = "FATURA_KOD";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fATURAKODDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.fATURAKODDataGridViewTextBoxColumn.HeaderText = "FATURA KOD";
            this.fATURAKODDataGridViewTextBoxColumn.Name = "fATURAKODDataGridViewTextBoxColumn";
            this.fATURAKODDataGridViewTextBoxColumn.ReadOnly = true;
            this.fATURAKODDataGridViewTextBoxColumn.Width = 160;
            // 
            // fATURANODataGridViewTextBoxColumn
            // 
            this.fATURANODataGridViewTextBoxColumn.DataPropertyName = "FATURA_NO";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fATURANODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.fATURANODataGridViewTextBoxColumn.HeaderText = "FATURA NO";
            this.fATURANODataGridViewTextBoxColumn.Name = "fATURANODataGridViewTextBoxColumn";
            this.fATURANODataGridViewTextBoxColumn.ReadOnly = true;
            this.fATURANODataGridViewTextBoxColumn.Width = 140;
            // 
            // tUTARDataGridViewTextBoxColumn
            // 
            this.tUTARDataGridViewTextBoxColumn.DataPropertyName = "TUTAR";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.tUTARDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.tUTARDataGridViewTextBoxColumn.HeaderText = "TUTAR";
            this.tUTARDataGridViewTextBoxColumn.Name = "tUTARDataGridViewTextBoxColumn";
            this.tUTARDataGridViewTextBoxColumn.ReadOnly = true;
            this.tUTARDataGridViewTextBoxColumn.Width = 120;
            // 
            // sONODEMETARIHIDataGridViewTextBoxColumn
            // 
            this.sONODEMETARIHIDataGridViewTextBoxColumn.DataPropertyName = "SON_ODEME_TARIHI";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.HeaderText = "SON ODEME TARIHI";
            this.sONODEMETARIHIDataGridViewTextBoxColumn.Name = "sONODEMETARIHIDataGridViewTextBoxColumn";
            this.sONODEMETARIHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.Width = 230;
            // 
            // dURUMKODUDataGridViewCheckBoxColumn
            // 
            this.dURUMKODUDataGridViewCheckBoxColumn.DataPropertyName = "DURUM_KODU";
            this.dURUMKODUDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMKODUDataGridViewCheckBoxColumn.Name = "dURUMKODUDataGridViewCheckBoxColumn";
            this.dURUMKODUDataGridViewCheckBoxColumn.Width = 120;
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "faturalar";
            this.faturalarBindingSource.DataSource = this.bankaMusteriDataSet5;
            // 
            // bankaMusteriDataSet5
            // 
            this.bankaMusteriDataSet5.DataSetName = "BankaMusteriDataSet5";
            this.bankaMusteriDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // YoneticiFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YoneticiFaturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YONETICI FATURALAR";
            this.Load += new System.EventHandler(this.YoneticiFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaMusteriDataSet5 bankaMusteriDataSet5;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private BankaMusteriDataSet5TableAdapters.faturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESAPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATURAKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATURANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONODEMETARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMKODUDataGridViewCheckBoxColumn;
    }
}
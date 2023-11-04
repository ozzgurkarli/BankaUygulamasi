namespace BankaUygulamasi
{
    partial class YoneticiFaturaOde
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.faturaNo_text = new System.Windows.Forms.TextBox();
            this.comboBoxFaturaTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonOde = new System.Windows.Forms.Button();
            this.faturalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaMusteriDataSet3 = new BankaUygulamasi.BankaMusteriDataSet3();
            this.faturalarTableAdapter = new BankaUygulamasi.BankaMusteriDataSet3TableAdapters.faturalarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONODEMETARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaMusteriDataSet6 = new BankaUygulamasi.BankaMusteriDataSet6();
            this.faturalarTableAdapter1 = new BankaUygulamasi.BankaMusteriDataSet6TableAdapters.faturalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fatura No:";
            // 
            // faturaNo_text
            // 
            this.faturaNo_text.Enabled = false;
            this.faturaNo_text.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaNo_text.Location = new System.Drawing.Point(101, 269);
            this.faturaNo_text.MaxLength = 10;
            this.faturaNo_text.Name = "faturaNo_text";
            this.faturaNo_text.Size = new System.Drawing.Size(171, 29);
            this.faturaNo_text.TabIndex = 11;
            // 
            // comboBoxFaturaTipi
            // 
            this.comboBoxFaturaTipi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxFaturaTipi.FormattingEnabled = true;
            this.comboBoxFaturaTipi.Location = new System.Drawing.Point(105, 32);
            this.comboBoxFaturaTipi.Name = "comboBoxFaturaTipi";
            this.comboBoxFaturaTipi.Size = new System.Drawing.Size(171, 31);
            this.comboBoxFaturaTipi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fatura Tipi:";
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "faturalar";
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGoruntule.Location = new System.Drawing.Point(304, 30);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(155, 32);
            this.buttonGoruntule.TabIndex = 13;
            this.buttonGoruntule.Text = "GÖRÜNTÜLE";
            this.buttonGoruntule.UseVisualStyleBackColor = true;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // buttonOde
            // 
            this.buttonOde.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOde.Location = new System.Drawing.Point(304, 267);
            this.buttonOde.Name = "buttonOde";
            this.buttonOde.Size = new System.Drawing.Size(155, 32);
            this.buttonOde.TabIndex = 14;
            this.buttonOde.Text = "ÖDE";
            this.buttonOde.UseVisualStyleBackColor = true;
            this.buttonOde.Click += new System.EventHandler(this.buttonOde_Click);
            // 
            // faturalarBindingSource1
            // 
            this.faturalarBindingSource1.DataMember = "faturalar";
            this.faturalarBindingSource1.DataSource = this.bankaMusteriDataSet3;
            // 
            // bankaMusteriDataSet3
            // 
            this.bankaMusteriDataSet3.DataSetName = "BankaMusteriDataSet3";
            this.bankaMusteriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.sONODEMETARIHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturalarBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(16, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 192);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FATURA_NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "FATURA NO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TUTAR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "TUTAR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // sONODEMETARIHIDataGridViewTextBoxColumn
            // 
            this.sONODEMETARIHIDataGridViewTextBoxColumn.DataPropertyName = "SON_ODEME_TARIHI";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.HeaderText = "SON ODEME TARIHI";
            this.sONODEMETARIHIDataGridViewTextBoxColumn.Name = "sONODEMETARIHIDataGridViewTextBoxColumn";
            this.sONODEMETARIHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.sONODEMETARIHIDataGridViewTextBoxColumn.Width = 160;
            // 
            // faturalarBindingSource2
            // 
            this.faturalarBindingSource2.DataMember = "faturalar";
            this.faturalarBindingSource2.DataSource = this.bankaMusteriDataSet6;
            // 
            // bankaMusteriDataSet6
            // 
            this.bankaMusteriDataSet6.DataSetName = "BankaMusteriDataSet6";
            this.bankaMusteriDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarTableAdapter1
            // 
            this.faturalarTableAdapter1.ClearBeforeFill = true;
            // 
            // YoneticiFaturaOde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 321);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOde);
            this.Controls.Add(this.buttonGoruntule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faturaNo_text);
            this.Controls.Add(this.comboBoxFaturaTipi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "YoneticiFaturaOde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÖDEME EKRANI";
            this.Load += new System.EventHandler(this.YoneticiFaturaOde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaMusteriDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox faturaNo_text;
        private System.Windows.Forms.ComboBox comboBoxFaturaTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATURANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDEMETARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonOde;
        private BankaMusteriDataSet3 bankaMusteriDataSet3;
        private System.Windows.Forms.BindingSource faturalarBindingSource1;
        private BankaMusteriDataSet3TableAdapters.faturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaMusteriDataSet6 bankaMusteriDataSet6;
        private System.Windows.Forms.BindingSource faturalarBindingSource2;
        private BankaMusteriDataSet6TableAdapters.faturalarTableAdapter faturalarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONODEMETARIHIDataGridViewTextBoxColumn;
    }
}
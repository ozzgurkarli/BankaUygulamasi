using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaUygulamasi.Serv;

namespace BankaUygulamasi
{
    public partial class YoneticiFaturaOde : Form
    {
        int musteriNo;
        string faturaKodu, faturaNo;
        BL bl = new BL();

        public YoneticiFaturaOde(int musteriNo)
        {
            InitializeComponent();
            this.musteriNo = musteriNo;
        }

        private void YoneticiFaturaOde_Load(object sender, EventArgs e)
        {
            this.faturalarTableAdapter1.Fill(this.bankaMusteriDataSet6.faturalar);

            comboBoxFaturaTipi.Items.Clear();

            comboBoxFaturaTipi.Items.Add("HEPSİ");

            comboBoxFaturaTipi.Items.AddRange(bl.FaturalarComboBox());

            this.faturalarTableAdapter1.FillByMusteriNoo(this.bankaMusteriDataSet6.faturalar, musteriNo);

            comboBoxFaturaTipi.SelectedIndex = 0;
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            if (comboBoxFaturaTipi.SelectedItem == "HEPSİ")
            {
                this.faturalarTableAdapter1.FillByMusteriNoo(this.bankaMusteriDataSet6.faturalar, musteriNo);
            }
            else
            {
                faturaKodu = bl.ParametreKodGetir(comboBoxFaturaTipi.SelectedItem.ToString());

                this.faturalarTableAdapter1.FillByFaturaKoduu(this.bankaMusteriDataSet6.faturalar, musteriNo, faturaKodu);
            }
        }

        private void buttonOde_Click(object sender, EventArgs e)
        {
            bl.FaturaOdeElIle(faturaNo);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dataGridView1.SelectedCells[0].RowIndex;
            faturaNo = dataGridView1.Rows[temp].Cells[0].Value.ToString();

            faturaNo_text.Text = faturaNo.ToString();
        }
    }
}

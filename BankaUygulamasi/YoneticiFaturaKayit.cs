
using BankaUygulamasi.Serv;
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

namespace BankaUygulamasi
{
    public partial class YoneticiFaturaKayit : Form
    {
        BL bl = new BL();
        int musteriNo, hesapNo;
        string faturaKodu;
        public YoneticiFaturaKayit(int musteriNo)
        {
            InitializeComponent();
            this.musteriNo = musteriNo;
        }

        private void YoneticiFaturaKayit_Load(object sender, EventArgs e)
        {
            this.hesaplar_tablosuTableAdapter.FillByMusteriNo(this.bankaMusteriDataSet2.hesaplar_tablosu, musteriNo);

            comboBoxFaturaTipi.Items.Clear();

            comboBoxFaturaTipi.Items.AddRange(bl.FaturalarComboBox());
        }
        private void hesapNo_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void faturaNo_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonKayet_Click(object sender, EventArgs e)
        {
            if (hesapNo_text.Text == string.Empty || aboneNo_text.Text == string.Empty || comboBoxFaturaTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Bilgiler Doldurulmalıdır.");
            }
            else
            {
                if (bl.HesapDetayGetir(Convert.ToInt32(hesapNo_text.Text)) == null)
                {
                    MessageBox.Show("Hesap No Bulunamadı.");
                }
                else
                {
                    faturaKodu = bl.ParametreKodGetir(comboBoxFaturaTipi.SelectedItem.ToString());

                    bl.FaturaBilgisiKaydet(musteriNo, Convert.ToInt32(hesapNo_text.Text),faturaKodu,aboneNo_text.Text,checkBoxOtomatik.Checked);

                    MessageBox.Show("Fatura Kaydedildi.");

                    this.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dataGridView1.SelectedCells[0].RowIndex;
            hesapNo = Convert.ToInt32(dataGridView1.Rows[temp].Cells[0].Value);

            hesapNo_text.Text = hesapNo.ToString();
        }
    }
}

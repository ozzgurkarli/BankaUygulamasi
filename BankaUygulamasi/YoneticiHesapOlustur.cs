using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaUygulamasi.Serv;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class YoneticiHesapOlustur : Form
    {
        int musteriNo;
        BL bl = new BL();

        public YoneticiHesapOlustur(int musteriNo)
        {
            InitializeComponent();
            this.musteriNo = musteriNo;
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            if (comboBoxBirim.SelectedIndex == -1)
            {
                MessageBox.Show("Birim Kısmı Boş Bırakılamaz.");
            }
            else
            {
                bl.HesapOlustur(musteriNo, comboBoxBirim.SelectedItem.ToString());

                MessageBox.Show(comboBoxBirim.SelectedItem + " Hesabı Oluşturuldu.");

                this.Close();
            }
        }
    }
}

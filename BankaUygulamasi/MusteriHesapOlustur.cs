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
    public partial class MusteriHesapOlustur : Form
    {
        BL bl = new BL();
        public MusteriHesapOlustur()
        {
            InitializeComponent();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            if (comboBoxBirim.SelectedIndex == -1)
            {
                MessageBox.Show("Birim Kısmı Boş Bırakılamaz.");
            }
            else
            {
                bl.HesapOlustur(MusteriAnaMenu.musteri.musteriNo,comboBoxBirim.SelectedItem.ToString());

                MessageBox.Show($"{comboBoxBirim.SelectedItem} Hesabı Oluşturuldu.");

                this.Close();
            }
        }
    }
}

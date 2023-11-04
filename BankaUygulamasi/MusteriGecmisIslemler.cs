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
using BankaUygulamasi.Common.DTO;
using BankaUygulamasi.Serv;

namespace BankaUygulamasi
{
    public partial class MusteriGecmisIslemler : Form
    {
        BL bl = new BL();

        private void buttonDetay_Click(object sender, EventArgs e)
        {
            if (comboBoxIslem.SelectedIndex != -1)
            {
                DTODetay detay = bl.DetayEkraninaGonder(comboBoxIslem.SelectedItem.ToString().Substring(0, 8));

                MusteriDetayEkrani fm = new MusteriDetayEkrani(detay);

                fm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir İşlem Seçin.");
            }
        }

        private void GecmisIslemler_Load(object sender, EventArgs e)
        {
            IslemleriAl();
        }
        public MusteriGecmisIslemler()
        {
            InitializeComponent();
        }

        private void IslemleriAl()
        {
            comboBoxIslem.Items.Clear();

            comboBoxIslem.Items.AddRange(bl.GecmisIslemlerComboBox(MusteriAnaMenu.musteri.musteriNo));
        }
    }
}

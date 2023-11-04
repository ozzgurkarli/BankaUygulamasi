
using BankaUygulamasi.Common.DTO;
using BankaUygulamasi.Serv;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class MusteriKredi : Form
    {
        BL bl = new BL();

        public MusteriKredi()
        {
            InitializeComponent();
        }
        private void Kredi_Load(object sender, EventArgs e)
        {
            comboBoxKredi.Items.Clear();

            comboBoxKredi.Items.AddRange(bl.MusteriKredileriString(MusteriAnaMenu.musteri.musteriNo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxKredi.SelectedIndex != -1)
            {
                DTOKredi kredi = bl.MusteriKrediDetay(MusteriAnaMenu.musteri.musteriNo, Convert.ToDecimal(comboBoxKredi.SelectedItem.ToString().Substring(15)));

                labelTutar.Text = "Kalan Tutar: " + ((kredi.vade - kredi.odenenTaksit) * kredi.aylikOdeme).ToString("0.00");
                labelVade.Text = "Kalan Vade: " + (kredi.vade - kredi.odenenTaksit);
                labelAylik.Text = "Aylık Ödeme: " + kredi.aylikOdeme.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Bir İşlem Seçin.");
            }
        }
    }
}

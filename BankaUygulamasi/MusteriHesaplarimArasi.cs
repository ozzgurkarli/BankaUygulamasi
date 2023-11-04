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
    public partial class MusteriHesaplarimArasi : Form
    {
        int gonderenHesap;
        int gonderilenHesap;
        string gonderenBirim;
        string gonderilenBirim;
        double gonderenBirimM;
        double gonderilenBirimM;
        int miktar;
        BL bl = new BL();

        public MusteriHesaplarimArasi()
        {
            InitializeComponent();
        }

        private void textBoxMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HesaplarimArasi_Load(object sender, EventArgs e)
        {
            comboBoxCikis.Items.Clear();
            comboBoxGiris.Items.Clear();

            string[] listt = bl.MusteriAktifHesaplarString(MusteriAnaMenu.musteri.musteriNo);

            string[] list = new string[listt.Length - 1];

            int count = 1;

            comboBoxCikis.Items.AddRange(listt);
            comboBoxGiris.Items.AddRange(listt);
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            if (comboBoxGiris.SelectedIndex == comboBoxCikis.SelectedIndex)
            {
                MessageBox.Show("Seçilen Hesaplar Farklı Olmalı.");
                return;
            }

            if (comboBoxCikis.SelectedIndex != -1 && comboBoxGiris.SelectedIndex != -1 && textBoxMiktar.Text != "")
            {
                gonderenHesap = Convert.ToInt32(comboBoxCikis.SelectedItem.ToString().Substring(0, 8));
                gonderilenHesap = Convert.ToInt32(comboBoxGiris.SelectedItem.ToString().Substring(0, 8));
                gonderenBirim = comboBoxGiris.SelectedItem.ToString().Substring(comboBoxGiris.SelectedItem.ToString().Length - 3, 3);
                gonderilenBirim = comboBoxCikis.SelectedItem.ToString().Substring(comboBoxCikis.SelectedItem.ToString().Length - 3, 3);
                gonderenBirimM = Doviz.birim[gonderenBirim];
                gonderilenBirimM = Doviz.birim[gonderilenBirim];
                miktar = Convert.ToInt32(textBoxMiktar.Text);

                if (bl.HesaplarArasiTransfer(gonderenHesap, gonderilenHesap, miktar))
                {
                    MusteriHesaplarimArasi fm = new MusteriHesaplarimArasi();
                    this.Close();
                    fm.Show();
                }
            }
            else
            {
                MessageBox.Show("Bilgilerin Hiçbiri Boş Bırakılamaz.");
            }
        }
    }
}

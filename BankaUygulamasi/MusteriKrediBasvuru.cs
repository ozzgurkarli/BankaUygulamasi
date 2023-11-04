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
    public partial class MusteriKrediBasvuru : Form
    {
        public static double aylikTutar = 0;
        BL bl = new BL();

        public MusteriKrediBasvuru()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            double faizOrani = 0.03;
            double vade = Convert.ToInt32(comboBoxVade.SelectedItem);
            double prntz = Math.Pow((1 + faizOrani), vade);

            aylikTutar = (Convert.ToInt32(textBoxTutar.Text) * (prntz) * faizOrani) / ((prntz) - 1);
            labelTutar.Text = "Kredi Tutarı: " + textBoxTutar.Text;
            labelVade.Text = "Vade: " + comboBoxVade.SelectedItem + " Ay";
            labelFaiz.Text = "Faiz: %3";
            labelOdenecek.Text = "Ödenecek Tutar: " + (aylikTutar * vade).ToString("0.00");
            labelGunluk.Text = "Aylık Ödenecek Tutar: " + (aylikTutar).ToString("0.00");
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            if (textBoxTutar.Text != "" && comboBoxVade.SelectedIndex != -1)
            {
                bl.KrediBasvuruGonder(MusteriAnaMenu.musteri.musteriNo, Convert.ToInt32(textBoxTutar.Text), Convert.ToInt32(comboBoxVade.SelectedItem));

                MessageBox.Show("Başvurunuz Gönderildi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgilerin Hiçbiri Boş Bırakılamaz.");
            }
        }

        private void textBoxTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}

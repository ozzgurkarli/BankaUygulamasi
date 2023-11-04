
using BankaUygulamasi.Common.DTO;
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
    public partial class MusteriParolaSifirlama : Form
    {
        BL bl = new BL();
        public MusteriParolaSifirlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOMusteri musteri = bl.MusteriGetirTCKNIle(tckn_text.Text);

            if (musteri != null)
            {
                if
                    (musteri.baba_ad == babaad_text.Text && musteri.dogum_tarihi == tarih.Text)
                {
                    if (parola_text.Text != tekrar_text.Text && parola_text.Text.Length == 6)
                    {
                        MessageBox.Show("Hatalı Parola Girdiniz.");
                    }
                    else if (parola_text.Text.Length != 6)
                    {
                        MessageBox.Show("Parola 6 Haneli Olmalıdır.");
                    }
                    else
                    {
                        bl.ParolaDegistir(musteri.tckn, parola_text.Text);

                        MessageBox.Show("Parola Değiştirildi.");
                        this.Hide();
                    }
                }
                else { MessageBox.Show("Güvenlik sorusu ya da soruları hatalı."); }
            }
            else { MessageBox.Show("Müşteri Bulunamadı."); }
        }

        private void tckn_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void parola_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tekrar_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

    }
}

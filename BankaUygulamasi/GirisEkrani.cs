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
    public partial class GirisEkrani : Form
    {
        public static string kullanici = "";
        BL bl = new BL();

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tck_text.Text.Length != 11 || parola_text.Text.Length != 6)
            {
                MessageBox.Show("TCKN 11, Parola 6 Haneli Olmalıdır.");
            }
            else
            {
                if (bl.AdminGirisKontrol(tck_text.Text, parola_text.Text))
                {
                    YoneticiMenu fm = new YoneticiMenu();

                    fm.Show();

                    this.Hide();
                }
                else
                {
                    DTOMusteri musteri = (bl.MusteriGirisKontrol(tck_text.Text, parola_text.Text));

                    if (musteri!=null)
                    {
                        MusteriAnaMenu fm = new MusteriAnaMenu(musteri);

                        fm.Show();

                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Bu Bilgilerle Müşteri Bulunamadı.");
                    }
                }
            }
        }

        private void tck_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriYeniKayit fm = new MusteriYeniKayit();
            fm.Show();
        }//YENI MUSTERI

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriParolaSifirlama fm = new MusteriParolaSifirlama();
            fm.Show();
        }//PAROLA UNUTTUM

        private void parola_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bl.KrediKontrol();
            bl.FaturaOlustur();
            bl.OtomatikFaturaOde();
        }

    }
}

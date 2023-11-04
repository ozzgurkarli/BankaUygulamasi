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
    public partial class YoneticiKayit : Form
    {
        BL bl = new BL();
        string cinsiyet;
        string ilKodu, ilceKodu;

        public YoneticiKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bl.MusteriGetirTCKNIle(tckn_text.Text) != null)
            {
                MessageBox.Show("Müşteri Zaten Kayıtlı.");
            }
            else
            {
                if (ad_text.Text == "" || babaad_text.Text == "" || comboBoxil.SelectedIndex == -1 || comboBoxilce.SelectedIndex == -1 || (!radioButtonErkek.Checked && !radioButtonKadin.Checked) || parola_text.Text != tekrar_text.Text || tckn_text.Text.Length != 11)
                {
                    MessageBox.Show("Tüm Soruları Cevaplamadınız ya da Bilgiler Hatalı Olabilir.");
                }
                else if (parola_text.Text.Length != 6)
                {
                    MessageBox.Show("Parola 6 Haneli Olmalıdır.");
                }
                else
                {
                    if (radioButtonErkek.Checked)
                    {
                        cinsiyet = "E";
                    }
                    else
                    {
                        cinsiyet = "K";
                    }

                    DTOMusteri musteri = bl.MusteriOlustur(tckn_text.Text, parola_text.Text, ad_text.Text, soyad_text.Text, babaad_text.Text, tarih.Text, cinsiyet, ilKodu, ilceKodu, DateTime.Today);


                    bl.HesapOlustur(musteri.musteriNo, "TRY");

                    string mesaj = String.Format("{0} {1}, Bankamıza Hoşgeldiniz.", ad_text.Text, soyad_text.Text);

                    MessageBox.Show(mesaj);

                    this.Close();
                }
            }
        }

        private void tekrar_text_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tckn_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            comboBoxil.Items.Clear();

            comboBoxil.Items.AddRange(bl.IllerComboBox());
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.Items.Clear();

            ilKodu = bl.ParametreKodGetir(comboBoxil.SelectedItem.ToString());

            comboBoxilce.Items.AddRange(bl.IlcelerComboBox(ilKodu));
        }

        private void comboBoxilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceKodu = bl.ParametreKodGetir(comboBoxilce.SelectedItem.ToString());
        }
    }
}

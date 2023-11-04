
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
    public partial class YoneticiMenu : Form
    {
        BL bl = new BL();
        int musteriNo, hesapNo;
        string tckn;
        bool aktiflik;

        public YoneticiMenu()
        {
            InitializeComponent();
        }

        private void textBoxtckn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HesapAktifMi()
        {
            DTOHesap hesap = bl.HesapDetayGetir(Convert.ToInt32(textBoxHesapNo.Text));

            if (hesap == null)
            {
                MessageBox.Show("Hesap No Bulunamadı.");
            }
            else
            {
                if (hesap.durumKodu)
                {
                    bl.HesapAktiflikGuncelle(Convert.ToInt32(textBoxHesapNo.Text), false);
                }
                else
                {
                    bl.HesapAktiflikGuncelle(Convert.ToInt32(textBoxHesapNo.Text), true);
                }

                this.hesaplar_tablosuTableAdapter1.FillBy(this.bankaMusteriDataSet1.hesaplar_tablosu);

                MessageBox.Show("Hesap Aktifliği Güncellendi.");
            }
        }

        private void menuTabloyuGuncelle_Click(object sender, EventArgs e)
        {
            int musteriNo = 0;
            int hesapNo = 0;
            tckn = textBoxtckn.Text;
            if (textBoxMusteriNo.Text != string.Empty)
            {
                musteriNo = Convert.ToInt32(textBoxMusteriNo.Text);
            }
            if (textBoxHesapNo.Text != string.Empty)
            {
                hesapNo = Convert.ToInt32(textBoxHesapNo.Text);
            }

            if (hesapNo != 0)
            {
                DTOHesap hesap = bl.HesapDetayGetir(hesapNo);

                if (hesap == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    this.hesaplar_tablosuTableAdapter1.FillByHesapNo(this.bankaMusteriDataSet1.hesaplar_tablosu, hesap.hesapNo);
                }
            }

            else if (musteriNo != 0)
            {
                DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(musteriNo);

                if (musteri == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    this.hesaplar_tablosuTableAdapter1.FillByMusteriNo(this.bankaMusteriDataSet1.hesaplar_tablosu, musteri.musteriNo);
                }
            }

            else if (tckn != string.Empty)
            {
                DTOMusteri musteri = bl.MusteriGetirTCKNIle(tckn);

                if (musteri == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    this.hesaplar_tablosuTableAdapter1.FillByMusteriNo(this.bankaMusteriDataSet1.hesaplar_tablosu, musteri.musteriNo);
                }
            }

            else
            {
                this.hesaplar_tablosuTableAdapter1.FillBy(this.bankaMusteriDataSet1.hesaplar_tablosu);
                MessageBox.Show("TCKN, Hesap No, Müşteri No Bilgilerinden En Az\nBirini Doldurarak Özel Arama Yapabilirsiniz.");
            }
        }

        private void menuMusteriTemizle_Click(object sender, EventArgs e)
        {
            textBoxAd.Text = string.Empty;
            textBoxBakiye.Text = string.Empty;
            textBoxBabaAd.Text = string.Empty;
            textBoxDoviz.Text = string.Empty;
            textBoxHesapNo.Text = string.Empty;
            textBoxMusteriNo.Text = string.Empty;
            textBoxtckn.Text = string.Empty;
            textBoxSoyad.Text = string.Empty;
            checkBoxAktiflik.Checked = false;
            comboBoxil.Text = string.Empty;
            comboBoxilce.Text = string.Empty;
        }

        private void menuKrediBasvuru_Click(object sender, EventArgs e)
        {
            YoneticiKredi fm = new YoneticiKredi();
            fm.Show();
        }

        private void menuYeniMusteri_Click(object sender, EventArgs e)
        {
            YoneticiKayit fm = new YoneticiKayit();
            fm.Show();
        }

        private void menuHesapOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(Convert.ToInt32(textBoxMusteriNo.Text));

                if (musteri == null)
                {
                    MessageBox.Show("Müşteri No Bulunamadı.");
                }
                else
                {
                    YoneticiHesapOlustur fm = new YoneticiHesapOlustur(Convert.ToInt32(textBoxMusteriNo.Text));
                    fm.Show();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Müşteri No Girilmelidir.");
            }
        }

        private void menuParaCekYatir_Click(object sender, EventArgs e)
        {
            try
            {
                DTOHesap hesap = bl.HesapDetayGetir(Convert.ToInt32(textBoxHesapNo.Text));

                if (hesap == null)
                {
                    MessageBox.Show("Hesap No Bulunamadı.");
                }
                else
                {
                    YoneticiCekYatirIslemleri fm = new YoneticiCekYatirIslemleri(Convert.ToInt32(textBoxHesapNo.Text));
                    fm.Show();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Hesap Seçin.");
            }
        }

        private void menuBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(Convert.ToInt32(textBoxMusteriNo.Text));

                if (musteri == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    YoneticiGuncelle fm = new YoneticiGuncelle(Convert.ToInt32(textBoxMusteriNo.Text));
                    fm.Show();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Müşteri No Girilmelidir.");
            }
        }

        private void menuAktiflikGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxHesapNo.Text != string.Empty)
            {
                if (aktiflik != checkBoxAktiflik.Checked)
                {
                    HesapAktifMi();
                }
            }
        }

        private void menuFaturaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(Convert.ToInt32(textBoxMusteriNo.Text));

                if (musteri == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    YoneticiFaturaKayit fm = new YoneticiFaturaKayit(Convert.ToInt32(textBoxMusteriNo.Text));
                    fm.Show();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Müşteri No Girilmelidir.");
            }
        }

        private void menuGecmisFaturalar_Click(object sender, EventArgs e)
        {
            YoneticiFaturalar fm = new YoneticiFaturalar();
            fm.Show();
        }

        private void menuFaturaOde_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(Convert.ToInt32(textBoxMusteriNo.Text));

                if (musteri == null)
                {
                    MessageBox.Show("Girdiğiniz Bilgilerle Müşteri Bulunamadı.");
                }
                else
                {
                    YoneticiFaturaOde fm = new YoneticiFaturaOde(Convert.ToInt32(textBoxMusteriNo.Text));
                    fm.Show();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Müşteri No Girilmelidir.");
            }
        }

        private void YoneticiMenu_Load(object sender, EventArgs e)
        {
            comboBoxil.Items.AddRange(bl.IllerComboBox());

            this.hesaplar_tablosuTableAdapter1.FillBy(this.bankaMusteriDataSet1.hesaplar_tablosu);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dataGridView1.SelectedCells[0].RowIndex;
            musteriNo = Convert.ToInt32(dataGridView1.Rows[temp].Cells[0].Value);
            hesapNo = Convert.ToInt32(dataGridView1.Rows[temp].Cells[1].Value);

            DTOHesap hesap = bl.HesapDetayGetir(hesapNo);
            DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(musteriNo);

            comboBoxilce.Items.AddRange(bl.IlcelerComboBox(musteri.kayitli_il));

            textBoxtckn.Text = musteri.tckn;
            textBoxAd.Text = musteri.ad;
            textBoxSoyad.Text = musteri.soyad;
            textBoxBabaAd.Text = musteri.baba_ad;
            textBoxMusteriNo.Text = musteri.musteriNo.ToString();
            textBoxHesapNo.Text = hesap.hesapNo.ToString();
            checkBoxAktiflik.Checked = hesap.durumKodu;
            textBoxBakiye.Text = hesap.bakiye.ToString();
            textBoxDoviz.Text = hesap.dovizCinsi;
            comboBoxil.SelectedItem = bl.IlGetir(musteri.kayitli_il);
            comboBoxilce.SelectedItem = bl.IlceGetir(musteri.kayitli_ilce);
            if (musteri.cinsiyet == "E")
            {
                radioButtonErkek.Checked = true;
            }
            else
            {
                radioButtonKadin.Checked = true;
            }
        }
    }
}

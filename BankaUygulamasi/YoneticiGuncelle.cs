
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
    public partial class YoneticiGuncelle : Form
    {
        BL bl = new BL();
        int musteriNo;
        string ilKodu, ilceKodu,cinsiyet;
        public YoneticiGuncelle(int musteriNo)
        {
            InitializeComponent();
            this.musteriNo = musteriNo;
        }

        private void YoneticiGuncelle_Load(object sender, EventArgs e)
        {
            comboBoxil.Items.Clear();

            comboBoxil.Items.AddRange(bl.IllerComboBox());

            DTOMusteri musteri = bl.MusteriGetirMusteriNoIle(musteriNo);

            tckn_text.Text = musteri.tckn;
            ad_text.Text = musteri.ad;
            soyad_text.Text = musteri.soyad;
            babaad_text.Text = musteri.baba_ad;
            tarih.Text = musteri.dogum_tarihi;
            if (musteri.cinsiyet == "E")
            {
                radioButtonErkek.Checked = true;
            }
            else
            {
                radioButtonKadin.Checked = true;
            }
            ilKodu = musteri.kayitli_il;
            ilceKodu = musteri.kayitli_ilce;

            comboBoxil.SelectedItem = bl.IlGetir(ilKodu);

            comboBoxilce.SelectedItem = bl.IlceGetir(ilceKodu);
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.Items.Clear();

            ilKodu = bl.ParametreKodGetir(comboBoxil.SelectedItem.ToString());

            comboBoxilce.Items.AddRange(bl.IlcelerComboBox(ilKodu));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonErkek.Checked)
            {
                cinsiyet = "E";
            }
            else
            {
                cinsiyet = "K";
            }
            bl.MusteriGuncelle(tckn_text.Text, ad_text.Text, soyad_text.Text,babaad_text.Text, tarih.Text, cinsiyet, ilKodu,ilceKodu, musteriNo);

            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            this.Close();
        }

        private void comboBoxilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceKodu = bl.ParametreKodGetir(comboBoxilce.SelectedItem.ToString());
        }

    }
}

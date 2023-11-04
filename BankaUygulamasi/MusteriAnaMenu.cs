
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
    public partial class MusteriAnaMenu : Form
    {
        public static DTOMusteri musteri;

        public MusteriAnaMenu()
        {
            InitializeComponent();
        }

        public MusteriAnaMenu(DTOMusteri musteri)
        {
            InitializeComponent();
            MusteriAnaMenu.musteri = musteri;
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            MusteriBilgisi();
            Doviz.DovizYukle();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            MusteriHesapOlustur fm = new MusteriHesapOlustur();
            fm.Show();
        }

        private void buttonHesaplarim_Click(object sender, EventArgs e)
        {
            MusteriHesaplarim fm = new MusteriHesaplarim();
            fm.Show();
        }

        private void buttonKredi_Click(object sender, EventArgs e)
        {
            MusteriKrediBasvuru fm = new MusteriKrediBasvuru();
            fm.Show();
        }

        private void buttonHavale_Click(object sender, EventArgs e)
        {
            MusteriParaGonder fm = new MusteriParaGonder();
            fm.Show();
        }

        private void buttonSonuc_Click(object sender, EventArgs e)
        {
            MusteriKredi fm = new MusteriKredi();
            fm.Show();
        }

        private void buttonGecmis_Click(object sender, EventArgs e)
        {
            MusteriGecmisIslemler fm = new MusteriGecmisIslemler();
            fm.Show();
        }
        public void MusteriBilgisi()
        {
            labelKullanici.Text = "Kullanıcı: " + musteri.ad + " " + musteri.soyad;
            labelMusteriNo.Text = "Müşteri Numarası: " + musteri.musteriNo;
        }

        private void buttonHesapArasi_Click(object sender, EventArgs e)
        {
            MusteriHesaplarimArasi fm = new MusteriHesaplarimArasi();
            fm.Show();
        }

        private void buttonKur_Click(object sender, EventArgs e)
        {
            MusteriKurlar fm = new MusteriKurlar();
            fm.Show();
        }
    }

}
using BankaUygulamasi.Common.DTO;
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
    public partial class MusteriDetayEkrani : Form
    {
        DTODetay detay;
        string  birim;

        private void DetayEkrani_Load(object sender, EventArgs e)
        {
            BirimBul();
            EkranaYaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public MusteriDetayEkrani(DTODetay detay)
        {
            InitializeComponent();
            this.detay = detay;
        }
        private void EkranaYaz()
        {
            if (detay.bilgi == "GELEN")
            {
                button1.ForeColor = Color.Green;
            }
            else if(detay.bilgi == "GIDEN" || detay.bilgi == "FATURA")
            {
                button1.ForeColor = Color.Red;
            }

            labelNo.Text = "İşlem No: " + detay.islemNo;
            labelBilgi.Text = "Bilgi: " + detay.bilgi;

            if (detay.gonderenMusteri == 19999999)
            {
                labelGM.Text = "Gönderen Müşteri: VAKIFBANK";
            }
            else
            {
                labelGM.Text = "Gönderen Müşteri: " + detay.gonderenMusteri;
            }

            if(detay.gonderilenMusteri == 19999999)
            {
                labelGLM.Text = "Gönderilen Müşteri: VAKIFBANK";
            }
            else
            {
                labelGLM.Text = "Gönderilen Müşteri: " + detay.gonderilenMusteri;
            }

            if (detay.gonderenMusteri == 19999999)
            {
                labelGH.Text = "Gönderen Hesap: VAKIFBANK";
            }
            else
            {
                labelGH.Text = "Gönderen Hesap: " + detay.gonderenHesap;
            }

            if(detay.gonderilenMusteri == 19999999)
            {
                labelGLH.Text = "Gönderilen Hesap: VAKIFBANK";
            }
            else
            {
                labelGLH.Text = "Gönderilen Hesap: " + detay.gonderilenHesap;
            }

            labelMiktar.Text = "Miktar: " + detay.miktar + " " + birim;
            labelTarih.Text = "Tarih: " + detay.tarih;
        }
        private void BirimBul()
        {
            switch (detay.gonderenHesap /10000000)
            {
                case 1: birim = "TRY"; break;
                case 2: birim = "EUR"; break;
                case 3: birim = "USD"; break;
                case 4: birim = "RUB"; break;
                case 5: birim = "JPY"; break;
                case 6: birim = "GBP"; break;
                case 7: birim = "CHF"; break;
                case 8: birim = "CAD"; break;
                case 9: birim = "CWD"; break;
            }
        }
    }
}

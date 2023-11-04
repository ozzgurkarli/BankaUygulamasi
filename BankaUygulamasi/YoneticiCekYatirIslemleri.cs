
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
    public partial class YoneticiCekYatirIslemleri : Form
    {
        BL bl = new BL();
        DTOHesap hesap;
        int hesapNo;
        public YoneticiCekYatirIslemleri(int hesapNo)
        {
            InitializeComponent();
            this.hesapNo = hesapNo;
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            if (textBoxMiktar.Text != string.Empty)
            {
                if (radioButtonCek.Checked)
                {
                    if (hesap.bakiye > Convert.ToDecimal(textBoxMiktar.Text))
                    {
                        bl.HesapBakiyeGuncelle(hesap.hesapNo, -Convert.ToDecimal(textBoxMiktar.Text));

                        MessageBox.Show("İşlem Tamamlandı.");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz Bakiye.");
                    }
                }
                else if (radioButtonYatir.Checked)
                {
                    bl.HesapBakiyeGuncelle(hesap.hesapNo, Convert.ToDecimal(textBoxMiktar.Text));

                    MessageBox.Show("İşlem Tamamlandı.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("İşlem Seçilmeli.");
                }
            }
        }

        private void YoneticiCekYatirIslemleri_Load(object sender, EventArgs e)
        {
            hesap = bl.HesapDetayGetir(hesapNo);
        }
    }
}

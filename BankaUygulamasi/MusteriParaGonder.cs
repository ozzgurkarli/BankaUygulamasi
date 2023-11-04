
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
    public partial class MusteriParaGonder : Form
    {
        BL bl = new BL();
        public MusteriParaGonder()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ParaGonder_Load(object sender, EventArgs e)
        {
            comboBoxHesap.Items.Clear();

            comboBoxHesap.Items.AddRange(bl.MusteriAktifHesaplarString(MusteriAnaMenu.musteri.musteriNo));
        }

        private void textBoxMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            DTOHesap gonderenHesap = null;
            DTOHesap gonderilenHesap = null;

            if (textBoxAlici.Text.Length < 1 || textBoxMiktar.Text.Length < 1)
            {
                MessageBox.Show("Alıcı ya da Miktar Kutucuğu Boş Bırakılamaz.");
            }
            else
            {
                if (comboBoxHesap.SelectedItem != null)
                {
                    gonderenHesap = bl.HesapDetayGetir(Convert.ToInt32(comboBoxHesap.SelectedItem.ToString().Substring(0, 8)));
                }
                else
                {
                    MessageBox.Show("Gönderen Hesap No Boş Bırakılamaz.");

                    return;
                }

                if (gonderenHesap.bakiye < Convert.ToDecimal(textBoxMiktar.Text))
                {
                    MessageBox.Show("Bakiyeniz Yetersiz.");
                }
                else
                {
                    if (checkBoxEFT.Checked)
                    {
                        bl.HesapBakiyeGuncelle(gonderenHesap.hesapNo, -Convert.ToDecimal(textBoxMiktar.Text));

                        MessageBox.Show("İşlem Tamamlandı.");

                        this.Close();
                    }
                    else
                    {
                        if (textBoxAlici.Text.Length != 8)
                        {
                            MessageBox.Show("Alıcı Hesap No 8 Haneli Olmalıdır.");
                        }
                        else if (gonderenHesap.hesapNo / 10000000 != Convert.ToInt32(textBoxAlici.Text) / 10000000)
                        {
                            MessageBox.Show("Gönderen Hesabın Para Birimi Gönderilen\nHesabın Para Birimiyle Aynı Olmalı.");
                        }
                        else
                        {
                            gonderilenHesap = bl.HesapDetayGetir(Convert.ToInt32(textBoxAlici.Text));

                            bl.BaskaHesabaTransfer(gonderenHesap, gonderilenHesap, Convert.ToDecimal(textBoxMiktar.Text));

                            MessageBox.Show("İşlem Tamamlandı.");

                            this.Close();
                        }
                    }
                }
            }
        }
    }
}

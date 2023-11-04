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
    public partial class MusteriHesaplarim : Form
    {
        BL bl = new BL();
        public MusteriHesaplarim()
        {
            InitializeComponent();
        }

        private void Hesaplarim_Load(object sender, EventArgs e)
        {
            listBoxHesaplar.Items.Clear();

            listBoxHesaplar.Items.Add("HESAP NO\t\t BAKİYE");

            string[] list = bl.MusteriAktifHesaplarString(MusteriAnaMenu.musteri.musteriNo);

            listBoxHesaplar.Items.AddRange(list);
        }
    }
}

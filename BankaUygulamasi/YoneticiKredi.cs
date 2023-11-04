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
    public partial class YoneticiKredi : Form
    {
        BL bl = new BL();
        public YoneticiKredi()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            listBoxKredi.Items.Clear();

            listBoxKredi.Items.AddRange(bl.KrediBasvurulariListele());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxKredi.SelectedItem==null)
            {
                MessageBox.Show("Seçim Yapılmadı.");
            }

            else 
            {
                bl.KrediBasvuruyuGetir(Convert.ToInt32(listBoxKredi.SelectedItem.ToString().Substring(0, 8)));
            }

            listBoxKredi.Items.Clear();

            listBoxKredi.Items.AddRange(bl.KrediBasvurulariListele());
        }

    }
}

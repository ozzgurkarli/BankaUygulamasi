using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaUygulamasi.Serv;

namespace BankaUygulamasi
{
    public partial class MusteriKurlar : Form
    {
        public MusteriKurlar()
        {
            InitializeComponent();
        }

        private void Kurlar_Load(object sender, EventArgs e)
        {
            labelNo.Text = "USD/TRY: " + Doviz.birim["TRY"];
            labelBilgi.Text = "USD/EUR: " + Doviz.birim["EUR"];
            labelGM.Text = "USD/USD: " + Doviz.birim["USD"];
            labelGLM.Text = "USD/RUB: " + Doviz.birim["RUB"];
            labelGH.Text = "USD/JPY: " + Doviz.birim["JPY"];
            labelGLH.Text = "USD/GBP: " + Doviz.birim["GBP"];
            labelMiktar.Text = "USD/CHF: " + Doviz.birim["CHF"];
            labelTarih.Text = "USD/CAD: " + Doviz.birim["CAD"];
            label1.Text = "USD/BRL: " + Doviz.birim["BRL"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

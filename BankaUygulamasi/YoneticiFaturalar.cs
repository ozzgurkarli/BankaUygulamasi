using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class YoneticiFaturalar : Form
    {
        public YoneticiFaturalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YoneticiFaturalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaMusteriDataSet5.faturalar' table. You can move, or remove it, as needed.
            this.faturalarTableAdapter.FillBy(this.bankaMusteriDataSet5.faturalar);

        }

    }
}

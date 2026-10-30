using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans
{
    public partial class fr_pc : Form
    {
        public fr_pc()
        {
            InitializeComponent();
        }

        private void bt_hesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            if (Intel_7.Checked)
                cpuFiyat = 300;
            else if (Intel_5.Checked)
                cpuFiyat = 200;
            else if (Intel_3.Checked)
                cpuFiyat = 100;
            else if (Intel_5.Checked)
                cpuFiyat = 250;
            else if (Intel_3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
            decimal ramFiyat = 0;
            if (gb_16.Checked)
                ramFiyat = 125;
            else if (gb_8.Checked)
                ramFiyat = 75;
            else if (gb_4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            MessageBox.Show(("Toplam Fiyat =" + tabanFiyat.ToString()));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

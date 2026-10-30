using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans
{
    public partial class fr_giris : Form
    {
        public fr_giris()
        {
            InitializeComponent();
        }
        
        private void bt_giris_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text == "yusuf" && txt_sifre.Text == "sifre")
            {
                fr_main fr = new fr_main();
                fr_giris giris = new fr_giris();
                giris.Hide();
                fr.Show();
            }
             else
                MessageBox.Show("sen kimsin");
         

        }

        private void bt_cıkıs_Click(object sender, EventArgs e)
        {
            fr_giris g = new fr_giris();
            
        }
    }
}

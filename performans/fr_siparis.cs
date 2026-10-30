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
    public partial class fr_siparis : Form
    {
        public fr_siparis()
        {
            InitializeComponent();
        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc.SelectedIndex == 2)
            {
                txt_bilgi.Text = "";
                txt_bilgi.Text += txt_adsoyad.Text + "\r\n";
                txt_bilgi.Text += txt_tel.Text + "\r\n";
                txt_bilgi.Text += txt_adres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;//Adet fiyatı 12 lira.
                    txt_bilgi.Text += string.Format("Corba { 0:C}",nCorba.Value * 12) + "\r\n";
                }
                txt_bilgi.Text += "-----------------";
                txt_bilgi.Text += string.Format("Toplam { 0:C}",hesap);
            }
        }

        private void txt_bilgi_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

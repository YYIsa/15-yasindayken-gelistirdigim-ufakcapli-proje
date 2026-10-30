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
    public partial class fr_blackjack : Form
    {
        public fr_blackjack()
        {
            InitializeComponent();
            bt_kart_cek.Enabled = false;
            bt_kal.Enabled = false;
            pc_kart3.Hide();
            pc_kart4.Hide();
            bt_kart_cek2.Hide();
            bt_kart_cek3.Hide();
            bt_kart_cek4.Hide();

        }
        Random rdm = new Random();
        int kart1, kart2, kart3, kart4, kart5, kart6;
       // int sonuc = 0;
       // int sonuc2 = 0;


        private void bt_kar_cek2_Click(object sender, EventArgs e)
        {

           int kart_degeri = Convert.ToInt16( image_kart.Images.Keys[kart6].ToString().Split('_')[0].ToString());


            if (kart_degeri==11)
            {
                DialogResult dialogResult = MessageBox.Show("tercih", " değer 1  olsun mu?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)      kart_degeri = 1;
            }



            pc_kart4.Image = image_kart.Images[kart6];
            pc_kart4.Show();

            pc_kart.Image.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            bt_basla.Enabled = false;
            bt_kal.Enabled = true;
            bt_kart_cek.Enabled = true;
            kart1 = rdm.Next(0, 52);
            kart2 = rdm.Next(0, 52);
            kart3 = rdm.Next(0, 52);
            kart4 = rdm.Next(0, 52);
            kart5 = rdm.Next(0, 52);
            kart6 = rdm.Next(0, 52);
            pc_kasa_kart.Image = image_kart.Images[kart1];
            pc_kasa_kart2.Image = image_kart.Images[kart2];
            pc_kart.Image = image_kart.Images[kart3];
            pc_kart2.Image = image_kart.Images[kart4];


        }

        private void btkartçek_Click(object sender, EventArgs e)
        {
            pc_kart3.Show();
            pc_kart3.Image = image_kart.Images[kart5];
            bt_kart_cek.Hide();
            bt_kart_cek2.Show();

        }
    }
}


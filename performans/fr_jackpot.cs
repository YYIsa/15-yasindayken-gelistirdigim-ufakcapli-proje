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
    public partial class fr_jackpot : Form
    {

        int say1;
        int say2; 
        int say3; 
        public fr_jackpot()
        {
            InitializeComponent();
        }
        Random rdm = new Random();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer_jackpot.Start();
        }
        int sayac;
        private void timer_jackpot_Tick(object sender, EventArgs e)
        {
            if (sayac<10) say1 = rdm.Next(0,15);
            if (sayac < 20) say2 = rdm.Next(0, 15);
            if (sayac < 30) say3 = rdm.Next(0, 15);
            pc_say1.Image = image_jackpot.Images[say1];
            pc_say2.Image = image_jackpot.Images[say2];
            pc_say3.Image = image_jackpot.Images[say3];
            sayac++;
            if (sayac == 30)
            {
                timer_jackpot.Stop();
                sayac = 0;

                if (say1==say2 && say1==say3)
                {
                    MessageBox.Show("büyük vurgun");
                }
                if ((say1 == say2 && say1 != say3) || (say1 == say3 && say1 != say2) || (say3 == say2 && say1 != say3))
                {
                    MessageBox.Show("küçük vurgun");
                }


            }
        }

        private void pc_kol_MouseDown(object sender, MouseEventArgs e)
        {
            pc_kol.Image = image_jackpot.Images[16];
        }

        private void pc_kol_MouseUp(object sender, MouseEventArgs e)
        {
            pc_kol.Image = image_jackpot.Images[17];
        }
    }
        
    }


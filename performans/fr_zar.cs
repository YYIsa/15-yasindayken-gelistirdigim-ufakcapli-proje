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
    public partial class fr_zar : Form
    {
        public fr_zar()
        {
            InitializeComponent();
        }

        private void bt_zar_at_Click(object sender, EventArgs e)
        {
            timer_zar.Start();
            bt_zar_at.Enabled = false;
        }
        int sayac = 0;

        private void timer_zar_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;
            Random say = new Random();
            zar1 = say.Next(0, 6);
            zar2 = say.Next(0, 6);
            pc_zar1.Image = image_zar1.Images[zar1];
            pc_zar2.Image = image_zar2.Images[zar2];
            sayac++;
            if (sayac == 30)
            {
                timer_zar.Stop();
                sayac = 0;
                bt_zar_at.Enabled = true;
            }    
        }

        private void pc_zar1_Click(object sender, EventArgs e)
        {

        }
    }
}

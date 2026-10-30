using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans
{
    public partial class fr_at_yarisi : Form
    {
        public fr_at_yarisi()
        {
            InitializeComponent();
          
        }
        int uzaklık1, uzaklık2, uzaklık3;

        private void fr_at_yarisi_Load(object sender, EventArgs e)
        {
            uzaklık1 = pc_at1.Left;
            uzaklık2 = pc_at2.Left;
            uzaklık3 = pc_at3.Left;
        }

        private void bt_basla_Click(object sender, EventArgs e)
        {
            timer_at.Start();
        }

        Random rastgelesayi = new Random();

        private void timer_at_Tick(object sender, EventArgs e)
        {
            if (pc_at1.Left < pc_at2.Left && pc_at2.Left > pc_at3.Left)
            {
                lb_durum.Text = "2. at yarışı önde götürüyor değerli seyirciler.";
            }
            if (pc_at3.Left > pc_at1.Left && pc_at3.Left > pc_at2.Left)
            {
                lb_durum.Text = "3. at yarışı önde götürüyor değerli seyirciler";
            }
            if (pc_at1.Left > pc_at2.Left && pc_at1.Left > pc_at3.Left)
            {
                lb_durum.Text = "1. at yarışı önde götürüyor değerli seyirciler";
            }
            int birinciatgenislik = pc_at1.Width;
            int ikinciatgenislik = pc_at2.Width;
            int ücüncüatgenislik = pc_at3.Width;
            int bitisuzaklıgı = pc_bitis.Left;
            pc_at1.Left += rastgelesayi.Next(2, 15);
            pc_at2.Left += rastgelesayi.Next(2, 15);
            pc_at3.Left += rastgelesayi.Next(2, 15);

            if (pc_at1.Left + pc_at1.Width > bitisuzaklıgı)
            {
                timer_at.Stop();
                MessageBox.Show("birinci at yarışı kazandı");

            }
            else if (pc_at2.Left + pc_at2.Width > bitisuzaklıgı)
            {
                timer_at.Stop();
                MessageBox.Show("ikinci at yarışı kazandı");

            }
            else if (pc_at3.Left + pc_at3.Width > bitisuzaklıgı)
            {
                timer_at.Stop();
                MessageBox.Show("üçüncü at yarışı kazandı");

            }
        }



    }

    
}

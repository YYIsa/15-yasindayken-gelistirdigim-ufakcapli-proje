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
    public partial class fr_vki_hesaplama : Form
    {
        public fr_vki_hesaplama()
        {
            InitializeComponent();
        }

        private void bt_hesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(txt_boy.Text);
            kilo = Convert.ToDouble(txt_kilo.Text);
            boy /= 100;
            vki = kilo / (boy * boy);
            lb_vki.Text = vki.ToString("##.##");
            if(rb_kadın.Checked)
            if (vki < 18)
            {
                lb_durum.Text = "Zayıf";
                pc_foto.Image = image_kadın.Images[0];
            }
            else if (vki >= 18 && vki < 25)
            {
                lb_durum.Text = "Normal";
                pc_foto.Image = image_kadın.Images[1];
            }
            else if (vki >= 25 && vki < 30)
            {
                
                lb_durum.Text = "Kilolu";
                pc_foto.Image = image_kadın.Images[2];
            }
            else if (vki >= 30 && vki < 35)
            {
                lb_durum.Text = "Obez";
                pc_foto.Image = image_kadın.Images[3];
            }
            else
            {
                lb_durum.Text = "Ciddi Obez";
                pc_foto.Image = image_kadın.Images[4];
            }
            else
            {
                if (vki < 18)
                {
                    lb_durum.Text = "Zayıf";
                    pc_foto.Image = image_erkek.Images[0];
                }
                else if (vki >= 18 && vki < 25)
                {
                    lb_durum.Text = "Normal";
                    pc_foto.Image = image_erkek.Images[1];
                }
                else if (vki >= 25 && vki < 30)
                {

                    lb_durum.Text = "Kilolu";
                    pc_foto.Image = image_erkek.Images[2];
                }
                else if (vki >= 30 && vki < 35)
                {
                    lb_durum.Text = "Obez";
                    pc_foto.Image = image_erkek.Images[3];
                }
                else
                {
                    lb_durum.Text = "Ciddi Obez";
                    pc_foto.Image = image_erkek.Images[4];
                }
            }
        }

        private void bt_temizle_Click(object sender, EventArgs e)
        {
            txt_boy.Clear();
            txt_kilo.Clear();
            lb_vki.Text = "";
            lb_durum.Text = "";
        }

        private void pc_foto_Click(object sender, EventArgs e)
        {

        }
    }
}

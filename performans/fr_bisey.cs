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
    public partial class fr_bisey : Form
    {
        public fr_bisey()
        {
            InitializeComponent();
            
        }
        int sayi;
        int sayac;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                    try
                    {
                    sayi = Convert.ToInt32(txt_list.Text);
                       list_bisey.Items.Add(sayi);
                      txt_list.Text = "";
                    txt_list.Focus();
                    }
                    catch (Exception)
                    {
                       txt_list.Text = "";
                        txt_list.Focus();
                        
                    }
                }
            if (list_bisey.Items.Count == 20)
                {
                    timer_bisey.Start();
                   txt_list.Enabled = false;
                    int buyuk = sayi, kucuk = sayi;

                    foreach (var item in list_bisey.Items)
                    {
                        int sayi2 = Convert.ToInt32(item.ToString());
                        if (buyuk < sayi2) buyuk = sayi2;

                        if (kucuk > sayi2) kucuk = sayi2;
                    }
                    lb_büyük.Text = buyuk.ToString();
                lb_kücük.Text = kucuk.ToString();
                lb_sayac.Text.ToString();
                }
            }

        private void timer_bisey_Tick(object sender, EventArgs e)
        {
            sayac--;
            lb_sayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                sayac = 5;
               txt_list.Enabled = true;
                txt_list.Clear();
                list_bisey.Items.Clear();
                lb_büyük.Text = "";
                lb_kücük.Text = "";
                lb_sayac.Text = "5";
                txt_list.Focus();
                timer_bisey.Stop();
            }
        }

        private void fr_bisey_Load(object sender, EventArgs e)
        {

        }
    }
    }


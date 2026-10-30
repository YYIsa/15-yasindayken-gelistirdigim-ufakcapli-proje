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
    public partial class fr_gun : Form
    {
        public fr_gun()
        {
            InitializeComponent();
        }

        private void bt_gun_Click(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime(2020, 10, 19);
            Console.WriteLine(tarih.DayOfWeek);
            string tarihTurkce = "";

            switch (tarih.DayOfWeek)
            {

                case DayOfWeek.Sunday:
                    MessageBox.Show("Pazar"); break;
                case DayOfWeek.Monday:
                    MessageBox.Show("Pazartesi"); break;
                case DayOfWeek.Tuesday:
                    MessageBox.Show("Salı"); break;
                case DayOfWeek.Wednesday:
                    MessageBox.Show("Çarşamba"); break;
                case DayOfWeek.Thursday:
                    MessageBox.Show("Perşembe"); break;
                case DayOfWeek.Friday:
                    MessageBox.Show("Cuma"); break;
                case DayOfWeek.Saturday:
                    MessageBox.Show("Cumartesi"); break;
                default: break;
            }

            Console.WriteLine(tarihTurkce);
            Console.ReadLine();
        }
    }
}

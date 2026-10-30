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
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
        }

        private void fr_main_Load(object sender, EventArgs e)
        {
            timer_zaman.Start();
        }

        private void zarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fr_zar zar = new fr_zar();
            zar.Show();
        }

        private void blackJackToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // fr_blackjack black = new fr_blackjack();
          //  black.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                
            }

        }
        private void vkiHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_vki_hesaplama vki = new fr_vki_hesaplama();
            vki.Show();
        }

        private void blackJackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fr_blackjack black = new fr_blackjack();
            black.Show();
        }

        private void günÖgrenmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_gun gun = new fr_gun();
            gun.Show();
        }

        private void timer_zaman_Tick(object sender, EventArgs e)
        {
            lb_zaman.Text = DateTime.Now.ToLongTimeString();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void biseyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_bisey bisey = new fr_bisey();
            bisey.Show();
        }

        private void lb_zaman_Click(object sender, EventArgs e)
        {

        }

        private void classDenemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_class_deneme clas = new fr_class_deneme();
            clas.Show();
            
        }

        private void atYarısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_at_yarisi at = new fr_at_yarisi();
            at.Show();
        }

        private void renkOyunuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_ren renk = new fr_ren();
            renk.Show(); 
        }

        private void jackPotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_jackpot jack = new fr_jackpot();
            jack.Show();
        }

        private void butonOyunuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_adres adres = new fr_adres();
            adres.Show();
        }

        private void pcToplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_pc pc = new fr_pc();
            pc.Show();
        }

        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_siparis siparis = new fr_siparis();
            siparis.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_menu menu = new fr_menu();
            menu.Show();
        }
    }
}

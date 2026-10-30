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
    public partial class fr_menu : Form
    {
        public fr_menu()
        {
            InitializeComponent();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Editor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Editor.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Editor.Paste();
        }
        private void menuKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txt_Editor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları | *.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txt_Editor.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_Editor.Text, txt_Editor.Font,
            Brushes.Black, new Point(100, 100));
        }
    }
}

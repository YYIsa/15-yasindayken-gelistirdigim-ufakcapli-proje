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
    public partial class fr_adres : Form
    {
        public fr_adres()
        {
            InitializeComponent();
        }

        private void bt_anasayfa_Click(object sender, EventArgs e)
        {
            wb.GoHome();
        }

        private void bt_git_Click(object sender, EventArgs e)
        {
            wb.Navigate(txt_adres.Text);
        }
          private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            list.Items.Add(wb.Url);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
    }


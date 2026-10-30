namespace performans
{
    partial class fr_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDüzen = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Editor = new System.Windows.Forms.RichTextBox();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.AnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDüzen,
            this.menuCıkıs});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(454, 24);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.açToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuDüzen
            // 
            this.menuDüzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.menuDüzen.Name = "menuDüzen";
            this.menuDüzen.Size = new System.Drawing.Size(52, 20);
            this.menuDüzen.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // menuCıkıs
            // 
            this.menuCıkıs.Name = "menuCıkıs";
            this.menuCıkıs.Size = new System.Drawing.Size(44, 20);
            this.menuCıkıs.Text = "Cıkış";
            // 
            // txt_Editor
            // 
            this.txt_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Editor.Location = new System.Drawing.Point(0, 24);
            this.txt_Editor.Name = "txt_Editor";
            this.txt_Editor.Size = new System.Drawing.Size(454, 297);
            this.txt_Editor.TabIndex = 1;
            this.txt_Editor.Text = "";
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // fr_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 321);
            this.Controls.Add(this.txt_Editor);
            this.Controls.Add(this.AnaMenu);
            this.MainMenuStrip = this.AnaMenu;
            this.Name = "fr_menu";
            this.Text = "fr_menu";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuDüzen;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCıkıs;
        private System.Windows.Forms.RichTextBox txt_Editor;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument belge;
    }
}
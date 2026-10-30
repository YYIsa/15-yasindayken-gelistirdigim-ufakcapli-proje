namespace performans
{
    partial class fr_main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vkiHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackJackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.günÖgrenmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biseyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classDenemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atYarısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkOyunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asalSayıBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mükemmelSayıBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jackPotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackJackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_zaman = new System.Windows.Forms.Timer(this.components);
            this.lb_zaman = new System.Windows.Forms.Label();
            this.butonOyunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcToplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.programsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarToolStripMenuItem2,
            this.vkiHesaplamaToolStripMenuItem,
            this.blackJackToolStripMenuItem1,
            this.günÖgrenmeToolStripMenuItem,
            this.biseyToolStripMenuItem,
            this.classDenemeToolStripMenuItem,
            this.atYarısıToolStripMenuItem,
            this.renkOyunuToolStripMenuItem,
            this.asalSayıBulmaToolStripMenuItem,
            this.mükemmelSayıBulmaToolStripMenuItem,
            this.jackPotToolStripMenuItem,
            this.butonOyunuToolStripMenuItem,
            this.adresToolStripMenuItem,
            this.pcToplaToolStripMenuItem,
            this.siparisToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // zarToolStripMenuItem2
            // 
            this.zarToolStripMenuItem2.Name = "zarToolStripMenuItem2";
            this.zarToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.zarToolStripMenuItem2.Text = "zar";
            this.zarToolStripMenuItem2.Click += new System.EventHandler(this.zarToolStripMenuItem1_Click);
            // 
            // vkiHesaplamaToolStripMenuItem
            // 
            this.vkiHesaplamaToolStripMenuItem.Name = "vkiHesaplamaToolStripMenuItem";
            this.vkiHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.vkiHesaplamaToolStripMenuItem.Text = "vki hesaplama";
            this.vkiHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.vkiHesaplamaToolStripMenuItem_Click);
            // 
            // blackJackToolStripMenuItem1
            // 
            this.blackJackToolStripMenuItem1.Name = "blackJackToolStripMenuItem1";
            this.blackJackToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.blackJackToolStripMenuItem1.Text = "BlackJack";
            this.blackJackToolStripMenuItem1.Click += new System.EventHandler(this.blackJackToolStripMenuItem1_Click);
            // 
            // günÖgrenmeToolStripMenuItem
            // 
            this.günÖgrenmeToolStripMenuItem.Name = "günÖgrenmeToolStripMenuItem";
            this.günÖgrenmeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.günÖgrenmeToolStripMenuItem.Text = "Gün Ögrenme";
            this.günÖgrenmeToolStripMenuItem.Click += new System.EventHandler(this.günÖgrenmeToolStripMenuItem_Click);
            // 
            // biseyToolStripMenuItem
            // 
            this.biseyToolStripMenuItem.Name = "biseyToolStripMenuItem";
            this.biseyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.biseyToolStripMenuItem.Text = "Bisey";
            this.biseyToolStripMenuItem.Click += new System.EventHandler(this.biseyToolStripMenuItem_Click);
            // 
            // classDenemeToolStripMenuItem
            // 
            this.classDenemeToolStripMenuItem.Name = "classDenemeToolStripMenuItem";
            this.classDenemeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.classDenemeToolStripMenuItem.Text = "Class deneme";
            this.classDenemeToolStripMenuItem.Click += new System.EventHandler(this.classDenemeToolStripMenuItem_Click);
            // 
            // atYarısıToolStripMenuItem
            // 
            this.atYarısıToolStripMenuItem.Name = "atYarısıToolStripMenuItem";
            this.atYarısıToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.atYarısıToolStripMenuItem.Text = "At  Yarısı";
            this.atYarısıToolStripMenuItem.Click += new System.EventHandler(this.atYarısıToolStripMenuItem_Click);
            // 
            // renkOyunuToolStripMenuItem
            // 
            this.renkOyunuToolStripMenuItem.Name = "renkOyunuToolStripMenuItem";
            this.renkOyunuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.renkOyunuToolStripMenuItem.Text = "Renk Oyunu";
            this.renkOyunuToolStripMenuItem.Click += new System.EventHandler(this.renkOyunuToolStripMenuItem_Click);
            // 
            // asalSayıBulmaToolStripMenuItem
            // 
            this.asalSayıBulmaToolStripMenuItem.Name = "asalSayıBulmaToolStripMenuItem";
            this.asalSayıBulmaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.asalSayıBulmaToolStripMenuItem.Text = "Asal sayı Bulma";
            // 
            // mükemmelSayıBulmaToolStripMenuItem
            // 
            this.mükemmelSayıBulmaToolStripMenuItem.Name = "mükemmelSayıBulmaToolStripMenuItem";
            this.mükemmelSayıBulmaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mükemmelSayıBulmaToolStripMenuItem.Text = "Mükemmel Sayı Bulma";
            // 
            // jackPotToolStripMenuItem
            // 
            this.jackPotToolStripMenuItem.Name = "jackPotToolStripMenuItem";
            this.jackPotToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.jackPotToolStripMenuItem.Text = "JackPot";
            this.jackPotToolStripMenuItem.Click += new System.EventHandler(this.jackPotToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.loginToolStripMenuItem.Text = "login";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.çıkışToolStripMenuItem.Text = "çıkış";
            // 
            // zarToolStripMenuItem
            // 
            this.zarToolStripMenuItem.Name = "zarToolStripMenuItem";
            this.zarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.zarToolStripMenuItem.Text = "dosyalar";
            // 
            // zarToolStripMenuItem1
            // 
            this.zarToolStripMenuItem1.Name = "zarToolStripMenuItem1";
            this.zarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.zarToolStripMenuItem1.Text = "zar";
            this.zarToolStripMenuItem1.Click += new System.EventHandler(this.zarToolStripMenuItem1_Click);
            // 
            // blackJackToolStripMenuItem
            // 
            this.blackJackToolStripMenuItem.Name = "blackJackToolStripMenuItem";
            this.blackJackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blackJackToolStripMenuItem.Text = "BlackJack";
            this.blackJackToolStripMenuItem.Click += new System.EventHandler(this.blackJackToolStripMenuItem_Click);
            // 
            // timer_zaman
            // 
            this.timer_zaman.Tick += new System.EventHandler(this.timer_zaman_Tick);
            // 
            // lb_zaman
            // 
            this.lb_zaman.AutoSize = true;
            this.lb_zaman.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_zaman.Location = new System.Drawing.Point(494, 0);
            this.lb_zaman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_zaman.Name = "lb_zaman";
            this.lb_zaman.Size = new System.Drawing.Size(23, 24);
            this.lb_zaman.TabIndex = 1;
            this.lb_zaman.Text = "0";
            this.lb_zaman.Click += new System.EventHandler(this.lb_zaman_Click);
            // 
            // butonOyunuToolStripMenuItem
            // 
            this.butonOyunuToolStripMenuItem.Name = "butonOyunuToolStripMenuItem";
            this.butonOyunuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.butonOyunuToolStripMenuItem.Text = "Buton oyunu";
            this.butonOyunuToolStripMenuItem.Click += new System.EventHandler(this.butonOyunuToolStripMenuItem_Click);
            // 
            // adresToolStripMenuItem
            // 
            this.adresToolStripMenuItem.Name = "adresToolStripMenuItem";
            this.adresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.adresToolStripMenuItem.Text = "Adres";
            this.adresToolStripMenuItem.Click += new System.EventHandler(this.adresToolStripMenuItem_Click);
            // 
            // pcToplaToolStripMenuItem
            // 
            this.pcToplaToolStripMenuItem.Name = "pcToplaToolStripMenuItem";
            this.pcToplaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pcToplaToolStripMenuItem.Text = "pc topla";
            this.pcToplaToolStripMenuItem.Click += new System.EventHandler(this.pcToplaToolStripMenuItem_Click);
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.siparisToolStripMenuItem.Text = "Siparis";
            this.siparisToolStripMenuItem.Click += new System.EventHandler(this.siparisToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.menuToolStripMenuItem.Text = "menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // fr_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lb_zaman);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fr_main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.fr_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackJackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vkiHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackJackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem günÖgrenmeToolStripMenuItem;
        private System.Windows.Forms.Timer timer_zaman;
        private System.Windows.Forms.Label lb_zaman;
        private System.Windows.Forms.ToolStripMenuItem biseyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classDenemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atYarısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkOyunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asalSayıBulmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mükemmelSayıBulmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jackPotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butonOyunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcToplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}


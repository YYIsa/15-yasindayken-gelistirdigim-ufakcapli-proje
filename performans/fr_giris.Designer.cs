namespace performans
{
    partial class fr_giris
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
            this.bt_giris = new System.Windows.Forms.Button();
            this.bt_cıkıs = new System.Windows.Forms.Button();
            this.bos2 = new System.Windows.Forms.Label();
            this.bos1 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_giris
            // 
            this.bt_giris.Location = new System.Drawing.Point(84, 162);
            this.bt_giris.Name = "bt_giris";
            this.bt_giris.Size = new System.Drawing.Size(75, 44);
            this.bt_giris.TabIndex = 3;
            this.bt_giris.Text = "Giriş";
            this.bt_giris.UseVisualStyleBackColor = true;
            this.bt_giris.Click += new System.EventHandler(this.bt_giris_Click);
            // 
            // bt_cıkıs
            // 
            this.bt_cıkıs.Location = new System.Drawing.Point(185, 162);
            this.bt_cıkıs.Name = "bt_cıkıs";
            this.bt_cıkıs.Size = new System.Drawing.Size(75, 44);
            this.bt_cıkıs.TabIndex = 4;
            this.bt_cıkıs.Text = "Çıkış";
            this.bt_cıkıs.UseVisualStyleBackColor = true;
            this.bt_cıkıs.Click += new System.EventHandler(this.bt_cıkıs_Click);
            // 
            // bos2
            // 
            this.bos2.AutoSize = true;
            this.bos2.Location = new System.Drawing.Point(84, 72);
            this.bos2.Name = "bos2";
            this.bos2.Size = new System.Drawing.Size(82, 16);
            this.bos2.TabIndex = 0;
            this.bos2.Text = "Kulanıcı Adı :";
            // 
            // bos1
            // 
            this.bos1.AutoSize = true;
            this.bos1.Location = new System.Drawing.Point(84, 126);
            this.bos1.Name = "bos1";
            this.bos1.Size = new System.Drawing.Size(40, 16);
            this.bos1.TabIndex = 0;
            this.bos1.Text = "Sifre :";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(185, 72);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(185, 126);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 2;
            // 
            // fr_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.bos1);
            this.Controls.Add(this.bos2);
            this.Controls.Add(this.bt_cıkıs);
            this.Controls.Add(this.bt_giris);
            this.Name = "fr_giris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_giris;
        private System.Windows.Forms.Button bt_cıkıs;
        private System.Windows.Forms.Label bos2;
        private System.Windows.Forms.Label bos1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_sifre;
    }
}


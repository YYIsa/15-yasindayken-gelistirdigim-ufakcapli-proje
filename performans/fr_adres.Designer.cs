namespace performans
{
    partial class fr_adres
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_yenile = new System.Windows.Forms.Button();
            this.bt_ileri = new System.Windows.Forms.Button();
            this.bt_geri = new System.Windows.Forms.Button();
            this.bt_anasayfa = new System.Windows.Forms.Button();
            this.bt_git = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(505, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 257);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_yenile);
            this.panel1.Controls.Add(this.bt_ileri);
            this.panel1.Controls.Add(this.bt_geri);
            this.panel1.Controls.Add(this.bt_anasayfa);
            this.panel1.Controls.Add(this.bt_git);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_adres);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 100);
            this.panel1.TabIndex = 3;
            // 
            // bt_yenile
            // 
            this.bt_yenile.Location = new System.Drawing.Point(535, 22);
            this.bt_yenile.Name = "bt_yenile";
            this.bt_yenile.Size = new System.Drawing.Size(75, 23);
            this.bt_yenile.TabIndex = 2;
            this.bt_yenile.Text = "Yenile";
            this.bt_yenile.UseVisualStyleBackColor = true;
            // 
            // bt_ileri
            // 
            this.bt_ileri.Location = new System.Drawing.Point(454, 22);
            this.bt_ileri.Name = "bt_ileri";
            this.bt_ileri.Size = new System.Drawing.Size(75, 23);
            this.bt_ileri.TabIndex = 2;
            this.bt_ileri.Text = "Ileri";
            this.bt_ileri.UseVisualStyleBackColor = true;
            // 
            // bt_geri
            // 
            this.bt_geri.Location = new System.Drawing.Point(373, 22);
            this.bt_geri.Name = "bt_geri";
            this.bt_geri.Size = new System.Drawing.Size(75, 23);
            this.bt_geri.TabIndex = 2;
            this.bt_geri.Text = "Geri";
            this.bt_geri.UseVisualStyleBackColor = true;
            // 
            // bt_anasayfa
            // 
            this.bt_anasayfa.Location = new System.Drawing.Point(292, 22);
            this.bt_anasayfa.Name = "bt_anasayfa";
            this.bt_anasayfa.Size = new System.Drawing.Size(75, 23);
            this.bt_anasayfa.TabIndex = 2;
            this.bt_anasayfa.Text = "Ana Sayfa";
            this.bt_anasayfa.UseVisualStyleBackColor = true;
            this.bt_anasayfa.Click += new System.EventHandler(this.bt_anasayfa_Click);
            // 
            // bt_git
            // 
            this.bt_git.Location = new System.Drawing.Point(211, 22);
            this.bt_git.Name = "bt_git";
            this.bt_git.Size = new System.Drawing.Size(75, 23);
            this.bt_git.TabIndex = 2;
            this.bt_git.Text = "Git";
            this.bt_git.UseVisualStyleBackColor = true;
            this.bt_git.Click += new System.EventHandler(this.bt_git_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(50, 22);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(155, 20);
            this.txt_adres.TabIndex = 0;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 110);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(471, 212);
            this.list.TabIndex = 6;
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(13, 110);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Size = new System.Drawing.Size(487, 250);
            this.wb.TabIndex = 7;
            // 
            // fr_adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 482);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_adres";
            this.Text = "fr_adres";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_yenile;
        private System.Windows.Forms.Button bt_ileri;
        private System.Windows.Forms.Button bt_geri;
        private System.Windows.Forms.Button bt_anasayfa;
        private System.Windows.Forms.Button bt_git;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.WebBrowser wb;
    }
}
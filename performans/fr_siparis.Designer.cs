namespace performans
{
    partial class fr_siparis
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
            this.components = new System.ComponentModel.Container();
            this.tc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bilgi = new System.Windows.Forms.TextBox();
            this.nAnayemek = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.nTatli = new System.Windows.Forms.NumericUpDown();
            this.tc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnayemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Controls.Add(this.tabPage3);
            this.tc.Location = new System.Drawing.Point(-1, 1);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(532, 296);
            this.tc.TabIndex = 0;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.txt_tel);
            this.tabPage1.Controls.Add(this.txt_adsoyad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nCorba);
            this.tabPage2.Controls.Add(this.nSalata);
            this.tabPage2.Controls.Add(this.nTatli);
            this.tabPage2.Controls.Add(this.nAnayemek);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adres :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(80, 21);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_adsoyad.TabIndex = 1;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(80, 60);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 1;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(80, 98);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(100, 20);
            this.txt_adres.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_bilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Corba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ana Yemek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tatlı";
            // 
            // txt_bilgi
            // 
            this.txt_bilgi.Location = new System.Drawing.Point(87, 48);
            this.txt_bilgi.Name = "txt_bilgi";
            this.txt_bilgi.Size = new System.Drawing.Size(100, 20);
            this.txt_bilgi.TabIndex = 0;
            this.txt_bilgi.TextChanged += new System.EventHandler(this.txt_bilgi_TextChanged);
            // 
            // nAnayemek
            // 
            this.nAnayemek.Location = new System.Drawing.Point(106, 98);
            this.nAnayemek.Name = "nAnayemek";
            this.nAnayemek.Size = new System.Drawing.Size(120, 20);
            this.nAnayemek.TabIndex = 1;
            this.nAnayemek.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(106, 66);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 20);
            this.nSalata.TabIndex = 1;
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(106, 32);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 20);
            this.nCorba.TabIndex = 1;
            // 
            // nTatli
            // 
            this.nTatli.Location = new System.Drawing.Point(106, 124);
            this.nTatli.Name = "nTatli";
            this.nTatli.Size = new System.Drawing.Size(120, 20);
            this.nTatli.TabIndex = 1;
            this.nTatli.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fr_siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 295);
            this.Controls.Add(this.tc);
            this.Name = "fr_siparis";
            this.Text = "fr_siparis";
            this.tc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnayemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bilgi;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nAnayemek;
        private System.Windows.Forms.NumericUpDown nTatli;
    }
}
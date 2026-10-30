namespace performans
{
    partial class fr_class_deneme
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
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.bt_topla = new System.Windows.Forms.Button();
            this.lb_toplam = new System.Windows.Forms.Label();
            this.bt_topla2 = new System.Windows.Forms.Button();
            this.bt_topla4 = new System.Windows.Forms.Button();
            this.bt_topla3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(79, 34);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi1.TabIndex = 0;
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(79, 74);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi2.TabIndex = 0;
            // 
            // bt_topla
            // 
            this.bt_topla.Location = new System.Drawing.Point(25, 127);
            this.bt_topla.Name = "bt_topla";
            this.bt_topla.Size = new System.Drawing.Size(100, 23);
            this.bt_topla.TabIndex = 1;
            this.bt_topla.Text = "Topla";
            this.bt_topla.UseVisualStyleBackColor = true;
            this.bt_topla.Click += new System.EventHandler(this.bt_topla_Click);
            // 
            // lb_toplam
            // 
            this.lb_toplam.AutoSize = true;
            this.lb_toplam.Location = new System.Drawing.Point(125, 111);
            this.lb_toplam.Name = "lb_toplam";
            this.lb_toplam.Size = new System.Drawing.Size(13, 13);
            this.lb_toplam.TabIndex = 2;
            this.lb_toplam.Text = "0";
            this.lb_toplam.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_topla2
            // 
            this.bt_topla2.Location = new System.Drawing.Point(140, 127);
            this.bt_topla2.Name = "bt_topla2";
            this.bt_topla2.Size = new System.Drawing.Size(100, 23);
            this.bt_topla2.TabIndex = 1;
            this.bt_topla2.Text = "Topla2";
            this.bt_topla2.UseVisualStyleBackColor = true;
            // 
            // bt_topla4
            // 
            this.bt_topla4.Location = new System.Drawing.Point(140, 156);
            this.bt_topla4.Name = "bt_topla4";
            this.bt_topla4.Size = new System.Drawing.Size(100, 23);
            this.bt_topla4.TabIndex = 1;
            this.bt_topla4.Text = "Topla4";
            this.bt_topla4.UseVisualStyleBackColor = true;
            // 
            // bt_topla3
            // 
            this.bt_topla3.Location = new System.Drawing.Point(25, 156);
            this.bt_topla3.Name = "bt_topla3";
            this.bt_topla3.Size = new System.Drawing.Size(100, 23);
            this.bt_topla3.TabIndex = 1;
            this.bt_topla3.Text = "Topla3";
            this.bt_topla3.UseVisualStyleBackColor = true;
            // 
            // fr_class_deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.lb_toplam);
            this.Controls.Add(this.bt_topla3);
            this.Controls.Add(this.bt_topla4);
            this.Controls.Add(this.bt_topla2);
            this.Controls.Add(this.bt_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Name = "fr_class_deneme";
            this.Text = "Class Deneme";
            this.Load += new System.EventHandler(this.fr_class_deneme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button bt_topla;
        private System.Windows.Forms.Label lb_toplam;
        private System.Windows.Forms.Button bt_topla2;
        private System.Windows.Forms.Button bt_topla4;
        private System.Windows.Forms.Button bt_topla3;
    }
}
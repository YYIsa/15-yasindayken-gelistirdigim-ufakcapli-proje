namespace performans
{
    partial class fr_bisey
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
            this.txt_list = new System.Windows.Forms.TextBox();
            this.list_bisey = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_büyük = new System.Windows.Forms.Label();
            this.lb_kücük = new System.Windows.Forms.Label();
            this.lb_sayac = new System.Windows.Forms.Label();
            this.timer_bisey = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_list
            // 
            this.txt_list.Location = new System.Drawing.Point(39, 12);
            this.txt_list.Name = "txt_list";
            this.txt_list.Size = new System.Drawing.Size(162, 20);
            this.txt_list.TabIndex = 0;
            this.txt_list.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // list_bisey
            // 
            this.list_bisey.FormattingEnabled = true;
            this.list_bisey.Location = new System.Drawing.Point(231, 1);
            this.list_bisey.Name = "list_bisey";
            this.list_bisey.Size = new System.Drawing.Size(120, 264);
            this.list_bisey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "En Küçük Sayı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "En Büyük Sayı :";
            // 
            // lb_büyük
            // 
            this.lb_büyük.AutoSize = true;
            this.lb_büyük.Location = new System.Drawing.Point(129, 96);
            this.lb_büyük.Name = "lb_büyük";
            this.lb_büyük.Size = new System.Drawing.Size(0, 13);
            this.lb_büyük.TabIndex = 3;
            // 
            // lb_kücük
            // 
            this.lb_kücük.AutoSize = true;
            this.lb_kücük.Location = new System.Drawing.Point(129, 135);
            this.lb_kücük.Name = "lb_kücük";
            this.lb_kücük.Size = new System.Drawing.Size(0, 13);
            this.lb_kücük.TabIndex = 3;
            // 
            // lb_sayac
            // 
            this.lb_sayac.AutoSize = true;
            this.lb_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sayac.Location = new System.Drawing.Point(74, 165);
            this.lb_sayac.Name = "lb_sayac";
            this.lb_sayac.Size = new System.Drawing.Size(69, 73);
            this.lb_sayac.TabIndex = 4;
            this.lb_sayac.Text = "5";
            // 
            // timer_bisey
            // 
            this.timer_bisey.Tick += new System.EventHandler(this.timer_bisey_Tick);
            // 
            // fr_bisey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 262);
            this.Controls.Add(this.lb_sayac);
            this.Controls.Add(this.lb_kücük);
            this.Controls.Add(this.lb_büyük);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_bisey);
            this.Controls.Add(this.txt_list);
            this.Name = "fr_bisey";
            this.Text = "fr_bisey";
            this.Load += new System.EventHandler(this.fr_bisey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_list;
        private System.Windows.Forms.ListBox list_bisey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_büyük;
        private System.Windows.Forms.Label lb_kücük;
        private System.Windows.Forms.Label lb_sayac;
        private System.Windows.Forms.Timer timer_bisey;
    }
}
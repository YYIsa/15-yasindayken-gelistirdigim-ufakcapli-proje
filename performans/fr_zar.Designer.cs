namespace performans
{
    partial class fr_zar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_zar));
            this.bt_zar_at = new System.Windows.Forms.Button();
            this.pc_zar1 = new System.Windows.Forms.PictureBox();
            this.timer_zar = new System.Windows.Forms.Timer(this.components);
            this.image_zar1 = new System.Windows.Forms.ImageList(this.components);
            this.image_zar2 = new System.Windows.Forms.ImageList(this.components);
            this.pc_zar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_zar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_zar2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_zar_at
            // 
            this.bt_zar_at.Location = new System.Drawing.Point(174, 231);
            this.bt_zar_at.Name = "bt_zar_at";
            this.bt_zar_at.Size = new System.Drawing.Size(86, 80);
            this.bt_zar_at.TabIndex = 0;
            this.bt_zar_at.Text = "Zar at";
            this.bt_zar_at.UseVisualStyleBackColor = true;
            this.bt_zar_at.Click += new System.EventHandler(this.bt_zar_at_Click);
            // 
            // pc_zar1
            // 
            this.pc_zar1.Location = new System.Drawing.Point(12, 12);
            this.pc_zar1.Name = "pc_zar1";
            this.pc_zar1.Size = new System.Drawing.Size(200, 200);
            this.pc_zar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_zar1.TabIndex = 2;
            this.pc_zar1.TabStop = false;
            this.pc_zar1.Click += new System.EventHandler(this.pc_zar1_Click);
            // 
            // timer_zar
            // 
            this.timer_zar.Tick += new System.EventHandler(this.timer_zar_Tick);
            // 
            // image_zar1
            // 
            this.image_zar1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_zar1.ImageStream")));
            this.image_zar1.TransparentColor = System.Drawing.Color.Transparent;
            this.image_zar1.Images.SetKeyName(0, "zar1.png");
            this.image_zar1.Images.SetKeyName(1, "zar2.jpg");
            this.image_zar1.Images.SetKeyName(2, "zar3.jpg");
            this.image_zar1.Images.SetKeyName(3, "zar4.jpg");
            this.image_zar1.Images.SetKeyName(4, "zar5.jpg");
            this.image_zar1.Images.SetKeyName(5, "zar6.jpg");
            // 
            // image_zar2
            // 
            this.image_zar2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_zar2.ImageStream")));
            this.image_zar2.TransparentColor = System.Drawing.Color.Transparent;
            this.image_zar2.Images.SetKeyName(0, "zar1.png");
            this.image_zar2.Images.SetKeyName(1, "zar2.jpg");
            this.image_zar2.Images.SetKeyName(2, "zar3.jpg");
            this.image_zar2.Images.SetKeyName(3, "zar4.jpg");
            this.image_zar2.Images.SetKeyName(4, "zar5.jpg");
            this.image_zar2.Images.SetKeyName(5, "zar6.jpg");
            // 
            // pc_zar2
            // 
            this.pc_zar2.Location = new System.Drawing.Point(225, 12);
            this.pc_zar2.Name = "pc_zar2";
            this.pc_zar2.Size = new System.Drawing.Size(200, 200);
            this.pc_zar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_zar2.TabIndex = 2;
            this.pc_zar2.TabStop = false;
            this.pc_zar2.Click += new System.EventHandler(this.pc_zar1_Click);
            // 
            // fr_zar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 323);
            this.Controls.Add(this.pc_zar2);
            this.Controls.Add(this.pc_zar1);
            this.Controls.Add(this.bt_zar_at);
            this.Name = "fr_zar";
            this.Text = "zar at (kumar)";
            ((System.ComponentModel.ISupportInitialize)(this.pc_zar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_zar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_zar_at;
        private System.Windows.Forms.PictureBox pc_zar1;
        private System.Windows.Forms.Timer timer_zar;
        private System.Windows.Forms.ImageList image_zar1;
        private System.Windows.Forms.ImageList image_zar2;
        private System.Windows.Forms.PictureBox pc_zar2;
    }
}
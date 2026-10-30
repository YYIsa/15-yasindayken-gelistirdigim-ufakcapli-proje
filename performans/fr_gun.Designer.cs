namespace performans
{
    partial class fr_gun
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
            this.bt_gun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gun
            // 
            this.bt_gun.Location = new System.Drawing.Point(135, 62);
            this.bt_gun.Name = "bt_gun";
            this.bt_gun.Size = new System.Drawing.Size(87, 64);
            this.bt_gun.TabIndex = 0;
            this.bt_gun.Text = "Günü Ögren";
            this.bt_gun.UseVisualStyleBackColor = true;
            this.bt_gun.Click += new System.EventHandler(this.bt_gun_Click);
            // 
            // fr_gun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 199);
            this.Controls.Add(this.bt_gun);
            this.Name = "fr_gun";
            this.Text = "gun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gun;
    }
}
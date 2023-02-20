namespace GunlukUygulamasi.My_Forms
{
    partial class about_us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us));
            this.co_name_label1 = new System.Windows.Forms.Label();
            this.product_name_label2 = new System.Windows.Forms.Label();
            this.version_label3 = new System.Windows.Forms.Label();
            this.site_label6 = new System.Windows.Forms.Label();
            this.programmer_label7 = new System.Windows.Forms.Label();
            this.year_label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // co_name_label1
            // 
            this.co_name_label1.AutoSize = true;
            this.co_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.co_name_label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.co_name_label1.Location = new System.Drawing.Point(75, 52);
            this.co_name_label1.Name = "co_name_label1";
            this.co_name_label1.Size = new System.Drawing.Size(220, 55);
            this.co_name_label1.TabIndex = 0;
            this.co_name_label1.Text = "SimTech";
            // 
            // product_name_label2
            // 
            this.product_name_label2.AutoSize = true;
            this.product_name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.product_name_label2.Location = new System.Drawing.Point(33, 142);
            this.product_name_label2.Name = "product_name_label2";
            this.product_name_label2.Size = new System.Drawing.Size(196, 25);
            this.product_name_label2.TabIndex = 1;
            this.product_name_label2.Text = "Yapı Adı : Günlük";
            // 
            // version_label3
            // 
            this.version_label3.AutoSize = true;
            this.version_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.version_label3.Location = new System.Drawing.Point(33, 183);
            this.version_label3.Name = "version_label3";
            this.version_label3.Size = new System.Drawing.Size(243, 25);
            this.version_label3.TabIndex = 2;
            this.version_label3.Text = "Versiyon : 2022.12.16";
            // 
            // site_label6
            // 
            this.site_label6.AutoSize = true;
            this.site_label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.site_label6.Location = new System.Drawing.Point(33, 226);
            this.site_label6.Name = "site_label6";
            this.site_label6.Size = new System.Drawing.Size(271, 25);
            this.site_label6.TabIndex = 3;
            this.site_label6.Text = "https://www.simtech.com";
            // 
            // programmer_label7
            // 
            this.programmer_label7.AutoSize = true;
            this.programmer_label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programmer_label7.Location = new System.Drawing.Point(33, 267);
            this.programmer_label7.Name = "programmer_label7";
            this.programmer_label7.Size = new System.Drawing.Size(305, 25);
            this.programmer_label7.TabIndex = 4;
            this.programmer_label7.Text = "Programcı : Mehmet Şimşek";
            // 
            // year_label5
            // 
            this.year_label5.AutoSize = true;
            this.year_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.year_label5.Location = new System.Drawing.Point(143, 316);
            this.year_label5.Name = "year_label5";
            this.year_label5.Size = new System.Drawing.Size(64, 25);
            this.year_label5.TabIndex = 5;
            this.year_label5.Text = "2022";
            // 
            // about_us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(381, 454);
            this.Controls.Add(this.year_label5);
            this.Controls.Add(this.programmer_label7);
            this.Controls.Add(this.site_label6);
            this.Controls.Add(this.version_label3);
            this.Controls.Add(this.product_name_label2);
            this.Controls.Add(this.co_name_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about_us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.about_us_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label co_name_label1;
        private System.Windows.Forms.Label product_name_label2;
        private System.Windows.Forms.Label version_label3;
        private System.Windows.Forms.Label site_label6;
        private System.Windows.Forms.Label programmer_label7;
        private System.Windows.Forms.Label year_label5;
    }
}
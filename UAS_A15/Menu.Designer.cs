namespace UAS_A15
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictBuku = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictDonatur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDonatur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBuku
            // 
            this.pictBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictBuku.Image = ((System.Drawing.Image)(resources.GetObject("pictBuku.Image")));
            this.pictBuku.Location = new System.Drawing.Point(286, 168);
            this.pictBuku.Name = "pictBuku";
            this.pictBuku.Size = new System.Drawing.Size(139, 111);
            this.pictBuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBuku.TabIndex = 9;
            this.pictBuku.TabStop = false;
            this.pictBuku.Click += new System.EventHandler(this.pictBuku_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Utama";
            // 
            // pictDonatur
            // 
            this.pictDonatur.Image = ((System.Drawing.Image)(resources.GetObject("pictDonatur.Image")));
            this.pictDonatur.Location = new System.Drawing.Point(44, 167);
            this.pictDonatur.Name = "pictDonatur";
            this.pictDonatur.Size = new System.Drawing.Size(144, 112);
            this.pictDonatur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictDonatur.TabIndex = 11;
            this.pictDonatur.TabStop = false;
            this.pictDonatur.Click += new System.EventHandler(this.pictDonatur_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(508, 384);
            this.Controls.Add(this.pictDonatur);
            this.Controls.Add(this.pictBuku);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDonatur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictDonatur;
    }
}
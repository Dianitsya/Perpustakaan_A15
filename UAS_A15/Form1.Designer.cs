namespace UAS_A15
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictBuku = new System.Windows.Forms.PictureBox();
            this.pictAnggota = new System.Windows.Forms.PictureBox();
            this.pictDonatur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAnggota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDonatur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Utama";
            // 
            // pictBuku
            // 
            this.pictBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictBuku.Image = ((System.Drawing.Image)(resources.GetObject("pictBuku.Image")));
            this.pictBuku.Location = new System.Drawing.Point(522, 133);
            this.pictBuku.Name = "pictBuku";
            this.pictBuku.Size = new System.Drawing.Size(139, 111);
            this.pictBuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBuku.TabIndex = 5;
            this.pictBuku.TabStop = false;
            this.pictBuku.Click += new System.EventHandler(this.pictBuku_Click);
            // 
            // pictAnggota
            // 
            this.pictAnggota.BackColor = System.Drawing.SystemColors.Window;
            this.pictAnggota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictAnggota.Image = ((System.Drawing.Image)(resources.GetObject("pictAnggota.Image")));
            this.pictAnggota.Location = new System.Drawing.Point(116, 133);
            this.pictAnggota.Name = "pictAnggota";
            this.pictAnggota.Size = new System.Drawing.Size(152, 113);
            this.pictAnggota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictAnggota.TabIndex = 6;
            this.pictAnggota.TabStop = false;
            this.pictAnggota.Click += new System.EventHandler(this.pictAnggota_Click);
            // 
            // pictDonatur
            // 
            this.pictDonatur.Image = ((System.Drawing.Image)(resources.GetObject("pictDonatur.Image")));
            this.pictDonatur.Location = new System.Drawing.Point(331, 280);
            this.pictDonatur.Name = "pictDonatur";
            this.pictDonatur.Size = new System.Drawing.Size(122, 107);
            this.pictDonatur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictDonatur.TabIndex = 7;
            this.pictDonatur.TabStop = false;
            this.pictDonatur.Click += new System.EventHandler(this.pictDonatur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictDonatur);
            this.Controls.Add(this.pictAnggota);
            this.Controls.Add(this.pictBuku);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Menu Utama";
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAnggota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDonatur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBuku;
        private System.Windows.Forms.PictureBox pictAnggota;
        private System.Windows.Forms.PictureBox pictDonatur;
    }
}


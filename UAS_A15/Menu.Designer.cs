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
            this.pictPengarang = new System.Windows.Forms.PictureBox();
            this.pctDonatur = new System.Windows.Forms.PictureBox();
            this.pctPetugas = new System.Windows.Forms.PictureBox();
            this.pctAnggota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPengarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDonatur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPetugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnggota)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBuku
            // 
            this.pictBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictBuku.Image = ((System.Drawing.Image)(resources.GetObject("pictBuku.Image")));
            this.pictBuku.Location = new System.Drawing.Point(247, 168);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Utama";
            // 
            // pictPengarang
            // 
            this.pictPengarang.Image = ((System.Drawing.Image)(resources.GetObject("pictPengarang.Image")));
            this.pictPengarang.Location = new System.Drawing.Point(44, 167);
            this.pictPengarang.Name = "pictPengarang";
            this.pictPengarang.Size = new System.Drawing.Size(144, 112);
            this.pictPengarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPengarang.TabIndex = 11;
            this.pictPengarang.TabStop = false;
            this.pictPengarang.Click += new System.EventHandler(this.pictPengarang_Click_1);
            // 
            // pctDonatur
            // 
            this.pctDonatur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctDonatur.BackgroundImage")));
            this.pctDonatur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctDonatur.Location = new System.Drawing.Point(453, 167);
            this.pctDonatur.Name = "pctDonatur";
            this.pctDonatur.Size = new System.Drawing.Size(139, 112);
            this.pctDonatur.TabIndex = 12;
            this.pctDonatur.TabStop = false;
            this.pctDonatur.Click += new System.EventHandler(this.pctDonatur_Click);
            // 
            // pctPetugas
            // 
            this.pctPetugas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctPetugas.BackgroundImage")));
            this.pctPetugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPetugas.Location = new System.Drawing.Point(691, 168);
            this.pctPetugas.Name = "pctPetugas";
            this.pctPetugas.Size = new System.Drawing.Size(139, 111);
            this.pctPetugas.TabIndex = 13;
            this.pctPetugas.TabStop = false;
            this.pctPetugas.Click += new System.EventHandler(this.pctPetugas_Click);
            // 
            // pctAnggota
            // 
            this.pctAnggota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctAnggota.Image = ((System.Drawing.Image)(resources.GetObject("pctAnggota.Image")));
            this.pctAnggota.Location = new System.Drawing.Point(910, 168);
            this.pctAnggota.Name = "pctAnggota";
            this.pctAnggota.Size = new System.Drawing.Size(139, 112);
            this.pctAnggota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnggota.TabIndex = 14;
            this.pctAnggota.TabStop = false;
            this.pctAnggota.Click += new System.EventHandler(this.pctAnggota_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 453);
            this.Controls.Add(this.pctAnggota);
            this.Controls.Add(this.pctPetugas);
            this.Controls.Add(this.pctDonatur);
            this.Controls.Add(this.pictPengarang);
            this.Controls.Add(this.pictBuku);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPengarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDonatur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPetugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnggota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictPengarang;
        private System.Windows.Forms.PictureBox pctDonatur;
        private System.Windows.Forms.PictureBox pctPetugas;
        private System.Windows.Forms.PictureBox pctAnggota;
    }
}
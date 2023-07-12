namespace UAS_A15
{
    partial class Anggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anggota));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictBack = new System.Windows.Forms.PictureBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtIDAngg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDAnggota = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxJK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(763, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 46);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(886, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(636, 401);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(95, 49);
            this.btnRead.TabIndex = 44;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(504, 255);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(513, 401);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 50);
            this.btnCreate.TabIndex = 42;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictBack
            // 
            this.pictBack.BackColor = System.Drawing.Color.Transparent;
            this.pictBack.Image = ((System.Drawing.Image)(resources.GetObject("pictBack.Image")));
            this.pictBack.Location = new System.Drawing.Point(12, 402);
            this.pictBack.Name = "pictBack";
            this.pictBack.Size = new System.Drawing.Size(100, 50);
            this.pictBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBack.TabIndex = 41;
            this.pictBack.TabStop = false;
            this.pictBack.Click += new System.EventHandler(this.pictBack_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(721, 73);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 26);
            this.txtNama.TabIndex = 39;
            // 
            // txtIDAngg
            // 
            this.txtIDAngg.Location = new System.Drawing.Point(721, 26);
            this.txtIDAngg.Name = "txtIDAngg";
            this.txtIDAngg.Size = new System.Drawing.Size(213, 26);
            this.txtIDAngg.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(551, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(551, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nama Anggota";
            // 
            // txtIDAnggota
            // 
            this.txtIDAnggota.AutoSize = true;
            this.txtIDAnggota.BackColor = System.Drawing.Color.Transparent;
            this.txtIDAnggota.Location = new System.Drawing.Point(551, 32);
            this.txtIDAnggota.Name = "txtIDAnggota";
            this.txtIDAnggota.Size = new System.Drawing.Size(91, 20);
            this.txtIDAnggota.TabIndex = 35;
            this.txtIDAnggota.Text = "ID Anggota";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(721, 221);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(213, 26);
            this.txtAlamat.TabIndex = 51;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(721, 174);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(213, 26);
            this.txtNoTelp.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(551, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(551, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "No Telp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(551, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tanggal Pinjam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(551, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Tanggal kembali";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(721, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(721, 318);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker2.TabIndex = 61;
            // 
            // cbxJK
            // 
            this.cbxJK.FormattingEnabled = true;
            this.cbxJK.Items.AddRange(new object[] {
            "P",
            "L"});
            this.cbxJK.Location = new System.Drawing.Point(721, 119);
            this.cbxJK.Name = "cbxJK";
            this.cbxJK.Size = new System.Drawing.Size(213, 28);
            this.cbxJK.TabIndex = 62;
            this.cbxJK.SelectedIndexChanged += new System.EventHandler(this.cbxJK_SelectedIndexChanged);
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 464);
            this.Controls.Add(this.cbxJK);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictBack);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIDAngg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDAnggota);
            this.Name = "Anggota";
            this.Text = "Anggota";
            this.Load += new System.EventHandler(this.Anggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictBack;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtIDAngg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtIDAnggota;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxJK;
    }
}
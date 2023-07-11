namespace UAS_A15
{
    partial class Data_Pengarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Pengarang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPeng = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.pictBack = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxJK = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pengarang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pengarang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telp";
            // 
            // txtIDPeng
            // 
            this.txtIDPeng.Location = new System.Drawing.Point(309, 208);
            this.txtIDPeng.Name = "txtIDPeng";
            this.txtIDPeng.Size = new System.Drawing.Size(213, 26);
            this.txtIDPeng.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(309, 260);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 26);
            this.txtNama.TabIndex = 4;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(309, 305);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(213, 26);
            this.txtNoTelp.TabIndex = 5;
            // 
            // pictBack
            // 
            this.pictBack.Image = ((System.Drawing.Image)(resources.GetObject("pictBack.Image")));
            this.pictBack.Location = new System.Drawing.Point(23, 367);
            this.pictBack.Name = "pictBack";
            this.pictBack.Size = new System.Drawing.Size(100, 50);
            this.pictBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBack.TabIndex = 10;
            this.pictBack.TabStop = false;
            this.pictBack.Click += new System.EventHandler(this.pictBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Jenis Kelamin";
            // 
            // cbxJK
            // 
            this.cbxJK.FormattingEnabled = true;
            this.cbxJK.Location = new System.Drawing.Point(309, 340);
            this.cbxJK.Name = "cbxJK";
            this.cbxJK.Size = new System.Drawing.Size(213, 28);
            this.cbxJK.TabIndex = 15;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(577, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 50);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(70, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(692, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 46);
            this.button3.TabIndex = 20;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Data_Pengarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbxJK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictBack);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIDPeng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pengarang";
            this.ShowIcon = false;
            this.Text = "Data_Pengarang";
            ((System.ComponentModel.ISupportInitialize)(this.pictBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPeng;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.PictureBox pictBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxJK;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
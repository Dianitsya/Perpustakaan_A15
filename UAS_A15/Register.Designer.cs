namespace UAS_A15
{
    partial class Register
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uASPABDDataSet1 = new UAS_A15.UASPABDDataSet1();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donaturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uASPABDDataSet = new UAS_A15.UASPABDDataSet();
            this.donaturTableAdapter = new UAS_A15.UASPABDDataSetTableAdapters.donaturTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.bukuTableAdapter = new UAS_A15.UASPABDDataSet1TableAdapters.bukuTableAdapter();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(129, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Registrasi";
            this.groupBox1.Enter += new System.EventHandler(this.Detail_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "judul_buku", true));
            this.txtPassword.Location = new System.Drawing.Point(226, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "buku";
            this.bukuBindingSource.DataSource = this.uASPABDDataSet1;
            // 
            // uASPABDDataSet1
            // 
            this.uASPABDDataSet1.DataSetName = "UASPABDDataSet1";
            this.uASPABDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuBindingSource, "id_buku", true));
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bukuBindingSource, "id_buku", true));
            this.txtUsername.Location = new System.Drawing.Point(226, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 26);
            this.txtUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // donaturBindingSource
            // 
            this.donaturBindingSource.DataMember = "donatur";
            this.donaturBindingSource.DataSource = this.uASPABDDataSet;
            // 
            // uASPABDDataSet
            // 
            this.uASPABDDataSet.DataSetName = "UASPABDDataSet";
            this.uASPABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donaturTableAdapter
            // 
            this.donaturTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(526, 293);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.DetailDonatur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UASPABDDataSet uASPABDDataSet;
        private System.Windows.Forms.BindingSource donaturBindingSource;
        private UASPABDDataSetTableAdapters.donaturTableAdapter donaturTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private UASPABDDataSet1 uASPABDDataSet1;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private UASPABDDataSet1TableAdapters.bukuTableAdapter bukuTableAdapter;
        private System.Windows.Forms.Button btnSubmit;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UAS_A15
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Detail_Enter(object sender, EventArgs e)
        {

        }

        private void DetailDonatur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASPABDDataSet1.buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.uASPABDDataSet1.buku);
            // TODO: This line of code loads data into the 'uASPABDDataSet.donatur' table. You can move, or remove it, as needed.
            this.donaturTableAdapter.Fill(this.uASPABDDataSet.donatur);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Regis(string username, string password)
        {
            // Menyimpan data ke dalam berkas teks
            using (StreamWriter writer = File.AppendText("data.txt"))
            {
                writer.WriteLine($"{username},{password}");
            }
            MessageBox.Show("Register berhasil!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                Regis(username, password);
                Form1 nextForm = new Form1();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        private bool log(string username, string password)
        {
            string filePath = "data.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    string storedUsername = data[0];
                    string storedPassword = data[1];

                    if (username == storedUsername && password == storedPassword)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat membaca data: {ex.Message}");
            }

            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string username = txtboxUser.Text;
            string password = txtboxPass.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (log(username, password))
                {
                    MessageBox.Show("Login berhasil!");
                    Menu nextForm = new Menu();
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");

                }

            }
        }
        

        private void txtboxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register nextForm = new Register();
            nextForm.Show();
            this.Hide();
        }
    }
    
}

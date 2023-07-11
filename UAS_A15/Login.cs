using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_A15
{
    public partial class Form1 : Form
    {
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

            if (username == "admin" && password == "123")
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
    
}

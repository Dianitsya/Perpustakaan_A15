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

        
        private void pictBuku_Click(object sender, EventArgs e)
        {
            Data_Buku nextForm = new Data_Buku();
            nextForm.Show();
            this.Hide();
        }

        private void pictAnggota_Click(object sender, EventArgs e)
        {
            Data_Anggota nextForm = new Data_Anggota();
            nextForm.Show();
            this.Hide();
        }

        private void pictDonatur_Click(object sender, EventArgs e)
        {
            Data_Donatur nextForm = new Data_Donatur();
            nextForm.Show();
            this.Hide();

        }
    }
}

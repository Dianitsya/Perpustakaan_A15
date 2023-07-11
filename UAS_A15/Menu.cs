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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictBuku_Click_1(object sender, EventArgs e)
        {
            Data_Buku nextForm = new Data_Buku();
            nextForm.Show();
            this.Hide();
        }

        private void pictDonatur_Click_1(object sender, EventArgs e)
        {
            Data_Pengarang nextForm = new Data_Pengarang();
            nextForm.Show();
            this.Hide();
        }
    }
}

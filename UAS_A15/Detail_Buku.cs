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
    public partial class Detail_Buku : Form
    {
        public Detail_Buku()
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

﻿using System;
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
    public partial class DetailDonatur : Form
    {
        public DetailDonatur()
        {
            InitializeComponent();
        }

        private void Detail_Enter(object sender, EventArgs e)
        {

        }

        private void DetailDonatur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASPABDDataSet.donatur' table. You can move, or remove it, as needed.
            this.donaturTableAdapter.Fill(this.uASPABDDataSet.donatur);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
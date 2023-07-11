using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Windows.Input;
using System.Collections;

namespace UAS_A15
{
    public partial class Data_Pengarang : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public Data_Pengarang()
        {
            InitializeComponent();
            string connectionString = "Data source = TASYA\\TASYA_MASTA; Initial Catalog = perpustakaan_A15; Persist Security Info = True; User ID = sa; Password = 123";
            connection = new SqlConnection(connectionString);
            dataGridView();
            cbJK();


        }

        private void cbJK()
        {
            cbxJK.Items.Add("P");
            cbxJK.Items.Add("L");
        }
        private void pictBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }



        private void pictOpen_Save(object sender, EventArgs e)
        {
            DetailDonatur nextForm = new DetailDonatur();
            nextForm.Show();
            this.Hide();
        }

        private void pictSave_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            connection.Open();
            string str = "select * from dbo.pengarang";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO pengarang (nama_pengarang, notelp_pengarang, jk_pengarang) 
            VALUES (@nama_pengarang, @notelp_pengarang, @jk_pengarang)";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nama_pengarang", txtNama.Text);
            command.Parameters.AddWithValue("@notelp_pengarang", txtNoTelp.Text);
            command.Parameters.AddWithValue("@jk_pengarang", cbxJK.SelectedItem.ToString());


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Table pengarang created successfully.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPeng.Text);

            string query = "DELETE FROM pengarang WHERE id_pengarang = @id_pengarang";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_pengarang", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Pengarang deleted successfully.");
        }

        
        
    }
}

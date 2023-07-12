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
    public partial class Donatur : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        public Donatur()
        {
            InitializeComponent();
            string connectionString = "Data source = TASYA\\TASYA_MASTA; Initial Catalog = perpustakaan_A15; Persist Security Info = True; User ID = sa; Password = 123";
            connection = new SqlConnection(connectionString);
            dataGridView();
            
        }
        private void dataGridView()
        {
            connection.Open();
            string str = "select * from dbo.donatur";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            connection.Close();
        }
        private void pictBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO donatur (nama_donatur, notelp_donatur) " +
            "VALUES (@nama_donatur, @notelp_donatur)";


            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama_donatur", txtNama.Text);
            cmd.Parameters.AddWithValue("@notelp_donatur", txtNoTelp.Text);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data created successfully.");

        }

        private void Donatur_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM donatur WHERE id_donatur = @id_donatur";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_donatur", txtIDDon.Text);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE donatur SET nama_donatur = @nama_donatur, notelp_donatur = @notelp_donatur, WHERE id_donatur = @id_donatur";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_donatur", int.Parse(txtIDDon.Text));
            cmd.Parameters.AddWithValue("@nama_donatur", txtNama.Text);
            cmd.Parameters.AddWithValue("@notelp_donatur", txtNoTelp.Text);
      
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Donatur updated successfully.");
        }
    }
}

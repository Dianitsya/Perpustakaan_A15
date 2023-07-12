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
    public partial class Petugas : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;

        public Petugas()
        {
            InitializeComponent();
            string connectionString = "Data source = TASYA\\TASYA_MASTA; Initial Catalog = perpustakaan_A15; Persist Security Info = True; User ID = sa; Password = 123";
            connection = new SqlConnection(connectionString);
            dataGridView();
        }
        private void dataGridView()
        {
            connection.Open();
            string str = "select * from dbo.petugas";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
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
            string query = @"INSERT INTO petugas (nama_petugas, notelp_petugas) " +
            "VALUES (@nama_petugas, @notelp_petugas)";


            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama_petugas", txtNama.Text);
            cmd.Parameters.AddWithValue("@notelp_petugas", txtNoTelp.Text);
            

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data created successfully.");
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASPABDDataSet2.petugas' table. You can move, or remove it, as needed.
            this.petugasTableAdapter.Fill(this.uASPABDDataSet2.petugas);

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM petugas WHERE id_petugas = @id_petugas";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_petugas", txtIDDon.Text);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDon.Text);

            string query = "DELETE FROM petugas WHERE id_petugas = @id_petugas";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_petugas", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Petugas deleted successfully.");
        }
    }
}

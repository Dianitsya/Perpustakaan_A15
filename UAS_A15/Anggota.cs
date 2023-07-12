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
    public partial class Anggota : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        public Anggota()
        {
            InitializeComponent();
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
        private void dataGridView()
        {
            connection.Open();
            string str = "select * from dbo.Anggota";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }
       

        private void Anggota_Load(object sender, EventArgs e)
        {

        }

        private void pictBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Anggota (nama_anggota, jk_anggota, notelp_anggota, alamat_anggota, tgl_pinjam, tgl_kembali) " +
            "VALUES (@nama_anggota, @jk_anggota, @notelp_anggota, @alamat_anggota, @tgl_pinjam, @tgl_kembali)";


            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama_anggota", txtNama.Text);
            cmd.Parameters.AddWithValue("@jk_anggota", cbxJK.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@notelp_anggota", txtNoTelp.Text);
            cmd.Parameters.AddWithValue("@alamat_anggota", txtAlamat.Text);
            cmd.Parameters.AddWithValue("@tgl_pinjam", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@tgl_kembali",dateTimePicker2.Value);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data created successfully.");

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Anggota WHERE id_anggota = @id_anggota";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_anggota", txtIDAngg.Text);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE buku SET nama_anggota = @nama_anggota, jk_anggota = @jk_anggota, notelp_anggota = @notelp_anggota, alamat_anggota = @alamat_anggota, tgl_pinjam = @tgl_pinjam, tgl_kembali = @tgl_kembali WHERE id_anggota = @id_anggota";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_anggota", int.Parse(txtIDAngg.Text));
            cmd.Parameters.AddWithValue("@nama_anggota", txtNama.Text);
            cmd.Parameters.AddWithValue("@jk_anggota", cbxJK.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@notelp_anggota", txtNoTelp.Text);
            cmd.Parameters.AddWithValue("@alamat_anggota", txtAlamat.Text);
            cmd.Parameters.AddWithValue("@tgl_pinjam", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@tgl_kembali", dateTimePicker2.Value);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Anggota updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDAngg.Text);

            string query = "DELETE FROM Anggota WHERE id_anggota = @id_anggota";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_anggota", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Anggota deleted successfully.");
        }
    }
}

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
    public partial class Data_Buku : Form
    {
        private SqlConnection connection;
        private SqlCommand cmd;

        public Data_Buku()
        {
            InitializeComponent();
            string connectionString = "Data source = TASYA\\TASYA_MASTA; Initial Catalog = perpustakaan_A15; Persist Security Info = True; User ID = sa; Password = 123";
            connection = new SqlConnection(connectionString);
            dataGridView();
            cbTahunTerbit();
            cbKat();
        }
        private void dataGridView()
        {
            connection.Open();
            string str = "select * from dbo.buku";
            SqlDataAdapter da = new SqlDataAdapter(str, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            connection.Close();
        }
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictBack_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void cbxPengarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM buku WHERE id_buku = @id_buku";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_buku", txtIDBuku.Text);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void Data_Buku_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO buku (judul_buku, id_pengarang, kategori, penerbit, tahun_terbit) " +
            "VALUES (@judul_buku, @id_pengarang, @kategori, @penerbit, @tahun_terbit)";
            
           
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@judul_buku", txtJdlBuku.Text);
            cmd.Parameters.AddWithValue("@id_pengarang", txtIDPen.Text);
            cmd.Parameters.AddWithValue("@kategori", cbxKat.SelectedItem);
            cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
            cmd.Parameters.AddWithValue("@tahun_terbit", cbxTahunTerbit.SelectedItem?.ToString());

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data created successfully.");
        }
            

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDBuku.Text);

            string query = "DELETE FROM buku WHERE id_buku = @id_buku";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_buku", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Pengarang deleted successfully.");

        }
        
        private void cbKat()
        {
            cbxKat.Items.Add("Horor");
            cbxKat.Items.Add("Romantis");
            cbxKat.Items.Add("Komedi");
        }
        private void cbTahunTerbit()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxTahunTerbit.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    cbxTahunTerbit.Items.Add(l.ToString());
                }
            }
        }

       


        private void pictOpen_Click(object sender, EventArgs e)
        {

        }

        private void txtIDBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE buku SET judul_buku = @judul_buku, id_pengarang = @id_pengarang, kategori = @kategori, penerbit = @penerbit, tahun_terbit = @tahun_terbit WHERE id_buku = @id_buku";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_buku", int.Parse(txtIDBuku.Text));
            cmd.Parameters.AddWithValue("@judul_buku", txtJdlBuku.Text);
            cmd.Parameters.AddWithValue("@id_pengarang", txtIDPen.Text);
            cmd.Parameters.AddWithValue("@kategori", cbxKat.Text);
            cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
            cmd.Parameters.AddWithValue("@tahun_terbit", cbxTahunTerbit.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data pengarang updated successfully.");
        }
    }
}

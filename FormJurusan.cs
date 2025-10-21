using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormJurusan : Form
    {

        string koneksiString = "server=localhost;database=db_latihangtihub_form;uid=root;pwd=;";
        MySqlConnection koneksi;

        public FormJurusan()
        {
            InitializeComponent();
        }


        private void clear()
        {
            txbKodeJurusan.Clear();
            txbJurusan.Clear();
            txbJurusan.Focus();
           

        }

        private void TampilData()
        {
            try
            {
                koneksi = new MySqlConnection(koneksiString);
                koneksi.Open();

                string query = @"SELECT s.Nisn, s.Nama_Siswa, s.Alamat, j.Jurusan 
                                FROM siswa s 
                                JOIN jurusan j ON s.Id_Jurusan = j.Id_Jurusan"; string query = @"SELECT s.Nisn, s.Nama_Siswa, s.Alamat, j.Jurusan 
                                FROM siswa s 
                                JOIN jurusan j ON s.Id_Jurusan = j.Id_Jurusan";

                string query = @"SELECT s.Nisn, s.Nama_Siswa, s.Alamat, j.Jurusan 
                                FROM siswa s 
                                JOIN jurusan j ON s.Id_Jurusan = j.Id_Jurusan";


                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvJurusan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (koneksi != null)
                    koneksi.Close();
            }
        }


        private void refreshData()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=db_latihangtihub_form;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "SELECT * FROM jurusan";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvJurusan.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormJurusan_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi = new MySqlConnection(koneksiString);
                koneksi.Open();

                string query = "INSERT INTO jurusan (Id_Jurusan, Jurusan)" +
                    "VALUES (@id,  @jurusan)";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@id", txbKodeJurusan.Text);
                cmd.Parameters.AddWithValue("@jurusan", txbJurusan.Text);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!", "Informasi");
                clear();
                TampilData();// refresh data di DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (koneksi != null)
                    koneksi.Close();
            }


        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (dgvJurusan.SelectedRows.Count > 0)
            {
                string id = dgvJurusan.SelectedRows[0].Cells["Id_Jurusan"].Value.ToString();

                try
                {
                    koneksi = new MySqlConnection(koneksiString);
                    koneksi.Open();

                    String query = "DELETE FROM jurusan WHERE Id_Jurusan=@id";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus!", "Informasi");
                    TampilData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally
                {
                    if (koneksi != null)
                        koneksi.Close();

                }
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormSiswa : Form
    {
        // String koneksi database
        string connectionString = "Server=localhost;Database=db_latihangtihub_form;Uid=root;Pwd=;";

        public FormSiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            LoadJurusan();
            LoadDataSiswa();

            button1.Click += Button1_Click;
            button3.Click += Button3_Click;
        }

        // Load Jurusan ke ComboBox
        void LoadJurusan()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT Id_Jurusan, Jurusan FROM jurusan";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Jurusan";
                comboBox1.ValueMember = "Id_Jurusan";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Load Data Siswa ke DataGridView
        void LoadDataSiswa()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"SELECT s.NISN, s.Nama_Siswa, s.Alamat, j.Jurusan 
                                FROM siswa s 
                                JOIN jurusan j ON s.Id_Jurusan = j.Id_Jurusan";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Tombol Simpan
        void Button1_Click(object sender, EventArgs e)
        {
            // Validasi
            if (textBox1.Text == "")
            {
                MessageBox.Show("NISN harus diisi!");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Nama harus diisi!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Alamat harus diisi!");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Jurusan harus dipilih!");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                // Cek NISN sudah ada atau belum
                string cek = "SELECT COUNT(*) FROM siswa WHERE NISN='" + textBox1.Text + "'";
                MySqlCommand cmdCek = new MySqlCommand(cek, conn);
                int count = Convert.ToInt32(cmdCek.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("NISN sudah terdaftar!");
                    return;
                }

                // Simpan data
                string query = "INSERT INTO siswa (NISN, Nama_Siswa, Alamat, Id_Jurusan) VALUES (@nisn, @nama, @alamat, @jurusan)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nisn", textBox1.Text);
                cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox3.Text);
                cmd.Parameters.AddWithValue("@jurusan", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!");

                // Bersihkan form dan refresh data
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                LoadDataSiswa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Tombol Kembali
        void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
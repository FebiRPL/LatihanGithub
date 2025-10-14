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

namespace LatihanGithub
{
    public partial class FormJurusan : Form
    {
        public FormJurusan()
        {
            InitializeComponent();
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
            DialogResult hasil = MessageBox.Show("yakin ingin menyimpan data?",
             "Konfirmasi", MessageBoxButtons.YesNo);

            if (hasil == DialogResult.Yes)
            {
                string[] datainput =
           {
                txbKodeJurusan.Text,
                txbKodeJurusan.Text,
               
            };
                dgvJurusan.Rows.Add(datainput);
                MessageBox.Show("Simpan berhasil");
                txbKodeJurusan.Clear();
                txbJurusan.Clear();
              
            }
            if (hasil == DialogResult.No)
            {
                MessageBox.Show("simpan dibatalkan");
            }
        }
    }
}

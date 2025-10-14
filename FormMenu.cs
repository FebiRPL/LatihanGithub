using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            FormJurusan f = new FormJurusan();
            f.ShowDialog();
            this.Hide();
        }

        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            FormSiswa f = new FormSiswa();
            f.ShowDialog();
            this.Hide();
        }
    }
}

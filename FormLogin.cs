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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBuser.Text == "")
            {
                MessageBox.Show("Username Tidak boleh kosong");
                TBuser.Focus();
            }

            if (TBPassword.Text == "")
            {
                MessageBox.Show("Password Tidak boleh kosong");
                TBPassword.Focus();
                return;
            }

            if (TBuser.Text == "Admin" && TBPassword.Text == "1234")
            {
                MessageBox.Show("Login Succes");
                FormMenu form1 = new FormMenu();
                form1.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
                TBuser.Text = "";
                TBPassword.Clear();
                TBuser.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

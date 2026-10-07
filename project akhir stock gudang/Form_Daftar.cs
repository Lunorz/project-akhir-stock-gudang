using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class Form_Daftar : Form
    {
        public Form_Daftar()
        {
            InitializeComponent();
        }

        private void Form_Daftar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reg_lihat_password_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_lihat_password.Checked)
            {
                reg_password.UseSystemPasswordChar = false;
            }
            else
            {
                reg_password.UseSystemPasswordChar = true;
            }
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1();
            kembali.Show();
            this.Hide();
        }

        private void reg_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombol_login_Click(object sender, EventArgs e)
        {
            string username = reg_nama.Text;
            string password = reg_password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("username dan password wajib diisi!");
                return;
            }

            bool berhasil = UserStore.Register(username, password);

            if (berhasil)
            {
                MessageBox.Show("Pendaftaran berhasil!silahkan login.");

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username sudah digunakan");
            }
        }
    }
}

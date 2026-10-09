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
    public partial class Dashboard_Keranjang : Form
    {
        public Dashboard_Keranjang()
        {
            InitializeComponent();
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 back7 = new Dashboard_User1();
            back7.Show();
            this.Hide();
        }

        private void Dashboard_Keranjang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_tulis_Click(object sender, EventArgs e)
        {
            Dashboard_User2 back8 = new Dashboard_User2();
            back8.Show();
            this.Hide();
        }

        private void tombol_perlengkapan_sekolah_Click(object sender, EventArgs e)
        {
            Dashboard_User3 back9 = new Dashboard_User3();
            back9.Show();
            this.Hide();
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 back20 = new Form1();
            back20.Show();
            this.Hide();
        }
    }
}

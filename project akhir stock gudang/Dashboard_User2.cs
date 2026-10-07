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
    public partial class Dashboard_User2 : Form
    {
        private int jumlahbolpoin = 1;
        private int jumlahpensil2B = 1;
        private int jumlahpenghapus = 1;
        private int jumlahtipeX = 1;
        private int jumlahstabilo = 1;
        private int jumlahbukutulis = 1;
        public Dashboard_User2()
        {
            InitializeComponent();
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void Dashboard_User2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 kembali_alat_gambar = new Dashboard_User1();
            kembali_alat_gambar.Show();
            this.Hide();
        }

        private void kurang_bolpoin_Click(object sender, EventArgs e)
        {
            if (jumlahbolpoin > 1)
            {
                jumlahbolpoin--;
                jumlah_beli_bolpoin.Text = jumlahbolpoin.ToString();
            }
        }

        private void tambah_bolpoin_Click(object sender, EventArgs e)
        {
            jumlahbolpoin++;
            jumlah_beli_bolpoin.Text = jumlahbolpoin.ToString();
        }

        private void kurang_pensil_2B_Click(object sender, EventArgs e)
        {
            if (jumlahpensil2B > 1)
            {
                jumlahpensil2B--;
                jumlah_beli_pensil_2B.Text = jumlahpensil2B.ToString();
            }
        }

        private void tambah_pensil_2B_Click(object sender, EventArgs e)
        {
            jumlahpensil2B++;
            jumlah_beli_pensil_2B.Text = jumlahpensil2B.ToString();
        }

        private void kurang_krayon_Click(object sender, EventArgs e)
        {
            if (jumlahpenghapus > 1)
            {
                jumlahpenghapus--;
                jumlah_beli_penghapus.Text = jumlahpenghapus.ToString();
            }
        }

        private void tambah_penghapus_Click(object sender, EventArgs e)
        {
            jumlahpenghapus++;
            jumlah_beli_penghapus.Text = jumlahpenghapus.ToString();
        }

        private void kurang_tipe_x_Click(object sender, EventArgs e)
        {
            if (jumlahtipeX > 1)
            {
                jumlahtipeX--;
                jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
            }
        }

        private void tambah_tipe_x_Click(object sender, EventArgs e)
        {
            jumlahtipeX++;
            jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
        }

        private void kurang_stabilo_Click(object sender, EventArgs e)
        {
            if (jumlahstabilo > 1)
            {
                jumlahstabilo--;
                jumlah_beli_stabilo.Text = jumlahstabilo.ToString();
            }
        }

        private void tambah_stabilo_Click(object sender, EventArgs e)
        {
            jumlahstabilo++;
            jumlah_beli_stabilo.Text = jumlahstabilo.ToString();
        }

        private void kurang_buku_tulis_Click(object sender, EventArgs e)
        {
            if (jumlahbukutulis > 1)
            {
                jumlahbukutulis--;
                jumlah_beli_buku_tulis.Text = jumlahbukutulis.ToString();
            }
        }

        private void tambah_buku_tulis_Click(object sender, EventArgs e)
        {
            jumlahbukutulis++;
            jumlah_beli_buku_tulis.Text = jumlahbukutulis.ToString();
        }

        private void tombol_perlengkapan_sekolah_Click(object sender, EventArgs e)
        {
            Dashboard_User3 Menuju2 = new Dashboard_User3();
            Menuju2.Show();
            this.Hide();
        }
    }
}

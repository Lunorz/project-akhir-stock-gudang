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
    public partial class Dashboard_User3 : Form
    {
        public Dashboard_User3()
        {
            InitializeComponent();
        }

        private void Dashboard_User3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 kembali1 = new Dashboard_User1();
            kembali1.Show();
            this.Hide();
        }

        private void tombol_alat_tulis_Click(object sender, EventArgs e)
        {
            Dashboard_User2 kembali2 = new Dashboard_User2();
            kembali2.Show();
            this.Hide();
        }
    }
}

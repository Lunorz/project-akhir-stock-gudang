namespace project_akhir_stock_gudang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lihat_password_CheckedChanged(object sender, EventArgs e)
        {
            if (lihat_password.Checked)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tombol_login_Click(object sender, EventArgs e)
        {
         
        }
    }
}

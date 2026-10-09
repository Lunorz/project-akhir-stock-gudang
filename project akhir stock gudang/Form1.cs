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
            string username = textnama.Text;
            string password = textpassword.Text;

            if (username == "admin" && password == "admin758150")
            {
                MessageBox.Show("login berhasil! selamat datang di panel admin");
                panel_admin panel = new panel_admin();
                panel.Show();
                this.Hide();
            }


            if (username == "" || password == "")
            {
                MessageBox.Show("username dan password wajib diisi!");
                return;
            }

            bool valid = UserStore.ValidateLogin(username, password);

            if (valid)
            {
                MessageBox.Show("Login berhasil!");

                Dashboard_User1 dashboard = new Dashboard_User1();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("username atau password salah!");
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form_Daftar daftar = new Form_Daftar();
            daftar.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}

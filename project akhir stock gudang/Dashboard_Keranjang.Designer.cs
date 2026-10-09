namespace project_akhir_stock_gudang
{
    partial class Dashboard_Keranjang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Keranjang));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            kembali_ke_login = new Label();
            panel2 = new Panel();
            tombol_keranjang = new Button();
            tombol_perlengkapan_sekolah = new Button();
            tombol_alat_tulis = new Button();
            tombol_alat_gambar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 639);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(kembali_ke_login);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 67);
            panel3.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-3, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(328, 67);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // kembali_ke_login
            // 
            kembali_ke_login.AutoSize = true;
            kembali_ke_login.Location = new Point(1170, 25);
            kembali_ke_login.Name = "kembali_ke_login";
            kembali_ke_login.Size = new Size(23, 25);
            kembali_ke_login.TabIndex = 0;
            kembali_ke_login.Text = "X";
            kembali_ke_login.Click += kembali_ke_login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tombol_keranjang);
            panel2.Controls.Add(tombol_perlengkapan_sekolah);
            panel2.Controls.Add(tombol_alat_tulis);
            panel2.Controls.Add(tombol_alat_gambar);
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 573);
            panel2.TabIndex = 0;
            // 
            // tombol_keranjang
            // 
            tombol_keranjang.BackColor = Color.Teal;
            tombol_keranjang.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_keranjang.ForeColor = Color.White;
            tombol_keranjang.Location = new Point(-3, 201);
            tombol_keranjang.Name = "tombol_keranjang";
            tombol_keranjang.Size = new Size(328, 72);
            tombol_keranjang.TabIndex = 3;
            tombol_keranjang.Text = "Keranjang";
            tombol_keranjang.UseVisualStyleBackColor = false;
            // 
            // tombol_perlengkapan_sekolah
            // 
            tombol_perlengkapan_sekolah.BackColor = Color.White;
            tombol_perlengkapan_sekolah.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_perlengkapan_sekolah.ForeColor = Color.Black;
            tombol_perlengkapan_sekolah.Location = new Point(-3, 136);
            tombol_perlengkapan_sekolah.Name = "tombol_perlengkapan_sekolah";
            tombol_perlengkapan_sekolah.Size = new Size(328, 68);
            tombol_perlengkapan_sekolah.TabIndex = 2;
            tombol_perlengkapan_sekolah.Text = "Perlengkapan Sekolah";
            tombol_perlengkapan_sekolah.UseVisualStyleBackColor = false;
            tombol_perlengkapan_sekolah.Click += tombol_perlengkapan_sekolah_Click;
            // 
            // tombol_alat_tulis
            // 
            tombol_alat_tulis.BackColor = Color.White;
            tombol_alat_tulis.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_alat_tulis.ForeColor = Color.Black;
            tombol_alat_tulis.Location = new Point(-3, 68);
            tombol_alat_tulis.Name = "tombol_alat_tulis";
            tombol_alat_tulis.Size = new Size(328, 72);
            tombol_alat_tulis.TabIndex = 1;
            tombol_alat_tulis.Text = "Alat Tulis";
            tombol_alat_tulis.UseVisualStyleBackColor = false;
            tombol_alat_tulis.Click += tombol_alat_tulis_Click;
            // 
            // tombol_alat_gambar
            // 
            tombol_alat_gambar.BackColor = Color.White;
            tombol_alat_gambar.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_alat_gambar.ForeColor = Color.Black;
            tombol_alat_gambar.Location = new Point(-3, 0);
            tombol_alat_gambar.Name = "tombol_alat_gambar";
            tombol_alat_gambar.Size = new Size(328, 72);
            tombol_alat_gambar.TabIndex = 0;
            tombol_alat_gambar.Text = "Alat Gambar";
            tombol_alat_gambar.UseVisualStyleBackColor = false;
            tombol_alat_gambar.Click += tombol_alat_gambar_Click;
            // 
            // Dashboard_Keranjang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 639);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Keranjang";
            Text = "Dashboard_Keranjang";
            FormClosed += Dashboard_Keranjang_FormClosed;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox7;
        private Label kembali_ke_login;
        private Panel panel2;
        private Button tombol_keranjang;
        private Button tombol_perlengkapan_sekolah;
        private Button tombol_alat_tulis;
        private Button tombol_alat_gambar;
    }
}
namespace project_akhir_stock_gudang
{
    partial class Form_Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Daftar));
            panel1 = new Panel();
            kembali_ke_login = new Label();
            reg_lihat_password = new CheckBox();
            tombol_login = new Button();
            reg_password = new TextBox();
            reg_nama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(kembali_ke_login);
            panel1.Controls.Add(reg_lihat_password);
            panel1.Controls.Add(tombol_login);
            panel1.Controls.Add(reg_password);
            panel1.Controls.Add(reg_nama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-5, -28);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 481);
            panel1.TabIndex = 1;
            // 
            // kembali_ke_login
            // 
            kembali_ke_login.AutoSize = true;
            kembali_ke_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_ke_login.Location = new Point(686, 37);
            kembali_ke_login.Name = "kembali_ke_login";
            kembali_ke_login.Size = new Size(24, 25);
            kembali_ke_login.TabIndex = 9;
            kembali_ke_login.Text = "X";
            kembali_ke_login.Click += kembali_ke_login_Click;
            // 
            // reg_lihat_password
            // 
            reg_lihat_password.AutoSize = true;
            reg_lihat_password.Location = new Point(546, 293);
            reg_lihat_password.Name = "reg_lihat_password";
            reg_lihat_password.Size = new Size(153, 29);
            reg_lihat_password.TabIndex = 8;
            reg_lihat_password.Text = "lihat password";
            reg_lihat_password.UseVisualStyleBackColor = true;
            reg_lihat_password.CheckedChanged += reg_lihat_password_CheckedChanged;
            // 
            // tombol_login
            // 
            tombol_login.BackColor = Color.IndianRed;
            tombol_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_login.Location = new Point(587, 340);
            tombol_login.Name = "tombol_login";
            tombol_login.Size = new Size(112, 53);
            tombol_login.TabIndex = 6;
            tombol_login.Text = "daftar";
            tombol_login.UseVisualStyleBackColor = false;
            tombol_login.Click += tombol_login_Click;
            // 
            // reg_password
            // 
            reg_password.Location = new Point(331, 254);
            reg_password.Name = "reg_password";
            reg_password.PlaceholderText = "masukkan password";
            reg_password.Size = new Size(358, 31);
            reg_password.TabIndex = 5;
            reg_password.UseSystemPasswordChar = true;
            // 
            // reg_nama
            // 
            reg_nama.Location = new Point(331, 181);
            reg_nama.Name = "reg_nama";
            reg_nama.PlaceholderText = "masukkan username";
            reg_nama.Size = new Size(358, 31);
            reg_nama.TabIndex = 4;
            reg_nama.TextChanged += reg_nama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 226);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 153);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 73);
            label1.Name = "label1";
            label1.Size = new Size(310, 23);
            label1.TabIndex = 1;
            label1.Text = "selamat datang di gudangkita!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 515);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(118, 302);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 2;
            label5.Text = "V 0.1.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(95, 279);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 1;
            label4.Text = "gudangkita";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form_Daftar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 452);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Daftar";
            Text = "Form_Daftar";
            FormClosed += Form_Daftar_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox reg_lihat_password;
        private Button tombol_login;
        private TextBox reg_password;
        private TextBox reg_nama;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label kembali_ke_login;
    }
}
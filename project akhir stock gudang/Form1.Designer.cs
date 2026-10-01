namespace project_akhir_stock_gudang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lihat_password = new CheckBox();
            tombol_batal = new Button();
            tombol_login = new Button();
            textpassword = new TextBox();
            textnama = new TextBox();
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
            panel1.Controls.Add(lihat_password);
            panel1.Controls.Add(tombol_batal);
            panel1.Controls.Add(tombol_login);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(textnama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-5, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 532);
            panel1.TabIndex = 0;
            // 
            // lihat_password
            // 
            lihat_password.AutoSize = true;
            lihat_password.Location = new Point(546, 293);
            lihat_password.Name = "lihat_password";
            lihat_password.Size = new Size(153, 29);
            lihat_password.TabIndex = 8;
            lihat_password.Text = "lihat password";
            lihat_password.UseVisualStyleBackColor = true;
            lihat_password.CheckedChanged += lihat_password_CheckedChanged;
            // 
            // tombol_batal
            // 
            tombol_batal.BackColor = Color.IndianRed;
            tombol_batal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_batal.Location = new Point(476, 328);
            tombol_batal.Name = "tombol_batal";
            tombol_batal.Size = new Size(112, 53);
            tombol_batal.TabIndex = 7;
            tombol_batal.Text = "batal";
            tombol_batal.UseVisualStyleBackColor = false;
            tombol_batal.Click += tombol_batal_Click;
            // 
            // tombol_login
            // 
            tombol_login.BackColor = Color.IndianRed;
            tombol_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_login.Location = new Point(587, 328);
            tombol_login.Name = "tombol_login";
            tombol_login.Size = new Size(112, 53);
            tombol_login.TabIndex = 6;
            tombol_login.Text = "login";
            tombol_login.UseVisualStyleBackColor = false;
            tombol_login.Click += tombol_login_Click;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(331, 254);
            textpassword.Name = "textpassword";
            textpassword.PlaceholderText = "masukkan password";
            textpassword.Size = new Size(358, 31);
            textpassword.TabIndex = 5;
            textpassword.UseSystemPasswordChar = true;
            textpassword.TextChanged += textBox2_TextChanged;
            // 
            // textnama
            // 
            textnama.Location = new Point(331, 181);
            textnama.Name = "textnama";
            textnama.PlaceholderText = "masukkan username";
            textnama.Size = new Size(358, 31);
            textnama.TabIndex = 4;
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
            label3.Click += label3_Click;
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
            label1.Location = new Point(360, 43);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 503);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textpassword;
        private TextBox textnama;
        private Label label3;
        private Button tombol_batal;
        private Button tombol_login;
        private CheckBox lihat_password;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}

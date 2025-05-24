namespace project_ecoranger.Views
{
    partial class UcRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cbRole = new ComboBox();
            tbKabupaten = new TextBox();
            tbKecamatan = new TextBox();
            tbPassword = new TextBox();
            tbDesa = new TextBox();
            tbJalan = new TextBox();
            tbKonfirmasiPw = new TextBox();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbNomorTelepon = new TextBox();
            tbNama = new TextBox();
            btnRegister = new Panel();
            btnToLogin = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.formRegisterPage;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(tbKabupaten);
            panel1.Controls.Add(tbKecamatan);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbDesa);
            panel1.Controls.Add(tbJalan);
            panel1.Controls.Add(tbKonfirmasiPw);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbNomorTelepon);
            panel1.Controls.Add(tbNama);
            panel1.Location = new Point(189, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 552);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FlatStyle = FlatStyle.Popup;
            cbRole.Font = new Font("Segoe UI", 14F);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(51, 498);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(397, 33);
            cbRole.TabIndex = 0;
            // 
            // tbKabupaten
            // 
            tbKabupaten.BorderStyle = BorderStyle.None;
            tbKabupaten.Font = new Font("Segoe UI", 14F);
            tbKabupaten.Location = new Point(1088, 399);
            tbKabupaten.Name = "tbKabupaten";
            tbKabupaten.Size = new Size(397, 25);
            tbKabupaten.TabIndex = 9;
            // 
            // tbKecamatan
            // 
            tbKecamatan.BorderStyle = BorderStyle.None;
            tbKecamatan.Font = new Font("Segoe UI", 14F);
            tbKecamatan.Location = new Point(1088, 292);
            tbKecamatan.Name = "tbKecamatan";
            tbKecamatan.Size = new Size(397, 25);
            tbKecamatan.TabIndex = 8;
            tbKecamatan.TextChanged += textBox1_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 14F);
            tbPassword.Location = new Point(564, 292);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(397, 25);
            tbPassword.TabIndex = 7;
            // 
            // tbDesa
            // 
            tbDesa.BorderStyle = BorderStyle.None;
            tbDesa.Font = new Font("Segoe UI", 14F);
            tbDesa.Location = new Point(1088, 191);
            tbDesa.Name = "tbDesa";
            tbDesa.Size = new Size(397, 25);
            tbDesa.TabIndex = 6;
            // 
            // tbJalan
            // 
            tbJalan.BorderStyle = BorderStyle.None;
            tbJalan.Font = new Font("Segoe UI", 14F);
            tbJalan.Location = new Point(564, 500);
            tbJalan.Name = "tbJalan";
            tbJalan.Size = new Size(397, 25);
            tbJalan.TabIndex = 5;
            // 
            // tbKonfirmasiPw
            // 
            tbKonfirmasiPw.BorderStyle = BorderStyle.None;
            tbKonfirmasiPw.Font = new Font("Segoe UI", 14F);
            tbKonfirmasiPw.Location = new Point(564, 399);
            tbKonfirmasiPw.Name = "tbKonfirmasiPw";
            tbKonfirmasiPw.Size = new Size(397, 25);
            tbKonfirmasiPw.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 14F);
            tbUsername.Location = new Point(564, 191);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(397, 25);
            tbUsername.TabIndex = 3;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 14F);
            tbEmail.Location = new Point(51, 403);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(397, 25);
            tbEmail.TabIndex = 2;
            // 
            // tbNomorTelepon
            // 
            tbNomorTelepon.BorderStyle = BorderStyle.None;
            tbNomorTelepon.Font = new Font("Segoe UI", 14F);
            tbNomorTelepon.Location = new Point(51, 292);
            tbNomorTelepon.Name = "tbNomorTelepon";
            tbNomorTelepon.Size = new Size(397, 25);
            tbNomorTelepon.TabIndex = 1;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Segoe UI", 14F);
            tbNama.Location = new Point(51, 191);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(397, 25);
            tbNama.TabIndex = 0;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackgroundImage = Properties.Resources.btnRegisterStartPage;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Location = new Point(766, 717);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(384, 122);
            btnRegister.TabIndex = 0;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnToLogin
            // 
            btnToLogin.BackgroundImage = Properties.Resources.NotesRegisterPage;
            btnToLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnToLogin.Location = new Point(833, 840);
            btnToLogin.Name = "btnToLogin";
            btnToLogin.Size = new Size(224, 38);
            btnToLogin.TabIndex = 1;
            btnToLogin.Click += btnToLogin_Click;
            // 
            // UcRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(btnToLogin);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            Name = "UcRegister";
            Size = new Size(1920, 1060);
            Load += UcRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel btnRegister;
        private Panel btnToLogin;
        private TextBox tbNama;
        private TextBox tbDesa;
        private TextBox tbJalan;
        private TextBox tbKonfirmasiPw;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbNomorTelepon;
        private TextBox tbKecamatan;
        private TextBox tbPassword;
        private TextBox tbKabupaten;
        private ComboBox cbRole;
    }
}

namespace project_ecoranger.Views
{
    partial class UcDataDiriPenyuplai
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
            panel9 = new Panel();
            btnLogout = new Panel();
            BtnKeuangan = new Panel();
            btnHistoryPenyuplai = new Panel();
            btnTransaksi = new Panel();
            btnDataDiri = new Panel();
            btnDashboard = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            alamat = new Label();
            panel4 = new Panel();
            btnEditAlamat = new Panel();
            btnEditDataNama = new Panel();
            email = new Label();
            nomorHp = new Label();
            nama = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboardFill;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(BtnKeuangan);
            panel1.Controls.Add(btnHistoryPenyuplai);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnDataDiri);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 1060);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Teal;
            panel9.Cursor = Cursors.No;
            panel9.Location = new Point(3, 256);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 52);
            panel9.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = Properties.Resources.LogoutLogo;
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Location = new Point(26, 952);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(186, 38);
            btnLogout.TabIndex = 6;
            btnLogout.Click += btnLogout_Click;
            // 
            // BtnKeuangan
            // 
            BtnKeuangan.BackColor = Color.Transparent;
            BtnKeuangan.BackgroundImage = Properties.Resources.btnKeuangan;
            BtnKeuangan.BackgroundImageLayout = ImageLayout.Zoom;
            BtnKeuangan.Location = new Point(36, 424);
            BtnKeuangan.Name = "BtnKeuangan";
            BtnKeuangan.Size = new Size(191, 30);
            BtnKeuangan.TabIndex = 5;
            BtnKeuangan.Click += BtnKeuangan_Click;
            // 
            // btnHistoryPenyuplai
            // 
            btnHistoryPenyuplai.BackColor = Color.Transparent;
            btnHistoryPenyuplai.BackgroundImage = Properties.Resources.btnHistory;
            btnHistoryPenyuplai.BackgroundImageLayout = ImageLayout.Zoom;
            btnHistoryPenyuplai.Location = new Point(42, 363);
            btnHistoryPenyuplai.Name = "btnHistoryPenyuplai";
            btnHistoryPenyuplai.Size = new Size(185, 50);
            btnHistoryPenyuplai.TabIndex = 4;
            btnHistoryPenyuplai.Click += btnHistoryPenyuplai_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.Transparent;
            btnTransaksi.BackgroundImage = Properties.Resources.btnDashboardTransaksi;
            btnTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksi.Location = new Point(42, 312);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(157, 50);
            btnTransaksi.TabIndex = 3;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnDataDiri
            // 
            btnDataDiri.BackColor = Color.Transparent;
            btnDataDiri.BackgroundImage = Properties.Resources.btnDataDiri;
            btnDataDiri.BackgroundImageLayout = ImageLayout.Zoom;
            btnDataDiri.Location = new Point(32, 269);
            btnDataDiri.Name = "btnDataDiri";
            btnDataDiri.Size = new Size(177, 31);
            btnDataDiri.TabIndex = 2;
            btnDataDiri.Click += btnDataDiri_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImage = Properties.Resources.dashboardLogo;
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Location = new Point(43, 218);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(169, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.EcoPenyuplai;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 100);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.tittleDataDiri;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(393, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 71);
            panel3.TabIndex = 1;
            // 
            // alamat
            // 
            alamat.AutoSize = true;
            alamat.BackColor = Color.Transparent;
            alamat.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            alamat.ForeColor = SystemColors.Control;
            alamat.Location = new Point(50, 240);
            alamat.Name = "alamat";
            alamat.Size = new Size(85, 33);
            alamat.TabIndex = 2;
            alamat.Text = "alamat";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.fillDataDiri;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnEditAlamat);
            panel4.Controls.Add(btnEditDataNama);
            panel4.Controls.Add(email);
            panel4.Controls.Add(nomorHp);
            panel4.Controls.Add(nama);
            panel4.Controls.Add(alamat);
            panel4.Location = new Point(393, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(1449, 430);
            panel4.TabIndex = 3;
            // 
            // btnEditAlamat
            // 
            btnEditAlamat.BackgroundImage = Properties.Resources.btnEditDataDiri;
            btnEditAlamat.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditAlamat.Location = new Point(1350, 240);
            btnEditAlamat.Name = "btnEditAlamat";
            btnEditAlamat.Size = new Size(47, 45);
            btnEditAlamat.TabIndex = 8;
            btnEditAlamat.Click += btnEditAlamat_Click;
            // 
            // btnEditDataNama
            // 
            btnEditDataNama.BackgroundImage = Properties.Resources.btnEditDataDiri;
            btnEditDataNama.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditDataNama.Location = new Point(1350, 55);
            btnEditDataNama.Name = "btnEditDataNama";
            btnEditDataNama.Size = new Size(47, 45);
            btnEditDataNama.TabIndex = 7;
            btnEditDataNama.Click += btnEditDataNama_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.Control;
            email.Location = new Point(50, 180);
            email.Name = "email";
            email.Size = new Size(73, 33);
            email.TabIndex = 6;
            email.Text = "email";
            // 
            // nomorHp
            // 
            nomorHp.AutoSize = true;
            nomorHp.BackColor = Color.Transparent;
            nomorHp.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nomorHp.ForeColor = SystemColors.Control;
            nomorHp.Location = new Point(50, 120);
            nomorHp.Name = "nomorHp";
            nomorHp.Size = new Size(111, 33);
            nomorHp.TabIndex = 5;
            nomorHp.Text = "nomorHp";
            nomorHp.Click += label3_Click;
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.BackColor = Color.Transparent;
            nama.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nama.ForeColor = SystemColors.Control;
            nama.Location = new Point(50, 60);
            nama.Name = "nama";
            nama.Size = new Size(71, 33);
            nama.TabIndex = 4;
            nama.Text = "nama";
            // 
            // UcDataDiriPenyuplai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UcDataDiriPenyuplai";
            Size = new Size(1920, 1060);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel btnDashboard;
        private Panel BtnKeuangan;
        private Panel btnHistoryPenyuplai;
        private Panel btnTransaksi;
        private Panel btnDataDiri;
        private Panel btnLogout;
        private Panel panel9;
        private Panel panel3;
        private Label alamat;
        private Panel panel4;
        private Label email;
        private Label nomorHp;
        private Label nama;
        private Panel btnEditAlamat;
        private Panel btnEditDataNama;
    }
}

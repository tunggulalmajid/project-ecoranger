namespace project_ecoranger.Views
{
    partial class UcKelolaLaporan
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
            BtnHistory = new Panel();
            btnLaporan = new Panel();
            btnPenyuplai = new Panel();
            btnSubKategori = new Panel();
            btnDashboard = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboardFill;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(BtnHistory);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPenyuplai);
            panel1.Controls.Add(btnSubKategori);
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
            panel9.Location = new Point(0, 388);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 47);
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
            // BtnHistory
            // 
            BtnHistory.BackColor = Color.Transparent;
            BtnHistory.BackgroundImage = Properties.Resources.HistoryLogo;
            BtnHistory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHistory.Location = new Point(43, 448);
            BtnHistory.Name = "BtnHistory";
            BtnHistory.Size = new Size(191, 38);
            BtnHistory.TabIndex = 5;
            BtnHistory.Click += BtnHistory_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.BackgroundImage = Properties.Resources.LaporanLogo;
            btnLaporan.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaporan.Location = new Point(39, 393);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(173, 35);
            btnLaporan.TabIndex = 4;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPenyuplai
            // 
            btnPenyuplai.BackColor = Color.Transparent;
            btnPenyuplai.BackgroundImage = Properties.Resources.PenyuplaiLogo;
            btnPenyuplai.BackgroundImageLayout = ImageLayout.Zoom;
            btnPenyuplai.Location = new Point(44, 327);
            btnPenyuplai.Name = "btnPenyuplai";
            btnPenyuplai.Size = new Size(160, 50);
            btnPenyuplai.TabIndex = 3;
            btnPenyuplai.Click += btnPenyuplai_Click;
            // 
            // btnSubKategori
            // 
            btnSubKategori.BackColor = Color.Transparent;
            btnSubKategori.BackgroundImage = Properties.Resources.SubKategoriLogo;
            btnSubKategori.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubKategori.Location = new Point(44, 269);
            btnSubKategori.Name = "btnSubKategori";
            btnSubKategori.Size = new Size(190, 50);
            btnSubKategori.TabIndex = 2;
            btnSubKategori.Click += btnSubKategori_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImage = Properties.Resources.dashboardLogo;
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Location = new Point(43, 218);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(178, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.EcoPengepul;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 100);
            panel2.TabIndex = 0;
            // 
            // UcKelolaLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(panel1);
            Name = "UcKelolaLaporan";
            Size = new Size(1920, 1060);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel btnDashboard;
        private Panel BtnHistory;
        private Panel btnLaporan;
        private Panel btnPenyuplai;
        private Panel btnSubKategori;
        private Panel btnLogout;
        private Panel panel9;
    }
}

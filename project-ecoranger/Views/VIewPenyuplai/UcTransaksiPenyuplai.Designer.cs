namespace project_ecoranger.Views
{
    partial class UcTransaksiPenyuplai
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
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
            panel9.Location = new Point(3, 312);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 50);
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
            panel3.BackgroundImage = Properties.Resources.tittleTransaksi;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(393, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 71);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(393, 170);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1423, 820);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // UcTransaksiPenyuplai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UcTransaksiPenyuplai";
            Size = new Size(1920, 1060);
            panel1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

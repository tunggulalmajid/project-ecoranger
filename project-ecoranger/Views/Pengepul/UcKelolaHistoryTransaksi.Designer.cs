namespace project_ecoranger.Views
{
    partial class UcKelolaHistoryTransaksi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            btnLogout = new Panel();
            BtnHistory = new Panel();
            btnLaporan = new Panel();
            btnPenyuplai = new Panel();
            btnSubKategori = new Panel();
            btnDashboard = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnBack = new Panel();
            dgvHistoryTransaksi = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryTransaksi).BeginInit();
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
            panel9.Location = new Point(3, 444);
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.tittleHistoryTransaksi;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(917, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 158);
            panel3.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.btnKembali;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(389, 61);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(256, 76);
            btnBack.TabIndex = 2;
            btnBack.Click += btnBack_Click;
            // 
            // dgvHistoryTransaksi
            // 
            dgvHistoryTransaksi.AllowUserToAddRows = false;
            dgvHistoryTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dgvHistoryTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistoryTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHistoryTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHistoryTransaksi.BackgroundColor = SystemColors.Control;
            dgvHistoryTransaksi.BorderStyle = BorderStyle.None;
            dgvHistoryTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistoryTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistoryTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistoryTransaksi.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistoryTransaksi.GridColor = SystemColors.Control;
            dgvHistoryTransaksi.Location = new Point(409, 359);
            dgvHistoryTransaksi.MultiSelect = false;
            dgvHistoryTransaksi.Name = "dgvHistoryTransaksi";
            dgvHistoryTransaksi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistoryTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHistoryTransaksi.RowHeadersWidth = 100;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvHistoryTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvHistoryTransaksi.Size = new Size(1443, 677);
            dgvHistoryTransaksi.StandardTab = true;
            dgvHistoryTransaksi.TabIndex = 5;
            // 
            // UcKelolaHistoryTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(dgvHistoryTransaksi);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UcKelolaHistoryTransaksi";
            Size = new Size(1920, 1060);
            Load += UcKelolaHistory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistoryTransaksi).EndInit();
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
        private Panel panel3;
        private Panel btnBack;
        private DataGridView dgvHistoryTransaksi;
    }
}

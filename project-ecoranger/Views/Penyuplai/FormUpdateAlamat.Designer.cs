namespace project_ecoranger.Views
{
    partial class FormUpdateAlamat
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnBatal = new Panel();
            btnSimpan = new Panel();
            tbJalan = new TextBox();
            tbDesa = new TextBox();
            tbKecamatan = new TextBox();
            tbKabupaten = new TextBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoPengepul;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(-40, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.tittleUpdateAlamat;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(613, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 35);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.formUpdateAlamat;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(tbKabupaten);
            panel3.Controls.Add(tbKecamatan);
            panel3.Controls.Add(tbDesa);
            panel3.Controls.Add(tbJalan);
            panel3.Location = new Point(21, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 584);
            panel3.TabIndex = 2;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImage = Properties.Resources.btnBatal;
            btnBatal.BackgroundImageLayout = ImageLayout.Zoom;
            btnBatal.Location = new Point(374, 833);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(269, 66);
            btnBatal.TabIndex = 3;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.btnSimpan;
            btnSimpan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpan.Location = new Point(655, 833);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(269, 66);
            btnSimpan.TabIndex = 4;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbJalan
            // 
            tbJalan.BorderStyle = BorderStyle.None;
            tbJalan.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbJalan.Location = new Point(46, 75);
            tbJalan.Name = "tbJalan";
            tbJalan.Size = new Size(820, 26);
            tbJalan.TabIndex = 0;
            // 
            // tbDesa
            // 
            tbDesa.BorderStyle = BorderStyle.None;
            tbDesa.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDesa.Location = new Point(46, 225);
            tbDesa.Name = "tbDesa";
            tbDesa.Size = new Size(820, 26);
            tbDesa.TabIndex = 1;
            // 
            // tbKecamatan
            // 
            tbKecamatan.BorderStyle = BorderStyle.None;
            tbKecamatan.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKecamatan.Location = new Point(46, 376);
            tbKecamatan.Name = "tbKecamatan";
            tbKecamatan.Size = new Size(820, 26);
            tbKecamatan.TabIndex = 2;
            // 
            // tbKabupaten
            // 
            tbKabupaten.BorderStyle = BorderStyle.None;
            tbKabupaten.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKabupaten.Location = new Point(46, 525);
            tbKabupaten.Name = "tbKabupaten";
            tbKabupaten.Size = new Size(820, 26);
            tbKabupaten.TabIndex = 3;
            // 
            // FormUpdateAlamat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(960, 940);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUpdateAlamat";
            Text = "FormTambahSubKategori";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel btnBatal;
        private Panel btnSimpan;
        private TextBox tbJalan;
        private TextBox tbKabupaten;
        private TextBox tbKecamatan;
        private TextBox tbDesa;
    }
}
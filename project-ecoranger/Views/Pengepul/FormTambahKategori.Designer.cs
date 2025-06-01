namespace project_ecoranger.Views
{
    partial class FormTambahKategori
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
            tbKategori = new TextBox();
            btnTambah = new Panel();
            btnBatal = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoTambahKategori;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.formSubKategori;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(tbKategori);
            panel2.Location = new Point(19, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 135);
            panel2.TabIndex = 1;
            // 
            // tbKategori
            // 
            tbKategori.BorderStyle = BorderStyle.None;
            tbKategori.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKategori.Location = new Point(28, 69);
            tbKategori.Name = "tbKategori";
            tbKategori.Size = new Size(839, 23);
            tbKategori.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Transparent;
            btnTambah.BackgroundImage = Properties.Resources.btnTambah1;
            btnTambah.BackgroundImageLayout = ImageLayout.Zoom;
            btnTambah.Location = new Point(659, 409);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(269, 66);
            btnTambah.TabIndex = 6;
            btnTambah.Click += btnSimpan_Click;
            btnTambah.Paint += btnSimpan_Paint;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImage = Properties.Resources.btnBatal;
            btnBatal.BackgroundImageLayout = ImageLayout.Zoom;
            btnBatal.Location = new Point(378, 409);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(269, 66);
            btnBatal.TabIndex = 5;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormTambahKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(981, 530);
            Controls.Add(btnTambah);
            Controls.Add(panel2);
            Controls.Add(btnBatal);
            Controls.Add(panel1);
            Name = "FormTambahKategori";
            Text = "FormTambahSubKategori";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox tbKategori;
        private Panel btnTambah;
        private Panel btnBatal;
    }
}
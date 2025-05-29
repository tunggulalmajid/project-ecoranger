namespace project_ecoranger.Views
{
    partial class FormUpdateDataDiri
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
            tbEmail = new TextBox();
            tbNoTelp = new TextBox();
            tbNama = new TextBox();
            btnBatal = new Panel();
            btnSimpan = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoPenyuplai;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(-46, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.tittleUpdateDataDiri;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(595, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.tittleUpdateDataDiri1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(tbEmail);
            panel3.Controls.Add(tbNoTelp);
            panel3.Controls.Add(tbNama);
            panel3.Location = new Point(12, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 425);
            panel3.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(44, 370);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(828, 28);
            tbEmail.TabIndex = 2;
            // 
            // tbNoTelp
            // 
            tbNoTelp.BorderStyle = BorderStyle.None;
            tbNoTelp.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNoTelp.Location = new Point(44, 215);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(828, 28);
            tbNoTelp.TabIndex = 1;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(44, 63);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(828, 28);
            tbNama.TabIndex = 0;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImage = Properties.Resources.btnBatal;
            btnBatal.Location = new Point(383, 836);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(268, 65);
            btnBatal.TabIndex = 3;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.btnSimpan;
            btnSimpan.Location = new Point(662, 836);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(268, 65);
            btnSimpan.TabIndex = 4;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormUpdateDataDiri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(953, 929);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUpdateDataDiri";
            Text = "FormTambahSubKategori";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox tbEmail;
        private TextBox tbNoTelp;
        private TextBox tbNama;
        private Panel btnBatal;
        private Panel btnSimpan;
    }
}
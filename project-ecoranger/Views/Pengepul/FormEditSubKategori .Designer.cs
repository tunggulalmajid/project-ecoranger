namespace project_ecoranger.Views
{
    partial class FormEditSubKategori
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
            cbListKategori = new ComboBox();
            panel2 = new Panel();
            tbHarga = new TextBox();
            tbSubKategori = new TextBox();
            btnSimpan = new Panel();
            btnBatal = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoEditSubKategori;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // cbListKategori
            // 
            cbListKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListKategori.FlatStyle = FlatStyle.Popup;
            cbListKategori.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListKategori.FormattingEnabled = true;
            cbListKategori.Location = new Point(34, 67);
            cbListKategori.Name = "cbListKategori";
            cbListKategori.Size = new Size(839, 31);
            cbListKategori.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.formSubKategori;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(tbHarga);
            panel2.Controls.Add(tbSubKategori);
            panel2.Controls.Add(cbListKategori);
            panel2.Location = new Point(19, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 432);
            panel2.TabIndex = 1;
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.None;
            tbHarga.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(34, 385);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(839, 23);
            tbHarga.TabIndex = 2;
            // 
            // tbSubKategori
            // 
            tbSubKategori.BorderStyle = BorderStyle.None;
            tbSubKategori.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSubKategori.Location = new Point(34, 227);
            tbSubKategori.Name = "tbSubKategori";
            tbSubKategori.Size = new Size(839, 23);
            tbSubKategori.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.btnSimpan;
            btnSimpan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpan.Location = new Point(660, 827);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(269, 66);
            btnSimpan.TabIndex = 6;
            btnSimpan.Click += btnSimpan_Click;
            btnSimpan.Paint += btnSimpan_Paint;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImage = Properties.Resources.btnBatal;
            btnBatal.BackgroundImageLayout = ImageLayout.Zoom;
            btnBatal.Location = new Point(379, 827);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(269, 66);
            btnBatal.TabIndex = 5;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormEditSubKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(981, 914);
            Controls.Add(btnSimpan);
            Controls.Add(panel2);
            Controls.Add(btnBatal);
            Controls.Add(panel1);
            Name = "FormEditSubKategori";
            Text = "FormTambahSubKategori";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbListKategori;
        private Panel panel2;
        private TextBox tbHarga;
        private TextBox tbSubKategori;
        private Panel btnSimpan;
        private Panel btnBatal;
    }
}
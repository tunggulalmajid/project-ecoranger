namespace project_ecoranger.Views
{
    partial class FormJualSampah
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nama = new Label();
            sampah = new Label();
            kategoriSampah = new Label();
            lblhargaSampah = new Label();
            panel2 = new Panel();
            tbBerat = new TextBox();
            btnBatal = new Panel();
            BtnJual = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoJualSampah;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(-10, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(28, 152);
            label1.Name = "label1";
            label1.Size = new Size(107, 33);
            label1.TabIndex = 0;
            label1.Text = "Nama : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(28, 188);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 1;
            label2.Text = "Sampah : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(28, 224);
            label3.Name = "label3";
            label3.Size = new Size(245, 33);
            label3.TabIndex = 2;
            label3.Text = "Kategori Sampah : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 260);
            label4.Name = "label4";
            label4.Size = new Size(200, 33);
            label4.TabIndex = 3;
            label4.Text = "Harga Per Kg : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(28, 319);
            label5.Name = "label5";
            label5.Size = new Size(259, 33);
            label5.TabIndex = 4;
            label5.Text = "Berat Sampah (Kg) :";
            label5.Click += label5_Click;
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.BackColor = Color.Transparent;
            nama.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama.ForeColor = SystemColors.Control;
            nama.Location = new Point(121, 153);
            nama.Name = "nama";
            nama.Size = new Size(107, 33);
            nama.TabIndex = 5;
            nama.Text = "Nama : ";
            // 
            // sampah
            // 
            sampah.AutoSize = true;
            sampah.BackColor = Color.Transparent;
            sampah.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sampah.ForeColor = SystemColors.Control;
            sampah.Location = new Point(153, 189);
            sampah.Name = "sampah";
            sampah.Size = new Size(107, 33);
            sampah.TabIndex = 6;
            sampah.Text = "Nama : ";
            // 
            // kategoriSampah
            // 
            kategoriSampah.AutoSize = true;
            kategoriSampah.BackColor = Color.Transparent;
            kategoriSampah.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kategoriSampah.ForeColor = SystemColors.Control;
            kategoriSampah.Location = new Point(264, 226);
            kategoriSampah.Name = "kategoriSampah";
            kategoriSampah.Size = new Size(107, 33);
            kategoriSampah.TabIndex = 7;
            kategoriSampah.Text = "Nama : ";
            // 
            // lblhargaSampah
            // 
            lblhargaSampah.AutoSize = true;
            lblhargaSampah.BackColor = Color.Transparent;
            lblhargaSampah.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhargaSampah.ForeColor = SystemColors.Control;
            lblhargaSampah.Location = new Point(218, 262);
            lblhargaSampah.Name = "lblhargaSampah";
            lblhargaSampah.Size = new Size(107, 33);
            lblhargaSampah.TabIndex = 8;
            lblhargaSampah.Text = "Nama : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.formUniversal;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(tbBerat);
            panel2.Location = new Point(28, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 76);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // tbBerat
            // 
            tbBerat.BorderStyle = BorderStyle.None;
            tbBerat.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBerat.Location = new Point(55, 24);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(816, 26);
            tbBerat.TabIndex = 0;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.BackgroundImage = Properties.Resources.btnBatal;
            btnBatal.BackgroundImageLayout = ImageLayout.Stretch;
            btnBatal.Location = new Point(385, 506);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(268, 65);
            btnBatal.TabIndex = 10;
            btnBatal.Click += btnBatal_Click;
            // 
            // BtnJual
            // 
            BtnJual.BackColor = Color.Transparent;
            BtnJual.BackgroundImage = Properties.Resources.BtnJualTransaksi;
            BtnJual.BackgroundImageLayout = ImageLayout.Stretch;
            BtnJual.Location = new Point(668, 506);
            BtnJual.Name = "BtnJual";
            BtnJual.Size = new Size(268, 65);
            BtnJual.TabIndex = 11;
            BtnJual.Click += BtnJual_Click;
            BtnJual.Paint += panel3_Paint;
            // 
            // FormJualSampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(972, 616);
            Controls.Add(BtnJual);
            Controls.Add(btnBatal);
            Controls.Add(panel2);
            Controls.Add(lblhargaSampah);
            Controls.Add(kategoriSampah);
            Controls.Add(sampah);
            Controls.Add(nama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormJualSampah";
            Text = "FormTambahSubKategori";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label nama;
        private Label sampah;
        private Label kategoriSampah;
        private Label lblhargaSampah;
        private Panel panel2;
        private TextBox tbBerat;
        private Panel btnBatal;
        private Panel BtnJual;
    }
}
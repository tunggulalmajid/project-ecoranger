namespace project_ecoranger.Views
{
    partial class FormTukarPoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTukarPoin));
            panel1 = new Panel();
            label1 = new Label();
            poinValue = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnTukar = new Panel();
            panel2 = new Panel();
            cbNominal = new ComboBox();
            tbHasil = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoTukarPoin;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(-11, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Black", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(30, 146);
            label1.Name = "label1";
            label1.Size = new Size(82, 29);
            label1.TabIndex = 1;
            label1.Text = "Poin : ";
            // 
            // poinValue
            // 
            poinValue.AutoSize = true;
            poinValue.BackColor = Color.Transparent;
            poinValue.Font = new Font("Roboto Black", 40F, FontStyle.Bold);
            poinValue.ForeColor = SystemColors.Control;
            poinValue.Location = new Point(30, 184);
            poinValue.Name = "poinValue";
            poinValue.Size = new Size(180, 65);
            poinValue.TabIndex = 2;
            poinValue.Text = "Poin : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto Black", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(30, 302);
            label2.Name = "label2";
            label2.Size = new Size(161, 29);
            label2.TabIndex = 3;
            label2.Text = "Nominal Poin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto Black", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(30, 572);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 4;
            label3.Text = "Saldo Didapat";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.formUniversal;
            pictureBox1.Location = new Point(30, 334);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(902, 78);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.formUniversal;
            pictureBox2.Location = new Point(30, 604);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(902, 78);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(433, 474);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 54);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnTukar
            // 
            btnTukar.BackColor = Color.Transparent;
            btnTukar.BackgroundImage = Properties.Resources.btnTukar;
            btnTukar.BackgroundImageLayout = ImageLayout.Zoom;
            btnTukar.Location = new Point(660, 821);
            btnTukar.Name = "btnTukar";
            btnTukar.Size = new Size(269, 64);
            btnTukar.TabIndex = 9;
            btnTukar.Click += btnTukar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.btnBatal;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(382, 822);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 64);
            panel2.TabIndex = 8;
            panel2.Click += panel2_Click;
            // 
            // cbNominal
            // 
            cbNominal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNominal.FlatStyle = FlatStyle.Popup;
            cbNominal.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbNominal.FormattingEnabled = true;
            cbNominal.Location = new Point(71, 355);
            cbNominal.Name = "cbNominal";
            cbNominal.Size = new Size(839, 33);
            cbNominal.TabIndex = 10;
            cbNominal.SelectedIndexChanged += cbNominal_SelectedIndexChanged;
            // 
            // tbHasil
            // 
            tbHasil.BackColor = SystemColors.ControlLightLight;
            tbHasil.BorderStyle = BorderStyle.None;
            tbHasil.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold);
            tbHasil.Location = new Point(71, 627);
            tbHasil.Name = "tbHasil";
            tbHasil.ReadOnly = true;
            tbHasil.Size = new Size(839, 26);
            tbHasil.TabIndex = 11;
            // 
            // FormTukarPoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(978, 910);
            Controls.Add(tbHasil);
            Controls.Add(cbNominal);
            Controls.Add(btnTukar);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(poinValue);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormTukarPoin";
            Text = "FormTambahSubKategori";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label poinValue;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel btnTukar;
        private Panel panel2;
        private ComboBox cbNominal;
        private TextBox tbHasil;
    }
}
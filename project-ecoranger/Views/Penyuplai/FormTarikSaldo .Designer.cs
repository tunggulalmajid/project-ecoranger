namespace project_ecoranger.Views
{
    partial class FormTarikSaldo
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
            panel4 = new Panel();
            tbRekening = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.EcoTarikSaldo;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(-20, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.btnBatal;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(371, 768);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 64);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.btnTarik;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(649, 768);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 64);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.formTarikSaldo;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(tbRekening);
            panel4.Location = new Point(21, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(910, 423);
            panel4.TabIndex = 4;
            // 
            // tbRekening
            // 
            tbRekening.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbRekening.Location = new Point(71, 217);
            tbRekening.Name = "tbRekening";
            tbRekening.Size = new Size(802, 33);
            tbRekening.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold);
            textBox2.Location = new Point(71, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(802, 33);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(802, 33);
            comboBox1.TabIndex = 2;
            // 
            // FormTarikSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(943, 844);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTarikSaldo";
            Text = "FormTambahSubKategori";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox tbRekening;
    }
}
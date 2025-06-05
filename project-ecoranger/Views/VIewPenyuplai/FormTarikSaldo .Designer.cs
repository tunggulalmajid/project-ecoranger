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
            btnTarik = new Panel();
            panel4 = new Panel();
            cbNominal = new ComboBox();
            cbBank = new ComboBox();
            tbRekening = new TextBox();
            label1 = new Label();
            saldoValue = new Label();
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
            panel2.Location = new Point(376, 850);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 64);
            panel2.TabIndex = 2;
            panel2.Click += panel2_Click;
            // 
            // btnTarik
            // 
            btnTarik.BackColor = Color.Transparent;
            btnTarik.BackgroundImage = Properties.Resources.btnTarik;
            btnTarik.BackgroundImageLayout = ImageLayout.Zoom;
            btnTarik.Location = new Point(654, 849);
            btnTarik.Name = "btnTarik";
            btnTarik.Size = new Size(269, 64);
            btnTarik.TabIndex = 3;
            btnTarik.Click += btnTarik_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.formTarikSaldo;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(cbNominal);
            panel4.Controls.Add(cbBank);
            panel4.Controls.Add(tbRekening);
            panel4.Location = new Point(21, 321);
            panel4.Name = "panel4";
            panel4.Size = new Size(910, 423);
            panel4.TabIndex = 4;
            // 
            // cbNominal
            // 
            cbNominal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNominal.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold);
            cbNominal.FormattingEnabled = true;
            cbNominal.Location = new Point(71, 369);
            cbNominal.Name = "cbNominal";
            cbNominal.Size = new Size(802, 33);
            cbNominal.TabIndex = 3;
            // 
            // cbBank
            // 
            cbBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBank.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold);
            cbBank.FormattingEnabled = true;
            cbBank.Location = new Point(71, 64);
            cbBank.Name = "cbBank";
            cbBank.Size = new Size(802, 33);
            cbBank.TabIndex = 2;
            // 
            // tbRekening
            // 
            tbRekening.Font = new Font("Roboto Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbRekening.Location = new Point(71, 217);
            tbRekening.Name = "tbRekening";
            tbRekening.Size = new Size(802, 33);
            tbRekening.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Black", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 159);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 5;
            label1.Text = "Saldo : ";
            // 
            // saldoValue
            // 
            saldoValue.AutoSize = true;
            saldoValue.BackColor = Color.Transparent;
            saldoValue.Font = new Font("Roboto Black", 40F, FontStyle.Bold);
            saldoValue.ForeColor = SystemColors.Control;
            saldoValue.Location = new Point(21, 200);
            saldoValue.Name = "saldoValue";
            saldoValue.Size = new Size(166, 65);
            saldoValue.TabIndex = 6;
            saldoValue.Text = "Saldo";
            // 
            // FormTarikSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboardFill;
            ClientSize = new Size(943, 926);
            Controls.Add(saldoValue);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(btnTarik);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTarikSaldo";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel btnTarik;
        private Panel panel4;
        private ComboBox cbBank;
        private TextBox tbRekening;
        private ComboBox cbNominal;
        private Label label1;
        private Label saldoValue;
    }
}
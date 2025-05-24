﻿namespace project_ecoranger.Views
{
    partial class UcLogin
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
            panel2 = new Panel();
            cbRole = new ComboBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new Panel();
            btnToRegister = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.loading_ecoranger;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(155, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 336);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.formLogin;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(cbRole);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbUsername);
            panel2.Location = new Point(1163, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 452);
            panel2.TabIndex = 2;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FlatStyle = FlatStyle.Popup;
            cbRole.Font = new Font("Segoe UI", 14F);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(93, 404);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(409, 33);
            cbRole.TabIndex = 2;
            cbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(93, 295);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(409, 26);
            tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(93, 187);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(409, 26);
            tbUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.btnLoginStartPage1;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Location = new Point(1256, 708);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(409, 104);
            btnLogin.TabIndex = 3;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Paint += btnLogin_Paint;
            // 
            // btnToRegister
            // 
            btnToRegister.BackgroundImage = Properties.Resources.NotesRegistStartPage;
            btnToRegister.BackgroundImageLayout = ImageLayout.Zoom;
            btnToRegister.Location = new Point(1320, 818);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(267, 34);
            btnToRegister.TabIndex = 4;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // UcLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(btnToRegister);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcLogin";
            Size = new Size(1920, 1074);
            Load += UcLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel btnLogin;
        private Panel btnToRegister;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private ComboBox cbRole;
    }
}

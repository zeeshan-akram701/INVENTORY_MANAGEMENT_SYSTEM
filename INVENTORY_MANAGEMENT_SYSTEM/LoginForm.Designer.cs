namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            lblLogin = new Label();
            panel2 = new Panel();
            button1 = new Button();
            lblName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(279, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 68);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Baskerville Old Face", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(211, 91);
            txtUsername.MaximumSize = new Size(300, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(300, 39);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(211, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(300, 37);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(194, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 373);
            panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(211, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(216, 33);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.ForestGreen;
            lblLogin.Location = new Point(265, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(187, 56);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.MaximumSize = new Size(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 60);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(984, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "❌";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(194, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(673, 72);
            lblName.TabIndex = 0;
            lblName.Text = "inventory management system ";
            lblName.TextAlign = ContentAlignment.TopCenter;
            lblName.Click += lblName_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1122, 566);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel1;
        private Panel panel2;
        private Label lblName;
        private Button button1;
        private Label lblLogin;
        private CheckBox checkBox1;
    }
}
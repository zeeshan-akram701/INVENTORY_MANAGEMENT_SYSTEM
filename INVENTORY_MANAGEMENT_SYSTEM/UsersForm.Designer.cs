namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtFullName;
        private TextBox txtUsername;

        private TextBox txtPassword;
        private TextBox txtPhone;

        private ComboBox cmbRole;
        private ComboBox cmbStatus;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();

            cmbRole = new ComboBox();
            cmbStatus = new ComboBox();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvUsers = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // txtFullName
            txtFullName.Location = new Point(30, 80);
            txtFullName.Size = new Size(220, 27);
            txtFullName.PlaceholderText = "Full Name";

            // txtUsername
            txtUsername.Location = new Point(270, 80);
            txtUsername.Size = new Size(220, 27);
            txtUsername.PlaceholderText = "Username";

            // txtPassword
            txtPassword.Location = new Point(510, 80);
            txtPassword.Size = new Size(220, 27);
            txtPassword.PlaceholderText = "Password";
            txtPassword.UseSystemPasswordChar = true;

            // txtPhone
            txtPhone.Location = new Point(30, 130);
            txtPhone.Size = new Size(220, 27);
            txtPhone.PlaceholderText = "Phone";

            // cmbRole
            cmbRole.Location = new Point(270, 130);
            cmbRole.Size = new Size(220, 28);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            // cmbStatus
            cmbStatus.Location = new Point(510, 130);
            cmbStatus.Size = new Size(220, 28);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnAdd
            btnAdd.Location = new Point(30, 190);
            btnAdd.Size = new Size(90, 35);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            // btnUpdate
            btnUpdate.Location = new Point(140, 190);
            btnUpdate.Size = new Size(90, 35);
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Location = new Point(250, 190);
            btnDelete.Size = new Size(90, 35);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;

            // btnClear
            btnClear.Location = new Point(360, 190);
            btnClear.Size = new Size(90, 35);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;

            // dgvUsers
            dgvUsers.Location = new Point(30, 250);
            dgvUsers.Size = new Size(900, 300);
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.CellClick += dgvUsers_CellClick;

            // UsersForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);

            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(cmbRole);
            Controls.Add(cmbStatus);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvUsers);

            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

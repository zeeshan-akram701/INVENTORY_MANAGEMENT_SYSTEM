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
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Size = new Size(1250, 81);
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(19, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            // 
            // lblInventory
            // 
            lblInventory.Location = new Point(625, 10);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1138, 0);
            btnClose.Margin = new Padding(4);
            btnClose.Size = new Size(56, 81);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1194, 0);
            btnMinimize.Margin = new Padding(4);
            btnMinimize.Size = new Size(56, 81);
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(38, 100);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(274, 31);
            txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(338, 100);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(274, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(638, 100);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(274, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(38, 162);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(274, 31);
            txtPhone.TabIndex = 4;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(338, 162);
            cmbRole.Margin = new Padding(4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(274, 33);
            cmbRole.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(638, 162);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(274, 33);
            cmbStatus.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(38, 238);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 44);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(175, 238);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(312, 238);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(450, 238);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 44);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeight = 34;
            dgvUsers.Location = new Point(165, 322);
            dgvUsers.Margin = new Padding(4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(916, 375);
            dgvUsers.TabIndex = 11;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1250, 750);
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
            Margin = new Padding(4);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            Controls.SetChildIndex(dgvUsers, 0);
            Controls.SetChildIndex(btnClear, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(cmbStatus, 0);
            Controls.SetChildIndex(cmbRole, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(txtUsername, 0);
            Controls.SetChildIndex(txtFullName, 0);
            Controls.SetChildIndex(pnlHeader, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

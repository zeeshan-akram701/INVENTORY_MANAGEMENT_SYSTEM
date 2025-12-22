using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class UsersForm : BaseForm
    {
        int selectedUserId = 0;

        public UsersForm()
        {
            InitializeComponent();
            lblTitle.Text = "Users / Employees Management";
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Staff", "Cashier" });
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });

            cmbRole.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            LoadUsers();
        }

        // ===================== LOAD USERS =====================
        private void LoadUsers()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT EmployeeID, FullName, Username, Role, Phone, Status FROM Employees",
                    con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        // ===================== VALIDATION =====================
        private bool IsValidInput(bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.");
                txtUsername.Focus();
                return false;
            }

            if (!isUpdate && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.");
                txtPassword.Focus();
                return false;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return false;
            }

            return true;
        }

        // ===================== DUPLICATE USER CHECK =====================
        private bool UsernameExists(string username)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Employees WHERE Username=@user", con);
                cmd.Parameters.AddWithValue("@user", username);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // ===================== ADD USER =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            if (UsernameExists(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username already exists. Choose another.");
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Employees
                    (FullName, Username, Password, Role, Phone, Status)
                    VALUES (@name,@user,@pass,@role,@phone,@status)", con);

                cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User added successfully");
            LoadUsers();
            ClearForm();
        }

        // ===================== UPDATE USER =====================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (!IsValidInput(isUpdate: true))
                return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Employees SET
                    FullName=@name,
                    Username=@user,
                    Role=@role,
                    Phone=@phone,
                    Status=@status
                    WHERE EmployeeID=@id", con);

                cmd.Parameters.AddWithValue("@id", selectedUserId);
                cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User updated successfully");
            LoadUsers();
            ClearForm();
        }

        // ===================== DELETE USER =====================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
                return;

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Employees WHERE EmployeeID=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
                ClearForm();
            }
        }

        // ===================== GRID CLICK =====================
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                selectedUserId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                cmbRole.Text = row.Cells["Role"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        // ===================== CLEAR FORM =====================
        private void ClearForm()
        {
            selectedUserId = 0;
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            cmbRole.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

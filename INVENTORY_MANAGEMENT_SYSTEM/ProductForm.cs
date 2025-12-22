using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class ProductForm : BaseForm
    {
        int selectedProductId = 0;

        public ProductForm()
        {
            InitializeComponent();
            lblTitle.Text = "Products Management";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;

            LoadProducts();
        }

        // ===================== LOAD PRODUCTS =====================
        private void LoadProducts()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Products", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        // ===================== VALIDATION =====================
        private bool IsValidProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required.");
                txtProductName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCostPrice.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Enter a valid cost price.");
                txtCostPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSellingPrice.Text, out decimal sell) || sell < 0)
            {
                MessageBox.Show("Enter a valid selling price.");
                txtSellingPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                txtQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text, out int reorder) || reorder < 0)
            {
                MessageBox.Show("Enter a valid reorder level.");
                txtReorderLevel.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select product status.");
                return false;
            }

            return true;
        }

        // ===================== ADD PRODUCT =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidProduct())
                return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Products
                    (ProductName, Category, CostPrice, SellingPrice, Quantity, ReorderLevel, Status)
                    VALUES (@name,@cat,@cp,@sp,@qty,@rl,@status)", con);

                cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@cp", decimal.Parse(txtCostPrice.Text));
                cmd.Parameters.AddWithValue("@sp", decimal.Parse(txtSellingPrice.Text));
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@rl", int.Parse(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product added successfully");
            LoadProducts();
            ClearForm();
        }

        // ===================== UPDATE PRODUCT =====================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (!IsValidProduct())
                return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Products SET
                    ProductName=@name,
                    Category=@cat,
                    CostPrice=@cp,
                    SellingPrice=@sp,
                    Quantity=@qty,
                    ReorderLevel=@rl,
                    Status=@status
                    WHERE ProductID=@id", con);

                cmd.Parameters.AddWithValue("@id", selectedProductId);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@cp", decimal.Parse(txtCostPrice.Text));
                cmd.Parameters.AddWithValue("@sp", decimal.Parse(txtSellingPrice.Text));
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@rl", int.Parse(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated successfully");
            LoadProducts();
            ClearForm();
        }

        // ===================== DELETE PRODUCT =====================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
                return;

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Products WHERE ProductID=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectedProductId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadProducts();
                ClearForm();
            }
        }

        // ===================== GRID CLICK =====================
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtCostPrice.Text = row.Cells["CostPrice"].Value.ToString();
                txtSellingPrice.Text = row.Cells["SellingPrice"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        // ===================== CLEAR FORM =====================
        private void ClearForm()
        {
            selectedProductId = 0;
            txtProductName.Clear();
            txtCategory.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtQuantity.Clear();
            txtReorderLevel.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

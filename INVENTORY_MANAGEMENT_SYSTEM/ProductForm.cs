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

        // 🔹 Load Products into Grid
        private void LoadProducts()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        // 🔹 Add Product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Products 
                (ProductName, Category, CostPrice, SellingPrice, Quantity, ReorderLevel, Status)
                VALUES (@name,@cat,@cp,@sp,@qty,@rl,@status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@cp", txtCostPrice.Text);
                cmd.Parameters.AddWithValue("@sp", txtSellingPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@rl", txtReorderLevel.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Added Successfully");
            LoadProducts();
            ClearForm();
        }

        // 🔹 Update Product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Products SET
                ProductName=@name, Category=@cat, CostPrice=@cp,
                SellingPrice=@sp, Quantity=@qty, ReorderLevel=@rl, Status=@status
                WHERE ProductID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedProductId);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@cp", txtCostPrice.Text);
                cmd.Parameters.AddWithValue("@sp", txtSellingPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@rl", txtReorderLevel.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Updated");
            LoadProducts();
            ClearForm();
        }

        // 🔹 Delete Product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0) return;

            DialogResult dr = MessageBox.Show(
                "Are you sure?",
                "Delete",
                MessageBoxButtons.YesNo);

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

        // 🔹 Grid Row Click
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

        // 🔹 Clear Form
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

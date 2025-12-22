using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class reportForm : BaseForm
    {
        public reportForm()
        {
            InitializeComponent();
            lblTitle.Text = "Reports";
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            LoadAllProductsReport();
        }

        // 🔹 Load All Products Report
        private void LoadAllProductsReport()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT ProductID, ProductName, Category,
                      Quantity, ReorderLevel, SellingPrice, Status
                      FROM Products", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        // 🔹 Low Stock Report
        private void btnLowStock_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT ProductID, ProductName, Category,
                      Quantity, ReorderLevel
                      FROM Products
                      WHERE Quantity <= ReorderLevel", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        // 🔹 Refresh / All Products
        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            LoadAllProductsReport();
        }

        // 🔹 Search by Product Name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT ProductID, ProductName, Category,
                      Quantity, ReorderLevel, SellingPrice, Status
                      FROM Products
                      WHERE ProductName LIKE @name", con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@name", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }
    }
}

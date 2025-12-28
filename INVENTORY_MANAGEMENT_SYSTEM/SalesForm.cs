using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class SalesForm : BaseForm
    {
        decimal price = 0;

        public SalesForm()
        {
            InitializeComponent();
            lblTitle.Text = "Sales";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using SqlConnection con = DatabaseHelper.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT ProductID, ProductName FROM Products WHERE Quantity > 0",
                con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = dt;
            cmbProduct.SelectedIndex = -1;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                price = 0;
                txtPrice.Text = "0.00";
                return;
            }

            int productId = Convert.ToInt32(cmbProduct.SelectedValue);

            using SqlConnection con = DatabaseHelper.GetConnection();
            SqlCommand cmd = new SqlCommand(
                "SELECT SellingPrice FROM Products WHERE ProductID=@id", con);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = productId;

            con.Open();
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                price = Convert.ToDecimal(result);
                txtPrice.Text = price.ToString("0.00");
            }
            else
            {
                price = 0;
                txtPrice.Text = "0.00";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int qty))
                txtTotal.Text = (qty * price).ToString("0.00");
            else
                txtTotal.Text = "0.00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            int productId = Convert.ToInt32(cmbProduct.SelectedValue);

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
               
                con.Open();

                //SqlTransaction tr = con.BeginTransaction();

               
                    // CHECK STOCK
                    SqlCommand stockCmd = new SqlCommand(
                        "SELECT Quantity FROM Products WHERE ProductID=@id",
                        con);

                    stockCmd.Parameters.Add("@id", SqlDbType.Int).Value = productId;

                    int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                    if (qty > stock)
                    {
                        MessageBox.Show("Not enough stock!");
                        //tr.Rollback();
                        return;
                    }

                    // INSERT SALE (FIXED)
                    SqlCommand insert = new SqlCommand(
                        @"INSERT INTO Paym (ProductID, Quantity, Price, Total)
                      VALUES (@pid, @qty, @price, @total)",
                        con);

                    insert.Parameters.Add("@pid", SqlDbType.Int).Value = productId;
                    insert.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
                    insert.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                    insert.Parameters.Add("@total", SqlDbType.Decimal).Value = qty * price;

                    
                    insert.ExecuteNonQuery();

                    // UPDATE PRODUCT STOCK
                    SqlCommand update = new SqlCommand(
                        "UPDATE Products SET Quantity = Quantity - @qty WHERE ProductID=@id",
                        con);

                    update.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
                    update.Parameters.Add("@id", SqlDbType.Int).Value = productId;

                    update.ExecuteNonQuery();

                    //tr.Commit();
                    MessageBox.Show("Sale completed successfully");

                    ClearForm();
                    LoadProducts();
            }

               
              
                    //tr.Rollback();
                    
            
        }

        private void ClearForm()
        {
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Text = "0.00";
            txtTotal.Text = "0.00";
            price = 0;
        }
    }
}

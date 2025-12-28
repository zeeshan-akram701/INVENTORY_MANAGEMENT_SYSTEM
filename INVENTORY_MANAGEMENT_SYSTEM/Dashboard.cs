using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class Dashboard : BaseForm
    {
        public Dashboard()
        {
            InitializeComponent();
            lblTitle.Text = "Dashboard";
            lblWelcome.Text = "Welcome " + Session.Username;

            //ApplyRolePermissions();


            if (Session.Role == "Cashier" || Session.Role == "Staff")
            {
                btnuser.Enabled = false;        // Admin only
                btncategory.Enabled = true;    // Admin only
                btnreports.Enabled = false;     // Admin only
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btndash.FlatAppearance.BorderSize = 0;
            btncategory.FlatAppearance.BorderSize = 0;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnproducts.FlatAppearance.BorderSize = 0;
            btnreports.FlatAppearance.BorderSize = 0;
            btnuser.FlatAppearance.BorderSize = 0;

            LoadDashboardCounts();

            lblSalesMain.BackColor = Color.DarkSlateGray;
            lblTodaySales.BackColor = Color.DarkSlateGray;

            LoadSales();
            LoadTodaySales();

            //btndash.FlatAppearance.BorderSize = 0;
        }

        private void pnlorders_Paint(object sender, PaintEventArgs e)
        {

        }

        //private Button activeButton;

        //private void ActivateButton(Button btn)
        //{
        //    if (activeButton != null)
        //    {
        //        activeButton.BackColor = Color.FromArgb(52, 73, 94);
        //        activeButton.Enabled = true;
        //    }

        //    activeButton = btn;
        //    btn.BackColor = Color.FromArgb(41, 128, 185);
        //    btn.Enabled = false;
        //}

        private void btndash_Click(object sender, EventArgs e)
        {
            //ActivateButton(btndash);
            //new Dashboard().Show();

        }

        ProductForm productForm;
        private void btnproducts_Click(object sender, EventArgs e)
        {
            if (productForm == null || productForm.IsDisposed)
            {
                productForm = new ProductForm();
                productForm.Show();
            }
            else
            {
                productForm.BringToFront();
                productForm.Focus();
            }
        }

        // user form=======================

        UsersForm userform;
        private void btnuser_Click(object sender, EventArgs e)
        {

            if (userform == null || userform.IsDisposed)
            {
                userform = new UsersForm();
                userform.Show();
            }
            else
            {
                userform.BringToFront();
                userform.Focus();
            }

        }


        /// repoort form=======================
        /// 
        reportForm reportForm;
        private void btnreports_Click(object sender, EventArgs e)
        {

            if (reportForm == null || reportForm.IsDisposed)
            {
                reportForm = new reportForm();
                reportForm.Show();
            }
            else
            {
                reportForm.BringToFront();
                reportForm.Focus();
            }






        }
        ////////categories form 
        ///
        //CategoriesForm categoriesForm;
        SalesForm salesform;
        private void btncategory_Click(object sender, EventArgs e)
        {
            if (salesform == null || salesform.IsDisposed)
            {
                salesform = new SalesForm();
                salesform.Show();
            }
            else
            {
                salesform.BringToFront();
                salesform.Focus();
            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                List<Form> openForms = Application.OpenForms.Cast<Form>().ToList();

                foreach (Form form in openForms)
                {
                    // Do NOT close LoginForm
                    if (!(form is LoginForm))
                    {
                        form.Close();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //get total count 

        private int GetTotalCount(string tableName)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    $"SELECT COUNT(*) FROM {tableName}", con);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //load counts on dashboard

        private void LoadDashboardCounts()
        {
            try
            {
                lblTotalProducts.Text = GetTotalCount("Products").ToString();
                lblTotalUsers.Text = GetTotalCount("Employees").ToString();
                lblTotalSales.Text = GetTotalCount("Paym").ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard counts:\n" + ex.Message);
            }
        }



        //load sales method for data grid view which can load the sales 

        private void LoadSales()
        {
            using SqlConnection con = DatabaseHelper.GetConnection();

            string query = @"
        SELECT 
            p.ProductName AS [Product],
            s.Quantity,
            s.Price,
            s.Total,
            s.SaleDate
        FROM Paym s
        INNER JOIN Products p ON s.ProductID = p.ProductID
        ORDER BY s.SaleDate DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvSales.DataSource = dt;
            BeautifySalesGrid();
        }

        //beautify the grid==================

        private void BeautifySalesGrid()
        {
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.RowTemplate.Height = 35;

            dgvSales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSales.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvSales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvSales.ReadOnly = true;
        }


        //load todays sales 

        private void LoadTodaySales()
        {
            using SqlConnection con = DatabaseHelper.GetConnection();

            string query = @"
        SELECT 
            p.ProductName,
            s.Quantity,
            s.Price,
            s.Total,
            s.SaleDate
        FROM Paym s
        INNER JOIN Products p ON s.ProductID = p.ProductID
        WHERE CAST(s.SaleDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvToday.DataSource = dt;
            Beautify();
        }

        private void Beautify()
        {
           dgvToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToday.RowTemplate.Height = 35;

            dgvToday.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvToday.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvToday.EnableHeadersVisualStyles = false;
            dgvToday.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvToday.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvToday.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvToday.ReadOnly = true;
        }


        //load the count and tell us the total count of products ,categories ,users

        //private void ApplyRolePermissions()
        //{
        //    if (Session.Role == "Admin")
        //    {
        //        // Full access
        //        btnuser.Visible = true;
        //        btncategory.Visible = true;
        //        btnproducts.Visible = true;
        //        btnreports.Visible = true;
        //        btndash.Visible = true;
        //    }
        //    else if (Session.Role == "Cashier")
        //    {
        //        // Limited access
        //        btnuser.Enabled = false;
        //        btncategory.Enabled = true;
        //        btnreports.Enabled = false;
        //        btnreports.Visible= true;

        //        btnproducts.Visible = true;
        //        btnproducts.Enabled = false;
        //        btndash.Visible = true;
        //    }
        //    else if (Session.Role == "Staff")
        //    {
        //        btnuser.Enabled = false;
        //        btncategory.Enabled = true;
        //        btnreports.Enabled = false;

        //        btnproducts.Visible = true;
        //        btndash.Visible = true;
        //    }
        //}



    }
}

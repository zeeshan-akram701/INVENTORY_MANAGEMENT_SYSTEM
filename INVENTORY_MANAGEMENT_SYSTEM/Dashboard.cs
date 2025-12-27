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
        CategoriesForm categoriesForm;
        private void btncategory_Click(object sender, EventArgs e)
        {
            if (categoriesForm == null || categoriesForm.IsDisposed)
            {
                categoriesForm = new CategoriesForm();
                categoriesForm.Show();
            }
            else
            {
                categoriesForm.BringToFront();
                categoriesForm.Focus();
            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard counts:\n" + ex.Message);
            }
        }





        //load the count and tell us the total count of products ,categories ,users

    }
}

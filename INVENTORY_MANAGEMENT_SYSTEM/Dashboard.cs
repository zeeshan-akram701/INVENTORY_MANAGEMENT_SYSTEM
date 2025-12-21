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
    }
}

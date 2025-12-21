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
    }
}

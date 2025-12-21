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
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
            lblTitle.Text = "Users";
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
    SELECT 
        UserID AS LoginID,
        Username,
        'Admin' AS Role
    FROM Users
    WHERE Username=@u AND Password=@p

    UNION ALL

    SELECT 
        EmployeeID AS LoginID,
        Username,
        Role
    FROM Employees
    WHERE Username=@u AND Password=@p AND Status='Active'
", con);




                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session.UserId = Convert.ToInt32(dr["LoginID"]);
                    Session.Username = dr["Username"].ToString();
                    Session.Role = dr["Role"].ToString();


                    Dashboard dash = new Dashboard();
                    dash.ShowDialog();           // WAIT until logout
                    this.Show();                      // login shows again
                    this.txtPassword.Clear();
                    this.txtUsername.Clear();
                }



                //if (dr.Read())
                //{
                //    this.Hide();                      // keep login alive
                //    Dashboard dashboard = new Dashboard();
                //    dashboard.ShowDialog();           // WAIT until logout
                //    this.Show();                      // login shows again
                //    this.txtPassword.Clear();
                //    this.txtUsername.Clear();
                //}
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
        }


        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }


        //private void LoginForm_shown(object sender, EventArgs e)
        //{
        //    txtUsername.Select();
        //    txtUsername.Focus();
        //}
        private void LoginForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            lblLogin.ForeColor = Color.DarkSlateGray;
            btnLogin.BackColor = Color.DarkSlateGray;
            //txtUsername.Focus();
            this.ActiveControl = txtUsername;
            //ForeColor = Color.DarkSlateGray;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
           
        }
    }
}

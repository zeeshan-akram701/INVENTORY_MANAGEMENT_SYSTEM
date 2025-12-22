using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class BaseForm : Form
    {
        protected Panel pnlHeader;
        protected Label lblTitle;
        protected Label lblInventory;
        protected Button btnClose;
        protected Button btnMinimize;

        public BaseForm()
        {
            InitializeComponent();   // VERY IMPORTANT
            CreateHeader();
        }

        private void CreateHeader()
        {
            // ===== Form Settings =====
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // ===== Header Panel =====
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = Color.Black,
            };
            this.Controls.Add(pnlHeader);
            pnlHeader.BringToFront();

            // ===== Title Label =====
            lblTitle = new Label
            {
                Text = "Page Title",
                ForeColor = Color.White,
                Font = new Font("Book Antiqua", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(15, 8)
            };
            pnlHeader.Controls.Add(lblTitle);

            //-==== inventory management system Label =====
            lblInventory = new Label
            {
                Text = "Inventory management system",
                ForeColor = Color.White,
                Font = new Font("Book Antiqua", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(500, 8)
            };
            pnlHeader.Controls.Add(lblInventory);

            // ===== Close Button =====
            btnClose = new Button
            {
                Text = "❌",
                Dock = DockStyle.Right,
                Width = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = pnlHeader.BackColor
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            pnlHeader.Controls.Add(btnClose);

            // ===== Minimize Button =====
            btnMinimize = new Button
            {
                Text = "➖",
                Dock = DockStyle.Right,
                Width = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = pnlHeader.BackColor
            };
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pnlHeader.Controls.Add(btnMinimize);

            // ===== Dragging =====
            pnlHeader.MouseDown += Header_MouseDown;
            lblTitle.MouseDown += Header_MouseDown;
        }

        // ===== Drag Logic =====
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ===== Methods for child forms =====
        protected void SetPageTitle(string title)
        {
            lblTitle.Text = title;
        }

        protected void ShowMinimizeButton(bool show)
        {
            btnMinimize.Visible = show;
        }
    }
}

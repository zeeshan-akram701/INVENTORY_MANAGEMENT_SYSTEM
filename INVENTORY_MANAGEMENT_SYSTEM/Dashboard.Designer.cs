namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnlogout = new Button();
            btndash = new Button();
            btncategory = new Button();
            btnreports = new Button();
            btnuser = new Button();
            btnproducts = new Button();
            userspanel = new Panel();
            lblTotalUsers = new Label();
            lblusersData = new Label();
            pnlorders = new Panel();
            lblTotalProducts = new Label();
            lblproducts = new Label();
            pnlsales = new Panel();
            lblTotalSales = new Label();
            lblsales = new Label();
            dgvSales = new DataGridView();
            lblSalesMain = new Label();
            dgvToday = new DataGridView();
            lblTodaySales = new Label();
            lblWelcome = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            userspanel.SuspendLayout();
            pnlorders.SuspendLayout();
            pnlsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToday).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Size = new Size(1851, 65);
            pnlHeader.Controls.SetChildIndex(btnMinimize, 0);
            pnlHeader.Controls.SetChildIndex(btnClose, 0);
            pnlHeader.Controls.SetChildIndex(lblInventory, 0);
            pnlHeader.Controls.SetChildIndex(lblTitle, 0);
            pnlHeader.Controls.SetChildIndex(lblWelcome, 0);
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(34, 9);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1761, 0);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1806, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btndash);
            panel1.Controls.Add(btncategory);
            panel1.Controls.Add(btnreports);
            panel1.Controls.Add(btnuser);
            panel1.Controls.Add(btnproducts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 825);
            panel1.TabIndex = 4;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Black;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = SystemColors.ButtonHighlight;
            btnlogout.Location = new Point(0, 198);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(297, 54);
            btnlogout.TabIndex = 15;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btndash
            // 
            btndash.BackColor = Color.Black;
            btndash.Cursor = Cursors.Hand;
            btndash.FlatStyle = FlatStyle.Flat;
            btndash.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndash.ForeColor = SystemColors.ButtonHighlight;
            btndash.Location = new Point(0, 18);
            btndash.Name = "btndash";
            btndash.Size = new Size(297, 54);
            btndash.TabIndex = 5;
            btndash.Text = "Dashboard";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // btncategory
            // 
            btncategory.BackColor = Color.Black;
            btncategory.Cursor = Cursors.Hand;
            btncategory.FlatStyle = FlatStyle.Flat;
            btncategory.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncategory.ForeColor = SystemColors.ButtonHighlight;
            btncategory.Location = new Point(0, 138);
            btncategory.Name = "btncategory";
            btncategory.Size = new Size(297, 54);
            btncategory.TabIndex = 12;
            btncategory.Text = "Sales";
            btncategory.UseVisualStyleBackColor = false;
            btncategory.Click += btncategory_Click;
            // 
            // btnreports
            // 
            btnreports.BackColor = Color.Black;
            btnreports.Cursor = Cursors.Hand;
            btnreports.FlatStyle = FlatStyle.Flat;
            btnreports.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreports.ForeColor = SystemColors.ButtonHighlight;
            btnreports.Location = new Point(0, 258);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(297, 54);
            btnreports.TabIndex = 13;
            btnreports.Text = "Reports";
            btnreports.UseVisualStyleBackColor = false;
            btnreports.Click += btnreports_Click;
            // 
            // btnuser
            // 
            btnuser.BackColor = Color.Black;
            btnuser.Cursor = Cursors.Hand;
            btnuser.FlatStyle = FlatStyle.Flat;
            btnuser.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnuser.ForeColor = SystemColors.ButtonHighlight;
            btnuser.Location = new Point(0, 318);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(297, 54);
            btnuser.TabIndex = 14;
            btnuser.Text = "User";
            btnuser.UseVisualStyleBackColor = false;
            btnuser.Click += btnuser_Click;
            // 
            // btnproducts
            // 
            btnproducts.BackColor = Color.Black;
            btnproducts.Cursor = Cursors.Hand;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducts.ForeColor = SystemColors.ButtonHighlight;
            btnproducts.Location = new Point(0, 78);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(297, 54);
            btnproducts.TabIndex = 11;
            btnproducts.Text = "Products";
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click;
            // 
            // userspanel
            // 
            userspanel.BackColor = Color.Gray;
            userspanel.Controls.Add(lblTotalUsers);
            userspanel.Controls.Add(lblusersData);
            userspanel.Cursor = Cursors.Hand;
            userspanel.Location = new Point(394, 646);
            userspanel.Name = "userspanel";
            userspanel.Size = new Size(300, 150);
            userspanel.TabIndex = 5;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = SystemColors.ButtonHighlight;
            lblTotalUsers.Location = new Point(125, 82);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(24, 28);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "0";
            // 
            // lblusersData
            // 
            lblusersData.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusersData.ForeColor = SystemColors.ButtonHighlight;
            lblusersData.Location = new Point(76, 16);
            lblusersData.Name = "lblusersData";
            lblusersData.Size = new Size(177, 47);
            lblusersData.TabIndex = 0;
            lblusersData.Text = "Total Users";
            // 
            // pnlorders
            // 
            pnlorders.BackColor = Color.DimGray;
            pnlorders.Controls.Add(lblTotalProducts);
            pnlorders.Controls.Add(lblproducts);
            pnlorders.Cursor = Cursors.Hand;
            pnlorders.Location = new Point(804, 646);
            pnlorders.Name = "pnlorders";
            pnlorders.Size = new Size(300, 150);
            pnlorders.TabIndex = 6;
            pnlorders.Paint += pnlorders_Paint;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.ForeColor = SystemColors.ButtonHighlight;
            lblTotalProducts.Location = new Point(140, 82);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(24, 28);
            lblTotalProducts.TabIndex = 2;
            lblTotalProducts.Text = "0";
            lblTotalProducts.Click += label2_Click;
            // 
            // lblproducts
            // 
            lblproducts.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblproducts.ForeColor = SystemColors.ButtonHighlight;
            lblproducts.Location = new Point(44, 16);
            lblproducts.Name = "lblproducts";
            lblproducts.Size = new Size(185, 38);
            lblproducts.TabIndex = 0;
            lblproducts.Text = "Total Products";
            // 
            // pnlsales
            // 
            pnlsales.BackColor = Color.FromArgb(64, 64, 64);
            pnlsales.Controls.Add(lblTotalSales);
            pnlsales.Controls.Add(lblsales);
            pnlsales.Cursor = Cursors.Hand;
            pnlsales.Location = new Point(1236, 646);
            pnlsales.Name = "pnlsales";
            pnlsales.Size = new Size(300, 150);
            pnlsales.TabIndex = 6;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = SystemColors.ButtonHighlight;
            lblTotalSales.Location = new Point(124, 82);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(24, 28);
            lblTotalSales.TabIndex = 1;
            lblTotalSales.Text = "0";
            // 
            // lblsales
            // 
            lblsales.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsales.ForeColor = SystemColors.ButtonHighlight;
            lblsales.Location = new Point(60, 16);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(200, 47);
            lblsales.TabIndex = 0;
            lblsales.Text = "Total Sales";
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.BackgroundColor = SystemColors.ButtonFace;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.GridColor = SystemColors.Window;
            dgvSales.Location = new Point(1120, 203);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 62;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(652, 332);
            dgvSales.TabIndex = 7;
            // 
            // lblSalesMain
            // 
            lblSalesMain.BackColor = Color.FromArgb(64, 64, 64);
            lblSalesMain.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesMain.ForeColor = SystemColors.ButtonHighlight;
            lblSalesMain.Location = new Point(1348, 113);
            lblSalesMain.Name = "lblSalesMain";
            lblSalesMain.Size = new Size(212, 57);
            lblSalesMain.TabIndex = 8;
            lblSalesMain.Text = "Total Sales ";
            // 
            // dgvToday
            // 
            dgvToday.AllowUserToAddRows = false;
            dgvToday.AllowUserToDeleteRows = false;
            dgvToday.AllowUserToResizeColumns = false;
            dgvToday.AllowUserToResizeRows = false;
            dgvToday.BackgroundColor = SystemColors.ButtonFace;
            dgvToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToday.Location = new Point(386, 208);
            dgvToday.Name = "dgvToday";
            dgvToday.ReadOnly = true;
            dgvToday.RowHeadersWidth = 62;
            dgvToday.Size = new Size(627, 327);
            dgvToday.TabIndex = 9;
            // 
            // lblTodaySales
            // 
            lblTodaySales.BackColor = Color.FromArgb(64, 64, 64);
            lblTodaySales.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySales.ForeColor = SystemColors.ButtonHighlight;
            lblTodaySales.Location = new Point(597, 113);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(246, 57);
            lblTodaySales.TabIndex = 10;
            lblTodaySales.Text = "Todays Sales ";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(1228, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(197, 42);
            lblWelcome.TabIndex = 11;
            lblWelcome.Text = "label1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1851, 890);
            Controls.Add(lblTodaySales);
            Controls.Add(dgvToday);
            Controls.Add(lblSalesMain);
            Controls.Add(dgvSales);
            Controls.Add(pnlsales);
            Controls.Add(pnlorders);
            Controls.Add(userspanel);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            Controls.SetChildIndex(pnlHeader, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(userspanel, 0);
            Controls.SetChildIndex(pnlorders, 0);
            Controls.SetChildIndex(pnlsales, 0);
            Controls.SetChildIndex(dgvSales, 0);
            Controls.SetChildIndex(lblSalesMain, 0);
            Controls.SetChildIndex(dgvToday, 0);
            Controls.SetChildIndex(lblTodaySales, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            userspanel.ResumeLayout(false);
            userspanel.PerformLayout();
            pnlorders.ResumeLayout(false);
            pnlorders.PerformLayout();
            pnlsales.ResumeLayout(false);
            pnlsales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btndash;
        private Button btnproducts;
        private Button btncategory;
        private Button btnreports;
        private Button btnuser;
        private Button btnlogout;
        private Panel userspanel;
        private Label lblusersData;
        private Panel pnlorders;
        private Label lblproducts;
        private Panel pnlsales;
        private Label lblsales;
        private Label lblTotalUsers;
        private Label lblTotalProducts;
        private Label lblTotalSales;
        private DataGridView dgvSales;
        private Label lblSalesMain;
        private DataGridView dgvToday;
        private Label lblTodaySales;
        private Label lblWelcome;
    }
}
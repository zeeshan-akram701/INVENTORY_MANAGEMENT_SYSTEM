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
            lblusersData = new Label();
            pnlorders = new Panel();
            lblproducts = new Label();
            pnlsales = new Panel();
            lblsales = new Label();
            lblTotalUsers = new Label();
            lblTotalProducts = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            userspanel.SuspendLayout();
            pnlorders.SuspendLayout();
            pnlsales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Size = new Size(1851, 65);
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
            btnlogout.Location = new Point(0, 318);
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
            btncategory.Location = new Point(0, 258);
            btncategory.Name = "btncategory";
            btncategory.Size = new Size(297, 54);
            btncategory.TabIndex = 12;
            btncategory.Text = "Category";
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
            btnreports.Location = new Point(0, 198);
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
            btnuser.Location = new Point(0, 138);
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
            pnlsales.Controls.Add(lblsales);
            pnlsales.Cursor = Cursors.Hand;
            pnlsales.Location = new Point(1236, 646);
            pnlsales.Name = "pnlsales";
            pnlsales.Size = new Size(300, 150);
            pnlsales.TabIndex = 6;
            // 
            // lblsales
            // 
            lblsales.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsales.ForeColor = SystemColors.ButtonHighlight;
            lblsales.Location = new Point(60, 59);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(200, 35);
            lblsales.TabIndex = 0;
            lblsales.Text = "Total Sales";
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1851, 890);
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
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            userspanel.ResumeLayout(false);
            userspanel.PerformLayout();
            pnlorders.ResumeLayout(false);
            pnlorders.PerformLayout();
            pnlsales.ResumeLayout(false);
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
    }
}
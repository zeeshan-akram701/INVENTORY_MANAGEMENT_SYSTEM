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
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Size = new Size(1601, 65);
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(34, 9);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1511, 0);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1556, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btndash);
            panel1.Controls.Add(btncategory);
            panel1.Controls.Add(btnreports);
            panel1.Controls.Add(btnuser);
            panel1.Controls.Add(btnproducts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 780);
            panel1.TabIndex = 4;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.ForestGreen;
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
            // 
            // btndash
            // 
            btndash.BackColor = Color.ForestGreen;
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
            // 
            // btncategory
            // 
            btncategory.BackColor = Color.ForestGreen;
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
            // 
            // btnreports
            // 
            btnreports.BackColor = Color.ForestGreen;
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
            // 
            // btnuser
            // 
            btnuser.BackColor = Color.ForestGreen;
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
            // 
            // btnproducts
            // 
            btnproducts.BackColor = Color.ForestGreen;
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
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1601, 845);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            Controls.SetChildIndex(pnlHeader, 0);
            Controls.SetChildIndex(panel1, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
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


    }
}
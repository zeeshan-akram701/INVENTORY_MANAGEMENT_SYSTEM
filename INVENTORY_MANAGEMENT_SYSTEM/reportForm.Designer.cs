namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class reportForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvReport;
        private Button btnAllProducts;
        private Button btnLowStock;
        private Button btnSearch;
        private TextBox txtSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvReport = new DataGridView();
            btnAllProducts = new Button();
            btnLowStock = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Size = new Size(1375, 81);
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(19, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            // 
            // lblInventory
            // 
            lblInventory.Location = new Point(625, 10);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1263, 0);
            btnClose.Margin = new Padding(4);
            btnClose.Size = new Size(56, 81);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1319, 0);
            btnMinimize.Margin = new Padding(4);
            btnMinimize.Size = new Size(56, 81);
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.ColumnHeadersHeight = 34;
            dgvReport.Location = new Point(148, 226);
            dgvReport.Margin = new Padding(4);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1085, 500);
            dgvReport.TabIndex = 1;
            // 
            // btnAllProducts
            // 
            btnAllProducts.Location = new Point(517, 127);
            btnAllProducts.Margin = new Padding(4);
            btnAllProducts.Name = "btnAllProducts";
            btnAllProducts.Size = new Size(150, 38);
            btnAllProducts.TabIndex = 4;
            btnAllProducts.Text = "All Products";
            btnAllProducts.Click += btnAllProducts_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Location = new Point(695, 127);
            btnLowStock.Margin = new Padding(4);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(150, 38);
            btnLowStock.TabIndex = 5;
            btnLowStock.Text = "Low Stock";
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(368, 127);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 38);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(32, 131);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Product Name";
            txtSearch.Size = new Size(310, 31);
            txtSearch.TabIndex = 2;
            // 
            // reportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1375, 794);
            Controls.Add(dgvReport);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAllProducts);
            Controls.Add(btnLowStock);
            Margin = new Padding(4);
            Name = "reportForm";
            Text = "reportForm";
            Load += reportForm_Load;
            Controls.SetChildIndex(btnLowStock, 0);
            Controls.SetChildIndex(btnAllProducts, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(dgvReport, 0);
            Controls.SetChildIndex(pnlHeader, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

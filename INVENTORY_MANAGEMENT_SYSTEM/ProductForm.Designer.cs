namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtCostPrice;
        private TextBox txtSellingPrice;
        private TextBox txtQuantity;
        private TextBox txtReorderLevel;

        private ComboBox cmbStatus;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtCostPrice = new TextBox();
            txtSellingPrice = new TextBox();
            txtQuantity = new TextBox();
            txtReorderLevel = new TextBox();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Size = new Size(1625, 81);
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
            btnClose.Location = new Point(1513, 0);
            btnClose.Margin = new Padding(4, 4, 4, 4);
            btnClose.Size = new Size(56, 81);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1569, 0);
            btnMinimize.Margin = new Padding(4, 4, 4, 4);
            btnMinimize.Size = new Size(56, 81);
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(38, 100);
            txtProductName.Margin = new Padding(4, 4, 4, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(249, 31);
            txtProductName.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(312, 100);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Category";
            txtCategory.Size = new Size(249, 31);
            txtCategory.TabIndex = 2;
            // 
            // txtCostPrice
            // 
            txtCostPrice.Location = new Point(38, 162);
            txtCostPrice.Margin = new Padding(4, 4, 4, 4);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.PlaceholderText = "Cost Price";
            txtCostPrice.Size = new Size(249, 31);
            txtCostPrice.TabIndex = 3;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(312, 162);
            txtSellingPrice.Margin = new Padding(4, 4, 4, 4);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.PlaceholderText = "Selling Price";
            txtSellingPrice.Size = new Size(249, 31);
            txtSellingPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(38, 225);
            txtQuantity.Margin = new Padding(4, 4, 4, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Quantity";
            txtQuantity.Size = new Size(249, 31);
            txtQuantity.TabIndex = 5;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(312, 225);
            txtReorderLevel.Margin = new Padding(4, 4, 4, 4);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.PlaceholderText = "Reorder Level";
            txtReorderLevel.Size = new Size(249, 31);
            txtReorderLevel.TabIndex = 6;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(38, 288);
            cmbStatus.Margin = new Padding(4, 4, 4, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(249, 33);
            cmbStatus.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 350);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(162, 350);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(288, 350);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(412, 350);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 44);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeight = 34;
            dgvProducts.Location = new Point(625, 100);
            dgvProducts.Margin = new Padding(4, 4, 4, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(875, 375);
            dgvProducts.TabIndex = 12;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 583);
            Controls.Add(txtProductName);
            Controls.Add(txtCategory);
            Controls.Add(txtCostPrice);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtReorderLevel);
            Controls.Add(cmbStatus);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvProducts);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            Controls.SetChildIndex(dgvProducts, 0);
            Controls.SetChildIndex(btnClear, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(cmbStatus, 0);
            Controls.SetChildIndex(txtReorderLevel, 0);
            Controls.SetChildIndex(txtQuantity, 0);
            Controls.SetChildIndex(txtSellingPrice, 0);
            Controls.SetChildIndex(txtCostPrice, 0);
            Controls.SetChildIndex(txtCategory, 0);
            Controls.SetChildIndex(txtProductName, 0);
            Controls.SetChildIndex(pnlHeader, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

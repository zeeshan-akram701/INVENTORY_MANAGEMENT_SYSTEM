namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbProduct;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtTotal;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbProduct = new ComboBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtTotal = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Size = new Size(1171, 65);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(1081, 0);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Location = new Point(1126, 0);
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Location = new Point(180, 100);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(274, 33);
            cmbProduct.TabIndex = 2;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(180, 150);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(274, 31);
            txtQuantity.TabIndex = 4;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(274, 31);
            txtPrice.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(180, 247);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(274, 31);
            txtTotal.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(180, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(274, 47);
            btnSave.TabIndex = 9;
            btnSave.Text = "Complete Sale";
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Location = new Point(50, 100);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.Location = new Point(50, 150);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.Location = new Point(50, 200);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.Location = new Point(50, 250);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 7;
            label4.Text = "Total";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            ClientSize = new Size(1171, 450);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtTotal);
            Controls.Add(btnSave);
            Name = "SalesForm";
            Load += SalesForm_Load;
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(txtTotal, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtQuantity, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbProduct, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(pnlHeader, 0);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

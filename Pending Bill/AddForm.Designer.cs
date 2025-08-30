using System.Windows.Forms;

namespace Pending_Bill
{
    partial class AddForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCustomer;
        private Label lblItem;
        private Label lblRate;
        private Label lblPurchases;
        private Label lblPaid;
        private TextBox txtCustomer;
        private TextBox txtItem;
        private TextBox txtRate;
        private TextBox txtPurchases;
        private TextBox txtPaid;
        private Button btnAdd;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(30, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(100, 23);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name:";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(30, 60);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(100, 23);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item Name:";
            // 
            // lblRate
            // 
            this.lblRate.Location = new System.Drawing.Point(30, 100);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 23);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Rate (₹):";
            // 
            // lblPurchases
            // 
            this.lblPurchases.Location = new System.Drawing.Point(30, 140);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(100, 23);
            this.lblPurchases.TabIndex = 6;
            this.lblPurchases.Text = "Purchases:";
            // 
            // lblPaid
            // 
            this.lblPaid.Location = new System.Drawing.Point(30, 180);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(100, 23);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "Paid (₹):";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(150, 20);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(200, 22);
            this.txtCustomer.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(150, 60);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(200, 22);
            this.txtItem.TabIndex = 3;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(150, 100);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 22);
            this.txtRate.TabIndex = 5;
            // 
            // txtPurchases
            // 
            this.txtPurchases.Location = new System.Drawing.Point(150, 140);
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.Size = new System.Drawing.Size(200, 22);
            this.txtPurchases.TabIndex = 7;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(150, 180);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(200, 22);
            this.txtPaid.TabIndex = 9;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(200, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblPurchases);
            this.Controls.Add(this.txtPurchases);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Pending Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

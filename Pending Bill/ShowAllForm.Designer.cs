using System.Windows.Forms;

namespace Pending_Bill
{
    partial class ShowAllForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBack;
        private CheckBox chkShowPending;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkShowPending = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 60);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(400, 200);
            this.dataGridView.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(150, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkShowPending
            // 
            this.chkShowPending.AutoSize = true;
            this.chkShowPending.Location = new System.Drawing.Point(186, 284);
            this.chkShowPending.Name = "chkShowPending";
            this.chkShowPending.Size = new System.Drawing.Size(79, 20);
            this.chkShowPending.TabIndex = 2;
            this.chkShowPending.Text = "Show all";
            this.chkShowPending.UseVisualStyleBackColor = true;
            this.chkShowPending.CheckedChanged += new System.EventHandler(this.chkShowPending_CheckedChanged);
            // 
            // ShowAllForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chkShowPending);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show All Pending Bills";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dataGridView;
    }
}

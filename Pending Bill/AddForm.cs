using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pending_Bill
{
    public partial class AddForm : Form
    {
        public AddForm() => InitializeComponent();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connStr = "Provider=MSOLEDBSQL.1;Data Source=RAHUL\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PendingBills";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO Bills (CustomerName, ItemName, Rate, Purchases, Paid) VALUES (?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("?", txtItem.Text);
                    cmd.Parameters.AddWithValue("?", Convert.ToDecimal(txtRate.Text));
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtPurchases.Text));
                    cmd.Parameters.AddWithValue("?", Convert.ToDecimal(txtPaid.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
                mainForm.Show();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

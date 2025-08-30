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
namespace Pending_Bill
{
    public partial class SearchForm : Form
    {
            public SearchForm()
    {
        InitializeComponent();
    }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connStr = "Provider=MSOLEDBSQL.1;Data Source=RAHUL\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PendingBills";
            decimal pendingTotal = 0;

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                // Load full transaction rows
                string query = "SELECT CustomerName, ItemName, Rate, Purchases, Paid FROM Bills WHERE CustomerName = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtSearchName.Text);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;

                        // Calculate pending total
                        foreach (DataRow row in dt.Rows)
                        {
                            decimal rate = Convert.ToDecimal(row["Rate"]);
                            int purchases = Convert.ToInt32(row["Purchases"]);
                            decimal paid = Convert.ToDecimal(row["Paid"]);
                            pendingTotal += (rate * purchases - paid);
                        }
                    }
                }
            }

            lblResult.Text = pendingTotal > 0
                ? $"Pending: ₹{pendingTotal}"
                : "No pending bills.";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
                mainForm.Show();
        }
    }

}
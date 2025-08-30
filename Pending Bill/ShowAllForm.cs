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
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            string connStr = "Provider=MSOLEDBSQL.1;Data Source=RAHUL\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PendingBills";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT *, (Rate * Purchases - Paid) AS PendingAmount FROM Bills";
                if (!chkShowPending.Checked)
                    query += " WHERE (Rate * Purchases - Paid) > 0";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
                mainForm.Show();
        }

        private void chkShowPending_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

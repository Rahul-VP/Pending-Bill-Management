// Note: Replace YOUR_SERVER and YOUR_DB with your actual SQL Server and Database name.

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pending_Bill
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllForm showAllForm = new ShowAllForm();
            showAllForm.Show();
        }
    
    }


   

   
}
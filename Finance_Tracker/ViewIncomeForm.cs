using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Tracker
{
    public partial class ViewIncomeForm : Form
    {
        static string sqlConnectionString = Properties.Resources.sqlConnector.ToString();
        SqlConnection connectionString = new SqlConnection(@sqlConnectionString);
        public ViewIncomeForm()
        {
            InitializeComponent();
            DisplayIncomes();
        }
        private void incomeLabel_Click(object sender, EventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.Show();
            this.Hide();
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            ExpensesForm expenses = new ExpensesForm();
            expenses.Show();
            this.Hide();
        }

        private void ExpensesBreakdownLabel_Click(object sender, EventArgs e)
        {
            ViewExpensesForm viewExpensesForm = new ViewExpensesForm();
            viewExpensesForm.Show();
            this.Hide();
        }
        private void DisplayIncomes()
        {
            connectionString.Open();

            string Query = "select * from Income_Table";
            SqlDataAdapter sda = new SqlDataAdapter(Query, connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];

            connectionString.Close();
        }

        private void logoutlabel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void Exit_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

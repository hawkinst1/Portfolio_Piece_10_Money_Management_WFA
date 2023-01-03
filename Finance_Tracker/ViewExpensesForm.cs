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
    public partial class ViewExpensesForm : Form
    {
        static string sqlConnectionString = Properties.Resources.sqlConnector.ToString();
        SqlConnection connectionString = new SqlConnection(@sqlConnectionString);
        public ViewExpensesForm()
        {
            InitializeComponent();
            DisplayExpenses();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            IncomeForm income = new IncomeForm();
            income.Show();
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
            ExpensesForm expensesForm = new ExpensesForm();
            expensesForm.Show();
            this.Hide();
        }

        private void incomeBreakdown_Click(object sender, EventArgs e)
        {
            ViewIncomeForm viewIncomeForm = new ViewIncomeForm();
            viewIncomeForm.Show();
            this.Hide();
        }
        private void DisplayExpenses()
        {
            connectionString.Open();

            string Query = "select * from Expenses_Table";
            SqlDataAdapter sda = new SqlDataAdapter(Query, connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            ExpensesDGV.DataSource = ds.Tables[0];

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

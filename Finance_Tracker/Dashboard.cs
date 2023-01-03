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
    public partial class Dashboard : Form
    {
        static string sqlConnectionString = Properties.Resources.sqlConnector.ToString();
        SqlConnection connectionString = new SqlConnection(@sqlConnectionString);

        public Dashboard()
        {
            InitializeComponent();
            GetTotalIncome();
            GetTotalExpenses();
            GetIncomeTransactionCount();
            GetExpenseTransactionCount();
            GetIncomeLatestDate();
            GetExpensesLatestDate();
            GetLargestIncome();
            GetLargestExpense();
            GetSmallestIncome();
            GetSmallestExpense();
            GetBalance();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.Show();
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

        private void ExpensesBreakdownLabel_Click(object sender, EventArgs e)
        {
            ViewExpensesForm expensesForm = new ViewExpensesForm();
            expensesForm.Show();
            this.Hide();
        }
        private void GetTotalIncome()
        {
            
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncomeAmount) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dashboard__income_amount_label.Text = "£" + dt.Rows[0][0].ToString();
          
            connectionString.Close();
        }
            
        private void GetTotalExpenses()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmount) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //If x.0 thne we need to turn into x.00
            dashboard__expenses_amount_label.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }
        private void GetIncomeTransactionCount()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dashboard__income_count_label.Text = dt.Rows[0][0].ToString();
         
            connectionString.Close();
        }
        private void GetExpenseTransactionCount()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dashboard__expenses_count_label.Text =  dt.Rows[0][0].ToString();

            connectionString.Close();
        }
        private void GetIncomeLatestDate() // need to make date uk
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Max(IncomeDate) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__income_date.Text = dt.Rows[0][0].ToString();
            dash__income_latest.Text = dt.Rows[0][0].ToString();


            connectionString.Close();
        }
        private void GetExpensesLatestDate()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__expenses_date.Text = dt.Rows[0][0].ToString();
            dash__expense_latest.Text = dt.Rows[0][0].ToString();

            connectionString.Close();
        }

        private void GetLargestIncome()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Max(IncomeAmount) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__income_largest.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }
      //need to make it monthly rollover
        private void GetLargestExpense()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmount) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__expense_largest.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }
        private void GetSmallestIncome()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Min(IncomeAmount) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__income_smallest.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }
        private void GetSmallestExpense()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmount) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dash__expense_smallest.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }
        private void GetBalance()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncomeAmount) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            SqlDataAdapter expenseData = new SqlDataAdapter("select Sum(ExpAmount) from Expenses_Table where ExpUser = '" + LoginForm.User + "'", connectionString);

            DataTable dt = new DataTable();
            DataTable expensesTable = new DataTable();

            sda.Fill(dt);
            expenseData.Fill(expensesTable);
            
            float totalIncome;
            float totalExpenses;

            var tableData = dt.Rows[0][0].ToString();
            var ExpTableData = expensesTable.Rows[0][0].ToString();

            bool Incomesuccess  =  float.TryParse(tableData, out totalIncome);
            bool Expensesuccess  =  float.TryParse(ExpTableData, out totalExpenses);

            float balanceTotal = totalIncome - totalExpenses;

            dash__balance_label.Text = "£"+ balanceTotal.ToString();

            connectionString.Close();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void logoutlabel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
            
        }

        private void close_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 
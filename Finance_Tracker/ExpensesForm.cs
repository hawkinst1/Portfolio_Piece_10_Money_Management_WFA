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

    public partial class ExpensesForm : Form
    {
        static string sqlConnectionString = Properties.Resources.sqlConnector.ToString();
        SqlConnection connectionString = new SqlConnection(@sqlConnectionString);
        public ExpensesForm()
        {
            InitializeComponent();
            GetExpenseTotal();
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

        private void incomeBreakdown_Click(object sender, EventArgs e)
        {
            ViewIncomeForm incomeForm = new ViewIncomeForm();
            incomeForm.Show();
            this.Hide();
        }

        private void ExpensesBreakdownLabel_Click(object sender, EventArgs e)
        {
            ViewExpensesForm viewExpensesForm = new ViewExpensesForm();
            viewExpensesForm.Show();
            this.Hide();
        }
        private void Clear()
        {
            Expenses__itemName_tb.Text = "";
            Expenses__Amount_tb.Text = "";
            Expenses__Category_dropdown.SelectedItem = 0;
            Expenses__Desc_tb.Text = "";
         }
        private void Expenses__submit_btn_Click(object sender, EventArgs e)
        {
            if (Expenses__itemName_tb.Text == "" || Expenses__Amount_tb.Text == "" || Expenses__Category_dropdown.SelectedIndex == -1 || Expenses__Desc_tb.Text == "" )
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand("insert into Expenses_Table (ExpName, ExpAmount, ExpCategory, ExpDate, ExpDescription, ExpUser) values (@EN,@EA,@EC,@ED,@EDesc,@EU)", connectionString);
                    cmd.Parameters.AddWithValue("@EN", Expenses__itemName_tb.Text);
                    cmd.Parameters.AddWithValue("@EA", Expenses__Amount_tb.Text);
                    cmd.Parameters.AddWithValue("@EC", Expenses__Category_dropdown.SelectedItem).ToString();
                    cmd.Parameters.AddWithValue("@ED", Expenses__Date_date.Value.Date);
                    cmd.Parameters.AddWithValue("@EDesc", Expenses__Desc_tb.Text);
                    cmd.Parameters.AddWithValue("@EU", LoginForm.User);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Added");
                    connectionString.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    throw;
                }
            }
        }
        private void GetExpenseTotal()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select sum(ExpAmount) from Expenses_Table where ExpUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            ExpenseForm__total_label.Text = "£" + dt.Rows[0][0].ToString();

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

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
    public partial class IncomeForm : Form
    {
        static string sqlConnectionString = Properties.Resources.sqlConnector.ToString();
        SqlConnection connectionString = new SqlConnection(@sqlConnectionString);
        public IncomeForm()
        {
            InitializeComponent();
            GetIncomeTotal();
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
            ViewIncomeForm viewIncome = new ViewIncomeForm();
            viewIncome.Show();
            this.Hide();    
        }

        private void ExpensesBreakdownLabel_Click(object sender, EventArgs e)
        {
            ViewExpensesForm expensesForm = new ViewExpensesForm();
            expensesForm.Show();
            this.Hide();
        }
        private void logoutlabel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
        private void Clear()
        {
            Income_name_tb.Text = "";
            income_amount_tb.Text = "";
            income_cat_cb.SelectedIndex = 0;
            Income_desc.Text = "";
        }
        private void Income_Save_btn_Click(object sender, EventArgs e)
        {
            if (Income_name_tb.Text == "" || income_amount_tb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand("insert into Income_Table (IncomeName, IncomeAmount, IncomeCategory, IncomeDate, IncomeDescription, IncomeUser) values (@IN,@IA,@IC,@ID,@IDesc,@IU)", connectionString);
                    cmd.Parameters.AddWithValue("@IN", Income_name_tb.Text);
                    cmd.Parameters.AddWithValue("@IA", income_amount_tb.Text);
                    cmd.Parameters.AddWithValue("@IC", income_cat_cb.SelectedItem).ToString();
                    cmd.Parameters.AddWithValue("@ID", IncomeDate.Value.Date);
                    cmd.Parameters.AddWithValue("@IDesc", Income_desc.Text);
                    cmd.Parameters.AddWithValue("@IU", LoginForm.User);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added");
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
        private void GetIncomeTotal()
        {
            connectionString.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select sum(IncomeAmount) from Income_Table where IncomeUser='" + LoginForm.User + "'", connectionString);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            Income__total_label.Text = "£" + dt.Rows[0][0].ToString();

            connectionString.Close();
        }

        private void Exit_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

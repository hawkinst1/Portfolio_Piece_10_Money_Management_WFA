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
    public partial class LoginForm : Form
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-USNVQBN\SQLEXPRESS;Initial Catalog=FinanceTrackerDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static string User;
        public LoginForm()
        {
            InitializeComponent();      
        }

        private void Register_Label_Click(object sender, EventArgs e)
        {
            UsersForm userform = new UsersForm();
            userform.Show();          
        }

        private void Login__button_Click(object sender, EventArgs e)
        {
            if(login__userName.Text == "" || Login__password.Text == "")
            {
                MessageBox.Show("Not all fields entered");
            } else
            {
                connectionString.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserInfo_Table where UserName='" + login__userName.Text + "' and UserPassword='" + Login__password.Text + "'", connectionString);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = login__userName.Text;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                    connectionString.Close();
                }
                else
                {
                    MessageBox.Show("UserName or Password Invalid");
                    login__userName.Text = "";
                    Login__password.Text = "";
                }
                connectionString.Close();
            }
          
        }

        private void Exit_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

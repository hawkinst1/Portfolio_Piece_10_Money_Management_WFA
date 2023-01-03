using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finance_Tracker
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-USNVQBN\SQLEXPRESS;Initial Catalog=FinanceTrackerDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void Clear()
        {
            CreateUserName.Text = "";
            CreateUserPass.Text = "";         
        }
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            if (CreateUserName.Text == "" || CreateUserPass.Text == "" )
            {
                MessageBox.Show("Missing information");
            } else
            {
                try
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserInfo_Table (UserName, UserPassword, UserDoB) values (@UN,@UP,@UD)", connectionString);
                    cmd.Parameters.AddWithValue("@UN",CreateUserName.Text);
                    cmd.Parameters.AddWithValue("@UP",CreateUserPass.Text);
                    cmd.Parameters.AddWithValue("@UD",CreateUserDOB.Value);
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("User Created Successfully");
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
         
        private void Exit_window_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

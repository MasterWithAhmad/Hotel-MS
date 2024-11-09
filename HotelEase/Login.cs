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

namespace HotelEase
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public Login()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password, out string firstName, out string lastName, out string role)
        {
            firstName = string.Empty;
            lastName = string.Empty;
            role = string.Empty;

            string query = "SELECT FirstName, LastName, Role FROM Staff WHERE Username = @Username AND Password = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    role = reader["Role"].ToString();
                    return true;
                }
            }
            return false;
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password, out string firstName, out string lastName, out string role))
            {
                Dashboard dashboard = new Dashboard(firstName, lastName, role);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

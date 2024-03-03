using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using Inventory_Management_App.Forms;
using System.Security.Cryptography;
using Inventory_Management_App.Utils;
using Inventory_Management_App.Models;
using Inventory_Management_App.Session;
using Inventory_Management_App.SqlDbConnection;

namespace Inventory_Management_App
{
    public partial class SignIn : Form
    {
        SqlConnection conn;
        public SignIn()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';
            conn = DbConnection.GetSqlConnection();
        }

        private void createAccountLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GetStarted().Show();
        }

        private void signInBtn_Click_1(object sender, EventArgs e)
        {
            string email = emailInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            if (!ValidationUtils.ValidationUtils.IsValidInput(email) || !ValidationUtils.ValidationUtils.IsValidInput(password))
            {
                MessageBox.Show("All fields should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!ValidationUtils.ValidationUtils.IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (!ValidationUtils.ValidationUtils.IsValidPassword(password))
            {
                MessageBox.Show("Password is not strong enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string query = "SELECT * FROM Users WHERE Email = '" + email + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string storedHashPassword = dataTable.Rows[0]["Password"].ToString();
                    if (HashPasswordUtils.VerifyPassword(password, storedHashPassword))
                    {
                        int userId = Convert.ToInt32(dataTable.Rows[0]["UserID"]);
                        string username = dataTable.Rows[0]["Username"].ToString();

                        User loggedInUser = new User
                        {
                            UserId = userId,
                            Username = username,
                            Email = email
                        };
                        UserManager.CurrentUser = loggedInUser;
                        MessageBox.Show("Signed in successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Dashboard().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordInput.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

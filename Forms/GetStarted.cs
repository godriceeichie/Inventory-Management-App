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
using System.Security.Cryptography;
using Inventory_Management_App.Utils;
using Inventory_Management_App.Models;
using Inventory_Management_App.Session;
using Inventory_Management_App.Forms;
using Inventory_Management_App.SqlDbConnection;

namespace Inventory_Management_App
{
    public partial class GetStarted : Form
    {
        SqlConnection conn;
        public GetStarted()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';

            conn = DbConnection.GetSqlConnection();


        }


        private void createAccountBtn_Click(object sender, EventArgs e)
        {

        }



        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordInput.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void createAccountBtn_Click_1(object sender, EventArgs e)
        {
            string username = usernameInput.Text.Trim();
            string email = emailInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            if (!ValidationUtils.ValidationUtils.IsValidInput(username) || !ValidationUtils.ValidationUtils.IsValidInput(email) || !ValidationUtils.ValidationUtils.IsValidInput(password))
            {
                MessageBox.Show("All fields should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (ValidationUtils.ValidationUtils.IsValidUsername(username))
            {
                MessageBox.Show("Username cannot begin with number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!ValidationUtils.ValidationUtils.IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (!ValidationUtils.ValidationUtils.IsValidPassword(password))
            {
                MessageBox.Show("Password is not strong enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (ValidationUtils.ValidationUtils.UserExists(username, email, conn))
            {
                MessageBox.Show("Username or email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                string hashedPassword = HashPasswordUtils.HashPassword(password);
                SqlCommand command = new SqlCommand(@"INSERT INTO [Users] ([Username], [Email], [Password]) VALUES (@Username, @Email, @Password)", conn);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                conn.Open();
                //command.ExecuteNonQuery();
                int newUserId = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();

                User loggedInUser = new User
                {
                    UserId = newUserId,
                    Username = username,
                    Email = email,
                };
                UserManager.CurrentUser = loggedInUser;
                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard().Show();
                this.Hide();


            }
        }


        private void signInLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void GetStartedForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

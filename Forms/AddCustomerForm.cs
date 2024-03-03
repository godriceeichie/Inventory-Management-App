using Inventory_Management_App.Session;
using Inventory_Management_App.SqlDbConnection;
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

namespace Inventory_Management_App.Forms
{
    public partial class AddCustomerForm : Form
    {
        Customers customersForm;
        public AddCustomerForm(Customers customersForm)
        {
            this.customersForm = customersForm;
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = customerFirstName.Text.Trim();
                string lastName = customerLastName.Text.Trim();
                string city = customerCity.Text.Trim();
                string country = customerCountry.Text.Trim();
                string phoneNumber = customerPhoneNumber.Text.Trim();
                string location = customerLocation.Text.Trim();

                if (!ValidationUtils.ValidationUtils.IsValidInput(firstName) || !ValidationUtils.ValidationUtils.IsValidInput(lastName) || !ValidationUtils.ValidationUtils.IsValidInput(city) || !ValidationUtils.ValidationUtils.IsValidInput(country) || !ValidationUtils.ValidationUtils.IsValidInput(phoneNumber) || !ValidationUtils.ValidationUtils.IsValidInput(location))
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    using (SqlConnection conn = DbConnection.GetSqlConnection())
                    {
                        conn.Open();

                        // Check if a product with the same name already exists
                        using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE [FirstName] = @FirstName AND [UserID] = @UserID", conn))
                        {
                            checkCommand.Parameters.AddWithValue("@FirstName", firstName);
                            checkCommand.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                            int existingProductCount = (int)checkCommand.ExecuteScalar();

                            if (existingProductCount > 0)
                            {
                                MessageBox.Show("Customer with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Exit the method if a duplicate product is found
                            }
                        }

                        // Insert the new product
                        using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [Customers] ([FirstName], [LastName], [City], [Country], [PhoneNumber], [Location], [UserID]) VALUES (@FirstName, @LastName, @City, @Country, @PhoneNumber, @Location, @UserID)", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                            insertCommand.Parameters.AddWithValue("@LastName", lastName);
                            insertCommand.Parameters.AddWithValue("@City", city);
                            insertCommand.Parameters.AddWithValue("@Country", country);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            insertCommand.Parameters.AddWithValue("@Location", location);
                            insertCommand.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    new Products().LoadProducts();
                    MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerFirstName.Clear();
                    customerLastName.Clear();
                    customerCity.Clear();
                    customerCountry.Clear();
                    customerPhoneNumber.Clear();
                    customerLocation.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                customersForm.LoadCustomers();
                this.Close();
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

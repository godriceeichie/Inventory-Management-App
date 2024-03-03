using Inventory_Management_App.SqlDbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Management_App.Forms
{
    public partial class EditCustomerForm : Form
    {
        Customers customersForm;
        readonly int id;
        public EditCustomerForm(int id, Customers customersForm)
        {
            InitializeComponent();
            this.customersForm = customersForm;
            this.id = id;
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

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            string firstName = customerFirstName.Text;
            string lastName = customerLastName.Text;
            string city = customerCity.Text;
            string country = customerCountry.Text;
            string phoneNumber = customerPhoneNumber.Text;
            string location = customerLocation.Text;

            if (!ValidationUtils.ValidationUtils.IsValidInput(firstName) || !ValidationUtils.ValidationUtils.IsValidInput(lastName) || !ValidationUtils.ValidationUtils.IsValidInput(city) || !ValidationUtils.ValidationUtils.IsValidInput(country) || !ValidationUtils.ValidationUtils.IsValidInput(phoneNumber) || !ValidationUtils.ValidationUtils.IsValidInput(location))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Update the record in the database
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                conn.Open();

                using (SqlCommand updateCommand = new SqlCommand(@"UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, City = @City, Country = @Country, PhoneNumber = @PhoneNumber, Location = @Location WHERE CustomerID = @CustomerID", conn))
                {

                    updateCommand.Parameters.AddWithValue("@FirstName", firstName);
                    updateCommand.Parameters.AddWithValue("@LastName", lastName);
                    updateCommand.Parameters.AddWithValue("@City", city);
                    updateCommand.Parameters.AddWithValue("@Country", country);
                    updateCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    updateCommand.Parameters.AddWithValue("@Location", location);
                    updateCommand.Parameters.AddWithValue("@CustomerID", id);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        customersForm.LoadCustomers();
                        this.Close(); // Close the form after successful update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

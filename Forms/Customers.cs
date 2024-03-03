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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            LoadCustomers();
        }

        public void LoadCustomers()
        {

            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                int i = 0;
                customersGrid.Rows.Clear();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE [UserID] = @UserID AND CONCAT([CustomerID], [FirstName], [LastName], [City], [Country], [PhoneNumber], [Location]) LIKE '%" + customerSearchBox.Text + "%'", conn))
                {
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        i++;
                        customersGrid.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void customersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the column of your buttons
            if (e.RowIndex >= 0 && (e.ColumnIndex == customersGrid.Columns["Column8"].Index || e.ColumnIndex == customersGrid.Columns["Column9"].Index))
            {
                // Get the selected row
                DataGridViewRow selectedRow = customersGrid.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[1].Value);
                // Check which button is clicked
                if (e.ColumnIndex == customersGrid.Columns["Column8"].Index)
                {
                    //Handle edit button click
                    EditCustomerForm editCustomerForm = new EditCustomerForm(id, this);
                    editCustomerForm.customerFirstName.Text = selectedRow.Cells[2].Value.ToString();
                    editCustomerForm.customerLastName.Text = selectedRow.Cells[3].Value.ToString();
                    editCustomerForm.customerCity.Text = selectedRow.Cells[4].Value.ToString();
                    editCustomerForm.customerCountry.Text = selectedRow.Cells[5].Value.ToString();
                    editCustomerForm.customerPhoneNumber.Text = selectedRow.Cells[6].Value.ToString();
                    editCustomerForm.customerLocation.Text = selectedRow.Cells[6].Value.ToString();
                    editCustomerForm.ShowDialog();

                }
                else if (e.ColumnIndex == customersGrid.Columns["Column9"].Index)
                {
                    // Handle delete button click
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DbConnection.GetSqlConnection())
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM Customers WHERE CustomerID = '" + id + "' ", conn))
                            {
                                conn.Open();
                                command.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        LoadCustomers();
                    }
                }
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            new AddCustomerForm(this).ShowDialog();
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

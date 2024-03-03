
using Inventory_Management_App.Session;
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
using Inventory_Management_App.SqlDbConnection;


namespace Inventory_Management_App.Forms
{
    public partial class AddCategoryForm : Form
    {
        Categories categoryForm;
        public AddCategoryForm(Categories categoryForm)
        {
            InitializeComponent();
            this.categoryForm = categoryForm;
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = categoryName.Text.Trim();


                if (!ValidationUtils.ValidationUtils.IsValidInput(name))
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    using (SqlConnection conn = DbConnection.GetSqlConnection())
                    {
                        conn.Open();
                        int existingCategoryCount;
                        // Check if a product with the same name already exists
                        using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Categories WHERE [CategoryName] = @CategoryName AND [UserID] = '" + UserManager.CurrentUser.UserId + "'", conn))
                        {
                            checkCommand.Parameters.AddWithValue("@CategoryName", name);

                            existingCategoryCount = (int)checkCommand.ExecuteScalar();


                        }

                        if (existingCategoryCount > 0)
                        {
                            MessageBox.Show("This category already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if a duplicate product is found
                        }

                        // Insert the new product
                        using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [Categories] ([CategoryName], [UserID]) VALUES (@CategoryName, @UserID)", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@CategoryName", name);
                            insertCommand.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);


                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    categoryForm.LoadCategories();
                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    categoryName.Clear();
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
                this.Close();
                categoryForm.LoadCategories();
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}

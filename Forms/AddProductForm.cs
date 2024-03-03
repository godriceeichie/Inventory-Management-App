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
    public partial class AddProductForm : Form
    {
        private Products productsForm;
        public AddProductForm(Products productForm)
        {
            InitializeComponent();
            LoadCategory();
            this.productsForm = productForm;
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string name = productName.Text;
                int quantity = int.Parse(productQty.Text); // Validate and parse as needed
                decimal price = decimal.Parse(productPrice.Text); // Validate and parse as needed
                string description = productDesc.Text;
                string category = productCategory.Text;

                if (!ValidationUtils.ValidationUtils.IsValidInput(name) || !ValidationUtils.ValidationUtils.IsValidInput(quantity.ToString()) || !ValidationUtils.ValidationUtils.IsValidInput(price.ToString()) || !ValidationUtils.ValidationUtils.IsValidInput(category))
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    using (SqlConnection conn = DbConnection.GetSqlConnection())
                    {
                        conn.Open();

                        // Check if a product with the same name already exists
                        using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Products WHERE [Name] = @Name", conn))
                        {
                            checkCommand.Parameters.AddWithValue("@Name", name);
                            int existingProductCount = (int)checkCommand.ExecuteScalar();

                            if (existingProductCount > 0)
                            {
                                MessageBox.Show("Product with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Exit the method if a duplicate product is found
                            }
                        }

                        // Insert the new product
                        using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [Products] ([Name], [Quantity], [Price], [Description], [Category], [UserID]) VALUES (@Name, @Quantity, @Price, @Description, @Category, @UserID)", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@Name", name);
                            insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                            insertCommand.Parameters.AddWithValue("@Price", price);
                            insertCommand.Parameters.AddWithValue("@Description", description);
                            insertCommand.Parameters.AddWithValue("@Category", category);
                            insertCommand.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    productsForm.LoadProducts();
                    MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productName.Clear();
                    productQty.Clear();
                    productPrice.Clear();
                    productDesc.Clear();
                    productCategory.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                productsForm.LoadProducts();
            }
        }

        public void LoadCategory()
        {
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                productCategory.Items.Clear();
                using (SqlCommand command = new SqlCommand("SELECT CategoryName FROM Categories WHERE UserID = '" + UserManager.CurrentUser.UserId + "'", conn))
                {
                    conn.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        productCategory.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }

            }

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
        }

        private void productQty_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void productPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void productDesc_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void productCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

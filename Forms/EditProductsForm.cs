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
    public partial class EditProductsForm : Form
    {
        private Products productsForm;
        readonly int id;
        public EditProductsForm(int id, Products productsForm)
        {
            InitializeComponent();
            LoadCategory();
            this.id = id;
            this.productsForm = productsForm;
        }

        public void LoadCategory()
        {
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                productCategory.Items.Clear();
                using (SqlCommand command = new SqlCommand("SELECT CategoryName FROM Categories", conn))
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

        private void EditProductsForm_Load(object sender, EventArgs e)
        {

        }

        
        private void editProductBtn_Click(object sender, EventArgs e)
        {
            string name = productName.Text;
            if (!int.TryParse(productQty.Text, out int quantity) ||
                !decimal.TryParse(productPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid quantity or price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = productDesc.Text;
            string category = productCategory.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Update the record in the database
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                conn.Open();

                using (SqlCommand updateCommand = new SqlCommand(@"UPDATE Products SET Name = @Name, Quantity = @Quantity, Price = @Price, Description = @Description, Category = @Category WHERE Product_Id = @ProductId", conn))
                {

                    updateCommand.Parameters.AddWithValue("@Name", name);
                    updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                    updateCommand.Parameters.AddWithValue("@Price", price);
                    updateCommand.Parameters.AddWithValue("@Description", description);
                    updateCommand.Parameters.AddWithValue("@Category", category);
                    updateCommand.Parameters.AddWithValue("@ProductId", id);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productsForm.LoadProducts();
                        this.Close(); // Close the form after successful update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void productCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void productDesc_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void productPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void productQty_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new Products().LoadProducts();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void InitializeProductsGrid()
        {

            // Find the "Actions" column by name
            DataGridViewButtonColumn actionsColumn = (DataGridViewButtonColumn)productsGrid.Columns["Actions"];

            if (actionsColumn != null)
            {
                // Create buttons with images
                DataGridViewButtonCell editButton = new DataGridViewButtonCell();
                editButton.Value = Properties.Resources.edit_text; // Replace with your edit image

                DataGridViewButtonCell deleteButton = new DataGridViewButtonCell();
                deleteButton.Value = Properties.Resources.delete; // Replace with your delete image

                // Add buttons to specific cells in the row

            }

        }

        public void LoadProducts()
        {

            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                int i = 0;
                productsGrid.Rows.Clear();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE [UserID] = @UserID AND CONCAT([Product_Id], [Name], [Quantity], [Price], [Description], [Category]) LIKE '%" + productSearchBox.Text + "%'", conn))
                {
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        i++;
                        productsGrid.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            new AddProductForm(this).ShowDialog();
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the column of your buttons
            if (e.RowIndex >= 0 && (e.ColumnIndex == productsGrid.Columns["Column8"].Index || e.ColumnIndex == productsGrid.Columns["Column9"].Index))
            {
                // Get the selected row
                DataGridViewRow selectedRow = productsGrid.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[1].Value);
                // Check which button is clicked
                if (e.ColumnIndex == productsGrid.Columns["Column8"].Index)
                {
                    //Handle edit button click
                    EditProductsForm editForm = new EditProductsForm(id, this);
                    editForm.productName.Text = selectedRow.Cells[2].Value.ToString();
                    editForm.productQty.Text = selectedRow.Cells[3].Value.ToString();
                    editForm.productPrice.Text = selectedRow.Cells[4].Value.ToString();
                    editForm.productDesc.Text = selectedRow.Cells[5].Value.ToString();
                    editForm.productCategory.Text = selectedRow.Cells[6].Value.ToString();
                    editForm.ShowDialog();

                }
                else if (e.ColumnIndex == productsGrid.Columns["Column9"].Index)
                {
                    // Handle delete button click
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DbConnection.GetSqlConnection())
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Product_Id = '" + id + "' ", conn))
                            {
                                conn.Open();
                                command.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        LoadProducts();
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e)
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

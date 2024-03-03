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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadCategories()
        {

            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                int i = 0;
                categoriesGrid.Rows.Clear();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Categories WHERE [UserID] = @UserID AND CONCAT([CategoryID], [CategoryName]) LIKE '%" + categorySearchBox.Text + "%'", conn))
                {
                    command.Parameters.AddWithValue("UserID", UserManager.CurrentUser.UserId);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        i++;
                        categoriesGrid.Rows.Add(i, reader[0].ToString(), reader[1].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void categoriesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void categoriesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            new AddCategoryForm(this).ShowDialog();
        }

        private void categoriesGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the column of your buttons
            if (e.RowIndex >= 0 && (e.ColumnIndex == categoriesGrid.Columns["Column8"].Index || e.ColumnIndex == categoriesGrid.Columns["Column9"].Index))
            {
                // Get the selected row
                DataGridViewRow selectedRow = categoriesGrid.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells[1].Value);
                // Check which button is clicked
                if (e.ColumnIndex == categoriesGrid.Columns["Column8"].Index)
                {
                    //Handle edit button click
                    EditCategoryForm editCategoryForm = new EditCategoryForm(id, this);
                    editCategoryForm.categoryName.Text = selectedRow.Cells[2].Value.ToString();
                    editCategoryForm.ShowDialog();

                }
                else if (e.ColumnIndex == categoriesGrid.Columns["Column9"].Index)
                {
                    // Handle delete button click
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DbConnection.GetSqlConnection())
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM Categories WHERE CategoryID = '" + id + "' ", conn))
                            {
                                conn.Open();
                                command.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        LoadCategories();
                    }
                }
            }
        }

        private void categorySearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadCategories();
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

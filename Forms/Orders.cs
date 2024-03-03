
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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadOrders();
        }

        public void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetSqlConnection())
                {
                    conn.Open();

                    // Adjust the SQL query to include relevant columns from OrderItem table
                    string query = @"
                        SELECT 
                            O.OrderID, 
                            O.OrderDate, 
                            O.CustomerID, 
                            O.ProductID, 
                            O.TotalAmount,
                            OI.OrderItemID, 
                            OI.UnitPrice, 
                            OI.Quantity
                        FROM Orders O
                        INNER JOIN OrderItem OI ON O.OrderID = OI.OrderID
                        WHERE O.UserID = '" + UserManager.CurrentUser.UserId + "'";

                    int i = 0;
                    ordersGrid.Rows.Clear();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            i++;
                            ordersGrid.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());
                        }
                        reader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            new AddOrdersForm(this).Show();

        }

        private void ordersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == ordersGrid.Columns["Column9"].Index))
            {
                // Get the selected row
                DataGridViewRow selectedRow = ordersGrid.Rows[e.RowIndex];

                int orderId = Convert.ToInt32(selectedRow.Cells[1].Value);

                // Check which button is clicked

                // Handle delete button click
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = DbConnection.GetSqlConnection())
                    {
                        conn.Open();

                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Delete from OrderItem table
                                using (SqlCommand deleteOrderItemCommand = new SqlCommand("DELETE FROM OrderItem WHERE OrderID = @OrderID", conn, transaction))
                                {
                                    deleteOrderItemCommand.Parameters.AddWithValue("@OrderID", orderId);
                                    deleteOrderItemCommand.ExecuteNonQuery();
                                }

                                // Delete from Orders table
                                using (SqlCommand deleteOrderCommand = new SqlCommand("DELETE FROM Orders WHERE OrderID = @OrderID", conn, transaction))
                                {
                                    deleteOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                                    deleteOrderCommand.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        conn.Close();
                    }

                    LoadOrders();
                }
            }

        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ordersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

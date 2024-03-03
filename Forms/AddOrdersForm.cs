using Guna.UI2.WinForms.Suite;
using Inventory_Management_App.Session;
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
    public partial class AddOrdersForm : Form
    {
        Orders ordersForm;
        public AddOrdersForm(Orders ordersForm)
        {
            InitializeComponent();
            LoadId();
            this.ordersForm = ordersForm;
        }

        public void LoadId()
        {
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                customerId.Items.Clear();
                productId.Items.Clear();
                using (SqlCommand command = new SqlCommand("SELECT CustomerID FROM Customers WHERE UserID = '" + UserManager.CurrentUser.UserId + "'", conn))
                {
                    conn.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        customerId.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }

                using (SqlCommand command = new SqlCommand("SELECT Product_Id FROM Products WHERE UserID = '" + UserManager.CurrentUser.UserId + "'", conn))
                {
                    conn.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        productId.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }

            }

        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            if (!ValidationUtils.ValidationUtils.IsValidInput(orderDate.Value.ToString()) || !ValidationUtils.ValidationUtils.IsValidInput(customerId.Text.Trim()) || !ValidationUtils.ValidationUtils.IsValidInput(productId.Text.Trim()) || !ValidationUtils.ValidationUtils.IsValidInput(orderQuantity.Text.Trim()))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6GSIV37\SQLEXPRESS;Initial Catalog=InventoryManagementDB;Integrated Security=True"))
                //{
                //    conn.Open();

                //    // Check if a product with the same name already exists
                //    //using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Products WHERE [Name] = @Name", conn))
                //    //{
                //    //    checkCommand.Parameters.AddWithValue("@Name", name);
                //    //    int existingProductCount = (int)checkCommand.ExecuteScalar();

                //    //    if (existingProductCount > 0)
                //    //    {
                //    //        MessageBox.Show("Product with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //        return; // Exit the method if a duplicate product is found
                //    //    }
                //    //}
                //    int orderID = 0;

                //    // Insert the new product
                //    using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [Orders] ([OrderDate], [CustomerID], [ProductID], [TotalAmount]) VALUES (@OrderDate, @CustomerID, @ProductID, @TotalAmount)", conn))
                //    {
                //        insertCommand.Parameters.Add("@OrderDate", System.Data.SqlDbType.DateTime).Value = orderDate.Value;
                //        insertCommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(customerId.Text));
                //        insertCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text));
                //        insertCommand.Parameters.AddWithValue("@TotalAmount", Convert.ToInt32(orderUnitPrice.Text) * Convert.ToInt32(orderQuantity.Text));

                //        object result = insertCommand.ExecuteScalar();

                //        if (result != null)
                //        {
                //            orderID = (int)result;
                //        }

                //        conn.Close();
                //    }

                //    conn.Open();

                //    using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [OrderItem] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)", conn))
                //    {

                //        insertCommand.Parameters.AddWithValue("@OrderID", orderID);
                //        insertCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text));
                //        insertCommand.Parameters.AddWithValue("@UnitPrice", Convert.ToInt32(orderUnitPrice.Text));
                //        insertCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(orderQuantity.Text));

                //        insertCommand.ExecuteNonQuery();
                //        conn.Close();
                //    }
                //}

                int orderID = 0;

                using (SqlConnection conn = DbConnection.GetSqlConnection())
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Check product quantity in stock
                            int availableQuantity;
                            using (SqlCommand checkQuantityCommand = new SqlCommand("SELECT Quantity FROM Products WHERE Product_Id = @ProductID", conn, transaction))
                            {
                                checkQuantityCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text.Trim()));
                                availableQuantity = Convert.ToInt32(checkQuantityCommand.ExecuteScalar());
                            }

                            // Check if the quantity being ordered is greater than the available quantity
                            int orderedQuantity = Convert.ToInt32(orderQuantity.Text.Trim());
                            if (orderedQuantity > availableQuantity)
                            {
                                // Display an error message
                                MessageBox.Show("Error: Insufficient quantity in stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Exit the method if there's an error
                            }

                            int unitPrice;
                            using (SqlCommand checkPriceCommand = new SqlCommand("SELECT Price FROM Products WHERE Product_Id = @ProductID", conn, transaction))
                            {
                                checkPriceCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text.Trim()));
                                unitPrice = Convert.ToInt32(checkPriceCommand.ExecuteScalar());
                            }

                            // Insert the new order
                            using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [Orders] ([OrderDate], [CustomerID], [ProductID], [TotalAmount], [UserID]) VALUES (@OrderDate, @CustomerID, @ProductID, @TotalAmount, @UserID); SELECT SCOPE_IDENTITY();", conn, transaction))
                            {
                                insertCommand.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = orderDate.Value;
                                insertCommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(customerId.Text.Trim()));
                                insertCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text.Trim()));
                                insertCommand.Parameters.AddWithValue("@TotalAmount", unitPrice);
                                insertCommand.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);

                                // Retrieve the newly inserted OrderID
                                orderID = Convert.ToInt32(insertCommand.ExecuteScalar());
                            }

                            // Insert the order item
                            using (SqlCommand insertCommand = new SqlCommand(@"INSERT INTO [OrderItem] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)", conn, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@OrderID", orderID);
                                insertCommand.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productId.Text.Trim()));
                                insertCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                insertCommand.Parameters.AddWithValue("@Quantity", orderedQuantity);

                                insertCommand.ExecuteNonQuery();
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


                ordersForm.LoadOrders();
                MessageBox.Show("Order added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                customerId.Text = "";
                productId.Text = "";
                orderQuantity.Clear();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new Orders().LoadOrders();
                this.Close();
            }
        }
    }
}


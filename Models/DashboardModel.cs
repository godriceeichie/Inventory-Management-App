
using Inventory_Management_App.Session;
using Inventory_Management_App.SqlDbConnection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class DashboardModel : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int CustomersNum { get; private set; }
        public int ProductsNum { get; private set; }
        public int OrdersNum { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public DashboardModel()
        {

        }

        private void GetItemsNumber()
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                // Get total number of customers for a specific user
                using (var command = new SqlCommand("SELECT COUNT(CustomerID) FROM Customers WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                    CustomersNum = (int)command.ExecuteScalar();
                }

                // Get total number of products for a specific user
                using (var command = new SqlCommand("SELECT COUNT(Product_Id) FROM Products WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                    ProductsNum = (int)command.ExecuteScalar();
                }

                // Get total number of orders for a specific user within a date range
                using (var command = new SqlCommand(@"SELECT COUNT(OrderID) FROM [Orders] WHERE OrderDate BETWEEN @fromDate AND @endDate AND UserID = @UserID", connection))
                {
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId);
                    OrdersNum = (int)command.ExecuteScalar();
                }
            }
        }


        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT 
                                    OrderDate, 
                                    SUM(TotalAmount) AS TotalAmount
                                FROM 
                                    Orders
                                WHERE 
                                    OrderDate BETWEEN @fromDate AND @endDate AND UserID = @UserID
                                GROUP BY 
                                    OrderDate
                                ORDER BY 
                                    OrderDate;";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId); // Replace with your actual way of getting the authenticated user's ID
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    reader.Close();

                    //Group by Days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });

                        }
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();

            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 products
                    command.CommandText = @"SELECT TOP 5 P.Name, SUM(OrderItem.Quantity) as Q
                                    FROM OrderItem
                                    INNER JOIN Products P on P.Product_Id = OrderItem.ProductID
                                    INNER JOIN Orders O on O.OrderID = OrderItem.OrderID
                                    WHERE OrderDate BETWEEN @fromDate AND @toDate AND O.UserID = @UserID
                                    GROUP BY P.Name
                                    ORDER BY Q desc";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.AddWithValue("@UserID", UserManager.CurrentUser.UserId); // Replace with your actual way of getting the authenticated user's ID
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetItemsNumber();
                GetProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine("Referred data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}

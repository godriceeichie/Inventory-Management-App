using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.SqlDbConnection
{
    public class DbConnection
    {

        private readonly static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("InventoryManagementDB.mdf") + "; Integrated Security=True;Connect Timeout=30;"; 

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connection);
        }
    }
}

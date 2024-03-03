using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory_Management_App.ValidationUtils
{
    
    public class ValidationUtils
    {
        public static bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^\d");
        }
        public static bool IsValidEmail(string email)
        {
            // Validation logic for email
            if (string.IsNullOrEmpty(email)) return false;
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        public static bool IsValidPassword(string password)
        {
            // Add validation logic for password (e.g., length requirements)
            return !(password.Length < 5);
        }

        public static bool IsValidInput(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        public static bool UserExists(string username, string email, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email", conn))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)command.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
        }
    }
}

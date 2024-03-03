using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Inventory_Management_App.Utils
{
    public class HashPasswordUtils
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash from the password
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    stringBuilder.Append(hashedBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public static bool VerifyPassword(string providedPassword, string hashedPassword)
        {
            // Hash the provided password using the same method
            string hashedProvidedPassword = HashPassword(providedPassword);

            // Compare the hashed passwords
            return string.Equals(hashedProvidedPassword, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}

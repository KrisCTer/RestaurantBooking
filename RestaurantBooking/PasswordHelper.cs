using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace RestaurantBooking
{

    public class PasswordHelper
    {
        public string HashPassword(string password)
        {
            // Generate a salt and hash the password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the password against the hashed password
            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            return isValid;
        }
    }
}

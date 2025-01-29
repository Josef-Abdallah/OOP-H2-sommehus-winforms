using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_H2_sommehus_winforms
{
    public static class validateUserInput
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 8 && phoneNumber.All(char.IsDigit);
        }

        public static bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}

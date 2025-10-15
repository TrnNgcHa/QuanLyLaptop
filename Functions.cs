using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
{
    
}

namespace QuanLyLaptop
{
    public class Functions
    {
        public static bool IsValidUsername(string username)
        {
            username = username.Trim();
            List<string> names = username.Split(' ').ToList();
            int countupper = 0;
            foreach (string name in names)
            {
                if (char.IsUpper(name[0]))
                {
                    countupper++;
                }
            }
            return username.All(char.IsLetterOrDigit) && (countupper == names.Count) && (username != "");
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true && (email != "");
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 15;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace QuanLyLaptop.Models
{
    public class Functions
    {
        public static bool IsValidUserName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            fullName = System.Text.RegularExpressions.Regex.Replace(fullName.Trim(), @"\s+", " ");

            var words = fullName.Split(' ');

            foreach (var word in words)
            {
                if (word.Length < 2)
                    return false;

                if (!char.IsUpper(word[0]))
                    return false;

                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLetter(word[i]) || !char.IsLower(word[i]))
                        return false;
                }
            }

            return true && words.Count() > 1;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true && email != "";
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            return phone.All(char.IsDigit) && phone != "";
        }

        public static bool IsValidIdCard(string idCard)
        {
            return idCard.All(char.IsDigit) && idCard != "";
        }

        public static string GetFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return "";

            fullName = System.Text.RegularExpressions.Regex.Replace(fullName.Trim(), @"\s+", " ");
            var parts = fullName.Split(' ');

            return parts.Last();
        }

        public static string GetLastName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return "";

            fullName = System.Text.RegularExpressions.Regex.Replace(fullName.Trim(), @"\s+", " ");
            var parts = fullName.Split(' ');

            if (parts.Length <= 1)
                return "";

            return string.Join(" ", parts.Take(parts.Length - 1));
        }
    }
}

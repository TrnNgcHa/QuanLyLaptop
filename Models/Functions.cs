using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace QuanLyLaptop.Models
{
    public static class Functions
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

            if(fullName.Any(char.IsDigit))
                return false;

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
            if (!idCard.All(char.IsDigit))
                return false;
            if (!(idCard.Length == 9))
                return false;
            if(MainMenu.Accounts.Any(a => a.IdCard == idCard))
                return false;
            return true;
        }

        public static bool IsValidDate(string date)
        {
            return DateOnly.TryParseExact(
                        date,
                        "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out _
                        );
        }

        public static bool IsValidCity(string city)
        {
            List<string> cityList = new List<string>{
                                        "An Giang",
                                        "Bà Rịa – Vũng Tàu",
                                        "Bắc Giang",
                                        "Bắc Kạn",
                                        "Bạc Liêu",
                                        "Bắc Ninh",
                                        "Bến Tre",
                                        "Bình Định",
                                        "Bình Dương",
                                        "Bình Phước",
                                        "Bình Thuận",
                                        "Cà Mau",
                                        "Cao Bằng",
                                        "Cần Thơ",
                                        "Đà Nẵng",
                                        "Đắk Lắk",
                                        "Đắk Nông",
                                        "Điện Biên",
                                        "Đồng Nai",
                                        "Đồng Tháp",
                                        "Gia Lai",
                                        "Hà Giang",
                                        "Hà Nam",
                                        "Hà Nội",
                                        "Hà Tĩnh",
                                        "Hải Dương",
                                        "Hải Phòng",
                                        "Hậu Giang",
                                        "Hòa Bình",
                                        "Hưng Yên",
                                        "Khánh Hòa",
                                        "Kiên Giang",
                                        "Kon Tum",
                                        "Lai Châu",
                                        "Lâm Đồng",
                                        "Lạng Sơn",
                                        "Lào Cai",
                                        "Long An",
                                        "Nam Định",
                                        "Nghệ An",
                                        "Ninh Bình",
                                        "Ninh Thuận",
                                        "Phú Thọ",
                                        "Phú Yên",
                                        "Quảng Bình",
                                        "Quảng Nam",
                                        "Quảng Ngãi",
                                        "Quảng Ninh",
                                        "Quảng Trị",
                                        "Sóc Trăng",
                                        "Sơn La",
                                        "Tây Ninh",
                                        "Thái Bình",
                                        "Thái Nguyên",
                                        "Thanh Hóa",
                                        "Thừa Thiên Huế",
                                        "Tiền Giang",
                                        "TP. Hồ Chí Minh",
                                        "Trà Vinh",
                                        "Tuyên Quang",
                                        "Vĩnh Long",
                                        "Vĩnh Phúc",
                                        "Yên Bái"
                                    };
            return cityList.Any(p => p == city);
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
        public static string ConvertToCsvLine(string path, List<Laptop> laptops)
        {
            if(laptops.Count < 1) return string.Empty;

            try
            {
                var sb = new StringBuilder();
                string lineHeader = "Mã Laptop;Tên Laptop;Tên Hãng;Ngày Nhập;Số Tồn;Giá Tiền;CPU;GPU;Ổ Cứng;RAM";
                sb.AppendLine(lineHeader);
                foreach (var laptop in laptops)
                {
                    var properties = laptop.GetType().GetProperties();
                    for(int i = 0; i < properties.Length; i++)
                    {
                        var value = properties[i].GetValue(laptop)?.ToString() ?? "";
                        if (value.Contains(";") || value.Contains("\""))
                        {
                            value = $"\"{value.Replace("\"", "\"\"")}\"";
                        }
                        sb.Append(value);
                        if (i < properties.Length - 1)
                        {
                            sb.Append(";");
                        }

                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting laptops to CSV: {ex.Message}");
                return string.Empty;
            }
        }

        public static string ConvertToCsvLine(string path, List<Account> accounts, bool isPerson = false)
        {
            if (accounts == null || accounts.Count < 1)
                return string.Empty;

            try
            {
                var sb = new StringBuilder();

                if (!isPerson)
                {
                    // ---- Ghi file Account.csv ----
                    sb.AppendLine("Mã Tài Khoản;Mã Người Dùng;Tên Tài Khoản;Mật Khẩu;Số Dư");

                    foreach (var acc in accounts)
                    {
                        string[] values = new string[]
                        {
                            acc.AccountID.ToString(),
                            acc.PersonID.ToString(),
                            acc.AccountName,
                            acc.Password.ToString(),
                            acc.Balance.ToString()
                        };

                        sb.AppendLine(string.Join(";", values.Select(v =>
                            v.Contains(";") || v.Contains("\"")
                                ? $"\"{v.Replace("\"", "\"\"")}\""
                                : v)));
                    }
                }
                else
                {
                    // ---- Ghi file Person.csv ----
                    sb.AppendLine("Mã Người Dùng;Họ;Tên;Giới Tính;Ngày Sinh;Thành Phố;Số Điện Thoại;Email;CCCD");

                    foreach (var acc in accounts)
                    {
                        string[] values = new string[]
                        {
                            acc.PersonID.ToString(),
                            acc.LastName,
                            acc.FirstName,
                            acc.Gender,
                            acc.DOB.ToString("dd/MM/yyyy"),
                            acc.City,
                            acc.PhoneNumber,
                            acc.Email,
                            acc.IdCard
                        };

                        sb.AppendLine(string.Join(";", values.Select(v =>
                            v.Contains(";") || v.Contains("\"")
                                ? $"\"{v.Replace("\"", "\"\"")}\""
                                : v)));
                    }
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting list to CSV: {ex.Message}");
                return string.Empty;
            }
        }

        public static string ConvertToCsvLine(string path, List<Receipt> receipts)
        {
            if (receipts.Count < 1) return string.Empty;

            try
            {
                var sb = new StringBuilder();
                string lineHeader = "ReceiptID;InvoiceDate;AccountID;AccountName;PersonID;LaptopID;LaptopName;LaptopPrice";
                sb.AppendLine(lineHeader);
                foreach (var laptop in receipts)
                {
                    var properties = laptop.GetType().GetProperties();
                    for (int i = 0; i < 8; i++)
                    {
                        var value = properties[i].GetValue(laptop)?.ToString() ?? "";
                        if (value.Contains(";") || value.Contains("\""))
                        {
                            value = $"\"{value.Replace("\"", "\"\"")}\"";
                        }
                        sb.Append(value);
                        if (i < properties.Length - 1)
                        {
                            sb.Append(";");
                        }

                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting laptops to CSV: {ex.Message}");
                return string.Empty;
            }
        }

        public static string ConvertToCsvLine(string path, List<Review> reviews)
        {
            if (reviews.Count < 1) return string.Empty;

            try
            {
                var sb = new StringBuilder();
                string lineHeader = "ReviewID;AccountID;AccountName;LaptopID;LaptopName;ReviewDate;Rating;Comments";
                sb.AppendLine(lineHeader);
                foreach (var laptop in reviews)
                {
                    var properties = laptop.GetType().GetProperties();
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var value = properties[i].GetValue(laptop)?.ToString() ?? "";
                        if (value.Contains(";") || value.Contains("\""))
                        {
                            value = $"\"{value.Replace("\"", "\"\"")}\"";
                        }
                        sb.Append(value);
                        if (i < properties.Length - 1)
                        {
                            sb.Append(";");
                        }

                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting laptops to CSV: {ex.Message}");
                return string.Empty;
            }
        }
        public static bool WriteFile(string filePath, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }
                //Console.WriteLine($"CSV file successfully written to: {filePath}");
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing CSV file: {ex.Message}");
                return false;
            }

        }
    }
}

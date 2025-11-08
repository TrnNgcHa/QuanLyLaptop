using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public DateOnly ReviewDate { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public TextBox ReviewTextBox { get; set; }
        public Button DeleteButton { get; set; }
        public Review()
        {
            ReviewID = LaptopID = AccountID = Rating = 0;
            AccountName = LaptopName = Comments = "";
            ReviewDate = new DateOnly(1, 1, 1);
            ReviewTextBox = new TextBox();
            DeleteButton = new Button();
        }

        public Review(string csvLine)
        {
            string[] values = csvLine.Split(';');
            ReviewID = Convert.ToInt32(values[0]);
            AccountID = Convert.ToInt32(values[1]);
            AccountName = values[2];
            LaptopID = Convert.ToInt32(values[3]);
            LaptopName = values[4];
            ReviewDate = DateOnly.Parse(values[5]);
            Rating = Convert.ToInt32(values[6]);
            Comments = values[7];
            ReviewTextBox = new TextBox()
            {
                Name = $"txtComent_{ReviewID}",
                Multiline = true,
                Enabled = false,
                ReadOnly = true,
                Width = 400,
                Height = 40,
                Text = $"[{Rating} ★][{ReviewDate:dd/MM/yyyy}] {AccountName}: {Comments}",
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            };
            DeleteButton = new Button()
            {
                Name = $"btnDelete_{ReviewID}",
                Image = Properties.Resources.delete,
                Width = 40,
                Height = 40,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                Visible = false
            };

        }

        public Review(int reviewID, int accountID, string accountName, int laptopID, string laptopName, DateOnly reviewDate, int rating, string comments)
        {
            ReviewID = reviewID;
            AccountID = accountID;
            AccountName = accountName;
            LaptopID = laptopID;
            LaptopName = laptopName;
            ReviewDate = reviewDate;
            Rating = rating;
            Comments = comments;
            ReviewTextBox = new TextBox()
            {
                Name = $"txtComent_{ReviewID}",
                Multiline = true,
                Enabled = false,
                ReadOnly = true,
                Width = 600,
                Height = 40,
                Text = $"[{Rating} ★][{ReviewDate:dd/MM/yyyy}] {AccountName}: {Comments}",
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            DeleteButton = new Button()
            {
                Name = $"btnDelete_{ReviewID}",
                Image = Properties.Resources.delete,
                Width = 40,
                Height = 40,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Visible = false
            };
        }

        public List<Review> GetList(string fileName = "")
        {
            List<Review> ReviewList = new List<Review>();
            fileName = fileName == "" ? GlobalSetting.ReviewFile : fileName;
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();
                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Review rv = new Review(line);
                    ReviewList.Add(rv);
                }
            }
            return ReviewList;
        }
    }
}

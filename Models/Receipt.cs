using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    public class Receipt : Person
    {
        public int ReceiptID { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }

        public new int PersonID { get; set; }
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public int Total { get; set; }

        public Receipt()
        {
            ReceiptID = AccountID = PersonID = LaptopID = Total = 0;
            InvoiceDate = new DateOnly(1,1,1);
            AccountName = LaptopName = "";
        }

        public Receipt(int receiptID, DateOnly invoiceDate, int accountID, string accountName, int personID, int laptopID, string laptopName,  int total)
        {
            ReceiptID = receiptID;
            InvoiceDate = invoiceDate;
            AccountID = accountID;
            AccountName = accountName;
            PersonID = personID;
            LaptopID = laptopID;
            LaptopName = laptopName;
            Total = total;
        }
        public string CleanCommaList(string str)
        {
            List<string> items = str.Split(',').ToList();
            foreach(string item in items.ToList())
            {
                if (item.Trim() == "")
                {
                    items.Remove(item);
                }
            }
            return string.Join(",", items);
        }
        public Receipt(string csvLine)
        {
            string[] values = csvLine.Split(';');
            ReceiptID = Convert.ToInt32(values[0]);
            InvoiceDate = DateOnly.Parse(values[1]);
            AccountID = Convert.ToInt32(values[2]);
            AccountName = values[3];
            PersonID = Convert.ToInt32(values[4]);
            LaptopID = Convert.ToInt32(values[5]);
            LaptopName = values[6];
            Total = Convert.ToInt32(values[7]);
        }

        public void FillData(List<Person> ps)
        {
            Person p = ps.First(x => x.PersonID == PersonID);
            LastName = p.LastName;
            FirstName = p.FirstName;
            Gender = p.Gender;
            DOB = p.DOB;
            PhoneNumber = p.PhoneNumber;
            City = p.City;
            Email = p.Email;
            IdCard = p.IdCard;
        }



        public new List<Receipt> GetList(string fileName = "")
        {
            List<Receipt> receiptList = new List<Receipt>();
            List<Person> personList = new Person().GetList();
            fileName = fileName == "" ? GlobalSetting.ReceiptFile : fileName;
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();
                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Receipt rc = new Receipt(line);
                    rc.FillData(personList);
                    receiptList.Add(rc);
                }
            }
            return receiptList;
        }
    }
}

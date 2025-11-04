using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public int Total { get; set; }

        public Receipt()
        {
            ReceiptID = AccountID = PersonID = LaptopID = Total = 0;
            InvoiceDate = new DateOnly(1,1,1);
            AccountName = PersonName = LaptopName = "";
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
            PersonName = values[5];
            LaptopID = Convert.ToInt32(values[6]);
            LaptopName = values[7];
            Total = Convert.ToInt32(values[8]);
        }

        
        public List<Receipt> GetList(string fileName = "")
        {
            List<Receipt> receiptList = new List<Receipt>();
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
                    receiptList.Add(rc);
                }
            }
            return receiptList;
        }
    }
}

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
        public int LaptopPrice { get; set; }
        public string ExtraItems { get; set; } 
        public string ExtraPrices { get; set; }
        public int TotalAmount { get; set; }

        public Receipt()
        {
            ReceiptID = AccountID = PersonID = LaptopID = TotalAmount = 0;
            InvoiceDate = new DateOnly(1,1,1);
            AccountName = PersonName = LaptopName = ExtraItems = ExtraPrices = "";
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
            LaptopPrice = Convert.ToInt32(values[8]);
            ExtraItems = values[9];
            ExtraPrices = values[10];
            TotalAmount = Convert.ToInt32(values[11]);
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

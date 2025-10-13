using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    internal class Laptop
    {
        //MaLaptop;TenLaptop;TenHang;NgayNhap;SoTon;CPU;GPU;OCung;RAM;GiaTien
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public string AgencyName { get; set; }
        public DateOnly StockInDate { get; set; }
        public string RemainAmount { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Hardware { get; set; }
        public string RAM { get; set; }
        public int Price { get; set; }

        public Laptop()
        {
            LaptopID = Price = 0;
            LaptopName = AgencyName = RemainAmount = CPU = GPU = Hardware = RAM = "";
        }

        public Laptop(string csvLine)
        {
            string[] values = csvLine.Split(';');
            LaptopID = Convert.ToInt32(values[0]);
            LaptopName = values[1];
            AgencyName = values[2];
            StockInDate = DateOnly.Parse(values[3]);
            RemainAmount = values[4];
            Price = Convert.ToInt32(values[5]);
            CPU = values[6];
            GPU = values[7];
            Hardware = values[8];
            RAM = values[9];
        }

        public List<Laptop> GetList(string fileName = "")
        {
            List<Laptop> laptopList = new List<Laptop>();
            fileName = fileName == "" ? GlobalSetting.LaptopFile : fileName;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Laptop lt = new Laptop(line);
                    laptopList.Add(lt);
                }
            }
            return laptopList;
        }
    }

}

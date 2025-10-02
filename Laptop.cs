using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class Laptop
    {
        public int MaLaptop { get; set; }
        public string TenLaptop { get; set; }
        public string HangSanXuat { get; set; }
        public string NgayNhap { get; set; }
        public int SoTon { get; set; }
        public int SoLuong { get; set; }
        public string GiaLaptop { get; set; }

        public Laptop()
        {
            MaLaptop = 0;
            TenLaptop = HangSanXuat = NgayNhap = GiaLaptop = "";
            SoTon = SoLuong = 0;
        }

        public Laptop(string csvFile)
        {
            string[] values = csvFile.Split(',');
            this.MaLaptop = int.Parse(values[0]);
            this.TenLaptop = values[1];
            this.HangSanXuat = values[2];
            this.NgayNhap = values[3];
            this.SoTon = int.Parse(values[4]);
            this.SoLuong = int.Parse(values[5]);
            this.GiaLaptop = values[6];
        }

        public List<Laptop> TaoList()
        {
            List<Laptop> list = new List<Laptop>();
            string file = GlobalSettings.LaptopFile;
            using (StreamReader reader = new StreamReader(file))
            {

                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Laptop lt = new Laptop(line);
                    list.Add(lt);
                }
            }

            return list;
        }

        public List<Laptop> TaoList(int maLT)
        {
            List<Laptop> list = new List<Laptop>();
            string file = GlobalSettings.LaptopFile;
            using (StreamReader reader = new StreamReader(file))
            {

                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Laptop lt = new Laptop(line);
                    list.Add(lt);
                }
            }

            return list;
        }
    }
}

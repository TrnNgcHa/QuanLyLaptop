using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class Laptop
    {
        public long MaLaptop { get; set; }
        public string TenLaptop { get; set; }
        public string HangSanXuat { get; set; }
        public string NgayNhap { get; set; }
        public string SoTon { get; set; }
        public string SoLuong { get; set; }
        public string GiaLaptop { get; set; }

        public string TenCPU { get; set; }
        public string TenGPU { get; set; }
        public string TenRAM { get; set; }
        public string TenOCung { get; set; }

        public Laptop()
        {
            MaLaptop = 0;
            SoTon = SoLuong = TenLaptop = HangSanXuat = NgayNhap = GiaLaptop = "";
            TenCPU = TenGPU = TenRAM = TenOCung = "";
        }

        public Laptop(string csvFile)
        {
            string[] values = csvFile.Split(',');
            this.MaLaptop = Convert.ToInt64(values[0]);
            this.TenLaptop = values[1];
            this.HangSanXuat = values[2];
            this.NgayNhap = values[3];
            this.SoTon = values[4];
            this.SoLuong = values[5];
            this.GiaLaptop = values[6];
            this.TenCPU = values[7];
            this.TenGPU = values[8];
            this.TenOCung = values[9];
            this.TenRAM = values[10];
        }

        public List<Laptop> GetList(string maLT="")
        {
            List<Laptop> list = new List<Laptop>();
            string file = GlobalSettings.LaptopFile;
            using (StreamReader reader = new StreamReader(file))
            {

                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Laptop lt = new Laptop(line);
                    list.Add(lt);
                }
            }

            return list;
        }
    }
}

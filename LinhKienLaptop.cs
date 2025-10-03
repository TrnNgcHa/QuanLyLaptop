using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class LinhKienLaptop:Laptop
    {
        public string cpu { get; set; }
        public string gpu { get; set; }
        public string ram { get; set; }
        public string oCung { get; set; }

        public LinhKienLaptop()
        {
            cpu = gpu = ram = oCung = string.Empty;
        }

        

        public LinhKienLaptop(string csvFile) : base(csvFile)
        {
            string[] values = csvFile.Split(',');
            this.MaLaptop = Convert.ToInt32(values[0]);
            this.TenCPU = values[7];
            this.TenGPU = values[8];
            this.TenOCung = values[9];
            this.TenRAM = values[10];
        }

        public LinhKienLaptop(Laptop lt)
        {
            this.MaLaptop = lt.MaLaptop;
            this.TenLaptop = lt.TenLaptop;
            this.TenCPU = lt.TenCPU;
            this.TenGPU = lt.TenGPU;
            this.TenOCung = lt.TenOCung;
        }

        public List<LinhKienLaptop> GetList()
        {
            List<LinhKienLaptop> list = new List<LinhKienLaptop>();

            string fileName = GlobalSettings.LaptopFile;
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row (Skip Header)            
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    LinhKienLaptop lk = new LinhKienLaptop(line);
                    list.Add(lk);
                }
            }
            return list;
        }

    }
}

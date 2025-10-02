using System;
using System.Collections.Generic;
using System.IO;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    public class GPU
    {
        public string MaGPU { get; set; }
        public string TenGPU { get; set; }
        public string TenHangGPU { get; set; }
        public string XungNhipCoBan { get; set; }
        public string Cache { get; set; }
        public string BoNhoAo { get; set; }
        public string TocDoDoc { get; set; }
        public string GiaGPU { get; set; }

        
        public GPU()
        {
            MaGPU = TenGPU = TenHangGPU = XungNhipCoBan = Cache = BoNhoAo = TocDoDoc = GiaGPU = "";
        }

        
        public GPU(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.MaGPU = values[0];
            this.TenGPU = values[1];
            this.TenHangGPU = values[2];
            this.XungNhipCoBan = values[3];
            this.Cache = values[4];
            this.BoNhoAo = values[5];
            this.TocDoDoc = values[6];
            this.GiaGPU = values[7];
        }

       
        public List<GPU> GetList()
        {
            List<GPU> list = new List<GPU>();
            string fileName = GlobalSettings.GPUFile; 

            using (StreamReader reader = new StreamReader(fileName))
            {
                
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    GPU gpu = new GPU(line);
                    list.Add(gpu);
                }
            }
            return list;
        }

        
        public List<GPU> GetList(string maGPU)
        {
            List<GPU> list = new List<GPU>();
            string fileName = GlobalSettings.GPUFile;

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    GPU gpu = new GPU(line);
                    if (gpu.MaGPU == maGPU)
                        list.Add(gpu);
                }
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;   // cần cho StreamReader
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    public class CPU
    {
        public string MaCPU { get; set; }
        public string TenCPU { get; set; }
        public string TenHangCPU { get; set; }
        public string TichHopDoHoa { get; set; }
        public string SoNhan { get; set; }
        public string SoLuong { get; set; }
        public string XungNhip { get; set; }
        public string CacheCPU { get; set; }
        public string GiaCPU { get; set; }

       
        public CPU()
        {
            MaCPU = TenCPU = TenHangCPU = TichHopDoHoa = SoNhan = SoLuong = XungNhip = CacheCPU = GiaCPU = "";
        }

        
        public CPU(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.MaCPU = values[0];
            this.TenCPU = values[1];
            this.TenHangCPU = values[2];
            this.TichHopDoHoa = values[3];
            this.SoNhan = values[4];
            this.SoLuong = values[5];
            this.XungNhip = values[6];
            this.CacheCPU = values[7];
            this.GiaCPU = values[8];
        }

        
        public List<CPU> GetList()
        {
            List<CPU> list = new List<CPU>();
            string fileName = GlobalSettings.CPUFile; 

            using (StreamReader reader = new StreamReader(fileName))
            {
                
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    CPU cpu = new CPU(line);
                    list.Add(cpu);
                }
            }
            return list;
        }

        
        public List<CPU> GetList(string maCPU)
        {
            List<CPU> list = new List<CPU>();
            string fileName = GlobalSettings.CPUFile;

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    CPU cpu = new CPU(line);
                    if (cpu.MaCPU == maCPU)
                        list.Add(cpu);
                }
            }
            return list;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class RAM
    {
        public string MaRam { get; set; }
        public string TenRam { get; set; }
        public string Hang { get; set; }
        public string DungLuong { get; set; }
        public string TheHe { get; set; }
        public string Bus { get; set; }
        public string GiaTien { get; set; }

        public RAM()
        {
            MaRam = TenRam = Hang = DungLuong = TheHe = Bus = GiaTien = "";
        }

        public RAM(string csvLine)
        {
            string[] values = csvLine.Split(',');

            MaRam = values[0];
            TenRam = values[1];
            Hang = values[2];
            DungLuong = values[3];
            TheHe = values[4];
            Bus = values[5];
            GiaTien = values[6];
        }

        public List<RAM> GetList()
        {
            List<RAM> list = new List<RAM>();
            string fileName = GlobalSettings.RAMFile;

            using (StreamReader reader = new StreamReader(fileName))
            {

                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    RAM ram = new RAM(line);
                    list.Add(ram);
                }
            }
            return list;
        }
        public List<RAM> GetList(string fileName)
        {
            List<RAM> list = new List<RAM>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    RAM ram = new RAM(line);
                    list.Add(ram);
                }
            }
            return list;
        }
    }
}

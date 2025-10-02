using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class RAM
    {
    }
    public class Ram
    {
        public string MaRam { get; set; }
        public string TenRam { get; set; }
        public string Hang { get; set; }
        public string DungLuong { get; set; }
        public string TheHe { get; set; }
        public string Bus { get; set; }
        public string GiaTien { get; set; }

        public Ram()
        {
            MaRam = TenRam = Hang = DungLuong = TheHe = Bus = GiaTien = "";
        }

        public Ram(string csvLine)
        {
            string[] values = csvLine.Split(',');

            MaRam     = values[0];
            TenRam    = values[1];
            Hang      = values[2];
            DungLuong = values[3];
            TheHe     = values[4];
            Bus       = values[5];
            GiaTien   = values[6];
        }

        public List<Ram> GetList(string fileName)
        {
            List<Ram> list = new List<Ram>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    Ram ram = new Ram(line);
                    list.Add(ram);
                }
            }
            return list;
        }

        public Ram GetById(string fileName, string maRam)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    Ram ram = new Ram(line);
                    if (ram.MaRam == maRam)
                        return ram;
                }
            }
            return null;
        }
    }
}

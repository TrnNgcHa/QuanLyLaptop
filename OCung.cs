using System;
using System.Collections.Generic;
using System.IO;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    public class OCung
    {
        public string MaOCung { get; set; }
        public string TenOCung { get; set; }
        public string TenHangOCung { get; set; }
        public string DungLuong { get; set; }
        public string Chuan { get; set; }
        public string DocTuanTu { get; set; }
        public string GiaOCung { get; set; }

       
        public OCung()
        {
            MaOCung = TenOCung = TenHangOCung = DungLuong = Chuan = DocTuanTu = GiaOCung = "";
        }

       
        public OCung(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.MaOCung = values[0];
            this.TenOCung = values[1];
            this.TenHangOCung = values[2];
            this.DungLuong = values[3];
            this.Chuan = values[4];
            this.DocTuanTu = values[5];
            this.GiaOCung = values[6];
        }

       
        public List<OCung> GetList()
        {
            List<OCung> list = new List<OCung>();
            string fileName = GlobalSettings.OCungFile; 

            using (StreamReader reader = new StreamReader(fileName))
            {
                
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    OCung oc = new OCung(line);
                    list.Add(oc);
                }
            }
            return list;
        }

        
        public List<OCung> GetList(string maOCung)
        {
            List<OCung> list = new List<OCung>();
            string fileName = GlobalSettings.OCungFile;

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    OCung oc = new OCung(line);
                    if (oc.MaOCung == maOCung)
                        list.Add(oc);
                }
            }
            return list;
        }
    }
}

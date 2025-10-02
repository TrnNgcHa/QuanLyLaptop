using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class LinhKienLaptop
    {
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public RAM ram { get; set; }
        public OCung oCung { get; set; }

        public LinhKienLaptop()
        {
            cpu = new CPU();
            gpu = new GPU();
            ram = new RAM();
            oCung = new OCung();
        }
    }
}

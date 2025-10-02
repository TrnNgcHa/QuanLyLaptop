using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class GlobalSettings
    {
        public static string LaptopFile { get; } = @"\data\ThongTinLaptop.csv";
        public static string CPUFile { get; } = @"\data\CPU.csv";
        public static string GPUFile { get; } = @"\data\GPU.csv";
        public static string OCungFile { get; } = @"\data\OCung.csv";
        public static string RAMFile { get; } = @"\data\RAM.csv";

    }
}

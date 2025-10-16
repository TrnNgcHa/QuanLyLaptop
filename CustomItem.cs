using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class CustomItem : Form
    {
        public CustomItem()
        {
            InitializeComponent();
        }

        public CustomItem(Laptop lt)
        {
            InitializeComponent();
            txtTenLaptop.Text = lt.LaptopName;
            txtCPU.Text = lt.CPU;
            txtGPU.Text = lt.GPU;
            txtRAM.Text = lt.RAM;
            txtOCung.Text = lt.Storage;
        }

        private void CustomItem_Load(object sender, EventArgs e)
        {
            int newID = 0;
            do
            {
                newID = new Random().Next(100000, 200000);
            } while (MainMenu.Laptops.Any(a => a.LaptopID == newID));
            txtMaLaptop.Text = newID.ToString();
        }
    }
}

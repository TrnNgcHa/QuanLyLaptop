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
        public static event Action DataChanged;

        bool isEdit = false;
        public CustomItem()
        {
            InitializeComponent();
        }

        public CustomItem(Laptop lt)
        {
            InitializeComponent();
            txtMaLaptop.Text = lt.LaptopID.ToString();
            txtTenLaptop.Text = lt.LaptopName;
            txtCPU.Text = lt.CPU;
            txtGPU.Text = lt.GPU;
            txtRAM.Text = lt.RAM;
            txtOCung.Text = lt.Storage;
            isEdit = true;
        }

        private void CustomItem_Load(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                btnRandom.Visible = true;
                int newID = 0;
                do
                {
                    newID = new Random().Next(100000, 200000);
                } while (MainMenu.Laptops.Any(a => a.LaptopID == newID));
                txtMaLaptop.Text = newID.ToString();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int newID = 0;
            do
            {
                newID = new Random().Next(100000, 200000);
            } while (MainMenu.Laptops.Any(a => a.LaptopID == newID));
            txtMaLaptop.Text = newID.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận lưu thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                if (isEdit)
                {
                    var laptop = MainMenu.Laptops.FirstOrDefault(a => a.LaptopID.ToString() == txtMaLaptop.Text);
                    if (laptop != null)
                    {
                        laptop.LaptopName = txtTenLaptop.Text;
                        laptop.CPU = txtCPU.Text;
                        laptop.GPU = txtGPU.Text;
                        laptop.RAM = txtRAM.Text;
                        laptop.Storage = txtOCung.Text;
                    }
                }
                else
                {
                    var newLaptop = new Laptop()
                    {
                        LaptopID = int.Parse(txtMaLaptop.Text),
                        LaptopName = txtTenLaptop.Text,
                        CPU = txtCPU.Text,
                        GPU = txtGPU.Text,
                        RAM = txtRAM.Text,
                        Storage = txtOCung.Text
                    };
                    MainMenu.Laptops.Add(newLaptop);
                }
                DataChanged?.Invoke();
                this.Close();
                
            }
        }
    }
}

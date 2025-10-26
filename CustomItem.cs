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
        bool isEdit = false;
        Laptop SelectedItem = new Laptop();
        public CustomItem()
        {
            InitializeComponent();
        }

        public CustomItem(Laptop lt)
        {
            InitializeComponent();
            SelectedItem = lt;

            isEdit = true;
        }

        private void CustomItem_Load(object sender, EventArgs e)
        {
            txtMaLaptop.Text = SelectedItem.LaptopID.ToString();
            txtTenLaptop.Text = SelectedItem.LaptopName;
            txtCPU.Text = SelectedItem.CPU;
            txtGPU.Text = SelectedItem.GPU;
            txtRAM.Text = SelectedItem.RAM;
            txtOCung.Text = SelectedItem.Storage;
            txtGiaTien.Text = SelectedItem.Price.ToString();
            if (!isEdit)
            {
                btnRandom.Visible = true;
                btnRandom_Click(sender, e);
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
                    LaptopManagement.SelectedItem.LaptopID = int.Parse(txtMaLaptop.Text);
                    LaptopManagement.SelectedItem.LaptopName = txtTenLaptop.Text;
                    LaptopManagement.SelectedItem.CPU = txtCPU.Text;
                    LaptopManagement.SelectedItem.GPU = txtGPU.Text;
                    LaptopManagement.SelectedItem.RAM = txtRAM.Text;
                    LaptopManagement.SelectedItem.Storage = txtOCung.Text;
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
                LaptopManagement.ActiveForm.Refresh();
                this.Close();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLaptop.Models;

namespace QuanLyLaptop
{
    public partial class LaptopManagement : Form
    {
        public LaptopManagement()
        {
            InitializeComponent();
        }

        Laptop CurrentItem = new Laptop();

        private void LaptopManagement_Load(object sender, EventArgs e)
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;

        }

        private void dgvDanhSachLaptop_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLaptop.CurrentRow != null)
            {
                lblTenLaptop.Text = dgvDanhSachLaptop.CurrentRow.Cells["TenLaptop"].Value.ToString();
                lblCPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["CPU"].Value.ToString();
                lblGPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["GPU"].Value.ToString();
                lblRAMInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["RAM"].Value.ToString();
                lblStorageInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["OCung"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new CustomItem();
            form.ShowDialog();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            var form = new CustomItem(CurrentItem);
            form.ShowDialog();
        }

        private void dgvDanhSachLaptop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(dgvDanhSachLaptop.CurrentRow != null)
            {
                lblTenLaptop.Text = dgvDanhSachLaptop.CurrentRow.Cells["TenLaptop"].Value.ToString();
                lblCPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["CPU"].Value.ToString();
                lblGPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["GPU"].Value.ToString();
                lblRAMInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["RAM"].Value.ToString();
                lblStorageInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["OCung"].Value.ToString();

                CurrentItem = dgvDanhSachLaptop.CurrentRow.DataBoundItem as Laptop;
            }
        }
    }
}

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
            LoadData();
        }

        Laptop SelectedItem = new Laptop();

        private void LaptopManagement_Load(object sender, EventArgs e)
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;

        }

        private void LoadData()
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;
            dgvDanhSachLaptop.Refresh();
            grbCTSP.Refresh();
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
                SelectedItem = dgvDanhSachLaptop.CurrentRow.DataBoundItem as Laptop;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new CustomItem();
            form.ShowDialog();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            var form = new CustomItem(SelectedItem);
            CustomItem.DataChanged += () =>
            {
                LoadData();
            };
            form.ShowDialog();
        }

        private void dgvDanhSachLaptop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachLaptop.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["STT1"].Value = row.Index + 1;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa laptop này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainMenu.Laptops.Remove(SelectedItem);
                dgvDanhSachLaptop.CurrentCell = null;
                lblTenLaptop.Text = lblCPUInfo.Text = lblGPUInfo.Text = lblRAMInfo.Text = lblStorageInfo.Text = "";
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgvDanhSachLaptop.DataSource = MainMenu.Laptops; // danh sách thời điểm frmStudentView_Load
            }
            else
            {
                List<Laptop> filtered = new List<Laptop>();
                switch (cmbLoaiTimKiem.Text)
                {
                    case "Mã Laptop":
                        filtered = MainMenu.Laptops.Where(s => s.LaptopID.ToString().ToLower().Contains(filterText)).ToList();
                        break;

                    case "Tên Laptop":
                        filtered = MainMenu.Laptops.Where(s => s.LaptopName.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Hãng Laptop":
                        filtered = MainMenu.Laptops.Where(s => s.AgencyName.ToLower().Contains(filterText)).ToList();
                        break;

                }
                dgvDanhSachLaptop.DataSource = filtered;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }
    }
}

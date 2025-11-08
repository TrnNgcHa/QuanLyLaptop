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
        BindingSource bs = new BindingSource();
        public void RefreshData()
        {
            bs.DataSource = MainMenu.Laptops;
            dgvDanhSachLaptop.DataSource = bs;
            dgvDanhSachLaptop.Refresh();
        }

        public Laptop SelectedItem = new Laptop();
        int id = 0;
        bool isEdit = false;

        private void LaptopManagement_Load(object sender, EventArgs e)
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;

            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Format = "#,##0 VND";

            cmbLoaiTimKiem.SelectedIndex = 0;
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
                id = Convert.ToInt32(dgvDanhSachLaptop.CurrentRow.Cells["MaLaptop"].Value);
                SelectedItem = MainMenu.Laptops.First(l => l.LaptopID == id);

                ChonLoaiDanhGia(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grbTTLaptop.Visible = true;
            int rd = 0;
            do
            {
                rd = new Random().Next(10000, 99999);
            } while (MainMenu.Laptops.Any(l => l.LaptopID == rd));
            txtMaLaptop.Text = rd.ToString();

            txtTenLaptop.Text = txtHang.Text = "";
            txtSoTon.Text = txtGiaTien.Text = "0";
            txtCPU.Text = txtGPU.Text = txtRAM.Text = txtOCung.Text = "";
            txtGiaTien.Enabled = true;
            dtpNgayNhap.Text = DateTime.Now.ToString();

            isEdit = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            grbTTLaptop.Visible = true;
            txtGiaTien.Enabled = false;
            txtMaLaptop.Text = SelectedItem.LaptopID.ToString();
            txtTenLaptop.Text = SelectedItem.LaptopName;
            txtHang.Text = SelectedItem.AgencyName;
            dtpNgayNhap.Text = SelectedItem.StockInDate.ToDateTime(new TimeOnly(0, 0)).ToString();
            txtSoTon.Text = SelectedItem.RemainAmount.ToString();
            txtCPU.Text = SelectedItem.CPU;
            txtGPU.Text = SelectedItem.GPU;
            txtRAM.Text = SelectedItem.RAM;
            txtOCung.Text = SelectedItem.Storage;
            txtGiaTien.Text = SelectedItem.Price.ToString();

            isEdit = true;
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
                bs.ResetBindings(false);
                dgvDanhSachLaptop.Refresh();
                lblTenLaptop.Text = lblCPUInfo.Text = lblGPUInfo.Text = lblRAMInfo.Text = lblStorageInfo.Text = "";
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
                    case "CPU":
                        filtered = MainMenu.Laptops.Where(s => s.CPU.ToLower().Contains(filterText)).ToList();
                        break;

                    case "GPU":
                        filtered = MainMenu.Laptops.Where(s => s.GPU.ToLower().Contains(filterText)).ToList();
                        break;

                    case "RAM":
                        filtered = MainMenu.Laptops.Where(s => s.RAM.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Ổ cứng":
                        filtered = MainMenu.Laptops.Where(s => s.Storage.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Tất cả":
                        filtered = MainMenu.Laptops.Where(s =>
                            s.LaptopID.ToString().ToLower().Contains(filterText) ||
                            s.LaptopName.ToLower().Contains(filterText) ||
                            s.AgencyName.ToLower().Contains(filterText) ||
                            s.CPU.ToLower().Contains(filterText) ||
                            s.GPU.ToLower().Contains(filterText) ||
                            s.RAM.ToLower().Contains(filterText) ||
                            s.Storage.ToLower().Contains(filterText)
                        ).ToList();
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận lưu thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (isEdit)
                {
                    SelectedItem.LaptopName = txtTenLaptop.Text;
                    SelectedItem.AgencyName = txtHang.Text;
                    SelectedItem.StockInDate = DateOnly.FromDateTime(dtpNgayNhap.Value);
                    SelectedItem.RemainAmount = int.Parse(txtSoTon.Text);
                    SelectedItem.CPU = txtCPU.Text;
                    SelectedItem.GPU = txtGPU.Text;
                    SelectedItem.RAM = txtRAM.Text;
                    SelectedItem.Storage = txtOCung.Text;
                }
                else
                {
                    var newLaptop = new Laptop()
                    {
                        LaptopID = int.Parse(txtMaLaptop.Text),
                        LaptopName = txtTenLaptop.Text,
                        AgencyName = txtHang.Text,
                        StockInDate = DateOnly.FromDateTime(dtpNgayNhap.Value),
                        RemainAmount = int.Parse(txtSoTon.Text),
                        CPU = txtCPU.Text,
                        GPU = txtGPU.Text,
                        RAM = txtRAM.Text,
                        Storage = txtOCung.Text,
                        Price = int.Parse(txtGiaTien.Text)
                    };
                    MainMenu.Laptops.Add(newLaptop);
                }
                bs.ResetBindings(false);
                dgvDanhSachLaptop.Refresh();
                isEdit = false;
            }


            grbTTLaptop.Visible = false;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            isEdit = false;
            grbTTLaptop.Visible = false;

        }

        private void txtSoTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChonLoaiDanhGia(object sender, EventArgs e)
        {
            List<Review> filteredReviews = new List<Review>();
            List<int> selectedRatings = new List<int>();
            if (ckbMotSao.Checked) selectedRatings.Add(1);
            if (ckbHaiSao.Checked) selectedRatings.Add(2);
            if (ckbBaSao.Checked) selectedRatings.Add(3);
            if (ckbBonSao.Checked) selectedRatings.Add(4);
            if (ckbNamSao.Checked) selectedRatings.Add(5);
            filteredReviews = MainMenu.Reviews
                .Where(r => r.LaptopID == SelectedItem.LaptopID && selectedRatings.Contains(r.Rating))
                .ToList();

            flpBinhLuan.Controls.Clear();
            foreach (Review rv in filteredReviews)
            {
                flpBinhLuan.Controls.Add(rv.ReviewTextBox);
                flpBinhLuan.Controls.Add(rv.DeleteButton);

                rv.DeleteButton.Click += (s, ev) =>
                {
                    MainMenu.Reviews.Remove(rv);
                    flpBinhLuan.Controls.Remove(rv.ReviewTextBox);
                    flpBinhLuan.Controls.Remove(rv.DeleteButton);
                };
            }
        }
    }
}

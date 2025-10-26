using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class LaptopList : Form
    {
        public LaptopList()
        {
            InitializeComponent();
        }
        public static Laptop SelectedItem = new Laptop();
        int id = 0;
        private void DanhSachLaptop_Load(object sender, EventArgs e)
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;
            lblTenNguoiDung.Text = AccountAuthentication.CurrentAccount.FirstName + " " + AccountAuthentication.CurrentAccount.LastName;
            lblTenTaiKhoan.Text = AccountAuthentication.CurrentAccount.AccountName;
            lblSoDu.Text = string.Format("{0:#,##0 VND}", AccountAuthentication.CurrentAccount.Balance);

            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Format = "#,##0 VND";

        }

        private void dgvDanhSachLaptop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachLaptop.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["STT1"].Value = row.Index + 1;
            }

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
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var form = new Review();
            form.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
            foreach (var laptop in MainMenu.Laptops)
            {
                if (laptop.LaptopID == id)
                {
                    SelectedItem = laptop;
                    break;
                }
            }
            var form = new Purchase(SelectedItem);
            form.TopMost = true;
            form.Show();
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
            var result = MessageBox.Show("Bạn có chắc muốn đóng cửa số này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {

        }
    }
}

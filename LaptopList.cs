using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyLaptop
{
    public partial class LaptopList : Form
    {
        public Account CurrentAccount;
        public LaptopList()
        {
            InitializeComponent();
        }

        public LaptopList(Account currAccount)
        {
            InitializeComponent();
            CurrentAccount = currAccount;
        }

        public Laptop SelectedLaptop = new Laptop();
        private void DanhSachLaptop_Load(object sender, EventArgs e)
        {
            dgvDanhSachLaptop.DataSource = MainMenu.Laptops;
            lblTenNguoiDung.Text = CurrentAccount.LastName + " " + CurrentAccount.FirstName;
            lblTenTaiKhoan.Text = CurrentAccount.AccountName;
            lblSoDu.Text = string.Format("{0:#,##0 VND}", CurrentAccount.Balance);

            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Format = "#,##0 VND";

            cmbLoaiTimKiem.SelectedIndex = 0;
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

                SelectedLaptop = MainMenu.Laptops.First(laptop => laptop.LaptopID == Convert.ToInt32(dgvDanhSachLaptop.CurrentRow.Cells["MaLaptop"].Value));

                ChonLoaiDanhGia(sender, e);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //truyền laptop được chọn và tài khoản hiện tại vào form Purchase
            var form = new Purchase(SelectedLaptop, CurrentAccount);
            form.UpdateAccountBalance = (updatedAcc) =>
            {
                CurrentAccount = updatedAcc;
                lblSoDu.Text = string.Format("{0:#,##0 VND}", updatedAcc.Balance);
            };
            form.TopMost = true;
            form.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgvDanhSachLaptop.DataSource = MainMenu.Laptops;
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
            var result = MessageBox.Show("Bạn có chắc muốn đóng cửa số này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            //Nạp tiền chưa có
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            //truyền vào tài khoản hiện tại
            var form = new AccountCenter();
            form.ShowDialog();
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
                .Where(r => r.LaptopID == SelectedLaptop.LaptopID && selectedRatings.Contains(r.Rating))
                .ToList();
            flpBinhLuan.Controls.Clear();
            foreach (Review rv in filteredReviews)
            {
                flpBinhLuan.Controls.Add(rv.ReviewTextBox);
                if (rv.AccountID == CurrentAccount.AccountID)
                {
                    rv.DeleteButton.Visible = true;
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

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (txtDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung đánh giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Review review = new Review(
                MainMenu.Reviews.Count > 0 ? MainMenu.Reviews.Max(r => r.ReviewID) + 1 : 1,
                AccountAuthentication.CurrentAccount.AccountID,
                AccountAuthentication.CurrentAccount.AccountName,
                SelectedLaptop.LaptopID,
                SelectedLaptop.LaptopName,
                DateOnly.FromDateTime(DateTime.Now),
                cmbSoSao.SelectedIndex + 1,
                txtDanhGia.Text.Trim()
                );
            review.DeleteButton.Click += (s, ev) =>
            {
                MainMenu.Reviews.Remove(review);
                flpBinhLuan.Controls.Remove(review.ReviewTextBox);
                flpBinhLuan.Controls.Remove(review.DeleteButton);
            };

            MainMenu.Reviews.Add(review);
            flpBinhLuan.Controls.Add(review.ReviewTextBox);
            flpBinhLuan.Controls.Add(review.DeleteButton);

            txtDanhGia.Text = "";
        }
    }
}

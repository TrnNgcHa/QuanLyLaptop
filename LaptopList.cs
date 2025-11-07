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
            var form = new Purchase(SelectedLaptop, CurrentAccount);
            form.UpdateAccountBalance = (updatedAcc) =>
            {
                CurrentAccount = updatedAcc;
                lblSoDu.Text = string.Format("{0:#,##0 VND}", updatedAcc.Balance);
            };
            form.TopMost = true;
            form.ShowDialog();
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

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            var form = new AccountCenter(CurrentAccount);
            form.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDanhGia.Text = "";
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

            var reviews = Functions.CommentList(filteredReviews, SelectedLaptop.LaptopID);
            flpBinhLuan.Controls.Clear();
            foreach (var txt in reviews)
            {
                flpBinhLuan.Controls.Add(txt);
            }
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (txtDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung đánh giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Review review = new Review();
            review.ReviewID = MainMenu.Reviews.Count > 0 ? MainMenu.Reviews.Max(r => r.ReviewID) + 1 : 1;
            review.AccountID = AccountAuthentication.CurrentAccount.AccountID;
            review.AccountName = AccountAuthentication.CurrentAccount.AccountName;
            review.LaptopID = SelectedLaptop.LaptopID;
            review.LaptopName = SelectedLaptop.LaptopName;
            review.ReviewDate = DateOnly.FromDateTime(DateTime.Now);
            review.Rating = cmbSoSao.SelectedIndex + 1;
            review.Comments = txtDanhGia.Text.Trim();
            MainMenu.Reviews.Add(review);

            TextBox txt = new TextBox();
            txt.Name = $"1{MainMenu.Reviews.Max(r => r.ReviewID) + 1}";
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.Width = 600;
            txt.Height = 40;
            txt.Text = $"[{review.Rating} ★][{review.ReviewDate.ToString("dd/MM/yyyy")}] {review.AccountName}: {review.Comments}";
            txt.BackColor = Color.WhiteSmoke;
            txt.ForeColor = Color.Black;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            flpBinhLuan.Controls.Add(txt);

            txtDanhGia.Text = "";
        }
    }
}

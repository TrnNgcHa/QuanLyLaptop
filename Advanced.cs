using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class Advanced : Form
    {
        public Account CurrentAccount = new Account();
        public Advanced()
        {
            InitializeComponent();
        }

        public Advanced(Account currAccount)
        {
            InitializeComponent();
            CurrentAccount = currAccount;
        }

        public Laptop SelectedLaptop = new Laptop();

        void SetCardColor(Panel card, Color color)
        {
            card.BackColor = color;
            foreach (Control c in card.Controls)
            {
                // Nếu là TextBox thì đổi luôn màu nền
                if (c is TextBox)
                    c.BackColor = color;
            }
        }
        public void LoadLaptopList(List<Laptop> list)
        {
            flpDanhSachLaptop.Controls.Clear();
            Panel selectedPanel = null;
            foreach (var laptop in list)
            {
                Panel Card = new Panel
                {
                    Width = 325,
                    Height = 375,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke,
                    Cursor = Cursors.Hand
                };

                PictureBox HinhAnh = new PictureBox
                {
                    Image = Properties.Resources.laptop_avatar,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Width = 350,
                    Height = 200,
                    Enabled = false
                };

                TextBox MaLaptop = new TextBox
                {
                    Text = laptop.LaptopID.ToString(),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = HorizontalAlignment.Left,
                    ReadOnly = true,
                    BackColor = Card.BackColor,
                    ForeColor = Color.Black,
                };

                TextBox TenLaptop = new TextBox
                {
                    Text = laptop.LaptopName,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    BackColor = Card.BackColor,
                    ForeColor = Color.Maroon
                };

                TextBox ThongTin = new TextBox
                {
                    Text = $"Hãng: {laptop.AgencyName}\r\nNgày nhập: {laptop.StockInDate:dd/MM/yyyy}\r\nSố tồn: {laptop.RemainAmount}",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Dock = DockStyle.Top,
                    Multiline = true,
                    Height = 80,
                    TextAlign = HorizontalAlignment.Left,
                    ReadOnly = true,
                    BackColor = Card.BackColor,
                    ForeColor = Color.FromArgb(24,24,24)
                };

                TextBox GiaTien = new TextBox
                {
                    Text = string.Format("{0:#,##0 VND}", laptop.Price),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = HorizontalAlignment.Right,
                    ReadOnly = true,
                    BackColor = Card.BackColor,
                    ForeColor = Color.Red
                };

                Card.Click += (s, e) =>
                {
                    if(selectedPanel != null)
                        SetCardColor(selectedPanel, Color.WhiteSmoke);
                    selectedPanel = Card;
                    SetCardColor(Card, Color.MistyRose);

                    SelectedLaptop = laptop;
                    lblTenLaptop.Text = SelectedLaptop.LaptopName;
                    lblCPUInfo.Text = SelectedLaptop.CPU;
                    lblGPUInfo.Text = SelectedLaptop.GPU;
                    lblRAMInfo.Text = SelectedLaptop.RAM;
                    lblStorageInfo.Text = SelectedLaptop.Storage;
                    ChonLoaiDanhGia(s, e);
                };

                Card.Controls.Add(GiaTien);
                Card.Controls.Add(ThongTin);
                Card.Controls.Add(TenLaptop);
                Card.Controls.Add(MaLaptop);
                Card.Controls.Add(HinhAnh);

                flpDanhSachLaptop.Controls.Add(Card);

            }
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = CurrentAccount.LastName + " " + CurrentAccount.FirstName;
            lblTenTaiKhoan.Text = CurrentAccount.AccountName;
            lblSoDu.Text = string.Format("{0:#,##0 VND}", CurrentAccount.Balance);

            LoadLaptopList(MainMenu.Laptops);

            cmbLoaiTimKiem.SelectedIndex = 0;
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
            LoadLaptopList(filtered);
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
            var form = new AccountCenter(CurrentAccount);
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

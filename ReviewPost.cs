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
    public partial class ReviewPost : Form
    {
        public ReviewPost()
        {
            InitializeComponent();
        }
        Laptop SelectedLaptop = new Laptop();
        public ReviewPost(Laptop selectedItem)
        {
            InitializeComponent();
            SelectedLaptop = selectedItem;
        }

        private void Review_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = AccountAuthentication.CurrentAccount.AccountName;
            lblTenLaptop.Text = SelectedLaptop.LaptopName;

            txtDanhSachDanhGia.Text = Functions.CommentList(MainMenu.Reviews, SelectedLaptop.LaptopID);
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
            txtDanhSachDanhGia.Text = Functions.CommentList(filteredReviews, SelectedLaptop.LaptopID);
        }
        private void btnDanhGia_Click(object sender, EventArgs e)
        {
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
            txtDanhSachDanhGia.Text += $"\r\n[{review.Rating} ★][{review.ReviewDate.ToString("dd/MM/yyyy")}] {review.AccountName}: {review.Comments}";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

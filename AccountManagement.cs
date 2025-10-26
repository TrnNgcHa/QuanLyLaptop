using QuanLyLaptop.Models;
using System.Data;

namespace QuanLyLaptop
{
    public partial class AccountManagement : Form
    {

        public AccountManagement()
        {
            InitializeComponent();
            dgvQuanLyTaiKhoan.AutoGenerateColumns = false;
            dgvLichSuGiaoDich.AutoGenerateColumns = false;
        }

        int id = 0;
        private void AccountManagement_Load(object sender, EventArgs e)
        {
            dgvQuanLyTaiKhoan.DataSource = MainMenu.Accounts;
            dgvLichSuGiaoDich.DataSource = MainMenu.Receipts;
            dgvLichSuGiaoDich.ForeColor = Color.Black;

        }

        private void dgvQuanLyTaiKhoan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyTaiKhoan.CurrentRow != null)
            {
                lblHoTen.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["HoNguoi"].Value.ToString() + " " + dgvQuanLyTaiKhoan.CurrentRow.Cells["TenNguoi"].Value.ToString();
                lblGioiTinh.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["GioiTinh"].Value.ToString();
                lblNgaySinh.Text = ((DateOnly)dgvQuanLyTaiKhoan.CurrentRow.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
                lblThanhPho.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["ThanhPho"].Value.ToString();
                lblSDT.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["SoDienThoai"].Value.ToString();
                lblEmail.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["Email"].Value.ToString();
                lblCCCD.Text = dgvQuanLyTaiKhoan.CurrentRow.Cells["CCCD"].Value.ToString();
                id = (int)dgvQuanLyTaiKhoan.CurrentRow.Cells["MaTaiKhoan"].Value;
                List<Receipt> receipts = MainMenu.Receipts.Where(r => r.AccountID == id).ToList();
                dgvLichSuGiaoDich.DataSource = receipts;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát cửa số này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgvQuanLyTaiKhoan.DataSource = MainMenu.Accounts; // danh sách thời điểm frmStudentView_Load
            }
            else
            {
                List<Account> filtered = new List<Account>();
                switch (cmbLoaiTimKiem.Text)
                {
                    case "Mã người dùng":
                        filtered = MainMenu.Accounts.Where(s => s.PersonID.ToString().ToLower().Contains(filterText)).ToList();
                        break;

                    case "Tên người dùng":
                        filtered = MainMenu.Accounts.Where(s => s.LastName.ToLower().Contains(filterText) || s.FirstName.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Mã tài khoản":
                        filtered = MainMenu.Accounts.Where(s => s.AccountID.ToString().Contains(filterText)).ToList();
                        break;
                    case "Tên tài khoản":
                        filtered = MainMenu.Accounts.Where(s => s.AccountName.ToLower().Contains(filterText)).ToList();
                        break;
                }
                dgvQuanLyTaiKhoan.DataSource = filtered;
            }
        }
    }
}

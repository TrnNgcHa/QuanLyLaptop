using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class AccountCenter : Form
    {
        Account acc = new Account();
        bool isEditing = false;
        public AccountCenter()
        {
            InitializeComponent();
        }

        public AccountCenter(Account currAccount)
        {
            InitializeComponent();
            acc = currAccount;

        }

        public void Loadtxt()
        {
            txtHoTen.Text = acc.LastName + " " + acc.FirstName;
            txtGioiTinh.Text = acc.Gender;
            txtNgaySinh.Text = acc.DOB.ToString("dd/MM/yyyy");
            txtSDT.Text = acc.PhoneNumber;
            txtThanhPho.Text = acc.City;
            txtEmail.Text = acc.Email;
            txtCCCD.Text = acc.IdCard;
            txtTaiKhoan.Text = acc.AccountName;
            txtMatKhau.Text = acc.Password.ToString();
            txtSoDu.Text = acc.Balance.ToString("#,##0 VND");
        }

        public void Loadlsv()
        {
            lsvLichSuGiaoDich.View = View.Details;
            lsvLichSuGiaoDich.FullRowSelect = true;
            lsvLichSuGiaoDich.GridLines = true;

            lsvLichSuGiaoDich.Columns.Clear();
            lsvLichSuGiaoDich.Columns.Add("Ngày lập", 120);
            lsvLichSuGiaoDich.Columns.Add("Tài khoản", 150);
            lsvLichSuGiaoDich.Columns.Add("Laptop", 250);
            lsvLichSuGiaoDich.Columns.Add("Phụ kiện", 200);
            lsvLichSuGiaoDich.Columns.Add("Tổng tiền", 100);

            List<Receipt> receipts = MainMenu.Receipts.Where(r => r.AccountID == acc.AccountID).ToList();
            lsvLichSuGiaoDich.Items.Clear();

            foreach (var r in receipts)
            {

                // Tạo item
                ListViewItem item = new ListViewItem(r.InvoiceDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(r.PersonName);
                item.SubItems.Add(r.LaptopName);
                item.SubItems.Add($"{r.Total:N0}₫");

                // Thêm vào ListView
                lsvLichSuGiaoDich.Items.Add(item);
            }
        }
        private void AccountCenter_Load(object sender, EventArgs e)
        {
            Loadtxt();
            Loadlsv();


        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name.Replace("btn", "txt");
            TextBox txt = this.Controls.Find(name, true).FirstOrDefault() as TextBox;
            txt.Enabled = true;
            txt.Focus();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox txt = sender as TextBox;
                if (txt != null && txt.Enabled)
                {
                    txt.Enabled = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Enabled)
            {
                txt.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                MessageBox.Show("Thay đổi thông tin tài khoản sẽ phải đăng nhập lại từ đầu!", "Thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = Application.OpenForms["LaptopList"];
                if (form != null)
                {
                    form.Close();
                }
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Thoát mà không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            acc.LastName = Functions.GetLastName(txtHoTen.Text);
            acc.FirstName = Functions.GetFirstName(txtHoTen.Text);
            acc.Gender = txtGioiTinh.Text;
            acc.DOB = DateOnly.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy");
            acc.PhoneNumber = txtSDT.Text;
            acc.City = txtThanhPho.Text;
            acc.Email = txtEmail.Text;
            acc.IdCard = txtCCCD.Text;
            acc.AccountName = txtTaiKhoan.Text;
            acc.Password = Convert.ToInt32(txtMatKhau.Text);

            var result = MessageBox.Show("Lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AccountAuthentication.CurrentAccount.CopyFrom(acc);
            }

            isEditing = true;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xóa tài khoản sẽ xóa tất cả dữ liệu liên quan. Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainMenu.Accounts.RemoveAll(a => a.AccountID == acc.AccountID);
                AccountAuthentication.CurrentAccount = null;
                this.Close();
            }
        }
    }
}

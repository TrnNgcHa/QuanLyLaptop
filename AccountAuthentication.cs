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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyLaptop
{
    public partial class AccountAuthentication : Form
    {
        public AccountAuthentication()
        {
            InitializeComponent();
        }

        public static Account CurrentAccount = new Account();
        private void Authentication_Load(object sender, EventArgs e)
        {

            grbDangNhap.Left = (this.ClientSize.Width - grbDangNhap.Width) / 2;
            grbDangNhap.Top = (this.ClientSize.Height - grbDangNhap.Height) / 2;

            grbDangKy.Left = (this.ClientSize.Width - grbDangKy.Width) / 2;
            grbDangKy.Top = (this.ClientSize.Height - grbDangKy.Height) / 2;
        }
        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbNam.Checked)
            {
                ckbNu.Checked = true;
            }
            else
            {
                ckbNu.Checked = false;
            }
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbNu.Checked)
            {
                ckbNam.Checked = true;
            }
            else
            {
                ckbNam.Checked = false;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            if (!Functions.IsValidUserName(txtHoTen.Text))
            {
                MessageBox.Show("Tên người dùng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDK.Focus();
                return;

            }
            if (!Functions.IsValidPhone(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;

            }
            if (!Functions.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;

            }
            //if (!Functions.IsValidIdCard(txtCCCD.Text))
            //{
            //    MessageBox.Show("Căn cước công dân không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCCCD.Focus();
            //    return;

            //}

            if (MainMenu.Accounts.Any(acc => acc.AccountName == txtTenDK.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string gender = ckbNam.Checked ? "Nam" : "Nữ";

            var newAccount = new Account(Functions.GetFirstName(txtHoTen.Text), Functions.GetLastName(txtHoTen.Text), gender, DateOnly.FromDateTime(dtpNgaySinh.Value), txtSDT.Text, cmbTinhThanh.Text, txtEmail.Text, txtCCCD.Text);
            do
            {
                newAccount.AccountID = Random.Shared.Next(20001, 29999);
            }
            while (MainMenu.Accounts.Any(a => a.AccountID == newAccount.AccountID));
            do
            {
                newAccount.PersonID = Random.Shared.Next(10001, 19999);
            }
            while (MainMenu.Accounts.Any(a => a.PersonID == newAccount.PersonID));
            newAccount.SetAccount(txtTenDK.Text, Convert.ToInt32(txtMatKhauDK.Text));

            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu.Accounts.Add(newAccount);
            CurrentAccount = newAccount;

            var form = new LaptopList(CurrentAccount);
            form.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!MainMenu.Accounts.Any(acc => acc.AccountName == txtTenDN.Text && acc.Password == Convert.ToInt32(txtMatKhauDN.Text)))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentAccount = MainMenu.Accounts.First(acc => acc.AccountName == txtTenDN.Text && acc.Password == Convert.ToInt32(txtMatKhauDN.Text));

            var form = new LaptopList(CurrentAccount);
            form.ShowDialog();
            this.Close();
            return;
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grbDangNhap.Visible = true;
            grbDangKy.Visible = false;
        }

        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grbDangKy.Visible = true;
            grbDangNhap.Visible = false;
        }

        private void AccountAuthentication_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentAccount = new Account();
        }

        private void ckbHienMK1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauDK.PasswordChar = ckbHienMK1.Checked ? '\0' : '*';
        }

        private void ckbHienMK2_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauDN.PasswordChar = ckbHienMK2.Checked ? '\0' : '*';
        }
    }
}

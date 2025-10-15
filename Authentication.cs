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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        
        private void Authentication_Load(object sender, EventArgs e)
        {
            

            grbDangNhap.Left = (this.ClientSize.Width - grbDangNhap.Width) / 2;
            grbDangNhap.Top = (this.ClientSize.Height - grbDangNhap.Height) / 2;

            grbDangKy.Left = (this.ClientSize.Width - grbDangKy.Width) / 2;
            grbDangKy.Top = (this.ClientSize.Height - grbDangKy.Height) / 2;
        }
        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNam.Checked)
            {
                ckbNu.Checked = false;
            }
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNu.Checked)
            {
                ckbNam.Checked = false;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            if(!Functions.IsValidUserName(txtHoTen.Text))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(!Functions.IsValidIdCard(txtCCCD.Text))
            {
                MessageBox.Show("Căn cước công dân không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Focus();
                return;

            }

            foreach (Account a in MainMenu.Accounts)
            {
                if (a.AccountName == txtTenDK.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string gender = ckbNam.Checked ? "Nam" : "Nữ";

            var newAccount = new Account(Functions.GetFirstName(txtHoTen.Text), Functions.GetLastName(txtHoTen.Text), gender, DateOnly.FromDateTime(dtpNgaySinh.Value), txtSDT.Text, cmbTinhThanh.Text, txtEmail.Text, txtCCCD.Text);
            do
            {
                newAccount.AccountID = Random.Shared.Next(15001, 20000);
            }
            while (MainMenu.Accounts.Any(a => a.AccountID == newAccount.AccountID));
            do
            {
                newAccount.PersonID = Random.Shared.Next(10001, 15000);
            }
            while (MainMenu.Accounts.Any(a => a.PersonID == newAccount.PersonID));
            newAccount.SetAccount(txtTenDK.Text, Convert.ToInt32(txtMatKhauDK.Text));

            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            MainMenu.Accounts.Add(newAccount);
            

            var form = new LaptopList();
            form.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            foreach (Account a in MainMenu.Accounts)
            {
                if (a.AccountName == txtTenDN.Text && a.Password.ToString() == txtMatKhauDN.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var form = new LaptopList();
                    form.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

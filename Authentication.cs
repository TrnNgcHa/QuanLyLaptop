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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        List<Account> accounts = new List<Account>();
        private void Authentication_Load(object sender, EventArgs e)
        {
            Account acc = new Account();
            accounts = acc.GetList();

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
            foreach (Account a in accounts)
            {
                if (a.AccountName == txtTenDK.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var form = new LaptopList();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            foreach (Account a in accounts)
            {
                if (a.AccountName == txtTenDN.Text && a.Password.ToString() == txtMatKhauDN.Text)
                {

                    var form = new LaptopList();
                    form.ShowDialog();
                    this.Close();
                    return;
                }
            }
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

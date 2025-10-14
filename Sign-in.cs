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
    public partial class Sign_in : Form
    {
        public static bool daDangNhap = false;
        public static string tenDN = "";
        public static string mkDN = "";
        public Sign_in()
        {
            InitializeComponent();
        }
        List<Account> accounts = new List<Account>();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text != "" && txtPassword.Text != "")
            {
                Account acc = new Account();
                accounts = acc.GetList();
                for (int i = 0; i < accounts.Count(); i++)
                {
                    if (txtAccountName.Text == accounts[i].AccountName && txtPassword.Text == accounts[i].Password.ToString())
                    {

                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        daDangNhap = true;
                        tenDN = txtAccountName.Text;
                        mkDN = txtPassword.Text;
                        this.Close();
                        break;
                    }
                    else if (i == accounts.Count() - 1)
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

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
using QuanLyLaptop.Models;

namespace QuanLyLaptop
{
    public partial class AccountCenter : Form
    {
        Account acc = new Account();
        string prevValue = "";
        public AccountCenter()
        {
            InitializeComponent();
        }

        public AccountCenter(Account currAccount)
        {
            InitializeComponent();
            acc = currAccount;

        }
        private void AccountCenter_Load(object sender, EventArgs e)
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
                if(txt != null && txt.Enabled)
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


    }
}

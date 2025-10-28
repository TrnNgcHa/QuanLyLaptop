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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        public Action<Account> UpdateAccountBalance;

        Laptop SelectedLaptop = new Laptop();
        Account CurrentAccount = new Account();
        int GiaPhuKien = 0;

        

        public Purchase(Laptop selected, Account current)
        {
            InitializeComponent();
            SelectedLaptop = selected;
            CurrentAccount = current;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            this.Left = 1280;
            this.Top = 320;

            lblTenLaptop.Text = SelectedLaptop.LaptopName;
            lblGiaLaptop.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
            lblTenKhachHang.Text = CurrentAccount.FirstName + " " + CurrentAccount.LastName;
            lblTenTaiKhoan.Text = CurrentAccount.AccountName;
            lblSoDu.Text += string.Format("{0:#,##0 VND}", CurrentAccount.Balance);

            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
            lblGiaThem.Text = "0 VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (CurrentAccount.Balance < SelectedLaptop.Price + GiaPhuKien)
            {
                MessageBox.Show("Số dư tài khoản không đủ để thực hiện thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(CurrentAccount.AccountID == 10000))
            {
                AccountAuthentication.CurrentAccount.Balance -= (SelectedLaptop.Price + GiaPhuKien);
                MainMenu.Laptops.First(l => l.LaptopID == SelectedLaptop.LaptopID).RemainAmount -= 1;
            }
            lblSoDu.Text = "Số dư tài khoản: " + string.Format("{0:#,##0 VND}", CurrentAccount.Balance);
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        public void PhuKien()
        {
            lblGiaThem.Text = string.Format("{0:#,##0 VND}", GiaPhuKien);
            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price + GiaPhuKien);
        }
        private void ckbUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUSB.Checked)
            {
                GiaPhuKien += 80000;
            }
            else
            {
                GiaPhuKien -= 80000;
            }
            PhuKien();
        }

        private void ckbTuiDung_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTuiDung.Checked)
            {
                GiaPhuKien += 80000;
            }
            else
            {
                GiaPhuKien -= 80000;
            }
            PhuKien();
        }

        private void ckbNuocRua_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNuocRua.Checked)
            {
                GiaPhuKien += 35000;
            }
            else
            {
                GiaPhuKien -= 35000;
            }
            PhuKien();
        }

        private void ckbLotChuot_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLotChuot.Checked)
            {
                GiaPhuKien += 30000;
            }
            else
            {
                GiaPhuKien -= 30000;
            }
            PhuKien();
        }

        private void Purchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAccountBalance?.Invoke(CurrentAccount);
        }
    }
}

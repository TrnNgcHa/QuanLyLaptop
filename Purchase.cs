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
        Laptop SelectedLaptop = new Laptop();
        int GiaPhuKien = 0;

        public Purchase(Laptop SelectedItem)
        {
            InitializeComponent();
            SelectedLaptop = SelectedItem;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            this.Left = 1280;
            this.Top = 320;

            lblTenLaptop.Text = SelectedLaptop.LaptopName;
            lblGiaLaptop.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
            lblTenKhachHang.Text = AccountAuthentication.CurrentAccount.FirstName + " " + AccountAuthentication.CurrentAccount.LastName;
            lblTenTaiKhoan.Text = AccountAuthentication.CurrentAccount.AccountName;
            lblSoDu.Text += string.Format("{0:#,##0 VND}", AccountAuthentication.CurrentAccount.Balance);

            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
            lblGiaThem.Text = "0 VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(AccountAuthentication.CurrentAccount.Balance >= SelectedLaptop.Price + GiaPhuKien)
            {
                if (!(AccountAuthentication.CurrentAccount.AccountID == 10000))
                {
                    AccountAuthentication.CurrentAccount.Balance -= (SelectedLaptop.Price + GiaPhuKien);
                    LaptopList.SelectedItem.RemainAmount--;
                }
                lblSoDu.Text = "Số dư tài khoản: " + string.Format("{0:#,##0 VND}", AccountAuthentication.CurrentAccount.Balance);
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LaptopList.ActiveForm.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Số dư tài khoản không đủ để thực hiện thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbUSB_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbUSB.Checked)
            {
                GiaPhuKien += 80000;
            }
            else
            {
                GiaPhuKien -= 80000;
            }
            lblGiaThem.Text = string.Format("{0:#,##0 VND}", GiaPhuKien);
            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price + GiaPhuKien);
        }

        private void ckbTuiDung_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTuiDung.Checked)
            {
                GiaPhuKien += 80000;
            }
            else
            {
                GiaPhuKien -= 80000;
            }
            lblGiaThem.Text = string.Format("{0:#,##0 VND}", GiaPhuKien);
            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price + GiaPhuKien);
        }

        private void ckbNuocRua_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNuocRua.Checked)
            {
                GiaPhuKien += 35000;
            }
            else
            {
                GiaPhuKien -= 35000;
            }
            lblGiaThem.Text = string.Format("{0:#,##0 VND}", GiaPhuKien);
            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price + GiaPhuKien);
        }

        private void ckbLotChuot_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbLotChuot.Checked)
            {
                GiaPhuKien += 30000;
            }
            else
            {
                GiaPhuKien -= 30000;
            }
            lblGiaThem.Text = string.Format("{0:#,##0 VND}", GiaPhuKien);
            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price + GiaPhuKien);
        }
    }
}

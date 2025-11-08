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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (CurrentAccount.Balance < SelectedLaptop.Price)
            {
                MessageBox.Show("Số dư tài khoản không đủ để thực hiện thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(CurrentAccount.AccountID == 20000))
            {
                AccountAuthentication.CurrentAccount.Balance -= (SelectedLaptop.Price);
                MainMenu.Laptops.First(l => l.LaptopID == SelectedLaptop.LaptopID).RemainAmount -= 1;

                Receipt receipt = new Receipt();
                int id = 0;
                do
                {
                    id = new Random().Next(50000, 69999);
                }while (MainMenu.Receipts.Any(r => r.ReceiptID == id));
                receipt.ReceiptID = id;
                receipt.InvoiceDate = DateOnly.FromDateTime(DateTime.Now);
                receipt.AccountID = CurrentAccount.AccountID;
                receipt.AccountName = CurrentAccount.AccountName;
                receipt.PersonID = CurrentAccount.PersonID;
                receipt.PersonName = CurrentAccount.LastName + " " + CurrentAccount.FirstName;
                receipt.LaptopID = SelectedLaptop.LaptopID;
                receipt.LaptopName = SelectedLaptop.LaptopName;
                receipt.Total = SelectedLaptop.Price;
                MainMenu.Receipts.Add(receipt);
            }
            lblSoDu.Text = "Số dư tài khoản: " + string.Format("{0:#,##0 VND}", CurrentAccount.Balance);
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
        private void Purchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAccountBalance?.Invoke(CurrentAccount);
        }
    }
}

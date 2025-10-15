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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        Laptop SelectedLaptop = new Laptop();

        public Receipt(Laptop SelectedItem) : this()
        {
            SelectedLaptop = SelectedItem;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            lblTenLaptop.Text = SelectedLaptop.LaptopName;
            lblGiaLaptop.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
            lblTenKhachHang.Text = Authentication.CurrentAccount.FirstName + " " + Authentication.CurrentAccount.LastName;
            lblTenTaiKhoan.Text = Authentication.CurrentAccount.AccountName;

            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

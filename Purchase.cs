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

            lblThanhTien.Text = string.Format("{0:#,##0 VND}", SelectedLaptop.Price);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}

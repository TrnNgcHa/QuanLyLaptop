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
    public partial class DanhSachLaptop : Form
    {
        public DanhSachLaptop()
        {
            InitializeComponent();
        }

        List<Laptop> laptopList = new List<Laptop>();

        private void DanhSachLaptop_Load(object sender, EventArgs e)
        {
            Laptop lt = new Laptop();
            laptopList = lt.GetList();
            dgvDanhSachLaptop.DataSource = laptopList;
        }
    }
}

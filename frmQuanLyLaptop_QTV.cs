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
    public partial class frmQuanLyLaptop_QTV : Form
    {
        List<Laptop> laptops = new List<Laptop>();
        public frmQuanLyLaptop_QTV()
        {
            InitializeComponent();
        }

        private void frmQuanLyLaptop_QTV_Load(object sender, EventArgs e)
        {
            Laptop lt = new Laptop();
            laptops = lt.GetList();
            dgvDanhSachLaptop.DataSource = laptops;
        }
    }
}

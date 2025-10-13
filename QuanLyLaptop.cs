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
    public partial class QuanLyLaptop : Form
    {
        List<Laptop> laptopList = new List<Laptop>();
        public QuanLyLaptop()
        {
            InitializeComponent();
        }

        private void QuanLyLaptop_Load(object sender, EventArgs e)
        {
            Laptop lt = new Laptop();
            laptopList = lt.GetList();
            dgvQuanLyLaptop.DataSource = laptopList;
        }
    }
}

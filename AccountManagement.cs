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
    public partial class AccountManagement : Form
    {
        
        public AccountManagement()
        {
            InitializeComponent();
            dgvQuanLyTaiKhoan.AutoGenerateColumns = false;
        }
        

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            dgvQuanLyTaiKhoan.DataSource = MainMenu.Accounts;
        }
    }
}

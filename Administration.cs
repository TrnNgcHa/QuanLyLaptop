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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form = new LaptopManagement();
            form.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var form = new AccountManagement();
            form.ShowDialog();
        }   

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            var form = new ReceiptManagement();
            form.ShowDialog();
        }
    }
}

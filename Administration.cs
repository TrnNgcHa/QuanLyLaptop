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

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Main.ActiveForm.Close();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Administration.ActiveForm.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form = new QuanLyLaptop();
            form.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var form = new AccountManagement();
            form.Show();
        }
    }
}

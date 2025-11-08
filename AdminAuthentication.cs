namespace QuanLyLaptop
{
    public partial class AdminAuthentication : Form
    {
        public AdminAuthentication()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Kiểm tra tên đăng nhập và mật khẩu có phải của Admin không
            if (txtName.Text == "Admin" && txtPassword.Text == "123456")
            {
                var form = new Administration();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Verification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var form = new Administration();
                form.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckbHienMK.Checked ? '\0' : '*';
        }
    }
}

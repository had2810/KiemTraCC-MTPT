namespace KIemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtpassword.Text.Trim();

            // Kiểm tra điều kiện đăng nhập
            if (username == "admin" && password == "admin")
            {
                // Mở form đăng nhập thành công
                loginSuccess frm = new loginSuccess();
                frm.Show();

                // Ẩn form hiện tại (nếu muốn)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace BaiTap2
{
    public partial class Form1 : Form
    {
        private XDocument loginDoc;

        public Form1()
        {
            InitializeComponent();

            btnSubmit.Click += btnSubmit_Click;
            btnReset.Click += btnReset_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

            string filePath = Path.Combine(Application.StartupPath, "data", "login.xml");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file login.xml trong thư mục data!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loginDoc = XDocument.Load(filePath);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (loginDoc == null)
            {
                MessageBox.Show("Chưa load được dữ liệu người dùng!");
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = loginDoc.Descendants("user")
                               .FirstOrDefault(u =>
                                   (string)u.Element("username") == username &&
                                   (string)u.Element("password") == password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai username hoặc password!", "Đăng nhập thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}

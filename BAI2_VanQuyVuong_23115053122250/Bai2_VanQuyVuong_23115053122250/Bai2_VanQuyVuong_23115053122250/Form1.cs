using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai2_VanQuyVuong_23115053122250
{
    public partial class Form1 : Form
    {
        private XDocument loginDoc;
        public Form1()
        {
            InitializeComponent();
                button2.Click += btnSubmit_Click;
                button1.Click += btnReset_Click;
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                textBox2.PasswordChar = '*';

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

                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                var user = loginDoc.Descendants("user")
                                   .FirstOrDefault(u =>
                                       (string)u.Element("username") == username &&
                                       (string)u.Element("password") == password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai username hoặc password!", "Đăng nhập thất bại");
                }
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
             textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            }

        
    }
    }


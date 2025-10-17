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
    public partial class Form4 : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "data", "sinhvien.xml");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadCourseCodes();
                LoadData();

                button1.Click += btnSearch_Click;
                comboBox1.SelectedIndexChanged += cboMaMon_SelectedIndexChanged;
                dataGridView1.CellClick += dataGridView1_CellClick;
            }

            private void LoadCourseCodes()
            {
                XDocument doc = XDocument.Load(filePath);
                var codes = doc.Descendants("course")
                               .Select(c => c.Attribute("code")?.Value)
                               .Where(c => !string.IsNullOrEmpty(c))
                               .Distinct()
                               .ToList();

                comboBox1.DataSource = codes;
            }

            private void LoadData()
            {
                XDocument doc = XDocument.Load(filePath);

                var query = from s in doc.Descendants("student")
                            from c in s.Elements("course")
                            select new
                            {
                                StudentCode = s.Attribute("code")?.Value,
                                StudentName = s.Attribute("name")?.Value,
                                Class = s.Attribute("class")?.Value,
                                CourseCode = c.Attribute("code")?.Value,
                                CourseName = c.Attribute("name")?.Value,
                                Point = c.Attribute("point")?.Value
                            };

                dataGridView1.DataSource = query.ToList();
            }

            private void cboMaMon_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox1.SelectedItem != null)
                {
                    string maMon = comboBox1.SelectedItem.ToString();
                    XDocument doc = XDocument.Load(filePath);

                    var mon = doc.Descendants("course")
                                 .FirstOrDefault(c => (string)c.Attribute("code") == maMon);

                    if (mon != null)
                    {
                        textBox2.Text = mon.Attribute("name")?.Value;
                    }
                }
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                XDocument doc = XDocument.Load(filePath);

                string stuCode = textBox1.Text.Trim();
                string maMon = comboBox1.Text.Trim();
                string diem = textBox3.Text.Trim();

                var query = from s in doc.Descendants("student")
                            from c in s.Elements("course")
                            where (string.IsNullOrEmpty(stuCode) || (string)s.Attribute("code") == stuCode)
                               && (string.IsNullOrEmpty(maMon) || (string)c.Attribute("code") == maMon)
                               && (string.IsNullOrEmpty(diem) || (string)c.Attribute("point") == diem)
                            select new
                            {
                                StudentCode = s.Attribute("code")?.Value,
                                StudentName = s.Attribute("name")?.Value,
                                Class = s.Attribute("class")?.Value,
                                CourseCode = c.Attribute("code")?.Value,
                                CourseName = c.Attribute("name")?.Value,
                                Point = c.Attribute("point")?.Value
                            };

                dataGridView1.DataSource = query.ToList();

                if (!query.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                }
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["StudentCode"].Value?.ToString();
                    comboBox1.Text = row.Cells["CourseCode"].Value?.ToString();
                    textBox2.Text = row.Cells["CourseName"].Value?.ToString();
                    textBox3.Text = row.Cells["Point"].Value?.ToString();
                }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }


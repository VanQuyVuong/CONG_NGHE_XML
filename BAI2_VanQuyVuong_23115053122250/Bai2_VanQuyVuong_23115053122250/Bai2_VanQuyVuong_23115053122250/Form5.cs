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
    public partial class Form5 : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "data", "sinhvien.xml");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadClasses();
                LoadStudents();

                button1.Click += btnSearch_Click;
                comboBox1.SelectedIndexChanged += cboClass_SelectedIndexChanged;
                dataGridView1.CellClick += dgvStudents_CellClick;
            }

            private void LoadClasses()
            {
                XDocument doc = XDocument.Load(filePath);
                var classes = doc.Descendants("student")
                                 .Select(s => s.Attribute("class")?.Value)
                                 .Where(c => !string.IsNullOrEmpty(c))
                                 .Distinct()
                                 .ToList();

                comboBox1.DataSource = classes;
                comboBox1.SelectedIndex = -1;
            }

            private void LoadStudents()
            {
                XDocument doc = XDocument.Load(filePath);

                var query = from s in doc.Descendants("student")
                            select new
                            {
                                StudentCode = s.Attribute("code")?.Value,
                                Name = s.Attribute("name")?.Value,
                                Class = s.Attribute("class")?.Value
                            };

                dataGridView1.DataSource = query.ToList();
            }

            private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox1.SelectedItem == null) return;

                string selectedClass = comboBox1.SelectedItem.ToString();
                XDocument doc = XDocument.Load(filePath);

                var query = from s in doc.Descendants("student")
                            where (string)s.Attribute("class") == selectedClass
                            select new
                            {
                                StudentCode = s.Attribute("code")?.Value,
                                Name = s.Attribute("name")?.Value,
                                Class = s.Attribute("class")?.Value
                            };

                dataGridView1.DataSource = query.ToList();
            }


            private void btnSearch_Click(object sender, EventArgs e)
            {
                XDocument doc = XDocument.Load(filePath);

                string stuCode = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string className = comboBox1.Text.Trim();

                var query = doc.Descendants("student")
                    .Where(s =>
                        (string.IsNullOrEmpty(stuCode) || (string)s.Attribute("code") == stuCode)
                        && (string.IsNullOrEmpty(name) || (((string)s.Attribute("name") ?? "").IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0))
                        && (string.IsNullOrEmpty(className) || (string)s.Attribute("class") == className)
                    )
                    .Select(s => new
                    {
                        StudentCode = s.Attribute("code")?.Value,
                        Name = s.Attribute("name")?.Value,
                        Class = s.Attribute("class")?.Value
                    });

                var list = query.ToList();
                dataGridView1.DataSource = list;

                if (!list.Any())
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp!");
            }


            private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["StudentCode"].Value?.ToString();
                    textBox2.Text = row.Cells["Name"].Value?.ToString();
                    comboBox1.Text = row.Cells["Class"].Value?.ToString();
                }
            }
        }
    }



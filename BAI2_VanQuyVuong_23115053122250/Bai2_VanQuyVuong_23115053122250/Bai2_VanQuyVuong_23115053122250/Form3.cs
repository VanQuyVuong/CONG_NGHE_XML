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
    public partial class Form3 : Form
    {
        private string filePath;
        private XDocument doc;

        public Form3()
        {
            InitializeComponent();
       
                button1.Click += BtnAdd_Click;
                button2.Click += BtnUpdate_Click;
                button3.Click += BtnDelete_Click;
                comboBox1.SelectedIndexChanged += CboClassSearch_SelectedIndexChanged;
                dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            }

            private void Form3_Load(object sender, EventArgs e)
            {
                string dataFolder = Path.Combine(Application.StartupPath, "Data");
                if (!Directory.Exists(dataFolder))
                    Directory.CreateDirectory(dataFolder);

                filePath = Path.Combine(dataFolder, "sinhvien.xml");

                if (!File.Exists(filePath))
                {
                    doc = new XDocument(new XElement("ute"));
                    doc.Save(filePath);
                }
                else
                {
                    doc = XDocument.Load(filePath);
                }

                LoadDataGrid();
                LoadClassComboBox();
            }

            private void LoadDataGrid()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("StudentCode");
                dt.Columns.Add("Name");
                dt.Columns.Add("Class");

                foreach (var s in doc.Descendants("student"))
                {
                    DataRow row = dt.NewRow();
                    row["StudentCode"] = s.Attribute("code").Value;
                    row["Name"] = s.Attribute("name").Value;
                    row["Class"] = s.Attribute("class").Value;
                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
            }

            private void LoadClassComboBox()
            {
                var classes = doc.Descendants("student")
                    .Select(x => x.Attribute("class").Value)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Tất cả");
                comboBox1.Items.AddRange(classes.ToArray());
                comboBox1.SelectedIndex = 0;
            }

            private void CboClassSearch_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedClass = comboBox1.Text.Trim();

                DataTable dt = new DataTable();
                dt.Columns.Add("StudentCode");
                dt.Columns.Add("Name");
                dt.Columns.Add("Class");

                var students = doc.Descendants("student");
                if (selectedClass != "Tất cả")
                {
                    students = students.Where(x => x.Attribute("class").Value == selectedClass);
                }

                foreach (var s in students)
                {
                    DataRow row = dt.NewRow();
                    row["StudentCode"] = s.Attribute("code").Value;
                    row["Name"] = s.Attribute("name").Value;
                    row["Class"] = s.Attribute("class").Value;
                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
            }

            private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["StudentCode"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Class"].Value.ToString();
            }

            private void BtnAdd_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Nhập mã sinh viên!");
                    return;
                }

                if (doc.Descendants("student").Any(x => x.Attribute("code").Value == textBox1.Text.Trim()))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                XElement newStudent = new XElement("student",
                    new XAttribute("code", textBox1.Text.Trim()),
                    new XAttribute("name", textBox2.Text.Trim()),
                    new XAttribute("class", textBox3.Text.Trim())
                );

                doc.Root.Add(newStudent);
                doc.Save(filePath);

                LoadDataGrid();
                LoadClassComboBox();
            }

            private void BtnUpdate_Click(object sender, EventArgs e)
            {
                var student = doc.Descendants("student")
                    .FirstOrDefault(x => x.Attribute("code").Value == textBox1.Text.Trim());

                if (student != null)
                {
                    student.SetAttributeValue("name", textBox2.Text.Trim());
                    student.SetAttributeValue("class", textBox3.Text.Trim());

                    doc.Save(filePath);

                    LoadDataGrid();
                    LoadClassComboBox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh để sửa!");
                }
            }

            private void BtnDelete_Click(object sender, EventArgs e)
            {
                var student = doc.Descendants("student")
                    .FirstOrDefault(x => x.Attribute("code").Value == textBox1.Text.Trim());

                if (student != null)
                {
                    student.Remove();
                    doc.Save(filePath);

                    LoadDataGrid();
                    LoadClassComboBox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh để xóa!");
                }
            }
        }
    }



using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.LinkLabel;

namespace Tuan5_QuyVuong
{
    public partial class StudentManager : Form
    {
        public string path = @"D:\CN_XML\T_CNXML\Bai5_VanQuyVuong_23115053122250\Tuan5_QuyVuong\Tuan5_QuyVuong\bin\Debug\data\student.xml";

        public XDocument doc;
        public int current = 0; // dòng hiện tại của DataGridView
        public int maxRow = 0;   // số dòng của DataGridView=số phần tử của tệp XML
        public string gr = "All";
        public StudentManager()
        {
            InitializeComponent();
        }




        public void initCombo()
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("student");

            string tmp = "All";
            this.cboClass.Items.Clear();
            this.cboClass.Items.Add("All");
            string group;

            ArrayList myClass = new ArrayList();

            foreach (XElement node in list)
            {
                group = node.Attribute("class").Value;
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    myClass.Add(group);
                }
            }

            myClass.Sort();
            for (int i = 0; i < myClass.Count - 1; i++)
            {
                this.cboClass.Items.Add(myClass[i]);
            }
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGrid(gr);
            grid2textbox(0);
        }

        public void grid2textbox(int cur)
        {
            // đưa dữ liệu dòng thứ cur lên textbox
            this.txtCode.Text =
                 this.dgvStudents.Rows[cur].Cells[0].Value.ToString();
            this.txtName.Text =
                 this.dgvStudents.Rows[cur].Cells[1].Value.ToString();
            this.txtClass.Text =
                 this.dgvStudents.Rows[cur].Cells[2].Value.ToString();
            this.txtAddress.Text =
                 this.dgvStudents.Rows[cur].Cells[3].Value.ToString();
        }

        public void initGrid(string gr)
        {
            this.dgvStudents.ColumnCount = 4;
            this.dgvStudents.Columns[0].Name = "Code";
            this.dgvStudents.Columns[0].DefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudents.Columns[0].HeaderCell
                .Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvStudents.Columns[0].Width = 85;

            this.dgvStudents.Columns[1].Name = "Name";
            this.dgvStudents.Columns[1].Width = 180;
            this.dgvStudents.Columns[2].Name = "Class";
            this.dgvStudents.Columns[2].DefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudents.Columns[2].HeaderCell
                .Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvStudents.Columns[2].Width = 85;

            this.dgvStudents.Columns[3].Name = "Address";
            this.dgvStudents.Columns[3].Width = 180;

            Labrary lb = new Labrary();
            doc = lb.open(path);
            var list = doc.Descendants("student");
            string code, name, group, add = "";

            this.dgvStudents.Rows.Clear();
            foreach (XElement node in list)
            {
                group = node.Attribute("class").Value;
                if (gr == group || gr == "All")
                {
                    code = node.Attribute("code").Value;
                    name = node.Attribute("name").Value;
                    add = node.Attribute("address").Value;
                    this.dgvStudents.Rows.Add(code, name, group, add);
                }
            }
            maxRow = this.dgvStudents.RowCount - 1; // trừ dòng tiêu đề
            initCombo();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Labrary lb = new Labrary();
            string code = this.txtCode.Text;
            XElement node = lb.find(code, path);
            emptyTextBox(true);

            if (node == null)
            {
                MessageBox.Show("Node not found or Student Code is empty");
            }
            else
            {
                this.txtCode.Text = code;
                this.txtName.Text = node.Attribute("name").Value;
                this.txtClass.Text = node.Attribute("class").Value;
                this.txtAddress.Text = node.Attribute("address").Value;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtClass.Text = "";
            this.txtAddress.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (this.btnNew.Text == "New")
            {
                this.btnNew.Text = "Save";
                this.btnNew.ForeColor = Color.Red;
                emptyTextBox(true);
                this.txtCode.Focus();
            }
            else
            {
                if (txtCode.Text != "" && txtName.Text != "" &&
                            txtClass.Text != "" && txtAddress.Text != "")
                {
                    this.btnNew.Text = "New";
                    this.btnNew.ForeColor = Color.Black;
                    Labrary lb = new Labrary();
                    lb.insert(this.txtCode.Text, this.txtName.Text,
                              this.txtClass.Text, this.txtAddress.Text, path);
                    initGrid(gr);
                }
                else
                {
                    MessageBox.Show("Không để trống mọi fiels");
                    this.txtCode.Focus();
                }
            }
        }

        public void emptyTextBox(bool ok)
        {
            if (ok)
            {
                this.txtCode.Text = "";
            }
            this.txtName.Text = "";
            this.txtClass.Text = "";
            this.txtAddress.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Labrary lb = new Labrary();
            bool ok = false;
            string code = this.txtCode.Text;
            DialogResult result =
                MessageBox.Show("You are sure to delete this node?",
                                 "Important Question",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes && code.Trim() != "")
            {
                ok = lb.delete(code, path);
            }

            /* -------------- Chạy tốt, sử dụng LINQ ----------------
            doc.Descendants("student")
                .Where(x => (string)x.Attribute("code") == code) 
                .Remove();
            doc.Save(path);           
           ---------------------------------------------------------*/

            emptyTextBox(true);
            initGrid(gr);
            MessageBox.Show((ok == true ? "Removed!" :
                             "Don't remove or Node not found"));
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current < maxRow - 1) { current++; }
            else { current = 0; }
            grid2textbox(current);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (current > 0) { current--; }
            else { current = maxRow - 1; }
            //MessageBox.Show(current.ToString());
            grid2textbox(current);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Labrary lb = new Labrary();
            if (this.btnUpdate.Text == "Update")
            {
                this.txtName.Focus();
                this.btnUpdate.Text = "Save";
                this.btnUpdate.ForeColor = Color.Red;
                this.txtCode.Enabled = false;
            }
            else if (this.btnUpdate.Text == "Save" &&
                     this.txtName.Text != "" &&
                     this.txtClass.Text != "" &&
                     this.txtAddress.Text != "")
            {
                lb.update(this.txtCode.Text,
                    this.txtName.Text,
                    this.txtClass.Text,
                    this.txtAddress.Text,
                    path);
                this.txtCode.Enabled = true;
                this.btnUpdate.ForeColor = Color.Black;
                initGrid(gr); grid2textbox(0);
                this.btnUpdate.Text = "Update";
            }
            else
            {
                MessageBox.Show("Không để trống các field",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.txtName.Focus();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1- Đưa dữ liệu vào mảng, sắp mảng, đưa lại tệp XML\n2- Dùng câu lệnh LINQ, rất gọn. Sẽ trình bày ở chương sau.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Sắp theo mã (code) tăng dần
            SortedDictionary<string, sv> student = new SortedDictionary<string, sv>();
            XDocument xdoc = XDocument.Load(path);

            // Lấy tất cả thẻ student
            var list = xdoc.Descendants("student");
            foreach (XElement el in list)
            {
                string code = (string)el.Attribute("code");
                string name = (string)el.Attribute("name");
                string group = (string)el.Attribute("class");
                string address = (string)el.Attribute("address");

                // tránh lỗi nếu có mã trùng — có thể kiểm tra trước khi Add
                if (!student.ContainsKey(code))
                {
                    sv s = new sv { name = name, group = group, address = address };
                    student.Add(code, s);
                }
            }

            // Tạo document mới (dùng root "ute" để giữ như ban đầu)
            XDocument doc = new XDocument(new XElement("ute"));

            foreach (var p in student)
            {
                XElement node = new XElement("student",
                    new XAttribute("code", p.Key),
                    new XAttribute("name", p.Value.name),
                    new XAttribute("class", p.Value.group),
                    new XAttribute("address", p.Value.address)
                );
                doc.Root.Add(node);
            }

            // Lưu lại file (ghi đè)
            doc.Save(path);

            // Cập nhật giao diện
            initGrid(gr);
            grid2textbox(0);
        }

        private void dgvStudents_CellContentClick(object sender,
                     DataGridViewCellEventArgs e)
        {
            this.txtCode.Text =
                 this.dgvStudents.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text =
                 this.dgvStudents.CurrentRow.Cells[1].Value.ToString();
            this.txtClass.Text =
                 this.dgvStudents.CurrentRow.Cells[2].Value.ToString();
            this.txtAddress.Text =
                 this.dgvStudents.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr = this.cboClass.Text;
            initGrid(gr);
            grid2textbox(0);
        }

    }
}


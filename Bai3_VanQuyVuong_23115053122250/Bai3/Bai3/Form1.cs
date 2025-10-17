using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Bai3
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        string path = "student.xml";

        public Form1()
        {
            InitializeComponent();
            Connect();
        }

        private void Connect()
        {
            string strCon = "Server=QUY-VUONG-1605\\SQLEXPRESS;Database=VanQuyVuong;Integrated Security=True;";
            con = new SqlConnection(strCon);
        }

        // Load dữ liệu SQL -> dgvRDB

        // Xuất XML cách 1 (DataSet.WriteXml)

        // Xuất XML cách 2 (FOR XML)


        // Xem XML trong Explorer


        private void ViewXML(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File XML chưa tồn tại!");
                return;
            }

            var fullpath = Path.GetFullPath(filePath);
            string url = "file:///" + fullpath.Replace("\\", "/");

            try
            {
                // Mở trực tiếp bằng Edge
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "msedge.exe",   // hoặc "chrome.exe"
                    Arguments = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được bằng trình duyệt: " + ex.Message);
            }
        }





        private void LoadXmlToGrid(string xmlPath)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(xmlPath);
                if (ds.Tables.Count > 0)
                {
                    dgvXML.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc XML: " + ex.Message);
            }
        }

        private void lklRDB2GRID_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM student";
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
                dgvRDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void lkl3XML_1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM student";
                DataTable dt = new DataTable("student");
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
                DataSet ds = new DataSet("ute");
                ds.Tables.Add(dt.Copy());
                ds.WriteXml(path, XmlWriteMode.WriteSchema);

                LoadXmlToGrid(path);
                ViewXML(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất XML (Cách 1): " + ex.Message);
            }
        }

        private void lkl3XML_2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM student FOR XML AUTO, ROOT('ute')";
                string xml = "";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (XmlReader xr = cmd.ExecuteXmlReader())
                    {
                        xr.MoveToContent();
                        xml = xr.ReadOuterXml();
                    }
                    con.Close();
                }

                File.WriteAllText(path, xml);
                LoadXmlToGrid(path);
                ViewXML(path);
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Lỗi xuất XML (Cách 2): " + ex.Message);
            }
        }

        private void lklViewXML_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewXML(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {

                DataSet ds = new DataSet();
                System.IO.FileStream fsReadXML = new System.IO.FileStream(FilePath, System.IO.FileMode.Open);
                ds.ReadXml(fsReadXML);
                DataView dv = new DataView(ds.Tables[0]);
                dt = dv.Table;
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }

            return dt;
        }
        public void InsertOrUpDateSQL(string sql)
        {
            Connect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + tenBang + ".xml";
            DataTable table = HienThi(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                InsertOrUpDateSQL(sql);
            }
        }
       

        private void lklxml2sqlserver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Xóa từng bảng dữ liệu
                InsertOrUpDateSQL("delete from student");
                //InsertOrUpDateSQL("delete from users");
                //Cập nhập toàn bộ dữ liệu các bảng
                CapNhapTungBang("student");
                //CapNhapTungBang("users");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}

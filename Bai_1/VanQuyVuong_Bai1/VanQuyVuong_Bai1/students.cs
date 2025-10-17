using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace VanQuyVuong_Bai1
{
    public partial class students : Form
    {
        string path = "sinhvien.xml";
        DataSet ds = new DataSet();
        public students()
        {
            InitializeComponent();
        }

        private void students_Load(object sender, EventArgs e)
        {
            
                if (System.IO.File.Exists(path))
                {
                    ds.ReadXml(path);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    ds.Tables.Add("SV");
                    ds.Tables["SV"].Columns.Add("Code");
                    ds.Tables["SV"].Columns.Add("Name");
                    ds.Tables["SV"].Columns.Add("Class");
                }
            }

            private void btnInsert_Click(object sender, EventArgs e)
            {
                DataRow row = ds.Tables["SV"].NewRow();
                row["Code"] = textBox1.Text;
                row["Name"] = textBox2.Text;
                row["Class"] = textBox3.Text;
                ds.Tables["SV"].Rows.Add(row);
                ds.WriteXml(path);
                dataGridView1.DataSource = ds.Tables[0];
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                foreach (DataRow row in ds.Tables["SV"].Rows)
                {
                    if (row["Code"].ToString() == textBox1.Text)
                    {
                        row["Name"] = textBox2.Text;
                        row["Class"] = textBox3.Text;
                        break;
                    }
                }
                ds.WriteXml(path);
                dataGridView1.DataSource = ds.Tables[0];
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < ds.Tables["SV"].Rows.Count; i++)
                {
                    if (ds.Tables["SV"].Rows[i]["Code"].ToString() == textBox1.Text)
                    {
                        ds.Tables["SV"].Rows[i].Delete();
                        break;
                    }
                }
                ds.WriteXml(path);
                dataGridView1.DataSource = ds.Tables[0];
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanQuyVuong_Bai1
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            
                students sv = new students();
                sv.Show();
            }

            private void linkBangDiemHocPhan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                MessageBox.Show("Chức năng Bảng điểm học phần đang phát triển...");
            }

            private void linkBangDiemSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                MessageBox.Show("Chức năng Bảng điểm sinh viên đang phát triển...");
            }
        }
    }


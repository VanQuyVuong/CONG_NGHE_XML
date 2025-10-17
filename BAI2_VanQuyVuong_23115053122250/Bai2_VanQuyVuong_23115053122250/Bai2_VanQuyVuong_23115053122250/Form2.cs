using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_VanQuyVuong_23115053122250
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        
            llb1.LinkClicked += linkLabel_LinkClicked;
            llb2.LinkClicked += linkLabel2_LinkClicked;
            llb3.LinkClicked += linkLabel3_LinkClicked;
            bt2.Click += button1_Click;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "DashBoard";
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

        

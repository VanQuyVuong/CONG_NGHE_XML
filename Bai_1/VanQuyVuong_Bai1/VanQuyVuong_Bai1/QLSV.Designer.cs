namespace VanQuyVuong_Bai1
{
    partial class QLSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumOrchid;
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Symbol", 10.2F);
            linkLabel1.Location = new Point(351, 128);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 23);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Danh sách sinh viên ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Symbol", 10.2F);
            linkLabel2.Location = new Point(351, 189);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(167, 23);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Bảng điểm học phấn";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI Symbol", 10.2F);
            linkLabel3.Location = new Point(351, 258);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(163, 23);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Bảng điểm sinh viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_QLSV;
            pictureBox1.Location = new Point(29, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 10.2F);
            button1.ForeColor = Color.MediumOrchid;
            button1.Location = new Point(495, 322);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 379);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "QLSV";
            Text = "QLSV";
            Load += QLSV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
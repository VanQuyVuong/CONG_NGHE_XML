namespace Bai2_VanQuyVuong_23115053122250
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.llb1 = new System.Windows.Forms.LinkLabel();
            this.llb2 = new System.Windows.Forms.LinkLabel();
            this.llb3 = new System.Windows.Forms.LinkLabel();
            this.bt2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // llb1
            // 
            this.llb1.AutoSize = true;
            this.llb1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.llb1.ForeColor = System.Drawing.Color.Blue;
            this.llb1.Location = new System.Drawing.Point(197, 88);
            this.llb1.Name = "llb1";
            this.llb1.Size = new System.Drawing.Size(167, 22);
            this.llb1.TabIndex = 1;
            this.llb1.TabStop = true;
            this.llb1.Text = "Danh sách sinh viên";
            // 
            // llb2
            // 
            this.llb2.AutoSize = true;
            this.llb2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.llb2.ForeColor = System.Drawing.Color.Blue;
            this.llb2.Location = new System.Drawing.Point(197, 135);
            this.llb2.Name = "llb2";
            this.llb2.Size = new System.Drawing.Size(210, 22);
            this.llb2.TabIndex = 2;
            this.llb2.TabStop = true;
            this.llb2.Text = "Danh sách điểm học phần";
            // 
            // llb3
            // 
            this.llb3.AutoSize = true;
            this.llb3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.llb3.ForeColor = System.Drawing.Color.Blue;
            this.llb3.Location = new System.Drawing.Point(197, 175);
            this.llb3.Name = "llb3";
            this.llb3.Size = new System.Drawing.Size(216, 22);
            this.llb3.TabIndex = 3;
            this.llb3.TabStop = true;
            this.llb3.Text = "Danh sách điểm sinh viên ";
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bt2.ForeColor = System.Drawing.Color.Blue;
            this.bt2.Location = new System.Drawing.Point(320, 234);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(104, 48);
            this.bt2.TabIndex = 4;
            this.bt2.Text = "Close";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bai2_VanQuyVuong_23115053122250.Properties.Resources.img_QLSV;
            this.pictureBox2.Location = new System.Drawing.Point(31, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(454, 307);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.llb3);
            this.Controls.Add(this.llb2);
            this.Controls.Add(this.llb1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llb1;
        private System.Windows.Forms.LinkLabel llb2;
        private System.Windows.Forms.LinkLabel llb3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
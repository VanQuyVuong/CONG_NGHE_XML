using System;

namespace BAI6_VANQUYVUONG
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.cboCCode = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCCode = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCustomerToolStripMenuItem,
            this.listItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listCustomerToolStripMenuItem
            // 
            this.listCustomerToolStripMenuItem.Name = "listCustomerToolStripMenuItem";
            this.listCustomerToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.listCustomerToolStripMenuItem.Text = "List Customer";
            this.listCustomerToolStripMenuItem.Click += new System.EventHandler(this.listCustomerToolStripMenuItem_Click);
            // 
            // listItemsToolStripMenuItem
            // 
            this.listItemsToolStripMenuItem.Name = "listItemsToolStripMenuItem";
            this.listItemsToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.listItemsToolStripMenuItem.Text = "List Iterms";
            this.listItemsToolStripMenuItem.Click += new System.EventHandler(this.listItemsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDER";
            // 
            // cboOrder
            // 
            this.cboOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrder.FormattingEnabled = true;
            this.cboOrder.Location = new System.Drawing.Point(142, 123);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(164, 30);
            this.cboOrder.TabIndex = 2;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged_1);
            // 
            // cboCCode
            // 
            this.cboCCode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboCCode.FormattingEnabled = true;
            this.cboCCode.Location = new System.Drawing.Point(439, 123);
            this.cboCCode.Name = "cboCCode";
            this.cboCCode.Size = new System.Drawing.Size(166, 30);
            this.cboCCode.TabIndex = 3;
            this.cboCCode.SelectedIndexChanged += new System.EventHandler(this.cboCCode_SelectedIndexChanged_1);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(40, 126);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(92, 23);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "OrderNO";
            this.lblOrder.Click += new System.EventHandler(this.lblOrder_Click);
            // 
            // lblCCode
            // 
            this.lblCCode.AutoSize = true;
            this.lblCCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCode.ForeColor = System.Drawing.Color.White;
            this.lblCCode.Location = new System.Drawing.Point(350, 126);
            this.lblCCode.Name = "lblCCode";
            this.lblCCode.Size = new System.Drawing.Size(73, 23);
            this.lblCCode.TabIndex = 5;
            this.lblCCode.Text = "C Code";
            this.lblCCode.Click += new System.EventHandler(this.lblCCode_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(660, 130);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 23);
            this.lblCustomer.TabIndex = 6;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(24, 161);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(776, 267);
            this.dgvData.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(40, 431);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(170, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Tổng : 0 triệu đồng";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BAI6_VANQUYVUONG.Properties.Resources.hehehehe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblCCode);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.cboCCode);
            this.Controls.Add(this.cboOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listItemsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrder;
        private System.Windows.Forms.ComboBox cboCCode;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCCode;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblTotal;
    }
}


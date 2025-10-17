namespace Bai3
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
            this.dgvRDB = new System.Windows.Forms.DataGridView();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            this.lklRDB2GRID = new System.Windows.Forms.LinkLabel();
            this.lkl3XML_1 = new System.Windows.Forms.LinkLabel();
            this.lkl3XML_2 = new System.Windows.Forms.LinkLabel();
            this.lklViewXML = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lklxml2sqlserver = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRDB
            // 
            this.dgvRDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRDB.Location = new System.Drawing.Point(50, 97);
            this.dgvRDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRDB.Name = "dgvRDB";
            this.dgvRDB.RowHeadersWidth = 51;
            this.dgvRDB.RowTemplate.Height = 24;
            this.dgvRDB.Size = new System.Drawing.Size(523, 122);
            this.dgvRDB.TabIndex = 0;
            // 
            // dgvXML
            // 
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXML.Location = new System.Drawing.Point(50, 266);
            this.dgvXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.RowHeadersWidth = 51;
            this.dgvXML.RowTemplate.Height = 24;
            this.dgvXML.Size = new System.Drawing.Size(523, 116);
            this.dgvXML.TabIndex = 1;
            // 
            // lklRDB2GRID
            // 
            this.lklRDB2GRID.AutoSize = true;
            this.lklRDB2GRID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lklRDB2GRID.Location = new System.Drawing.Point(48, 73);
            this.lklRDB2GRID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklRDB2GRID.Name = "lklRDB2GRID";
            this.lklRDB2GRID.Size = new System.Drawing.Size(150, 19);
            this.lklRDB2GRID.TabIndex = 2;
            this.lklRDB2GRID.TabStop = true;
            this.lklRDB2GRID.Text = "SQL SEVER TO Grid ";
            this.lklRDB2GRID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRDB2GRID_LinkClicked_1);
            // 
            // lkl3XML_1
            // 
            this.lkl3XML_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkl3XML_1.AutoSize = true;
            this.lkl3XML_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl3XML_1.Location = new System.Drawing.Point(47, 240);
            this.lkl3XML_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lkl3XML_1.Name = "lkl3XML_1";
            this.lkl3XML_1.Size = new System.Drawing.Size(132, 19);
            this.lkl3XML_1.TabIndex = 3;
            this.lkl3XML_1.TabStop = true;
            this.lkl3XML_1.Text = "1-RBD 2 TO XML ";
            this.lkl3XML_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl3XML_1_LinkClicked_1);
            // 
            // lkl3XML_2
            // 
            this.lkl3XML_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkl3XML_2.AutoSize = true;
            this.lkl3XML_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl3XML_2.Location = new System.Drawing.Point(208, 240);
            this.lkl3XML_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lkl3XML_2.Name = "lkl3XML_2";
            this.lkl3XML_2.Size = new System.Drawing.Size(129, 19);
            this.lkl3XML_2.TabIndex = 4;
            this.lkl3XML_2.TabStop = true;
            this.lkl3XML_2.Text = "2-RBD 2 TO XML";
            this.lkl3XML_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl3XML_2_LinkClicked_1);
            // 
            // lklViewXML
            // 
            this.lklViewXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lklViewXML.AutoSize = true;
            this.lklViewXML.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklViewXML.Location = new System.Drawing.Point(380, 240);
            this.lklViewXML.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklViewXML.Name = "lklViewXML";
            this.lklViewXML.Size = new System.Drawing.Size(209, 19);
            this.lklViewXML.TabIndex = 5;
            this.lklViewXML.TabStop = true;
            this.lklViewXML.Text = "VIEW RESULT IN BROWSER";
            this.lklViewXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklViewXML_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONVERT RDB DATA TO XML ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Using ADO.NET and Statement SELECT FROM XML AUTO [,ELEMENT]";
            // 
            // lklxml2sqlserver
            // 
            this.lklxml2sqlserver.AutoSize = true;
            this.lklxml2sqlserver.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lklxml2sqlserver.Location = new System.Drawing.Point(421, 73);
            this.lklxml2sqlserver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklxml2sqlserver.Name = "lklxml2sqlserver";
            this.lklxml2sqlserver.Size = new System.Drawing.Size(152, 19);
            this.lklxml2sqlserver.TabIndex = 8;
            this.lklxml2sqlserver.TabStop = true;
            this.lklxml2sqlserver.Text = "XML TO SQL SEVER";
            this.lklxml2sqlserver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklxml2sqlserver_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 410);
            this.Controls.Add(this.lklxml2sqlserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklViewXML);
            this.Controls.Add(this.lkl3XML_2);
            this.Controls.Add(this.lkl3XML_1);
            this.Controls.Add(this.lklRDB2GRID);
            this.Controls.Add(this.dgvXML);
            this.Controls.Add(this.dgvRDB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRDB;
        private System.Windows.Forms.DataGridView dgvXML;
        private System.Windows.Forms.LinkLabel lklRDB2GRID;
        private System.Windows.Forms.LinkLabel lkl3XML_1;
        private System.Windows.Forms.LinkLabel lkl3XML_2;
        private System.Windows.Forms.LinkLabel lklViewXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lklxml2sqlserver;
    }
}


using System;

namespace Tuan5_QuyVuong
{
    partial class StudentManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASIC OF XDOCUMENT CLASS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCode.Location = new System.Drawing.Point(134, 88);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(144, 30);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.Location = new System.Drawing.Point(134, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(406, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtClass.Location = new System.Drawing.Point(134, 185);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(144, 30);
            this.txtClass.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtAddress.Location = new System.Drawing.Point(134, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(406, 30);
            this.txtAddress.TabIndex = 4;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(644, 92);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(176, 24);
            this.cboClass.TabIndex = 5;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(673, 139);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(147, 36);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSort.Location = new System.Drawing.Point(673, 181);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(147, 36);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort by Code";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnNew.Location = new System.Drawing.Point(673, 226);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(147, 36);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(673, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDelete.Location = new System.Drawing.Point(673, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.Blue;
            this.btnNext.Location = new System.Drawing.Point(673, 351);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 36);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnPre.ForeColor = System.Drawing.Color.Blue;
            this.btnPre.Location = new System.Drawing.Point(673, 394);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(147, 36);
            this.btnPre.TabIndex = 12;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnQuit.ForeColor = System.Drawing.Color.Crimson;
            this.btnQuit.Location = new System.Drawing.Point(673, 433);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(147, 36);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "QuIt";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(16, 287);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(604, 224);
            this.dgvStudents.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Student Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(560, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Class";
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 574);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "StudentManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


﻿namespace WinForms.Forms
{
    partial class frmLopHoc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaTKB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaCS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenLoptt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLoptt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLoptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1265, 618);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtMaTKB);
            this.groupBox1.Controls.Add(this.txtMaCS);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.txtTenLoptt);
            this.groupBox1.Controls.Add(this.txtMaLoptt);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học trung tâm";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(278, 426);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.TabIndex = 15;
            this.buttonX3.Text = "Xóa";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(143, 426);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.TabIndex = 14;
            this.buttonX2.Text = "Sửa";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(29, 319);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Mã TKB";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(29, 256);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Mã Cơ Sở";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(29, 194);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Mã Giáo Viên";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(29, 133);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Tên Lớp TT";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(29, 68);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Mã Lớp TT";
            // 
            // txtMaTKB
            // 
            // 
            // 
            // 
            this.txtMaTKB.Border.Class = "TextBoxBorder";
            this.txtMaTKB.Location = new System.Drawing.Point(129, 322);
            this.txtMaTKB.Name = "txtMaTKB";
            this.txtMaTKB.Size = new System.Drawing.Size(202, 21);
            this.txtMaTKB.TabIndex = 7;
            // 
            // txtMaCS
            // 
            // 
            // 
            // 
            this.txtMaCS.Border.Class = "TextBoxBorder";
            this.txtMaCS.Location = new System.Drawing.Point(129, 259);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(202, 21);
            this.txtMaCS.TabIndex = 6;
            // 
            // txtMaGV
            // 
            // 
            // 
            // 
            this.txtMaGV.Border.Class = "TextBoxBorder";
            this.txtMaGV.Location = new System.Drawing.Point(129, 197);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(202, 21);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtTenLoptt
            // 
            // 
            // 
            // 
            this.txtTenLoptt.Border.Class = "TextBoxBorder";
            this.txtTenLoptt.Location = new System.Drawing.Point(129, 133);
            this.txtTenLoptt.Name = "txtTenLoptt";
            this.txtTenLoptt.Size = new System.Drawing.Size(202, 21);
            this.txtTenLoptt.TabIndex = 1;
            // 
            // txtMaLoptt
            // 
            // 
            // 
            // 
            this.txtMaLoptt.Border.Class = "TextBoxBorder";
            this.txtMaLoptt.Location = new System.Drawing.Point(129, 68);
            this.txtMaLoptt.Name = "txtMaLoptt";
            this.txtMaLoptt.Size = new System.Drawing.Size(202, 21);
            this.txtMaLoptt.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonX4);
            this.splitContainer2.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer2.Panel1.Controls.Add(this.labelX6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(840, 618);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(363, 99);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "Tìm Kiếm";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(332, 53);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(357, 21);
            this.txtTimKiem.TabIndex = 2;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(88, 50);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(174, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Nhập thông tin tìm kiếm(Tên Lớp)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoptt,
            this.TenLoptt,
            this.MaGV,
            this.MaCS,
            this.MaTKB});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaLoptt
            // 
            this.MaLoptt.DataPropertyName = "MaLoptt";
            this.MaLoptt.HeaderText = "Mã Lớp TT";
            this.MaLoptt.Name = "MaLoptt";
            this.MaLoptt.Width = 150;
            // 
            // TenLoptt
            // 
            this.TenLoptt.DataPropertyName = "TenLoptt";
            this.TenLoptt.HeaderText = "Tên Lớp TT";
            this.TenLoptt.Name = "TenLoptt";
            this.TenLoptt.Width = 150;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 150;
            // 
            // MaCS
            // 
            this.MaCS.DataPropertyName = "MaCS";
            this.MaCS.HeaderText = "Mã Cơ Sở";
            this.MaCS.Name = "MaCS";
            this.MaCS.Width = 150;
            // 
            // MaTKB
            // 
            this.MaTKB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTKB.DataPropertyName = "MaTKB";
            this.MaTKB.HeaderText = "Mã TKB";
            this.MaTKB.Name = "MaTKB";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(29, 426);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 16;
            this.buttonX1.Text = "Thêm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 618);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLopHoc";
            this.Text = "frmLopHoc";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaTKB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaCS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoptt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoptt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoptt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoptt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKB;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}
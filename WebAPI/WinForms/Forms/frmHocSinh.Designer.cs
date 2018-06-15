namespace WinForms.Forms
{
    partial class frmHocSinh
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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.txtMaHS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLtt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX3);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 574);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(22, 435);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Text = "Thêm";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(45, 207);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Lớp";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(45, 138);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên HS";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(45, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã HS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX4);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.txtTenHS);
            this.groupBox1.Controls.Add(this.txtL);
            this.groupBox1.Controls.Add(this.txtLtt);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txtTruong);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 570);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(145, 431);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.TabIndex = 10;
            this.buttonX3.Text = "Sửa";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click_1);
            // 
            // txtMaHS
            // 
            // 
            // 
            // 
            this.txtMaHS.Border.Class = "TextBoxBorder";
            this.txtMaHS.Location = new System.Drawing.Point(145, 66);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(182, 21);
            this.txtMaHS.TabIndex = 5;
            // 
            // txtTenHS
            // 
            // 
            // 
            // 
            this.txtTenHS.Border.Class = "TextBoxBorder";
            this.txtTenHS.Location = new System.Drawing.Point(145, 137);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(182, 21);
            this.txtTenHS.TabIndex = 6;
            // 
            // txtL
            // 
            // 
            // 
            // 
            this.txtL.Border.Class = "TextBoxBorder";
            this.txtL.Location = new System.Drawing.Point(145, 206);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(182, 21);
            this.txtL.TabIndex = 7;
            // 
            // txtLtt
            // 
            // 
            // 
            // 
            this.txtLtt.Border.Class = "TextBoxBorder";
            this.txtLtt.Location = new System.Drawing.Point(145, 340);
            this.txtLtt.Name = "txtLtt";
            this.txtLtt.Size = new System.Drawing.Size(182, 21);
            this.txtLtt.TabIndex = 9;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(41, 272);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Trường";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(41, 337);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Lớp TT";
            // 
            // txtTruong
            // 
            // 
            // 
            // 
            this.txtTruong.Border.Class = "TextBoxBorder";
            this.txtTruong.Location = new System.Drawing.Point(145, 272);
            this.txtTruong.Name = "txtTruong";
            this.txtTruong.Size = new System.Drawing.Size(182, 21);
            this.txtTruong.TabIndex = 8;
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
            this.splitContainer2.Panel1.Controls.Add(this.buttonX1);
            this.splitContainer2.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer2.Panel1.Controls.Add(this.labelX6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(747, 574);
            this.splitContainer2.SplitterDistance = 147;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(314, 100);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Tìm kiếm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(258, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(338, 21);
            this.txtTimKiem.TabIndex = 1;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(47, 58);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(169, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Nhập thông tin tìm kiếm(Tên HS)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.TenHS,
            this.Lop,
            this.Truong,
            this.Loptt});
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã HS";
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 120;
            // 
            // TenHS
            // 
            this.TenHS.DataPropertyName = "TenHS";
            this.TenHS.HeaderText = "Tên HS";
            this.TenHS.Name = "TenHS";
            this.TenHS.Width = 120;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.Width = 120;
            // 
            // Truong
            // 
            this.Truong.DataPropertyName = "Truong";
            this.Truong.HeaderText = "Trường";
            this.Truong.Name = "Truong";
            this.Truong.Width = 120;
            // 
            // Loptt
            // 
            this.Loptt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loptt.DataPropertyName = "Loptt";
            this.Loptt.HeaderText = "Lớp TT";
            this.Loptt.Name = "Loptt";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(272, 431);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.TabIndex = 11;
            this.buttonX4.Text = "Xóa";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 574);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHocSinh";
            this.Text = "frmHocSinh";
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
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLtt;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTruong;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loptt;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
    }
}
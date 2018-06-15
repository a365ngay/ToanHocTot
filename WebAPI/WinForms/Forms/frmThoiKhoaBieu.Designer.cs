namespace WinForms.Forms
{
    partial class frmThoiKhoaBieu
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
            this.txtTGH = new System.Windows.Forms.ComboBox();
            this.txtNH = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaTKB = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTGH = new System.Windows.Forms.ComboBox();
            this.cbNH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaTKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Size = new System.Drawing.Size(1165, 548);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTGH);
            this.groupBox1.Controls.Add(this.txtNH);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtMaTKB);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 548);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thơi Khóa Biểu";
            // 
            // txtTGH
            // 
            this.txtTGH.FormattingEnabled = true;
            this.txtTGH.Items.AddRange(new object[] {
            "18h-19h30",
            "19h45-21h15"});
            this.txtTGH.Location = new System.Drawing.Point(103, 192);
            this.txtTGH.Name = "txtTGH";
            this.txtTGH.Size = new System.Drawing.Size(238, 21);
            this.txtTGH.TabIndex = 8;
            this.txtTGH.Text = "18h-19h30";
            // 
            // txtNH
            // 
            this.txtNH.FormattingEnabled = true;
            this.txtNH.Items.AddRange(new object[] {
            "Thứ 2, Thứ 4",
            "Thứ 2, Thứ 5",
            "Thứ 2, Thứ 6",
            "Thứ 2, Thứ 7",
            "Thứ 3, Thứ 5",
            "Thứ 3, Thứ 6",
            "Thứ 3, Thứ 7",
            "Thứ 3, Chủ Nhật",
            "Thứ 4, Thứ 6",
            "Thứ 4, Thứ 7",
            "Thứ 4, Chủ Nhật",
            "Thứ 5, Thứ 7",
            "Thứ 5, Chủ Nhật",
            "Thứ 6, Chủ Nhật"});
            this.txtNH.Location = new System.Drawing.Point(103, 130);
            this.txtNH.Name = "txtNH";
            this.txtNH.Size = new System.Drawing.Size(238, 21);
            this.txtNH.TabIndex = 7;
            this.txtNH.Text = "Thứ 2, Thứ 4";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 308);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã TKB";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(144, 308);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaTKB
            // 
            this.txtMaTKB.Location = new System.Drawing.Point(103, 57);
            this.txtMaTKB.Name = "txtMaTKB";
            this.txtMaTKB.Size = new System.Drawing.Size(238, 21);
            this.txtMaTKB.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời Gian Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Học";
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
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.cbTGH);
            this.splitContainer2.Panel1.Controls.Add(this.cbNH);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(794, 548);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày học";
            // 
            // cbTGH
            // 
            this.cbTGH.FormattingEnabled = true;
            this.cbTGH.Items.AddRange(new object[] {
            "(none)",
            "18h-19h30",
            "19h45-21h15"});
            this.cbTGH.Location = new System.Drawing.Point(445, 33);
            this.cbTGH.Name = "cbTGH";
            this.cbTGH.Size = new System.Drawing.Size(121, 21);
            this.cbTGH.TabIndex = 2;
            this.cbTGH.Text = "(none)";
            // 
            // cbNH
            // 
            this.cbNH.FormattingEnabled = true;
            this.cbNH.Items.AddRange(new object[] {
            "(none)",
            "Thứ 2, Thứ 4",
            "Thứ 2, Thứ 5",
            "Thứ 2, Thứ 6",
            "Thứ 2, Thứ 7",
            "Thứ 3, Thứ 5",
            "Thứ 3, Thứ 6",
            "Thứ 3, Thứ 7",
            "Thứ 3, Chủ Nhật",
            "Thứ 4, Thứ 6",
            "Thứ 4, Thứ 7",
            "Thứ 4, Chủ Nhật",
            "Thứ 5, Thứ 7",
            "Thứ 5, Chủ Nhật",
            "Thứ 6, Chủ Nhật"});
            this.cbNH.Location = new System.Drawing.Point(100, 33);
            this.cbNH.Name = "cbNH";
            this.cbNH.Size = new System.Drawing.Size(121, 21);
            this.cbNH.TabIndex = 1;
            this.cbNH.Text = "(none)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTKB,
            this.NgayHoc,
            this.ThoiGianHoc});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaTKB
            // 
            this.MaTKB.DataPropertyName = "MaTKB";
            this.MaTKB.HeaderText = "Mã TKB";
            this.MaTKB.Name = "MaTKB";
            this.MaTKB.Width = 200;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày Học";
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 200;
            // 
            // ThoiGianHoc
            // 
            this.ThoiGianHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGianHoc.DataPropertyName = "ThoiGianHoc";
            this.ThoiGianHoc.HeaderText = "Thời Gian Học";
            this.ThoiGianHoc.Name = "ThoiGianHoc";
            // 
            // frmThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThoiKhoaBieu";
            this.Text = "frmThoiKhoaBieu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaTKB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianHoc;
        private System.Windows.Forms.ComboBox txtTGH;
        private System.Windows.Forms.ComboBox txtNH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTGH;
        private System.Windows.Forms.ComboBox cbNH;
    }
}
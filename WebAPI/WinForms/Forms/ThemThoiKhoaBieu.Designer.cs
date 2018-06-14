namespace WinForms.Forms
{
    partial class ThemThoiKhoaBieu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTGH = new System.Windows.Forms.ComboBox();
            this.txtNH = new System.Windows.Forms.ComboBox();
            this.txtMaTKB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTGH);
            this.groupBox1.Controls.Add(this.txtNH);
            this.groupBox1.Controls.Add(this.txtMaTKB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm thông tin";
            // 
            // txtTGH
            // 
            this.txtTGH.FormattingEnabled = true;
            this.txtTGH.Items.AddRange(new object[] {
            "18h-19h30",
            "19h45-21h15"});
            this.txtTGH.Location = new System.Drawing.Point(111, 190);
            this.txtTGH.Name = "txtTGH";
            this.txtTGH.Size = new System.Drawing.Size(180, 21);
            this.txtTGH.TabIndex = 10;
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
            this.txtNH.Location = new System.Drawing.Point(111, 128);
            this.txtNH.Name = "txtNH";
            this.txtNH.Size = new System.Drawing.Size(180, 21);
            this.txtNH.TabIndex = 9;
            this.txtNH.Text = "Thứ 2, Thứ 4";
            // 
            // txtMaTKB
            // 
            this.txtMaTKB.Enabled = false;
            this.txtMaTKB.Location = new System.Drawing.Point(111, 62);
            this.txtMaTKB.Name = "txtMaTKB";
            this.txtMaTKB.Size = new System.Drawing.Size(180, 21);
            this.txtMaTKB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời Gian Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TKB";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(148, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(294, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ThemThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemThoiKhoaBieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới thời khóa biểu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaTKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox txtTGH;
        private System.Windows.Forms.ComboBox txtNH;
    }
}
namespace WinForms.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnTKB = new DevComponents.DotNetBar.ButtonX();
            this.btnCoSo = new DevComponents.DotNetBar.ButtonX();
            this.btnLopHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImage = global::WinForms.Properties.Resources._38;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1345, 411);
            this.splitContainer1.SplitterDistance = 902;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer2.Panel1.Controls.Add(this.labelX7);
            this.splitContainer2.Panel1.Controls.Add(this.labelX6);
            this.splitContainer2.Panel1.Controls.Add(this.buttonX2);
            this.splitContainer2.Panel1.Controls.Add(this.buttonX1);
            this.splitContainer2.Panel1.Controls.Add(this.labelX4);
            this.splitContainer2.Panel1.Controls.Add(this.labelX3);
            this.splitContainer2.Panel1.Controls.Add(this.labelX2);
            this.splitContainer2.Panel1.Controls.Add(this.labelX1);
            this.splitContainer2.Panel1.Controls.Add(this.btnTKB);
            this.splitContainer2.Panel1.Controls.Add(this.btnCoSo);
            this.splitContainer2.Panel1.Controls.Add(this.btnLopHoc);
            this.splitContainer2.Panel1.Controls.Add(this.btnThanhToan);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelX5);
            this.splitContainer2.Size = new System.Drawing.Size(439, 411);
            this.splitContainer2.SplitterDistance = 337;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(188, 299);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(107, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Thời Khóa Biểu";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(60, 299);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Cơ Sở";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(194, 146);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Lớp Học";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(50, 146);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Thanh Toán";
            // 
            // btnTKB
            // 
            this.btnTKB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTKB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTKB.Image = global::WinForms.Properties.Resources._34;
            this.btnTKB.Location = new System.Drawing.Point(194, 192);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(91, 89);
            this.btnTKB.TabIndex = 3;
            // 
            // btnCoSo
            // 
            this.btnCoSo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCoSo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCoSo.Image = global::WinForms.Properties.Resources._37;
            this.btnCoSo.Location = new System.Drawing.Point(49, 192);
            this.btnCoSo.Name = "btnCoSo";
            this.btnCoSo.Size = new System.Drawing.Size(88, 89);
            this.btnCoSo.TabIndex = 2;
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLopHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLopHoc.Image = global::WinForms.Properties.Resources._33;
            this.btnLopHoc.Location = new System.Drawing.Point(194, 34);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(91, 88);
            this.btnLopHoc.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThanhToan.Image = global::WinForms.Properties.Resources._39;
            this.btnThanhToan.Location = new System.Drawing.Point(50, 34);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(87, 88);
            this.btnThanhToan.TabIndex = 0;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(98, 22);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(288, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Trung Tâm Toán Học Tốt";
            this.labelX5.Click += new System.EventHandler(this.labelX5_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::WinForms.Properties.Resources._36;
            this.buttonX1.Location = new System.Drawing.Point(321, 34);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(94, 88);
            this.buttonX1.TabIndex = 8;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::WinForms.Properties.Resources._35;
            this.buttonX2.Location = new System.Drawing.Point(321, 192);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(94, 89);
            this.buttonX2.TabIndex = 9;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(330, 146);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Điểm Danh";
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(340, 299);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Điểm";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnTKB;
        private DevComponents.DotNetBar.ButtonX btnCoSo;
        private DevComponents.DotNetBar.ButtonX btnLopHoc;
        private DevComponents.DotNetBar.ButtonX btnThanhToan;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}
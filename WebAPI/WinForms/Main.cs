using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using WinForms.Forms;
using DevExpress.XtraEditors;

namespace WinForms
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            var form = new Home();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            var form = new Home();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show(); 
        }
        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmThoiKhoaBieu();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show(); 

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmCoSo();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show(); 
        }

        private void btnQLCSLH_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmLopHoc();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show(); ;

        }

        private void btnQLHS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmHocSinh();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show(); 
        }

        private void btnQLNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmNhanVien();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmBangDiem();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmPhuHuynh();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmGVDiemDanhHS();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }
    }
}
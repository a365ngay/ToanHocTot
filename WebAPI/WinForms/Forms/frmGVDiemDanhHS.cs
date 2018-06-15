using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinForms.Forms
{
    public partial class frmGVDiemDanhHS : DevExpress.XtraEditors.XtraForm
    {
        public frmGVDiemDanhHS()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var form = new ThemGVDiemDanhHS();
            form.Show();
        }
    }
}
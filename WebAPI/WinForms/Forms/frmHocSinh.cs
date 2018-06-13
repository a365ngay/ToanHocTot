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
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var form = new ThemHocSinh();
            form.Show();
        }
    }
}
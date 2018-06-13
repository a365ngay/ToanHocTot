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
    public partial class frmThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new ThemThoiKhoaBieu();
            form.Show();
        }
    }
}
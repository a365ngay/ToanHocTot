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
    public partial class frmCoSo : DevExpress.XtraEditors.XtraForm
    {
        public frmCoSo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new ThemCoSo();
            form.Show();
        }
    }
}
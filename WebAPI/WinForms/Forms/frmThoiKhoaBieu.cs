using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WebAPIData.DTO;
using WinForms.Forms;

namespace WinForms.Forms
{
    public partial class frmThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
            loadData();
        }
        public string baseAddress = "http://localhost:55137/api/";
        List<ThoiKhoaBieu> listThoiKhoaBieu = null;

        private void loadData()
        {
            listThoiKhoaBieu = loadThoiKhoaBieu();

            dataGridView1.DataSource = listThoiKhoaBieu;
        }
        private List<ThoiKhoaBieu> loadThoiKhoaBieu()
        {
            List<ThoiKhoaBieu> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("thoikhoabieu");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<ThoiKhoaBieu>>();
                    readTask.Wait();

                    list = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThoiKhoaBieu themnv = null;
            Check_Them:
            if (themnv == null || themnv.IsDisposed)
            {
                themnv = new ThemThoiKhoaBieu();
            }
            if (themnv.ShowDialog() == DialogResult.OK)
            {
                if (ThemThoiKhoaBieu.x == 0)
                {
                    goto Check_Them;
                }
            }

            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTKB.Text = dataGridView1.CurrentRow.Cells["MaTKB"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["MaTKB"].Value != null)
            {
                txtMaTKB.Text = dataGridView1.CurrentRow.Cells["MaTKB"].Value.ToString();
            }
            else
            {
                txtMaTKB.Text = "";
            }
            txtNH.Text = dataGridView1.CurrentRow.Cells["NgayHoc"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["NgayHoc"].Value != null)
            {
                txtNH.Text = dataGridView1.CurrentRow.Cells["NgayHoc"].Value.ToString();
            }
            else
            {
                txtNH.Text = "";
            }
            txtTGH.Text = dataGridView1.CurrentRow.Cells["ThoiGianHoc"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["ThoiGianHoc"].Value != null)
            {
                txtTGH.Text = dataGridView1.CurrentRow.Cells["ThoiGianHoc"].Value.ToString();
            }
            else
            {
                txtTGH.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu thoikhoabieu = new ThoiKhoaBieu(txtMaTKB.Text, txtNH.Text, txtTGH.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<ThoiKhoaBieu>("thoikhoabieu", thoikhoabieu);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã sửa thành công");
                }
            }

            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.DeleteAsync("ThoiKhoaBieu/Del/" + txtMaTKB.Text);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string giatri1 = cbNH.Text;
            string giatri2 = cbTGH.Text;
            List<ThoiKhoaBieu> nvFiltermalop = null;

            if (giatri1 != "(none)" && giatri2 == "(none)")
            {
                nvFiltermalop = loadThoiKhoaBieu().Where(x => x.NgayHoc == giatri1).ToList();
            }
            else if (giatri1 == "(none)" && giatri2 != "(none)")
            {
                nvFiltermalop = loadThoiKhoaBieu().Where(x => x.ThoiGianHoc == giatri2).ToList();
            }
            else if (giatri1 == "(none)" && giatri2 == "(none)")
            {
                nvFiltermalop = loadThoiKhoaBieu().ToList();
            }
            else
            {
                nvFiltermalop = loadThoiKhoaBieu().Where(x => x.NgayHoc == giatri1).ToList();
                nvFiltermalop = nvFiltermalop.Where(x => x.ThoiGianHoc == giatri2).ToList();
            }
            dataGridView1.DataSource = nvFiltermalop;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebAPIData.DTO;
using System.Net.Http;
using System.Linq;

namespace WinForms.Forms
{
    public partial class frmCoSo : DevExpress.XtraEditors.XtraForm
    {
        public frmCoSo()
        {
            InitializeComponent();
            loadData();
        }
        public string baseAddress = "http://localhost:55137/api/";
        List<CoSo> listcoso = null;
        private void loadData()
        {
            listcoso = loadCoSo();

            dataGridView1.DataSource = listcoso;
        }
        private List<CoSo> loadCoSo()
        {
            List<CoSo> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("coso");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<CoSo>>();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CoSo> cs = loadCoSo().Where(a => a.TenCS.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.DataSource = cs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCS.Text = dataGridView1.CurrentRow.Cells["MaCS"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenCS"].Value != null)
            {
                txtTenCS.Text = dataGridView1.CurrentRow.Cells["TenCS"].Value.ToString();
            }
            else
            {
                txtTenCS.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["DiaChi"].Value != null)
            {
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
            else
            {
                txtDiaChi.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaNQL"].Value != null)
            {
                txtMaNQL.Text = dataGridView1.CurrentRow.Cells["MaNQL"].Value.ToString();
            }
            else
            {
                txtMaNQL.Text = "";
            }
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ThemCoSo themcs = null;
        Check_Them:
            if (themcs == null || themcs.IsDisposed)
            {
                themcs = new ThemCoSo();
            }
            if (themcs.ShowDialog() == DialogResult.OK)
            {
                if (ThemCoSo.x == 0)
                {
                    goto Check_Them;
                }
            }

            loadData();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            CoSo coso = new CoSo(txtMaCS.Text, txtTenCS.Text, txtDiaChi.Text, txtMaNQL.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<CoSo>("coso", coso);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã sửa thành công");
                }
            }
            loadData();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.DeleteAsync("coso/" + txtMaCS.Text);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            loadData();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebAPIData.DTO;
using System.Net.Http;
using System.Linq;

namespace WinForms.Forms
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmHocSinh()
        {
            InitializeComponent();
            loadData();
        }
        public string baseAddress = "http://localhost:55137/api/";
        List<HocSinh> listhocsinh = null;

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ThemHocSinh themhs = null;
        Check_Them:
            if (themhs == null || themhs.IsDisposed)
            {
                themhs = new ThemHocSinh();
            }
            if (themhs.ShowDialog() == DialogResult.OK)
            {
                if(ThemHocSinh.x == 0)
                {
                    goto Check_Them;
                }
            }

            loadData();
        }

        private void loadData()
        {
            listhocsinh = loadHocSinh();

            dataGridView1.DataSource = listhocsinh;
        }
        private List<HocSinh> loadHocSinh()
        {
            List<HocSinh> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("hocsinh");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<HocSinh>>();
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.DeleteAsync("hocsinh/" + txtMaHS.Text);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            loadData();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            List<HocSinh> hs = loadHocSinh().Where(a => a.TenHS.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.DataSource = hs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = dataGridView1.CurrentRow.Cells["MaHS"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenHS"].Value != null)
            {
                txtTenHS.Text = dataGridView1.CurrentRow.Cells["TenHS"].Value.ToString();
            }
            else
            {
                txtTenHS.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["Lop"].Value != null)
            {
                txtL.Text = dataGridView1.CurrentRow.Cells["Lop"].Value.ToString();
            }
            else
            {
                txtL.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["Truong"].Value != null)
            {
                txtTruong.Text = dataGridView1.CurrentRow.Cells["Truong"].Value.ToString();
            }
            else
            {
                txtTruong.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["Loptt"].Value != null)
            {
                txtLtt.Text = dataGridView1.CurrentRow.Cells["Loptt"].Value.ToString();
            }
            else
            {
                txtLtt.Text = "";
            }
            
        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(txtMaHS.Text, txtTenHS.Text, txtL.Text, txtTruong.Text, txtLtt.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<HocSinh>("hocsinh", hocsinh);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã sửa thành công");
                }

            }
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.DeleteAsync("hocsinh/" + txtMaHS.Text);

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
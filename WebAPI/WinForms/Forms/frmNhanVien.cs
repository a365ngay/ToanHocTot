using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebAPIData.DTO;
using System.Net.Http;
using System.Linq;

namespace WinForms.Forms
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
            loadData();
        }
        public string baseAddress = "http://localhost:55137/api/";
        List<NhanVien> listnhanvien = null;
       


        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ThemNhanVien themnv = null;
        Check_Them:
            if (themnv == null || themnv.IsDisposed)
            {
                themnv = new ThemNhanVien();
            }
            if (themnv.ShowDialog() == DialogResult.OK)
            {
                if (ThemNhanVien.x == 0)
                {
                    goto Check_Them;
                }
            }

            loadData();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            listnhanvien = loadNhanVien();

            dataGridView1.DataSource = listnhanvien;
        }

        private List<NhanVien> loadNhanVien()
        {
            List<NhanVien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("nhanvien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<NhanVien>>();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtGT.Text, txtDC.Text, txtSDT.Text, txtCV.Text, Convert.ToInt32(txtL.Text), txtMaCS.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<NhanVien>("nhanvien", nhanvien);

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
                var postTask = client.DeleteAsync("nhanvien/" + txtMaNV.Text);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            loadData();
        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            List<NhanVien> nv = loadNhanVien().Where(a=>a.TenNV.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.DataSource = nv;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenNV"].Value != null)
            {
                txtTenNV.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            }
            else
            {
                txtTenNV.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value != null)
            {
                txtGT.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            }
            else
            {
                txtGT.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["DiaChi"].Value != null)
            {
                txtDC.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
            else
            {
                txtDC.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["SoDT"].Value != null)
            {
                txtSDT.Text = dataGridView1.CurrentRow.Cells["SoDT"].Value.ToString();
            }
            else
            {
                txtSDT.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["ChucVu"].Value != null)
            {
                txtCV.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            }
            else
            {
                txtCV.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["Luong"].Value != null)
            {
                txtL.Text = dataGridView1.CurrentRow.Cells["Luong"].Value.ToString();
            }
            else
            {
                txtL.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaCS"].Value != null)
            {
                txtMaCS.Text = dataGridView1.CurrentRow.Cells["MaCS"].Value.ToString();
            }
            else
            {
                txtMaCS.Text = "";
            }
        }
    }
}

  
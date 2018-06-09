using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPIData.DTO;
using WinForms.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        public string baseAddress = "http://localhost:55137/api/";
        List<NhanVien> listnhanvien = null;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            if(dataGridView1.CurrentRow.Cells["TenNV"].Value != null)
            {
                txtTennv.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            }
            else
            {
                txtTennv.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value != null)
            {
                txtGt.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            }
            else
            {
                txtGt.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["DiaChi"].Value != null)
            {
                txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
            else
            {
                txtDiachi.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["SoDT"].Value != null)
            {
                txtSoDT.Text = dataGridView1.CurrentRow.Cells["SoDT"].Value.ToString();
            }
            else
            {
                txtSoDT.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["ChucVu"].Value != null)
            {
                txtCv.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            }
            else
            {
                txtCv.Text = "";
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
                txtMacs.Text = dataGridView1.CurrentRow.Cells["MaCS"].Value.ToString();
            }
            else
            {
                txtMacs.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien(txtManv.Text, txtTennv.Text, txtGt.Text, txtDiachi.Text, txtSoDT.Text, txtCv.Text, Convert.ToInt32(txtL.Text), txtMacs.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.DeleteAsync("nhanvien/"+ txtManv.Text);

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
            AddNhanVien add = new AddNhanVien();
            add.Show();
        }
    }
}

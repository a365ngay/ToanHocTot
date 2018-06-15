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
using WebAPIData.DTO;
using WinForms.Forms;
using System.Net.Http;

namespace WinForms.Forms
{
    public partial class ThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public string baseAddress = "http://localhost:55137/api/";
        List<NhanVien> listNhanVien = null;
      
        public ThemNhanVien()
        {
            InitializeComponent();
            //Thêm mã tự động
            int t = 0;
            String maauto = "nv";
            Random rd = new Random();
            int x = rd.Next(0, 1000);
            while (t == 0)
            {
                maauto = maauto + x.ToString();
                List<NhanVien> nv = loadNhanVien().Where(m => m.MaNV == maauto).ToList();
                if (nv.Count() == 0)
                {
                    t = 1;
                }
            }
            txtMaNV.Text = maauto;

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




        

        

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtGT.Text == ""|| txtDC.Text == "" || txtSDT.Text == ""||txtCV.Text== "" || txtL.Text == ""||txtMaCS.Text== "")
         
            {
                if (MessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                x = 0;
            }
            else
            {
                NhanVien nhanvien= new NhanVien(txtMaNV.Text, txtTenNV.Text, txtGT.Text, txtDC.Text, txtSDT.Text,txtCV.Text,Convert.ToInt32(txtL.Text),txtMaCS.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<NhanVien>("nhanvien", nhanvien);

                    postTask.Wait();

                    var result = postTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã thêm thành công");
                    }
                }
                x = 1;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
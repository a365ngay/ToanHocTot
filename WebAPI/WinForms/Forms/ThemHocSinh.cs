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
using System.Net.Http;

namespace WinForms.Forms
{
    public partial class ThemHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public string baseAddress = "http://localhost:55137/api/";
        List<HocSinh> listHocSinh = null;
        public ThemHocSinh()
        {
            InitializeComponent();
           
            //Thêm mã tự động
            int t = 0;
            String maauto = "hs";
            Random rd = new Random();
            int x = rd.Next(0, 1000);
            while (t == 0)
            {
                maauto = maauto + x.ToString();
                List<HocSinh> nv = loadHocSinh().Where(m => m.MaHS == maauto).ToList();
                if (nv.Count() == 0)
                {
                    t = 1;
                }
            }
            txtMaHS.Text = maauto;
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
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "" || txtTenHS.Text == "" || txtL.Text == "" || txtTruong.Text == "" || txtLtt.Text == "")

            {
                if (MessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                x = 0;
            }
            else
            {
                HocSinh hocsinh = new HocSinh(txtMaHS.Text, txtTenHS.Text, txtL.Text, txtTruong.Text, txtLtt.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<HocSinh>("hocsinh", hocsinh);

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
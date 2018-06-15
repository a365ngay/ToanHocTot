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
    public partial class ThemCoSo : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public string baseAddress = "http://localhost:55137/api/";
        List<CoSo> listCoSo = null;
        public ThemCoSo()
        {
            InitializeComponent();
            //Thêm mã tự động
            int t = 0;
            String maauto = "cs";
            Random rd = new Random();
            int x = rd.Next(0, 1000);
            while (t == 0)
            {
                maauto = maauto + x.ToString();
                List<CoSo> nv = loadCoSo().Where(m => m.MaCS == maauto).ToList();
                if (nv.Count() == 0)
                {
                    t = 1;
                }
            }
            txtMaCS.Text = maauto;
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtMaCS.Text == "" || txtTenCS.Text == "" || txtDiaChi.Text == "" || txtMaNQL.Text == "")

            {
                if (MessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                x = 0;
            }
            else
            {
                CoSo coso = new CoSo(txtMaCS.Text, txtTenCS.Text, txtDiaChi.Text, txtMaNQL.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<CoSo>("coso", coso);

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
    }
}
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
    public partial class ThemLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public string baseAddress = "http://localhost:55137/api/";
        List<Loptt> listloptt = null;
        public ThemLopHoc()
        {
            InitializeComponent();
           
            //Thêm mã tự động
            int t = 0;
            String maauto = "l";
            Random rd = new Random();
            int x = rd.Next(0, 1000);
            while (t == 0)
            {
                maauto = maauto + x.ToString();
                List<Loptt> l = loadLoptt().Where(m => m.MaLoptt == maauto).ToList();
                if (l.Count() == 0)
                {
                    t = 1;
                }
            }
            txtMaLoptt.Text = maauto;
        }
        private List<Loptt> loadLoptt()
        {
            List<Loptt> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("loptt");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Loptt>>();
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
            if (txtMaLoptt.Text == "" || txtTenLoptt.Text == "" || txtMaGV.Text == "" || txtMaCS.Text == "" || txtMaTKB.Text == "")

            {
                if (MessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                x = 0;
            } 
            else
            {
                Loptt loptt = new Loptt(txtMaLoptt.Text, txtTenLoptt.Text, txtMaGV.Text, txtMaCS.Text, txtMaTKB.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Loptt>("loptt", loptt);

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

        private void ThemLopHoc_Load(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
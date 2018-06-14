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

namespace WinForms.Forms
{
    public partial class ThemThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public ThemThoiKhoaBieu()
        {
            InitializeComponent();
            //Thêm mã tự động
            int t = 0;
            String maauto = "tkb";
            Random rd = new Random();
            int x = rd.Next(0, 1000);
            while (t == 0)
            {
                maauto = maauto + x.ToString();
                List<ThoiKhoaBieu> nv = loadThoiKhoaBieu().Where(m => m.MaTKB == maauto).ToList();
                if (nv.Count() == 0)
                {
                    t = 1;
                }
            }
            txtMaTKB.Text = maauto;

        }
        public string baseAddress = "http://localhost:55137/api/";
        List<ThoiKhoaBieu> listThoiKhoaBieu = null;

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaTKB.Text == "" || txtNH.Text == "" || txtTGH.Text == "")
            {
                if (MessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                x = 0;
            }
            else
            {
                ThoiKhoaBieu thoikhoabieu = new ThoiKhoaBieu(txtMaTKB.Text, txtNH.Text, txtTGH.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<ThoiKhoaBieu>("thoikhoabieu", thoikhoabieu);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
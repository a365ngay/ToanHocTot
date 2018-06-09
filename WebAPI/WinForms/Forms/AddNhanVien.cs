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

namespace WinForms.Forms
{
    public partial class AddNhanVien : Form
    {
        public AddNhanVien()
        {
            InitializeComponent();
            loadData();
        }

        public string baseAddress = "http://localhost:55137/api/";
        List<NhanVien> listNhanVien = null;
        List<CoSo> listCoso = null;

        private void loadData()
        {
            listCoso = loadCoso();
            //load combobox

            foreach (var item in listCoso)
            {
                cbMacs.Items.Add(item.MaCS);
            }

        }

        private List<CoSo> loadCoso()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien(txtManv.Text, txtTennv.Text, txtGt.Text, txtDiachi.Text, txtSoDT.Text, txtCv.Text, Convert.ToInt32(txtL.Text), cbMacs.Text);
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
        }
    }
}

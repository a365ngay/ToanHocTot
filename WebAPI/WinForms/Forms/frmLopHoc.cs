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
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmLopHoc()
        {
            InitializeComponent();
            loadData();
        }
        public string baseAddress = "http://localhost:55137/api/";
        List<Loptt> listloptt= null;
        private void loadData()
        {
            listloptt = loadLoptt();

            dataGridView1.DataSource = listloptt;
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
            ThemLopHoc themltt = null;
        Check_Them:
            if (themltt == null || themltt.IsDisposed)
            {
                themltt = new ThemLopHoc();
            }
            if (themltt.ShowDialog() == DialogResult.OK)
            {
                if (ThemLopHoc.x == 0)
                {
                    goto Check_Them;
                }
            }

            loadData();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Loptt loptt = new Loptt(txtMaLoptt.Text, txtTenLoptt.Text, txtMaGV.Text, txtMaCS.Text, txtMaTKB.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<Loptt>("loptt", loptt);

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
                var postTask = client.DeleteAsync("loptt/" + txtMaLoptt.Text);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoptt.Text = dataGridView1.CurrentRow.Cells["MaLoptt"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenLoptt"].Value != null)
            {
                txtTenLoptt.Text = dataGridView1.CurrentRow.Cells["TenLoptt"].Value.ToString();
            }
            else
            {
                txtTenLoptt.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaGV"].Value != null)
            {
                txtMaGV.Text = dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString();
            }
            else
            {
                txtMaGV.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaCS"].Value != null)
            {
                txtMaCS.Text = dataGridView1.CurrentRow.Cells["MaCS"].Value.ToString();
            }
            else
            {
                txtMaCS.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaTKB"].Value != null)
            {
                txtMaTKB.Text = dataGridView1.CurrentRow.Cells["MaTKB"].Value.ToString();
            }
            else
            {
                txtMaTKB.Text = "";
            }

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            List<Loptt> l = loadLoptt().Where(a => a.TenLoptt.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.DataSource = l;
        }
    }
}
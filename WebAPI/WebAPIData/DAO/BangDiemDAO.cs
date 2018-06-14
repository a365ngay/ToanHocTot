using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class BangDiemDAO
    {
        private BangDiemDAO() { }

        private static volatile BangDiemDAO instance;

        static object key = new object();

        public static BangDiemDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new BangDiemDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<BangDiem> GetList()
        {
            List<BangDiem> list = new List<BangDiem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.view_bangdiem");
            foreach (DataRow item in data.Rows)
            {
                BangDiem obj = new BangDiem(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaBangDiem, string MaHS, string Ngay, double DiemHocTap, double DiemYThuc)
        {
            string query = $" exec dbo.them_diem '{MaBangDiem}',  '{MaHS}',  '{Ngay}',  {DiemHocTap},  {DiemYThuc}  ";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaBangDiem, string MaHS, string Ngay, double DiemHocTap, double DiemYThuc)
        {
            string query = $"exec dbo.sua_diem '{MaHS}', '{Ngay}', {DiemHocTap}, {DiemYThuc} ";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaBangDiem)
        {
            string query = $"exec dbo.xoa_diem '{MaBangDiem}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public List<BangDiem> TimKiemBangDiem(string MaBangDiem)
        {
            List<BangDiem> list = new List<BangDiem>();
            string query = $"SELECT * FROM dbo.view_bangdiem";
            //khi view bảng phức hợp 
            //string query = $"SELECT * FROM tên_bảng_view";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BangDiem obj = new BangDiem(item);
                list.Add(obj);
            }
            return list;
        }
    }
}

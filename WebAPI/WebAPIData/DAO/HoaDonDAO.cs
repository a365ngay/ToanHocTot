using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class HoaDonDAO
    {
        private HoaDonDAO() { }

        private static volatile HoaDonDAO instance;

        static object key = new object();

        public static HoaDonDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new HoaDonDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<HoaDon> GetList()
        {
            List<HoaDon> list = new List<HoaDon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HoaDon");
            foreach (DataRow item in data.Rows)
            {
                HoaDon obj = new HoaDon(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaHD, string Ngay, string MaHS, string MaNV, int SoTien, string GhiChu)
        {
            string query = $"INSERT dbo.HoaDon VALUES  ( '{MaHD}',  '{Ngay}',  '{MaHS}',  '{MaNV}',  {SoTien},  N'{GhiChu}'  )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaHD, string Ngay, string MaHS, string MaNV, int SoTien, string GhiChu)
        {
            string query = $"UPDATE dbo.HoaDon SET Ngay = '{Ngay}', MaHS = '{MaHS}', MaNV = '{MaNV}', SoTien = '{SoTien}', GhiChu = N'{GhiChu}' WHERE MaHD = '{MaHD}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaHD)
        {
            string query = $"DELETE dbo.HoaDon WHERE MaHD = '{MaHD}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

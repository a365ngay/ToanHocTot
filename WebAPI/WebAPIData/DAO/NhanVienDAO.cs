using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class NhanVienDAO
    {
        private NhanVienDAO() { }

        private static volatile NhanVienDAO instance;

        static object key = new object();

        public static NhanVienDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new NhanVienDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<NhanVien> GetList()
        {
            List<NhanVien> list = new List<NhanVien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien");
            foreach (DataRow item in data.Rows)
            {
                NhanVien obj = new NhanVien(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SoDT, string ChucVu, int Luong, string MaCS)
        {
            string query = $"EXEC dbo.them_nv '{MaNV}',  N'{TenNV}',  N'{GioiTinh}',  N'{DiaChi}',  '{SoDT}',  N'{ChucVu}',  {Luong},  '{MaCS}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SoDT, string ChucVu, int Luong, string MaCS)
        {
            string query = $"EXEC dbo.sua_nv '{MaNV}', N'{TenNV}', N'{GioiTinh}', N'{DiaChi}', '{SoDT}',  N'{ChucVu}',  {Luong}, '{MaCS}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaNV)
        {
            string query = $"EXEC dbo.xoa_nv '{MaNV}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public List<NhanVien> TimKiemNhanVien(string TenNV)
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = $"Select * From dbo.NhanVien Where TenNV= '{TenNV}'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien obj = new NhanVien(item);
                list.Add(obj);
            }

            return list;

        }
    }
}

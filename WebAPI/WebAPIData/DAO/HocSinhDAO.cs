using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class HocSinhDAO
    {
        private HocSinhDAO() { }

        private static volatile HocSinhDAO instance;

        static object key = new object();

        public static HocSinhDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new HocSinhDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<HocSinh> GetList()
        {
            List<HocSinh> list = new List<HocSinh>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HocSinh");
            foreach (DataRow item in data.Rows)
            {
                HocSinh obj = new HocSinh(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaHS, string TenHS, string Lop, string Truong, string Loptt)
        {
            string query = $"EXEC dbo.them_hs  '{MaHS}',  N'{TenHS}',  N'{Lop}',  N'{Truong}',  '{Loptt}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaHS, string TenHS, string Lop, string Truong, string Loptt)
        {
            string query = $"EXEC dbo.sua_hs {MaHS} ,N'{TenHS}',  N'{Lop}',  N'{Truong}','{Loptt}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaHS)
        {
            string query = $"EXEC dbo.xoa_hs  '{MaHS}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public List<HocSinh> TimKiemHocSinh(string TenHS)
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = $"Select * From dbo.HocSinh Where TenHS= '{TenHS}'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocSinh obj = new HocSinh(item);
                list.Add(obj);
            }

            return list;

        }
    }
}

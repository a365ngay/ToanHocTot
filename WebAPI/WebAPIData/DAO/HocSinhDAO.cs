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
            string query = $"INSERT dbo.HocSinh VALUES  ( '{MaHS}',  N'{TenHS}',  N'{Lop}',  N'{Truong}',  '{Loptt}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaHS, string TenHS, string Lop, string Truong, string Loptt)
        {
            string query = $"UPDATE dbo.HocSinh SET TenHS = N'{TenHS}', Lop = N'{Lop}', Truong = N'{Truong}', Loptt = '{Loptt}' WHERE MaHS = '{MaHS}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaHS)
        {
            string query = $"DELETE dbo.HocSinh WHERE MaHS = '{MaHS}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

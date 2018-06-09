using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class ThoiKhoaBieuDAO
    {
        private ThoiKhoaBieuDAO() { }

        private static volatile ThoiKhoaBieuDAO instance;

        static object key = new object();

        public static ThoiKhoaBieuDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ThoiKhoaBieuDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<ThoiKhoaBieu> GetList()
        {
            List<ThoiKhoaBieu> list = new List<ThoiKhoaBieu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThoiKhoaBieu");
            foreach (DataRow item in data.Rows)
            {
                ThoiKhoaBieu obj = new ThoiKhoaBieu(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaTKB, string NgayHoc, string ThoiGianHoc)
        {
            string query = $"INSERT dbo.ThoiKhoaBieu VALUES  ( '{MaTKB}',  '{NgayHoc}',  N'{ThoiGianHoc}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaTKB, string NgayHoc, string ThoiGianHoc)
        {
            string query = $"UPDATE dbo.ThoiKhoaBieu SET NgayHoc = '{NgayHoc}', ThoiGianHoc = N'{ThoiGianHoc}' WHERE MaTKB = '{MaTKB}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaTKB)
        {
            string query = $"DELETE dbo.ThoiKhoaBieu WHERE MaTKB = '{MaTKB}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

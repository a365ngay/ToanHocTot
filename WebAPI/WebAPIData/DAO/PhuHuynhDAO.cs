using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class PhuHuynhDAO
    {
        private PhuHuynhDAO() { }

        private static volatile PhuHuynhDAO instance;

        static object key = new object();

        public static PhuHuynhDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new PhuHuynhDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<PhuHuynh> GetList()
        {
            List<PhuHuynh> list = new List<PhuHuynh>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhuHuynh");
            foreach (DataRow item in data.Rows)
            {
                PhuHuynh obj = new PhuHuynh(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaPH, string TenPH, string DiaChi, string SoDT, string MaHS)
        {
            string query = $"INSERT dbo.PhuHuynh VALUES  ( '{MaPH}',  N'{TenPH}',  N'{DiaChi}',  '{SoDT}',  '{MaHS}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaPH, string TenPH, string DiaChi, string SoDT, string MaHS)
        {
            string query = $"UPDATE dbo.PhuHuynh SET TenPH = N'{TenPH}', DiaChi = N'{DiaChi}', SoDT = '{SoDT}', MaHS = '{MaHS}' WHERE MaPH = '{MaPH}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaPH)
        {
            string query = $"DELETE dbo.PhuHuynh WHERE MaPH = '{MaPH}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

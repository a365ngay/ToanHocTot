using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class ChiTietDDDAO
    {
        private ChiTietDDDAO() { }

        private static volatile ChiTietDDDAO instance;

        static object key = new object();

        public static ChiTietDDDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ChiTietDDDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<ChiTietDD> GetList()
        {
            List<ChiTietDD> list = new List<ChiTietDD>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ChiTietDD");
            foreach (DataRow item in data.Rows)
            {
                ChiTietDD obj = new ChiTietDD(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(int IDDiemDanh, string MaHS, string TinhTrangDD, string GhiChu)
        {
            string query = $"INSERT dbo.ChiTietDD VALUES  ( {IDDiemDanh},  '{MaHS}',  N'{TinhTrangDD}',  N'{GhiChu}'  )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(int IDDiemDanh, string MaHS, string TinhTrangDD, string GhiChu)
        {
            string query = $"UPDATE dbo.ChiTietDD SET MaHS = '{MaHS}', TinhTrangDD = N'{TinhTrangDD}', GhiChu = N'{GhiChu}' WHERE IDDiemDanh = '{IDDiemDanh}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(int IDDiemDanh)
        {
            string query = $"DELETE dbo.ChiTietDD WHERE IDDiemDanh = '{IDDiemDanh}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

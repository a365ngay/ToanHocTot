using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class GVDiemDanhHSDAO
    {
        private GVDiemDanhHSDAO() { }

        private static volatile GVDiemDanhHSDAO instance;

        static object key = new object();

        public static GVDiemDanhHSDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new GVDiemDanhHSDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<GVDiemDanhHS> GetList()
        {
            List<GVDiemDanhHS> list = new List<GVDiemDanhHS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.GVDiemDanhHS");
            foreach (DataRow item in data.Rows)
            {
                GVDiemDanhHS obj = new GVDiemDanhHS(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(int IDDiemDanh, string MaNV, string Malop, string NgayDD)
        {
            string query = $"INSERT dbo.GVDiemDanhHS VALUES  ( {IDDiemDanh},  '{MaNV}',  '{Malop}',  '{NgayDD}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(int IDDiemDanh, string MaNV, string Malop, string NgayDD)
        {
            string query = $"UPDATE dbo.GVDiemDanhHS SET MaNV = '{MaNV}', Malop = '{Malop}', NgayDD = '{NgayDD}' WHERE IDDiemDanh = '{IDDiemDanh}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(int IDDiemDanh)
        {
            string query = $"DELETE dbo.GVDiemDanhHS WHERE IDDiemDanh = '{IDDiemDanh}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

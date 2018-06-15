using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class CoSoDAO
    {
        private CoSoDAO() { }

        private static volatile CoSoDAO instance;

        static object key = new object();

        public static CoSoDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new CoSoDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<CoSo> GetList()
        {
            List<CoSo> list = new List<CoSo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CoSo");
            foreach (DataRow item in data.Rows)
            {
                CoSo obj = new CoSo(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaCS, string TenCS, string DiaChi, string MaNQL)
        {
            string query = $"EXEC dbo.them_cs '{MaCS}',  N'{TenCS}',  N'{DiaChi}',  '{MaNQL}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaCS, string TenCS, string DiaChi, string MaNQL)
        {
            string query = $"EXEC dbo.sua_cs '{MaCS}' ,N'{TenCS}', N'{DiaChi}', '{MaNQL}' ";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaCS)
        {
            string query = $"EXEC dbo.xoa_cs '{MaCS}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public List<CoSo> TimKiemCoSo(string TenCS)
        {
            List<CoSo> list = new List<CoSo>();
            string query = $"Select * From dbo.CoSo Where TenCS= '{TenCS}'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CoSo obj = new CoSo(item);
                list.Add(obj);
            }

            return list;

        }
    }
}

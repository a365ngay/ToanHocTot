using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class TaiKhoanDAO
    {
        private TaiKhoanDAO() { }

        private static volatile TaiKhoanDAO instance;

        static object key = new object();

        public static TaiKhoanDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new TaiKhoanDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<TaiKhoan> GetList()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TaiKhoan");
            foreach (DataRow item in data.Rows)
            {
                TaiKhoan obj = new TaiKhoan(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string Username, string Password, string IDUser, string IDQuyen)
        {
            string query = $"INSERT dbo.TaiKhoan VALUES  ( '{Username}',  '{Password}',  '{IDUser}',  '{IDQuyen}' )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string Username, string Password, string IDUser, string IDQuyen)
        {
            string query = $"UPDATE dbo.TaiKhoan SET Password = '{Password}', IDUser = '{IDUser}', IDQuyen = '{IDQuyen}' WHERE Username = '{Username}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string Username)
        {
            string query = $"DELETE dbo.TaiKhoan WHERE Username = '{Username}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}

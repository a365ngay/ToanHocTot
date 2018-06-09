﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIData.DTO;

namespace WebAPIData.DAO
{
    public class LopttDAO
    {
        private LopttDAO() { }

        private static volatile LopttDAO instance;

        static object key = new object();

        public static LopttDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new LopttDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Loptt> GetList()
        {
            List<Loptt> list = new List<Loptt>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Loptt");
            foreach (DataRow item in data.Rows)
            {
                Loptt obj = new Loptt(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string MaLoptt, string TenLoptt, string MaGV, string MaCS, string MaTKB)
        {
            string query = $"INSERT dbo.Loptt VALUES  ( '{MaLoptt}',  N'{TenLoptt}',  '{MaGV}',  '{MaCS}',  '{MaTKB}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string MaLoptt, string TenLoptt, string MaGV, string MaCS, string MaTKB)
        {
            string query = $"UPDATE dbo.Loptt SET TenLoptt = N'{TenLoptt}', MaGV = '{MaGV}', MaCS = '{MaCS}', MaTKB = '{MaTKB}' WHERE MaLoptt = '{MaLoptt}'";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }

        public int Delete(string MaLoptt)
        {
            string query = $"DELETE dbo.Loptt WHERE MaLoptt = '{MaLoptt}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class Quyen
    {
        public string IDQuyen { get; set; }
        public string TenQuyen { get; set; }

        public Quyen(string IDQuyen, string TenQuyen)
        {
            this.IDQuyen = IDQuyen;
            this.TenQuyen = TenQuyen;
        }

        public Quyen(DataRow row)
        {
            this.IDQuyen = row["IDQuyen"].ToString();
            this.TenQuyen = row["TenQuyen"].ToString();
        }

        public Quyen()
        {

        }
    }
}

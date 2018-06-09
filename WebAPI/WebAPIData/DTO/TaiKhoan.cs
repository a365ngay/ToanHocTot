using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class TaiKhoan
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IDUser { get; set; }
        public string IDQuyen { get; set; }

        public TaiKhoan(string Username, string Password, string IDUser, string IDQuyen)
        {
            this.Username = Username;
            this.Password = Password;
            this.IDUser = IDUser;
            this.IDQuyen = IDQuyen;
        }

        public TaiKhoan(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.IDUser = row["IDUser"].ToString();
            this.IDQuyen = row["IDQuyen"].ToString();

        }

        public TaiKhoan()
        {

        }
    }
}

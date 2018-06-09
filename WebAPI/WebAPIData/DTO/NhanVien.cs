using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string ChucVu { get; set; }
        public int Luong { get; set; }
        public string MaCS { get; set; }

        public NhanVien(string MaNV, string TenNV, string GioiTinh, string DiaChi, string SoDT, string ChucVu, int Luong, string MaCS)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.ChucVu = ChucVu;
            this.Luong = Luong;
            this.MaCS = MaCS;
        }

        public NhanVien(DataRow row)
        {
            bool success;
            int ketqua;
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDT = row["SoDT"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            success = Int32.TryParse(row["Luong"].ToString(),out ketqua);
            this.Luong = ketqua;
            this.MaCS = row["MaCS"].ToString();

        }

        public NhanVien()
        {

        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return true;
            }
            return false;
        }
    }
}

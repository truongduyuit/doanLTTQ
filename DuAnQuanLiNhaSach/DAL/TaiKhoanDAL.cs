using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachTaiKhoan");
            List<TaiKhoanDTO> ltk = new List<TaiKhoanDTO>();
            while (reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.id = reader.GetString(0);
                tk.pass = reader.GetString(1);
                tk.manv = reader.GetString(2);
                tk.chucvu = reader.GetString(3);
                ltk.Add(tk);
            }
            reader.Close();
            return ltk;
        }

        public static List<TaiKhoanDTO> LayMaNVChuaTaoTK()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayMaNVChuaTaoTK");
            List<TaiKhoanDTO> ltk = new List<TaiKhoanDTO>();
            while (reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.id = "1";
                tk.pass = "1";
                tk.manv = reader.GetString(0);
                tk.chucvu = reader.GetString(1);
                ltk.Add(tk);
            }
            reader.Close();
            return ltk;
        }

        public static bool ThemTaiKhoan(string tk, string mk, string manv, string cv)
        {
            return DataProvider.ThemTaiKhoan("ThemTaiKhoan", tk, mk, manv, cv);
        }

        public static bool SuaMatKhau(string tk, string pass)
        {
            return DataProvider.SuaMatKhau("SuaMatKhau", tk, pass);
        }

        public static bool XoaTK(string manv)
        {
            return DataProvider.XoaTK("XoaTK", manv);
        }
    }
}

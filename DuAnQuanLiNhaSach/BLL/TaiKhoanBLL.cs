using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            return DAL.TaiKhoanDAL.LayDanhSachTaiKhoan();
        }

        public static List<TaiKhoanDTO> LayMaNVChuaTaoTK()
        {
            return DAL.TaiKhoanDAL.LayMaNVChuaTaoTK();
        }

        public static bool ThemTaiKhoan(TaiKhoanDTO t)
        {
            return DAL.TaiKhoanDAL.ThemTaiKhoan(t.id, t.pass, t.manv, t.chucvu);
        }

        public static bool SuaMatKhau(string tk, string pass)
        {
            return DAL.TaiKhoanDAL.SuaMatKhau(tk, pass);
        }

        public static bool XoaTK(string manv)
        {
            return DAL.TaiKhoanDAL.XoaTK(manv);
        }
    }
}

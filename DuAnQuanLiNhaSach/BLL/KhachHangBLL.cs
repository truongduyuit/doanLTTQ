using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return DAL.KhachHangDAL.LayDanhSachKhachHang();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return DAL.KhachHangDAL.ThemKhachHang(kh);
        }

        public static bool SuaKhachHang(KhachHangDTO kh)
        {
            return DAL.KhachHangDAL.SuaKhachHang(kh);
        }

        public static bool XoaKhachHang(string MaKH)
        {
            return DAL.KhachHangDAL.XoaKhachHang(MaKH);
        }

        public static List<KhachHangDTO> TimKhachHangTheoTuKhoa(string tukhoa)
        {
            return DAL.KhachHangDAL.TimKhachHangTheoTuKhoa(tukhoa);
        }

        public static List<KhachHangDTO> TimKhachHangTheoLoaiKH(string loaikh)
        {
            return DAL.KhachHangDAL.TimKhachHangTheoLoaiKH(loaikh);
        }
        public static List<KhachHangDTO> TimKhachHangTheoTuKhoaLoai(string tukhoa, string loai)
        {
            return DAL.KhachHangDAL.TimKhachHangTheoTuKhoaLoai(tukhoa, loai);
        }
    }
}

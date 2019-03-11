using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            List<KhachHangDTO> lkh = new List<KhachHangDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachKhachHang");

                while (reader.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKH = reader.GetString(0);
                    kh.HoTen = reader.GetString(1);
                    kh.NgaySinh = reader.GetDateTime(2);
                    kh.Cmnd = reader.GetString(3);
                    kh.Sdt = reader.GetString(4);
                    kh.DiaChi = reader.GetString(5);
                    kh.NgayDK = reader.GetDateTime(6);
                    kh.Loai = reader.GetString(7);
                    kh.DoanhSo =(uint) reader.GetDecimal(8);
                    lkh.Add(kh);
                }
                reader.Close();
            }
            catch
            {

            }
            return lkh;
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            if (DataProvider.ThemKhachHang("ThemKhachHang", kh))
                return true;
            return false;
        }

        public static bool SuaKhachHang(KhachHangDTO kh)
        {
            if (DataProvider.ThemKhachHang("SuaKhachHang", kh))
                return true;
            return false;
        }
        public static bool XoaKhachHang(string MaKH)
        {
            if (DataProvider.XoaKhachHang("XoaKhachHang", MaKH))
                return true;
            return false;
        }

        public static List<KhachHangDTO> TimKhachHangTheoTuKhoa(string tukhoa)
        {
            List<KhachHangDTO> lkh = new List<KhachHangDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TimKhachHangTheoTuKhoa("TimKhachHangTheoTuKhoa", tukhoa);
                while (reader.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKH = reader.GetString(0).Trim();
                    kh.HoTen = reader.GetString(1);
                    kh.NgaySinh = reader.GetDateTime(2);
                    kh.Cmnd = reader.GetString(3).Trim();
                    kh.Sdt = reader.GetString(4).Trim();
                    kh.DiaChi = reader.GetString(5);
                    kh.NgayDK = reader.GetDateTime(6);
                    kh.Loai = reader.GetString(7);
                    kh.DoanhSo = (uint)reader.GetDecimal(8);
                    lkh.Add(kh);
                }
                reader.Close();
            }
            catch
            {

            }
            return lkh;
        }

        public static List<KhachHangDTO> TimKhachHangTheoLoaiKH(string loaikh)
        {
            List<KhachHangDTO> lkh = new List<KhachHangDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TimKhachHangTheoLoaiKH("TimKhachHangTheoLoaiKH", loaikh);
                while (reader.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKH = reader.GetString(0).Trim();
                    kh.HoTen = reader.GetString(1);
                    kh.NgaySinh = reader.GetDateTime(2);
                    kh.Cmnd = reader.GetString(3).Trim();
                    kh.Sdt = reader.GetString(4).Trim();
                    kh.DiaChi = reader.GetString(5);
                    kh.NgayDK = reader.GetDateTime(6);
                    kh.Loai = reader.GetString(7);
                    kh.DoanhSo = (uint)reader.GetDecimal(8);
                    lkh.Add(kh);
                }
                reader.Close();
            }
            catch
            {

            }
            return lkh;
        }

        public static List<KhachHangDTO> TimKhachHangTheoTuKhoaLoai(string tukhoa, string loai)
        {
            List<KhachHangDTO> lkh = new List<KhachHangDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TimKhachHangTheoTuKhoaLoai("TimKhachHangTheoTuKhoaLoai", tukhoa, loai);
                while (reader.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKH = reader.GetString(0).Trim();
                    kh.HoTen = reader.GetString(1);
                    kh.NgaySinh = reader.GetDateTime(2);
                    kh.Cmnd = reader.GetString(3).Trim();
                    kh.Sdt = reader.GetString(4).Trim();
                    kh.DiaChi = reader.GetString(5);
                    kh.NgayDK = reader.GetDateTime(6);
                    kh.Loai = reader.GetString(7);
                    kh.DoanhSo = (uint)reader.GetDecimal(8);
                    lkh.Add(kh);
                }
                reader.Close();
            }
            catch
            {

            }
            return lkh;
        }
    }
}

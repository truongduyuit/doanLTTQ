using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    
    public class NhanVienDAL
    {
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachNhanVien");
            List<NhanVienDTO> lnv = new List<NhanVienDTO>();
            while (reader.Read())
            {

                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader.GetString(0);
                nv.HoTen = reader.GetString(1);
                nv.NgaySinh = reader.GetDateTime(2);
                nv.NgayVaoLam = reader.GetDateTime(3);
                nv.SDT = reader.GetString(4);
                nv.DiaChi = reader.GetString(5);
                nv.ChucVu = reader.GetString(6);
                nv.CMND = reader.GetString(7);
                nv.Anh =(byte[])reader.GetValue(8);
                lnv.Add(nv);
            }
            reader.Close();
            return lnv;
        }

        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            return DataProvider.ThemNhanvien("ThemNhanVien", nv);
        }

        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            return DataProvider.ThemNhanvien("SuaNhanVien", nv);
        }

        public static bool XoaNhanVien(string manv)
        {
            return DataProvider.XoaNhanVien("XoaNhanVienTheoMaNV", manv);
        }

        public static List<NhanVienDTO> TimNhanVienTheoMaNV(string manv)
        {
            SqlDataReader reader = DataProvider.TimNhanVienTheoMaNV("TimNhanVienTheoMaNV", manv);
            List<NhanVienDTO> lnv = new List<NhanVienDTO>();
            try
            {
                while (reader.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNV = reader.GetString(0);
                    nv.HoTen = reader.GetString(1);
                    nv.NgaySinh = reader.GetDateTime(2);
                    nv.NgayVaoLam = reader.GetDateTime(3);
                    nv.SDT = reader.GetString(4);
                    nv.DiaChi = reader.GetString(5);
                    nv.ChucVu = reader.GetString(6);
                    nv.CMND = reader.GetString(7);
                    nv.Anh = (byte[])reader.GetValue(8);
                    lnv.Add(nv);
                }
            }
            catch
            {
                if (reader.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNV = reader.GetString(0);
                    nv.HoTen = reader.GetString(1);
                    nv.NgaySinh = reader.GetDateTime(2);
                    nv.NgayVaoLam = reader.GetDateTime(3);
                    nv.SDT = reader.GetString(4);
                    nv.DiaChi = reader.GetString(5);
                    nv.ChucVu = reader.GetString(6);
                    nv.CMND = reader.GetString(7);
                    nv.Anh = (byte[])reader.GetValue(8);
                    lnv.Add(nv);
                }
            }
            reader.Close();
            return lnv;
        }

        public static List<NhanVienDTO> TimNhanVienTheoChucVu(string chucvu)
        {
            SqlDataReader reader = DataProvider.TimNhanVienTheoChucVu("TimNhanVienTheoChucVu", chucvu);
            List<NhanVienDTO> lnv = new List<NhanVienDTO>();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nv = new NhanVienDTO();
                        nv.MaNV = reader.GetString(0);
                        nv.HoTen = reader.GetString(1);
                        nv.NgaySinh = reader.GetDateTime(2);
                        nv.NgayVaoLam = reader.GetDateTime(3);
                        nv.SDT = reader.GetString(4);
                        nv.DiaChi = reader.GetString(5);
                        nv.ChucVu = reader.GetString(6);
                        nv.CMND = reader.GetString(7);
                        nv.Anh = (byte[])reader.GetValue(8);
                        lnv.Add(nv);
                    }
                    reader.Close();
                }

            }
            catch
            {

            }

            
            return lnv;
        }

        public static List<NhanVienDTO> TimNhanVienTheoTuKhoa(string tukhoa)
        {
            SqlDataReader reader = DataProvider.TimNhanVienTheoTuKhoa("TimNhanVienTheoTuKhoa", tukhoa);
            List<NhanVienDTO> lnv = new List<NhanVienDTO>();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nv = new NhanVienDTO();
                        nv.MaNV = reader.GetString(0);
                        nv.HoTen = reader.GetString(1);
                        nv.NgaySinh = reader.GetDateTime(2);
                        nv.NgayVaoLam = reader.GetDateTime(3);
                        nv.SDT = reader.GetString(4);
                        nv.DiaChi = reader.GetString(5);
                        nv.ChucVu = reader.GetString(6);
                        nv.CMND = reader.GetString(7);
                        nv.Anh = (byte[])reader.GetValue(8);
                        lnv.Add(nv);
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            return lnv;
        }
    }
}

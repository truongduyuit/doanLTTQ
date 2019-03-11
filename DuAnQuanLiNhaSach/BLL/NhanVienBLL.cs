using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return DAL.NhanVienDAL.LayDanhSachNhanVien();
        }

        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            return DAL.NhanVienDAL.ThemNhanVien(nv);
        }

        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            return DAL.NhanVienDAL.SuaNhanVien(nv);
        }

        public static bool XoaNhanVien(string manv)
        {
            return DAL.NhanVienDAL.XoaNhanVien(manv);
        }

        public static List<NhanVienDTO> TimNhanVienTheoMaNV(string manv)
        {
            return DAL.NhanVienDAL.TimNhanVienTheoMaNV(manv);
        }

        public static List<NhanVienDTO> TimNhanVienTheoChucVu(string chucvu)
        {
            return DAL.NhanVienDAL.TimNhanVienTheoChucVu(chucvu);
        }

        public static List<NhanVienDTO> TimNhanVienTheoTuKhoa(string tukhoa)
        {
            return DAL.NhanVienDAL.TimNhanVienTheoTuKhoa(tukhoa);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        public static List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return DAL.HoaDonDAL.LayDanhSachHoaDon();
        }

        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            return DAL.HoaDonDAL.ThemHoaDon(hd);
        }

        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            return DAL.HoaDonDAL.SuaHoaDon(hd);
        }
        public static bool XoaHoaDon(int sohd)
        {
            return DAL.HoaDonDAL.XoaHoaDon(sohd);
        }

        public static List<HoaDonDTO> LayHoaDonTheoTuKhoa(string tukhoa)
        {
            return DAL.HoaDonDAL.LayHoaDonTheoTuKhoa(tukhoa);
        }

        public static HoaDonDTO TimHoaDonTheoSoHD(int sohd)
        {
            return DAL.HoaDonDAL.TimHoaDonTheoSoHD(sohd);
        }
    }
}

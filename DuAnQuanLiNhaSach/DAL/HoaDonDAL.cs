using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class HoaDonDAL
    {
        public static List<HoaDonDTO> LayDanhSachHoaDon()
        {
            List<HoaDonDTO> lhd = new List<HoaDonDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachHoaDon");

                while(reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    hd.SoHD = reader.GetInt32(0);
                    hd.MaKH = reader.GetString(1);
                    hd.MaNV = reader.GetString(2);
                    hd.NgayHoaDon = reader.GetDateTime(3);
                    hd.TriGia = (int)reader.GetDecimal(4);
                    lhd.Add(hd);
                }
                reader.Close();
            }
            catch
            {

            }
            return lhd;
        }

        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            return DataProvider.ThemHoaDon("ThemHoaDon", hd);
        }

        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            return DataProvider.ThemHoaDon("SuaHoaDon", hd);
        }
        public static bool XoaHoaDon(int sohd)
        {
            return DataProvider.XoaHoaDon("XoaHoaDon", sohd);
        }

        public static List<HoaDonDTO> LayHoaDonTheoTuKhoa(string tukhoa)
        {
            List<HoaDonDTO> lhd = new List<HoaDonDTO>();
            try
            {
                SqlDataReader reader = DataProvider.TimHoaDonTheoTuKhoa("TimHoaDonTheoTuKhoa", tukhoa);

                while (reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    hd.SoHD = reader.GetInt32(0);
                    hd.MaKH = reader.GetString(1);
                    hd.MaNV = reader.GetString(2);
                    hd.NgayHoaDon = reader.GetDateTime(3);
                    hd.TriGia = (int)reader.GetDecimal(4);
                    lhd.Add(hd);
                }
                reader.Close();
            }
            catch
            {

            }
            return lhd;
        }

        public static HoaDonDTO TimHoaDonTheoSoHD(int sohd)
        {
            List<HoaDonDTO> lhd = new List<HoaDonDTO>();
            HoaDonDTO hd = new HoaDonDTO();
            try
            {
                SqlDataReader reader = DataProvider.TimHoaDonTheoSoHD("TimHoaDonTheoSoHD", sohd);
                while (reader.Read())
                {
                    
                    hd.SoHD = reader.GetInt32(0);
                    hd.MaKH = reader.GetString(1);
                    hd.MaNV = reader.GetString(2);
                    hd.NgayHoaDon = reader.GetDateTime(3);
                    hd.TriGia = (int)reader.GetDecimal(4);
                }
                reader.Close();
            }
            catch
            {

            }
            return hd;
        }
    }
}

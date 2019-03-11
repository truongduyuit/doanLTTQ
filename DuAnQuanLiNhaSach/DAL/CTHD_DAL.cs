using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CTHD_DAL
    {
        public static List<CTHD_DTO> LayCTHD(int sohd)
        {
            List<CTHD_DTO> cthd = new List<CTHD_DTO>();
            try
            {
                SqlDataReader reader = DataProvider.LayCTHD("LayCTHDTheoSoHD", sohd);
                while(reader.Read())
                {
                    CTHD_DTO ct = new CTHD_DTO();
                    ct.SoHD = reader.GetInt32(0);
                    ct.TenSP = reader.GetString(1);
                    ct.SoLuong = reader.GetByte(2);
                    ct.TriGia = (int)reader.GetDecimal(3);
                    cthd.Add(ct);
                }

            }
            catch
            {

            }

            return cthd;
        }

        public static bool ThemCTHD(CTHD_DTO cthd)
        {
            return DataProvider.ThemCTHD("ThemCTHD", cthd);
        }
        
        public static bool SuaCTHD(CTHD_DTO cthd)
        {
            return DataProvider.ThemCTHD("SuaCTHD", cthd);
        }
        public static bool XoaCTHD(int sohd, string tensp)
        {
            return DataProvider.XoaCTHD("XoaCTHD", sohd, tensp);
        }
    }
}

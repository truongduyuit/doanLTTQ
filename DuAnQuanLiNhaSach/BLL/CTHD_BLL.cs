using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CTHD_BLL
    {
        public static List<CTHD_DTO> LayCTHD(int sohd)
        {
            return DAL.CTHD_DAL.LayCTHD(sohd);
        }

        public static bool ThemCTHD(CTHD_DTO cthd)
        {
            return DAL.CTHD_DAL.ThemCTHD(cthd);
        }

        public static bool SuaCTHD(CTHD_DTO cthd)
        {
            return DAL.CTHD_DAL.SuaCTHD(cthd);
        }
        public static bool XoaCTHD(int sohd, string tensp)
        {
            return DAL.CTHD_DAL.XoaCTHD(sohd, tensp);
        }
    }
}

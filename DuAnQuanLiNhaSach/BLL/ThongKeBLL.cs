using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThongKeBLL
    {
        public class TK_SP
        {
            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeSPBanRaTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeSPBanRaTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeSPBanRaTheoNam(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeDTSPTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeDTSPTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_SP.ThongKeDTSPTheoNam(ngay, thang, nam);
            }
        }

        public class TK_NV
        {
            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeNVTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeNVTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeNVTheoNam(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeDTNVTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeDTNVTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_NV.ThongKeDTNVTheoNam(ngay, thang, nam);
            }
        }

        public class TK_KH
        {
            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_KH.ThongKeDSKHTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_KH.ThongKeDSKHTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_KH.ThongKeDSKHTheoNam(ngay, thang, nam);
            }
        }

        public class TK_HD
        {
            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoNgay(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_HD.ThongKeTGHDTheoNgay(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoThang(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_HD.ThongKeTGHDTheoThang(ngay, thang, nam);
            }

            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoNam(int ngay, int thang, int nam)
            {
                return DAL.ThongKeDAL.TK_HD.ThongKeTGHDTheoNam(ngay, thang, nam);
            }
        }
    }
}

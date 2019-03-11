using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThongKeDAL
    {
        public class TK_SP
        {
            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeSPBanRaTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetSqlInt32(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeSPBanRaTheoThang", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetSqlInt32(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_SP> ThongKeSPBanRaTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeSPBanRaTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetSqlInt32(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }


            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTSPTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetDecimal(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTSPTheoThang", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetDecimal(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_SP> ThongKeDTSPTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_SP> tk = new List<ThongKeDTO.TK_SP>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTSPTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_SP t = new ThongKeDTO.TK_SP();
                        t.tensp = reader.GetString(0);
                        t.soluong = (int)reader.GetDecimal(1);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }
        }

        public class TK_NV
        {
            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeNVTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetSqlInt32(2);
                        tk.Add(t);
                    }
                }
                catch { }

                return tk;
            }

            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeNVTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetSqlInt32(2);
                        tk.Add(t);
                    }
                }
                catch { }

                return tk;
            }

            public static List<ThongKeDTO.TK_NV> ThongKeNVTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeNVTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetSqlInt32(2);
                        tk.Add(t);
                    }
                }
                catch { }

                return tk;
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTNVTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTNVTheoThang", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_NV> ThongKeDTNVTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_NV> tk = new List<ThongKeDTO.TK_NV>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDTNVTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_NV t = new ThongKeDTO.TK_NV();
                        t.manv = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }
        }

        public class TK_KH
        {
            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_KH> tk = new List<ThongKeDTO.TK_KH>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDSKHTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_KH t = new ThongKeDTO.TK_KH();
                        t.makh = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_KH> tk = new List<ThongKeDTO.TK_KH>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDSKHTheoThang", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_KH t = new ThongKeDTO.TK_KH();
                        t.makh = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_KH> ThongKeDSKHTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_KH> tk = new List<ThongKeDTO.TK_KH>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeDSKHTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_KH t = new ThongKeDTO.TK_KH();
                        t.makh = reader.GetString(0);
                        t.hoten = reader.GetString(1);
                        t.soluong = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }
        }

        public class TK_HD
        {
            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoNgay(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_HD> tk = new List<ThongKeDTO.TK_HD>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeTGHDTheoNgay", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_HD t = new ThongKeDTO.TK_HD();
                        t.sohd = reader.GetInt32(0);
                        t.ngayhd = reader.GetDateTime(1);
                        t.trigia = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoThang(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_HD> tk = new List<ThongKeDTO.TK_HD>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeTGHDTheoThang", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_HD t = new ThongKeDTO.TK_HD();
                        t.sohd = reader.GetInt32(0);
                        t.ngayhd = reader.GetDateTime(1);
                        t.trigia = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }

            public static List<ThongKeDTO.TK_HD> ThongKeTGHDTheoNam(int ngay, int thang, int nam)
            {
                List<ThongKeDTO.TK_HD> tk = new List<ThongKeDTO.TK_HD>();
                try
                {

                    SqlDataReader reader = DataProvider.ThongKe("ThongKeTGHDTheoNam", ngay, thang, nam);
                    while (reader.Read())
                    {
                        ThongKeDTO.TK_HD t = new ThongKeDTO.TK_HD();
                        t.sohd = reader.GetInt32(0);
                        t.ngayhd = reader.GetDateTime(1);
                        t.trigia = (int)reader.GetDecimal(2);
                        tk.Add(t);
                    }
                }
                catch { }
                return tk;
            }
        }
    }
}

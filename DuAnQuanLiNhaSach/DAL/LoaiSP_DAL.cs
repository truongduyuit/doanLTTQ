using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LoaiSP_DAL
    {
        public static List<LoaiSP> LayLoaiSPTheoDanhMuc(string para)
        {
            SqlDataReader reader = DataProvider.TruyVan1ParaString("LayLoaiSPTheoDanhMuc", para);
            List<LoaiSP> loaisp = new List<LoaiSP>();
            while (reader.Read())
            {
                LoaiSP sp = new LoaiSP();
                sp.MaDanhMuc = reader.GetString(0);
                sp.TenLoaiSP = reader.GetString(1); 
                sp.MaDanhMuc = reader.GetString(2);
                loaisp.Add(sp);
            }
            return loaisp;
        }

    }

}


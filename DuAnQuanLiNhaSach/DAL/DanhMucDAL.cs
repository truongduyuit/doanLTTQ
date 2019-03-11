using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;



namespace DAL
{
    public class DanhMucDAL
    {
        public static List<DanhMucDTO> LayDanhMuc()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachDanhMuc");
            List<DanhMucDTO> danhmuc = new List<DanhMucDTO>();
            while (reader.Read())
            {
                DanhMucDTO d = new DanhMucDTO();
                d.MaDanhMuc = reader.GetString(0);
                d.TenDanhMuc = reader.GetString(1);
                danhmuc.Add(d);
            }
            reader.Close();
            return danhmuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class LoaiSP_BLL
    {
        public static List<LoaiSP> LayLoaiSPTheoDanhMuc(string para)
        {
            return DAL.LoaiSP_DAL.LayLoaiSPTheoDanhMuc(para);
        }
    }
}

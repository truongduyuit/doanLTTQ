using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class DanhMucBLL
    {
        public static List<DanhMucDTO> LayDanhMuc()
        {
            return DAL.DanhMucDAL.LayDanhMuc();
        }
    }
}

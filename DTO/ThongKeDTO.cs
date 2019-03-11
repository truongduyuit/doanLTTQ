using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {

        public class TK_SP
        {
            public string tensp { get; set; }
            public int soluong { get; set; }
        }

        public class TK_NV
        {
            public string manv { get; set; }
            public string hoten { get; set; }
            public int soluong { get; set; }
        }

        public class TK_KH
        {
            public string makh { get; set; }
            public string hoten { get; set; }
            public int soluong { get; set; }
        }

        public class TK_HD
        {
            public int sohd { get; set; }
            public DateTime ngayhd { get; set; }
            public int trigia { get; set; }

        }
    }
}

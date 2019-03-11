using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Cmnd { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDK { get; set; }
        public string Loai { get; set; }
        public uint DoanhSo { get; set; }

    }
}

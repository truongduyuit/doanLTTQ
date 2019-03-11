using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; } 
        public string TenSP { get; set; }
        public string TenDanhMuc { get; set; }
        public string TenLoaiSP { get; set; }
        public string XuatXu { get; set; }
        public string DonViTinh { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
    }
}

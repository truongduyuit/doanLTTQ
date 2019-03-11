using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class SanPhamBLL
    {
        public static List<SanPhamDTO> LayDanhSachSanPham()
        {
            return DAL.SanPhamDAL.LayDanhSachSanPham();
        }

        public static List<SanPhamDTO> LaySanPhamTheoDanhMuc(string tendanhmuc)
        {
            return DAL.SanPhamDAL.LaySanPhamTheoDanhMuc(tendanhmuc);
        }

        public static List<SanPhamDTO> LaySanPhamTheoDanhMucLoaiSP(string tendanhmuc, string tenloaisp)
        {
            return DAL.SanPhamDAL.LaySanPhamTheoDanhMucLoaiSP(tendanhmuc,tenloaisp);
        }

        public static List<SanPhamDTO> LaySPTheoTuKhoa(string tukhoa)
        {
            return DAL.SanPhamDAL.LaySPTheoTuKhoa(tukhoa);
        }

        public static bool ThemSanPham(SanPhamDTO sp)
        {
            return DAL.SanPhamDAL.ThemSanPham(sp);
        }

        public static bool SuaSanPham(SanPhamDTO sp)
        {
            return DAL.SanPhamDAL.SuaSanPham(sp);
        }

        public static List<string> LayDanhSachMaSP()
        {
            return DAL.SanPhamDAL.LayDanhSachMaSP();
        }

        public static bool XoaSanPhamTheoMaSP(string masp)
        {
            return DAL.SanPhamDAL.XoaSanPhamTheoMaSP(masp);
        }

        public static List<SanPhamDTO> TimSapXepGiaTu(string loaisp, int giatu)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTu(loaisp, giatu);
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDen(string loaisp, int giatu, int giaden)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTuDen(loaisp, giatu, giaden);
        }

        public static List<SanPhamDTO> TimSapXepGiaDen(string loaisp, int giaden)
        { 
            return DAL.SanPhamDAL.TimSapXepGiaDen(loaisp, giaden);
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDM(string danhmuc, int giatu)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTuDM(danhmuc, giatu);
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDenDM(string danhmuc, int giatu, int giaden)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTuDenDM(danhmuc, giatu, giaden);
        }

        public static List<SanPhamDTO> TimSapXepGiaDenDM(string danhmuc, int giaden)
        {
            return DAL.SanPhamDAL.TimSapXepGiaDenDM(danhmuc, giaden);
        }


        public static List<SanPhamDTO> TimSapXepGiaTuDMALL(int giatu)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTuDMALL(giatu);
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDenDMALL( int giatu, int giaden)
        {
            return DAL.SanPhamDAL.TimSapXepGiaTuDenDMALL(giatu, giaden);
        }

        public static List<SanPhamDTO> TimSapXepGiaDenDMALL(int giaden)
        {
            return DAL.SanPhamDAL.TimSapXepGiaDenDMALL(giaden);
        }
    }
}

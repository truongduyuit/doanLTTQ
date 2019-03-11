using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SanPhamDAL
    {
        public static List<SanPhamDTO> LayDanhSachSanPham()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayToanBoSanPham");
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> LaySanPhamTheoDanhMuc(string tendanhmuc)
        {
            SqlDataReader reader = DataProvider.TruyVanSPTheoDanhMuc("LaySPTheoDanhMuc", tendanhmuc);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            try
            {
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP = reader.GetString(0);
                    sp.TenSP = reader.GetString(1);
                    sp.TenLoaiSP = reader.GetString(3);
                    sp.TenDanhMuc = reader.GetString(2);
                    sp.XuatXu = reader.GetString(4);
                    sp.DonViTinh = reader.GetString(5);
                    sp.GiaBan = (int)reader.GetDecimal(6);
                    sp.SoLuong = reader.GetInt32(7);
                    lsp.Add(sp);
                }
                reader.Close();
            }
            catch 
            {
                
            }

            return lsp;
        }

        public static List<SanPhamDTO> LaySanPhamTheoDanhMucLoaiSP(string tendanhmuc, string tenloaisp)
        {
            SqlDataReader reader = DataProvider.TruyVanSPTheoDanhMucLoaiSP("LaySPTheoDanhMucLoaiSP", tendanhmuc, tenloaisp);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            try
            {
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP = reader.GetString(0);
                    sp.TenSP = reader.GetString(1);
                    sp.TenLoaiSP = reader.GetString(3);
                    sp.TenDanhMuc = reader.GetString(2);
                    sp.XuatXu = reader.GetString(4);
                    sp.DonViTinh = reader.GetString(5);
                    sp.GiaBan = (int)reader.GetDecimal(6);
                    sp.SoLuong = reader.GetInt32(7);
                    lsp.Add(sp);
                }
                reader.Close();
            }
            catch
            {

            }

            return lsp;
        }

        public static List<SanPhamDTO> LaySPTheoTuKhoa(string tukhoa)
        {
            SqlDataReader reader = DataProvider.TruyVanSPTheoTuKhoa("LaySPTheoTuKhoa", tukhoa);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            try
            {
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP = reader.GetString(0);
                    sp.TenSP = reader.GetString(1);
                    sp.TenLoaiSP = reader.GetString(3);
                    sp.TenDanhMuc = reader.GetString(2);
                    sp.XuatXu = reader.GetString(4);
                    sp.DonViTinh = reader.GetString(5);
                    sp.GiaBan =(int) reader.GetDecimal(6);
                    sp.SoLuong = reader.GetInt32(7);
                    lsp.Add(sp);
                }
                reader.Close();
            }
            catch
            {

            }

            return lsp;
        }

        public static bool ThemSanPham(SanPhamDTO sp)
        {
            return DataProvider.ThemSanPham("ThemSanPham", sp);           
        }

        public static bool SuaSanPham(SanPhamDTO sp)
        {
            return DataProvider.ThemSanPham("SuaSanPham", sp);
        }

        public static bool XoaSanPhamTheoMaSP(string masp)
        {
            return DataProvider.XoaSanPhamTheoMaSP("XoaSanPhamTheoMasP", masp);
        }

        public static List<string> LayDanhSachMaSP()
        {
            SqlDataReader reader = DataProvider.TruyVanSqlDataReader("LayDanhSachMaSP");
            List<string> dssp = new List<string>();
            while(reader.Read())
            {
                string sp = reader.GetString(0);
                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }

        public static List<SanPhamDTO> TimSapXepGiaTu(string loaisp, int giatu)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTu("TimSapXepGiaTu", loaisp, giatu);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDen(string loaisp, int giatu, int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTuDen("TimSapXepGiaTuDen", loaisp, giatu, giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaDen(string loaisp, int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaDen("TimSapXepGiaDen", loaisp, giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }


        // Danh mục
        public static List<SanPhamDTO> TimSapXepGiaTuDM(string danhmuc, int giatu)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTu("TimSapXepGiaTuDM", danhmuc, giatu);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDenDM(string danhmuc, int giatu, int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTuDen("TimSapXepGiaTuDenDM", danhmuc, giatu, giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaDenDM(string danhmuc, int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaDen("TimSapXepGiaDenDM", danhmuc, giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }


        public static List<SanPhamDTO> TimSapXepGiaTuDMALL(int giatu)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTuALL("TimSapXepGiaTuALL", giatu);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaTuDenDMALL(int giatu, int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaTuDenALL("TimSapXepGiaTuDenALL", giatu, giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

        public static List<SanPhamDTO> TimSapXepGiaDenDMALL(int giaden)
        {
            SqlDataReader reader = DataProvider.TimSapXepGiaDenALL("TimSapXepGiaDenALL", giaden);
            List<SanPhamDTO> lsp = new List<SanPhamDTO>();
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenDanhMuc = reader.GetString(2);
                sp.TenLoaiSP = reader.GetString(3);
                sp.XuatXu = reader.GetString(4);
                sp.DonViTinh = reader.GetString(5);
                sp.GiaBan = (int)reader.GetDecimal(6);
                sp.SoLuong = reader.GetInt32(7);
                lsp.Add(sp);
            }
            reader.Close();
            return lsp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DataProvider
    {

        public static SqlConnection KetNoi()
        {
            SqlConnection conn = null;
            string strConn = @"Data Source=.;Initial Catalog=QuanLiNhaSachLTTQ;Integrated Security=True";

            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public static SqlDataReader TruyVanSqlDataReader(string sStoredProcedure)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();
                SqlDataReader reader = cmd.ExecuteReader();              
                return reader;
            }
            catch { }
            return null;
        }
// Sản phẩm
        public static SqlDataReader TruyVan1ParaString(string sStoredProcedure, string para)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@madanhmuc", para);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }
       
        public static SqlDataReader TruyVanSPTheoDanhMuc(string sStoredProcedure, string para)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tendanhmuc", para);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TruyVanSPTheoDanhMucLoaiSP(string sStoredProcedure, string tendanhmuc, string tenloaisp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tendanhmuc", tendanhmuc);
                cmd.Parameters.AddWithValue("@tenloaisp", tenloaisp);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TruyVanSPTheoTuKhoa(string sStoredProcedure, string tukhoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static bool ThemSanPham(string sStoredProcedure, SanPhamDTO sp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@masp",sp.MaSP );
                cmd.Parameters.AddWithValue("@tensp", sp.TenSP);
                cmd.Parameters.AddWithValue("@tendanhmuc", sp.TenDanhMuc);
                cmd.Parameters.AddWithValue("@tenloaisp", sp.TenLoaiSP);
                cmd.Parameters.AddWithValue("@xuatxu", sp.XuatXu);
                cmd.Parameters.AddWithValue("@dvt", sp.DonViTinh);
                cmd.Parameters.AddWithValue("@giaban", sp.GiaBan);
                cmd.Parameters.AddWithValue("@soluong", sp.SoLuong);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch { }
            return false;
        }
        public static bool XoaSanPhamTheoMaSP(string sStoredProcedure, string masp)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@masp", masp);

                cmd.ExecuteNonQuery();                
                return true;
            }
            catch { }
            return false;
        }

        public static SqlDataReader TimSapXepGiaTu(string sStoredProcedure, string loaisp, int gia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@loaisp", loaisp);
                cmd.Parameters.AddWithValue("@giatu", gia);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TimSapXepGiaTuDen(string sStoredProcedure, string loaisp, int giatu, int giaden)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@loaisp", loaisp);
                cmd.Parameters.AddWithValue("@giatu", giatu);
                cmd.Parameters.AddWithValue("@giaden", giaden);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }
        public static SqlDataReader TimSapXepGiaDen(string sStoredProcedure, string loaisp, int giaden)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@loaisp", loaisp);
                cmd.Parameters.AddWithValue("@giaden", giaden);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }


        // ALL
        public static SqlDataReader TimSapXepGiaTuALL(string sStoredProcedure, int gia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@giatu", gia);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TimSapXepGiaTuDenALL(string sStoredProcedure, int giatu, int giaden)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@giatu", giatu);
                cmd.Parameters.AddWithValue("@giaden", giaden);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }
        public static SqlDataReader TimSapXepGiaDenALL(string sStoredProcedure, int giaden)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@giaden", giaden);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        // Nhân viên
        public static bool ThemNhanvien(string sStoredProcedure, NhanVienDTO nv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@manv", nv.MaNV);
                cmd.Parameters.AddWithValue("@hoten", nv.HoTen);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@ngayvaolam", nv.NgayVaoLam);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@cmnd", nv.CMND);
                cmd.Parameters.AddWithValue("@anh", nv.Anh);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {                
            }
            return false;
        }

        public static bool XoaNhanVien(string sStoredProcedure, string manv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@manv", manv);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch { }
            return false;
        }

        public static SqlDataReader TimNhanVienTheoMaNV(string sStoredProcedure, string manv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@manv", manv);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TimNhanVienTheoChucVu(string sStoredProcedure, string chucvu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@chucvu", chucvu);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

        public static SqlDataReader TimNhanVienTheoTuKhoa(string sStoredProcedure, string tukhoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch { }
            return null;
        }

 
// Hóa đơn
        
        public static bool ThemHoaDon(string sStoredProcedure, HoaDonDTO hd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", hd.SoHD);
                cmd.Parameters.AddWithValue("@makh", hd.MaKH);
                cmd.Parameters.AddWithValue("@manv", hd.MaNV);
                cmd.Parameters.AddWithValue("@ngayhoadon", hd.NgayHoaDon);
                cmd.Parameters.AddWithValue("@trigia", (Decimal)hd.TriGia);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

            }
            return false;
        }

        public static bool XoaHoaDon(string sStoredProcedure, int sohd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", sohd);
                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {
                
            }
            return false;
        }

        public static SqlDataReader TimHoaDonTheoTuKhoa(string sStoredProcedure, string tukhoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }
            return null;
        }

        public static SqlDataReader TimHoaDonTheoSoHD(string sStoredProcedure, int sohd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", sohd);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }
            return null;
        }

        // Cấu trúc hóa đơn
        public static SqlDataReader LayCTHD(string sStoredProcedure, int sohd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedure;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", sohd);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }
            return null;
        }

        public static bool ThemCTHD (string sStoredProcedue, CTHD_DTO cthd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", cthd.SoHD);
                cmd.Parameters.AddWithValue("@tensp", cthd.TenSP);
                cmd.Parameters.AddWithValue("@soluong", cthd.SoLuong);
                cmd.Parameters.AddWithValue("@trigia", (Decimal)cthd.TriGia);


                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {
                
            }
            return false;
        }

        public static bool XoaCTHD(string sStoredProcedue, int sohd, string tensp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@sohd", sohd);
                cmd.Parameters.AddWithValue("@tensp", tensp);

                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {

            }

            return false;
        }

 // Khách hàng
        public static bool ThemKhachHang(string sStoredProcedue, KhachHangDTO kh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@makh", kh.MaKH);
                cmd.Parameters.AddWithValue("@hoten", kh.HoTen);
                cmd.Parameters.AddWithValue("@ngaysinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@cmnd", kh.Cmnd);
                cmd.Parameters.AddWithValue("@sdt", kh.Sdt);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@ngaydk", kh.NgayDK);
                cmd.Parameters.AddWithValue("@loai", kh.Loai);
                cmd.Parameters.AddWithValue("@doanhso",(Decimal) kh.DoanhSo);


                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {

            }

            return false;
        }
        
        public static bool XoaKhachHang(string sStoredProcedue, string MaKH)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@makh", MaKH);

                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {

            }

            return false;
        }

        public static SqlDataReader TimKhachHangTheoTuKhoa(string sStoredProcedue, string tukhoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                SqlDataReader reader=  cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }

            return null;
        }

        public static SqlDataReader TimKhachHangTheoLoaiKH(string sStoredProcedue, string loaikh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@loai", loaikh);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }

            return null;
        }

        public static SqlDataReader TimKhachHangTheoTuKhoaLoai(string sStoredProcedue, string tukhoa, string loai)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
                cmd.Parameters.AddWithValue("@loai", loai);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }

            return null;
        }

 // Thống kê

        public static SqlDataReader ThongKe(string sStoredProcedue, int ngay, int thang, int nam)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);

                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {

            }

            return null;
        }

// Tài  khoản

        public static bool ThemTaiKhoan(string sStoredprocedue, string tk, string mk, string manv, string chucvu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredprocedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@taikhoan", tk);
                cmd.Parameters.AddWithValue("@matkhau", mk);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@chucvu", chucvu);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
            }
            catch
            {

            }

            return false;
        }

        public static bool SuaMatKhau(string sStoredProcedue, string tk, string pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@taikhoan", tk);
                cmd.Parameters.AddWithValue("@matkhau", pass);
                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }

        public static bool XoaTK(string sStoredProcedue, string manv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoredProcedue;
                cmd.Connection = KetNoi();

                cmd.Parameters.AddWithValue("@manv", manv);
                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }
    }
}

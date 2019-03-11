using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using Facebook;
using System.Dynamic;

namespace DuAnQuanLiNhaSach
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public string manv;
        public string chucvu;
        public string id;
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain _frmMain;
        public static frmMain FrmMain
        {
            get
            {
                if (_frmMain == null)
                    _frmMain = new frmMain();
                return _frmMain;
            }
            set
            {
                _frmMain = value;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string sqlConnectionString = @"Data Source=.;Initial Catalog=QuanLiNhaSachLTTQ;Integrated Security=True";
            //    using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            //    {
            //        string script = File.ReadAllText(Application.StartupPath + "\\data.sql");
            //        IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
            //                   RegexOptions.Multiline | RegexOptions.IgnoreCase);
            //        conn.Open();
            //        foreach (string commandString in commandStrings)
            //        {
            //            if (commandString.Trim() != "")
            //            {
            //                using (var command = new SqlCommand(commandString, conn))
            //                {
            //                    command.ExecuteNonQuery();
            //                }
            //            }
            //        }
            //        conn.Close();
            //    }
            //}
            //catch { };

            toolID.Text = "Xin chào, " + manv;
            if (chucvu != "Admin")
            {
                btnThemNV.Enabled = false;
                btnSuaNV.Enabled = false;
                btnXoaNV.Enabled = false;

                btnXoaThongBao.Enabled = false;
                richThongBao.Enabled = false;

                btnThongKeNV.Enabled = false;
                radNV.Enabled = false;
                btnThongKeKH.Enabled = false;
                radKH.Enabled = false;
                toolThemTaiKhoan.Enabled = false;
            }

            TabPages.SelectedIndex = 0;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            DateTime datetime = DateTime.Now;
            lblDate.Text = datetime.ToShortDateString();
// SANPHAM
            LockInsert();
            LoadDanhMuc();
            LoadSP();
// HOADON
            LockInsertHD();
            LoadDanhSachHoaDon();
            btnLuuHD.Enabled = false;
            btnHuyHD.Enabled = false;

// NHANVIEN
            LockInsertNV();
            LoadDanhSachNhanVien();
            btnLuuNV.Enabled = false;
            btnHuyNV.Enabled = false;

 // KHACHHANG

            LoadDanhSachKhachHang();
            LockInsertKH();

// THONGKE

            KhoiTaoThongKe();
        }



        private void LockInsert()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtDVT.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = false;
            txtXuatXu.Enabled = false;

            cbbDanhMuc1.Enabled = false;
            cbbLoaiSP1.Enabled = false;
        }

        private void AllowInsert()
        {
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtDVT.Enabled = true;
            txtGiaBan.Enabled = true;
            txtSoLuong.Enabled = true;
            txtXuatXu.Enabled = true;

            cbbDanhMuc1.Enabled = true;
            cbbLoaiSP1.Enabled = true;
        }

        private void ClearToInsert()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDVT.Text = "";
            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtXuatXu.Text = "";

            cbbDanhMuc1.Text = "";
            cbbLoaiSP1.Text = "";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            lblTime.Text = datetime.ToLongTimeString();
        }

        private string Ten(string ten)
        {
            string result = "";
            string[] words = ten.Split(' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }

            }

            return result.Trim();
        }

        private void GhiThongBao(string str)
        {
            richThongBao.AppendText(DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToShortTimeString() + ":\n" + str + "\n");
        }

//SanPham code ở đây


        private void KiemTraSL(List<SanPhamDTO> lsp)
        {
            //richThongBao.AppendText(DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToShortTimeString() + ":\n");
            foreach (SanPhamDTO sp in lsp)
            {               
                if (sp.SoLuong < 10)
                {
                    richThongBao.AppendText("\t" + sp.TenSP + " chỉ còn " + sp.SoLuong + " "+ sp.DonViTinh + "\n");
                }
            }
        }
        public void LoadSP()
        {
            List<SanPhamDTO> lsp = BLL.SanPhamBLL.LayDanhSachSanPham();
            data.DataSource = lsp;
            KiemTraSL(lsp);
        }

        private void LoadDanhMuc()
        {
            List<DanhMucDTO> danhmuc = BLL.DanhMucBLL.LayDanhMuc();
            if (danhmuc.Count > 0)
            {
                foreach (DanhMucDTO d in danhmuc)
                {
                    cbbDanhMuc.Items.Add(d.TenDanhMuc);
                    cbbDanhMuc1.Items.Add(d.TenDanhMuc);
                }
            }
        }

        public void LoadLoaiSP(string para)
        {
            
            List<LoaiSP> loaisp = BLL.LoaiSP_BLL.LayLoaiSPTheoDanhMuc(para);
            if (loaisp.Count > 0)
            {
                foreach (LoaiSP sp in loaisp)
                {
                    cbbLoaiSP.Items.Add(sp.TenLoaiSP);
                }
            }
            if (cbbLoaiSP.Items.Count == 0)
            {
                cbbLoaiSP.Items.Add("Chưa cập nhật");
            }
        }

        private void cbbDanhMuc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSP.Items.Count > 0)
            {
                cbbLoaiSP.Items.Clear();
            }

            List<DanhMucDTO> danhmuc = BLL.DanhMucBLL.LayDanhMuc();
            if (danhmuc.Count > 0)
            {
                foreach (DanhMucDTO d in danhmuc)
                {
                    if (d.TenDanhMuc == cbbDanhMuc.SelectedItem.ToString())
                    {
                        LoadLoaiSP(d.MaDanhMuc);
                    }
                }
            }
        }
        private void cbbDanhMuc1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSP1.Items.Count > 0)
            {
                cbbLoaiSP1.Items.Clear();
            }

            List<DanhMucDTO> danhmuc = BLL.DanhMucBLL.LayDanhMuc();
            if (danhmuc.Count > 0)
            {
                foreach (DanhMucDTO d in danhmuc)
                {
                    if (d.TenDanhMuc == cbbDanhMuc1.SelectedItem.ToString())
                    {
                        List<LoaiSP> loaisp = BLL.LoaiSP_BLL.LayLoaiSPTheoDanhMuc(d.MaDanhMuc);
                        if (loaisp.Count > 0)
                        {
                            foreach (LoaiSP sp in loaisp)
                            {
                                cbbLoaiSP1.Items.Add(sp.TenLoaiSP);
                            }
                        }
                        if (cbbLoaiSP1.Items.Count == 0)
                        {
                            cbbLoaiSP1.Items.Add("Chưa cập nhật");
                        }
                    }
                }
            }
        }

        private void data_SelectionChanged(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                try
                {
                    DataGridViewRow row = data.CurrentRow;
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                    txtTenSP.Text = row.Cells[1].Value.ToString();
                    txtXuatXu.Text = row.Cells[4].Value.ToString();
                    txtDVT.Text = row.Cells[5].Value.ToString();
                    txtSoLuong.Text = row.Cells[7].Value.ToString();
                    txtGiaBan.Text = row.Cells[6].Value.ToString();

                    cbbDanhMuc.SelectedText = row.Cells[2].Value.ToString();
                    cbbLoaiSP.SelectedText = row.Cells[3].Value.ToString();

                    cbbDanhMuc1.Text = row.Cells[2].Value.ToString();
                    cbbLoaiSP1.Text = row.Cells[3].Value.ToString();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                catch
                {

                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                if (cbbDanhMuc.SelectedItem == null || cbbDanhMuc.SelectedItem.ToString() == "Tất cả")
                {
                    if (txtGiaTu.Text.Trim() == "" && txtGiaDen.Text.Trim() == "")
                    {
                        LoadSP();
                    }
                    if (txtGiaDen.Text.Trim() == "" && txtGiaTu.Text.Trim() != "")
                    {
                        List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTuDMALL(int.Parse(txtGiaTu.Text));
                        data.DataSource = sp;
                    }
                    if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() != "")
                    {
                        List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTuDenDMALL( int.Parse(txtGiaTu.Text), int.Parse(txtGiaDen.Text));
                        data.DataSource = sp;
                    }
                    if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() == "")
                    {
                        List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaDenDMALL(int.Parse(txtGiaDen.Text));
                        data.DataSource = sp;
                    }
                }
                else
                {
                    if (cbbLoaiSP.SelectedItem == null)
                    {
                        if (txtGiaTu.Text.Trim() == "" && txtGiaDen.Text.Trim() == "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.LaySanPhamTheoDanhMuc(cbbDanhMuc.Text);
                            data.DataSource = sp;
                        }

                        if (txtGiaDen.Text.Trim() == "" && txtGiaTu.Text.Trim() != "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTuDM(cbbDanhMuc.Text, int.Parse(txtGiaTu.Text));
                            data.DataSource = sp;
                        }
                        if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() != "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTuDenDM(cbbDanhMuc.Text, int.Parse(txtGiaTu.Text), int.Parse(txtGiaDen.Text));
                            data.DataSource = sp;
                        }
                        if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() == "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaDenDM(cbbDanhMuc.Text, int.Parse(txtGiaDen.Text));
                            data.DataSource = sp;
                        }
                    }
                    else
                    {
                        //MessageBox.Show(cbbDanhMuc.Text, cbbLoaiSP.Text);

                        if (txtGiaTu.Text.Trim() == "" && txtGiaDen.Text.Trim() == "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.LaySanPhamTheoDanhMucLoaiSP(cbbDanhMuc.Text, cbbLoaiSP.Text);
                            data.DataSource = sp;
                        }
                        if (txtGiaDen.Text.Trim() == "" && txtGiaTu.Text.Trim() != "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTu(cbbLoaiSP.Text, int.Parse(txtGiaTu.Text));
                            data.DataSource = sp;
                        }
                        if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() != "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaTuDen(cbbLoaiSP.Text, int.Parse(txtGiaTu.Text), int.Parse(txtGiaDen.Text));
                            data.DataSource = sp;
                        }
                        if (txtGiaDen.Text.Trim() != "" && txtGiaTu.Text.Trim() == "")
                        {
                            List<SanPhamDTO> sp = BLL.SanPhamBLL.TimSapXepGiaDen(cbbLoaiSP.Text, int.Parse(txtGiaDen.Text));
                            data.DataSource = sp;
                        }
                    }
                }
            }
            else
            {
                List<SanPhamDTO> sp = BLL.SanPhamBLL.LaySPTheoTuKhoa(txtTuKhoa.Text);
                data.DataSource = sp;
            }

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm thỏa mãn", "Thông báo");
            }
        }

        private bool KiemTraInsert()
        {
// mã sản phẩm
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }
            if (txtMaSP.Text.Length >=20)
            {
                MessageBox.Show("Mã sản phẩm phải ít hơn 20 kí tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }

// tên sản phẩm
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return false;
            }
            if (txtTenSP.Text.Length >= 50)
            {
                MessageBox.Show("Tên sản phẩm phải ít hơn 50 kí tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return false;
            }
// xuất xứ
            if (txtXuatXu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập xuất xứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtXuatXu.Focus();
                return false;
            }
            if (txtTenSP.Text.Length >= 20)
            {
                MessageBox.Show("Nơi xuất xứ phải ít hơn 20 kí tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtXuatXu.Focus();
                return false;
            }
// đơn vị tính
            if (txtDVT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDVT.Focus();
                return false;
            }
            if (txtDVT.Text.Length >= 20)
            {
                MessageBox.Show("Đơn vị tính phải ít hơn 20 kí tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDVT.Focus();
                return false;
            }
 // gia ban
            if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return false;
            }
            if (int.Parse(txtGiaBan.Text) <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return false;
            }
// số lượng
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }
            if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }
// danh mục
            if (cbbDanhMuc1.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn danh mục", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                cbbDanhMuc1.Focus();
                return false;
            }
// loại sản phẩm
            if (cbbLoaiSP1.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                cbbLoaiSP1.Focus();
                return false;
            }
            return true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu";

                AllowInsert();
                ClearToInsert();
                btnHuy.Visible = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else if (btnThem.Text == "Lưu")
            {

                if (KiemTraInsert())
                {                   
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP = txtMaSP.Text;
                    sp.TenSP = txtTenSP.Text;
                    sp.TenDanhMuc = cbbDanhMuc1.Text;
                    sp.TenLoaiSP = cbbLoaiSP1.Text;
                    sp.XuatXu = txtXuatXu.Text;
                    sp.DonViTinh = txtDVT.Text;
                    sp.GiaBan = int.Parse(txtGiaBan.Text);
                    sp.SoLuong = int.Parse(txtSoLuong.Text);

                    if (BLL.SanPhamBLL.ThemSanPham(sp))
                    {
                        MessageBox.Show("Thêm thành công");
                        string str =  "\tĐã thêm sản phẩm: " + sp.TenSP;
                        GhiThongBao(str);
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        
                    }
                    LoadSP();
                    
                }
                else
                {
                    return;
                }
                btnThem.Text = "Thêm";
                LockInsert();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Phải chọn 1 sản phẩm để sửa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                AllowInsert();
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Visible = true;
            }
            else if (btnSua.Text == "Lưu")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn chỉnh sửa sản phẩm ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //DataGridViewRow row = data.CurrentRow;
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSP = txtMaSP.Text;
                    sp.TenSP = txtTenSP.Text;
                    sp.TenDanhMuc = cbbDanhMuc1.Text;
                    sp.TenLoaiSP = cbbLoaiSP1.Text;
                    sp.XuatXu = txtXuatXu.Text;
                    sp.DonViTinh = txtDVT.Text;
                    sp.GiaBan = int.Parse(txtGiaBan.Text);
                    sp.SoLuong = int.Parse(txtSoLuong.Text);

                     if (BLL.SanPhamBLL.SuaSanPham(sp))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        string str = "\tCập nhật sản phẩm " + sp.TenSP + " thành công";
                        GhiThongBao(str);
                    }
                     else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK);

                    }
                    LoadSP();

                    btnSua.Text = "Sửa";
                    btnHuy.Visible = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    LockInsert();
                    
                }
                else
                {

                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = data.CurrentRow;
            string masp = row.Cells[0].Value.ToString();
            string tensp = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa sản phẩm có mã " + masp , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                BLL.SanPhamBLL.XoaSanPhamTheoMaSP(masp);
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                LoadSP();
                string str = "\tĐã xóa sản phẩm: " + tensp ;
                GhiThongBao(str);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if( result == DialogResult.OK)
            {
                LockInsert();
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Visible = false;
            }
        }

        private void data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SanPhamDTO sp = new SanPhamDTO();
                DataGridViewRow row = data.CurrentRow;
                sp.MaSP = row.Cells[0].Value.ToString();
                sp.TenSP = row.Cells[1].Value.ToString();
                sp.XuatXu = row.Cells[4].Value.ToString();
                sp.DonViTinh = row.Cells[5].Value.ToString();
                sp.SoLuong = Convert.ToInt32(row.Cells[7].Value.ToString());
                sp.GiaBan = Convert.ToInt32(row.Cells[6].Value.ToString());

                sp.TenDanhMuc = row.Cells[2].Value.ToString();
                sp.TenLoaiSP = row.Cells[3].Value.ToString();

                cbbDanhMuc1.Text = row.Cells[2].Value.ToString();
                cbbLoaiSP1.Text = row.Cells[3].Value.ToString();

                if (BLL.SanPhamBLL.SuaSanPham(sp))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    string str = "\tCập nhật sản phẩm " + sp.TenSP + " thành công";
                    GhiThongBao(str);
                }
                
                LoadSP();

                
            }
            catch
            {
                
            }            
        }


// NHANVIEN code ở đây
        private void btnChonAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter =
                "All Image files|*.bmp;*.gif;*.jpg;*.ico;" +
                "*.emf;,*.wmf|Bitmap Files(*.bmp;*.gif;*.jpg;" +
                "*.ico)|*.bmp;*.gif;*.jpg;*.ico|" +
                "Meta Files(*.emf;*.wmf;*.png)|*.emf;*.wmf;*.png";
            opnDlg.Title = "Mời bạn chọn ảnh";
            opnDlg.ShowHelp = true;

            string curFileName;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opnDlg.FileName;
                try
                {
                    pictureNV.Image = Image.FromFile(curFileName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private byte[] ConvertImageToBytes(Image img)
        {
            byte[] arr;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            return arr;
        }

        private Image ConvertBytesToImage(byte[] arr)
        {
            Image img;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(arr))
            {
                img = Image.FromStream(ms);
            }
            return img;
        }

        private void LoadDanhSachNhanVien()
        {
            List<NhanVienDTO> lnv = BLL.NhanVienBLL.LayDanhSachNhanVien();
            dataNV.DataSource = lnv;
        }
        private void LockInsertNV()
        {
            txtMaNV.Enabled = false;
            txtHoTenNV.Enabled = false;
            dateNgaySinhNV.Enabled = false;
            dateNgayVaoLam.Enabled = false;
            txtSDT_NV.Enabled = false;
            txtDiaChiNV.Enabled = false;
            txtChucVuNV.Enabled = false;
            txtCMND_NV.Enabled = false;
            btnChonAnhNV.Visible = false;
        }

        private void AllowInsertNV()
        {
            txtMaNV.Enabled = true;

            txtHoTenNV.Enabled = true;
            dateNgaySinhNV.Enabled = true;
            dateNgayVaoLam.Enabled = true;
            txtSDT_NV.Enabled = true;
            txtDiaChiNV.Enabled = true;
            txtChucVuNV.Enabled = true;
            txtCMND_NV.Enabled = true;
            btnChonAnhNV.Visible = true;
        }

        private void ClearInsertNV()
        {
            pictureNV.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Policeman-icon.png");
            txtHoTenNV.Text = "";
            txtSDT_NV.Text = "";
            txtDiaChiNV.Text = "";
            txtChucVuNV.Text = "";
            txtCMND_NV.Text = "";
            dateNgaySinhNV.Value = DateTime.Now;
            dateNgayVaoLam.Value = DateTime.Now;
        }

        private bool KiemTraInsertNV()
        {
            if (txtHoTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtHoTenNV.Focus();
                return false;
            }
            if (txtSDT_NV.Text.Length != 10)
            {
                MessageBox.Show("Sô điện thoại phải có 10 chữ số", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSDT_NV.Focus();
                return false;
            }
            if (txtSDT_NV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSDT_NV.Focus();
                return false;
            }
            if (txtDiaChiNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDiaChiNV.Focus();
                return false;
            }
            if (txtChucVuNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtChucVuNV.Focus();
                return false;
            }
            if (txtCMND_NV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số chứng minh nhân dân", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtCMND_NV.Focus();
                return false;
            }


            return true;
        }
        private string status;
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            status = "Thêm";
            AllowInsertNV();
            ClearInsertNV();
            btnThemNV.Enabled = false;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnHuyNV.Enabled = true;

            txtMaNV.Text = "NV" + Convert.ToString(dataNV.Rows.Count + 1);
        }

        private Image i;
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            status = "Sửa";
            i = pictureNV.Image;
            if (dataNV.SelectedCells.Count != 1)
            {
                MessageBox.Show("Phải chọn duy nhất 1 nhân viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AllowInsertNV();

                btnThemNV.Enabled = false;
                btnSuaNV.Enabled = false;
                btnXoaNV.Enabled = false;
                btnLuuNV.Enabled = true;
                btnHuyNV.Enabled = true;
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dataNV.SelectedCells.Count != 1 && dataNV.SelectedRows.Count != 1)
            {
                MessageBox.Show("Phải chọn duy nhất 1 nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa ", " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow row = dataNV.CurrentRow;
                    string ten = row.Cells[1].Value.ToString();
                    if (BLL.NhanVienBLL.XoaNhanVien(row.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadDanhSachNhanVien();

                        string str = "\tĐã xóa nhân viên: " + ten;
                        GhiThongBao(str);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = Ten(txtHoTenNV.Text);
            nv.NgaySinh = dateNgaySinhNV.Value;
            nv.NgayVaoLam = dateNgayVaoLam.Value;
            nv.SDT = txtSDT_NV.Text;
            nv.DiaChi = txtDiaChiNV.Text;
            nv.ChucVu = txtChucVuNV.Text;
            nv.CMND = txtCMND_NV.Text;

            if (status == "Thêm")
            {
                nv.Anh = ConvertImageToBytes(pictureNV.Image);
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (BLL.NhanVienBLL.ThemNhanVien(nv))
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                        string str = "\tĐã thêm nhân viên: " + nv.HoTen;
                        GhiThongBao(str);
                        btnThemNV.Enabled = true;
                        btnSuaNV.Enabled = true;
                        btnXoaNV.Enabled = true;
                        btnLuuNV.Enabled = false;
                        btnHuyNV.Enabled = false;
                        LoadDanhSachNhanVien();
                        LockInsertNV();
                        status = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }

            }
            else if (status == "Sửa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (i != pictureNV.Image)
                    {
                        nv.Anh = ConvertImageToBytes(pictureNV.Image);
                    }
                    else
                    {
                        nv.Anh = (byte[])dataNV.CurrentRow.Cells[8].Value;
                    }
                    if (BLL.NhanVienBLL.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        string str = "\tCập nhật nhân viên " + nv.HoTen + " thành công";
                        GhiThongBao(str);
                        btnThemNV.Enabled = true;
                        btnSuaNV.Enabled = true;
                        btnXoaNV.Enabled = true;
                        btnLuuNV.Enabled = false;
                        btnHuyNV.Enabled = false;
                        LoadDanhSachNhanVien();
                        LockInsertNV();
                        status = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }

            status = "";
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LockInsertNV();
                btnHuyNV.Enabled = false;
                btnLuuNV.Enabled = false;
                btnThemNV.Enabled = true;
                btnSuaNV.Enabled = true;
                btnXoaNV.Enabled = true;
            }
            status = "";
        }

        private void dataNV_SelectionChanged(object sender, EventArgs e)
        {
            if (btnThemNV.Enabled != false)
            {

                
                    try
                    {
                        DataGridViewRow row = dataNV.CurrentRow;
                        txtMaNV.Text = row.Cells[0].Value.ToString();
                        txtHoTenNV.Text = row.Cells[1].Value.ToString();
                        dateNgaySinhNV.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                        dateNgayVaoLam.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                        txtSDT_NV.Text = row.Cells[4].Value.ToString();
                        txtDiaChiNV.Text = row.Cells[5].Value.ToString();
                        txtChucVuNV.Text = row.Cells[6].Value.ToString();
                        txtCMND_NV.Text = row.Cells[7].Value.ToString();
                        pictureNV.Image = ConvertBytesToImage((byte[])row.Cells[8].Value);

                    }
                    catch
                    {
                        //MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
        }

        private void txtSDT_NV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_NV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSearch_MaNV_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch_ChucVu.Text = "";
            txtSearch_TuKhoa.Text = "";
        }

        private void txtSearch_ChucVu_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch_MaNV.Text = "";
            txtSearch_TuKhoa.Text = "";
        }

        private void txtSearch_TuKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch_MaNV.Text = "";
            txtSearch_ChucVu.Text = "";
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            if (txtSearch_MaNV.Text != "")
            {
                List<NhanVienDTO> lnv = BLL.NhanVienBLL.TimNhanVienTheoMaNV(txtSearch_MaNV.Text);
                dataNV.DataSource = lnv;
            }
            else if (txtSearch_ChucVu.Text != "")
            {
                List<NhanVienDTO> lnv = BLL.NhanVienBLL.TimNhanVienTheoChucVu(txtSearch_ChucVu.Text);
                dataNV.DataSource = lnv;
            }
            else if (txtSearch_TuKhoa.Text != "")
            {
                List<NhanVienDTO> lnv = BLL.NhanVienBLL.TimNhanVienTheoTuKhoa(txtSearch_TuKhoa.Text);
                dataNV.DataSource = lnv;
            }
            else
            {
                LoadDanhSachNhanVien();
            }
        }

        private void dataNV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (chucvu == "Admin")
            {

                try
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    DataGridViewRow row = dataNV.CurrentRow;
                    nv.MaNV = row.Cells[0].Value.ToString();
                    nv.HoTen = row.Cells[1].Value.ToString();
                    nv.NgaySinh = (DateTime)row.Cells[2].Value;
                    nv.NgayVaoLam = (DateTime)row.Cells[3].Value;
                    nv.SDT = row.Cells[4].Value.ToString();
                    nv.DiaChi = row.Cells[5].Value.ToString();

                    nv.ChucVu = row.Cells[6].Value.ToString();
                    nv.CMND = row.Cells[7].Value.ToString();
                    nv.Anh = (byte[])row.Cells[8].Value;

                    if (BLL.NhanVienBLL.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        string str = "\tCập nhật nhân viên " + nv.HoTen + " thành công";
                        GhiThongBao(str);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK);
                        
                    }
                }
                catch
                {

                }
            }
            LoadDanhSachNhanVien();
        }


// begin HOADON code
        public void LoadDanhSachHoaDon()
        {
            List<HoaDonDTO> hd = BLL.HoaDonBLL.LayDanhSachHoaDon();
            dataHD.DataSource = hd;
            LoadDanhSachKhachHang();
        }

        private void LockInsertHD()
        {
            txtSoHD.Enabled = false;
            txtMaKHHD.Enabled = false;
            txtMaNVHD.Enabled = false;
            dateHD.Enabled = false;
            txtTriGiaHD.Enabled = false;
        }

        private void AllowInsertHD()
        {
            txtMaKHHD.Enabled = true;
            txtMaNVHD.Enabled = true;
            dateHD.Enabled = true;            
        }

        private void ClearInsertHD()
        {
            txtMaKHHD.Text = "";
            txtMaNVHD.Text = "";
            dateHD.Value = DateTime.Now;
            txtTriGiaHD.Text = "0";
        }

        private void dataHD_SelectionChanged(object sender, EventArgs e)
        {
            if (btnThemHD.Enabled == true)
            {
                try
                {
                    DataGridViewRow row = dataHD.CurrentRow;
                    txtSoHD.Text = row.Cells[0].Value.ToString().Trim();
                    txtMaKHHD.Text = row.Cells[1].Value.ToString().Trim();
                    txtMaNVHD.Text = row.Cells[2].Value.ToString().Trim();
                    dateHD.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                    txtTriGiaHD.Text = row.Cells[4].Value.ToString().Trim();
                }
                catch
                {

                }
            }

        }

        private bool KiemTraInsertHD()
        {
            if (txtMaKHHD.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKHHD.Focus();
                return false;
            }
            if (txtMaNVHD.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNVHD.Focus();
                return false;
            }
            return true;
        }

        private string statusHD;
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            statusHD = "ThêmHD";
            AllowInsertHD();
            ClearInsertHD();
            txtSoHD.Text = (Convert.ToInt32(dataHD.Rows[dataHD.Rows.Count - 1].Cells[0].Value) + 1).ToString();
            btnThemHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnLuuHD.Enabled = true;
            btnHuyHD.Enabled = true;
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            statusHD = "SửaHD";
            if (dataHD.SelectedCells.Count != 1 && dataHD.SelectedRows.Count != 1)
            {
                MessageBox.Show("Phải chọn duy nhất 1 hóa đơn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AllowInsertHD();
                btnThemHD.Enabled = false;
                btnSuaHD.Enabled = false;
                btnXoaHD.Enabled = false;
                btnLuuHD.Enabled = true;
                btnHuyHD.Enabled = true;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (dataHD.SelectedCells.Count != 1 && dataHD.SelectedRows.Count != 1)
            {
                MessageBox.Show("Phải chọn 1 hóa đơn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataGridViewRow row = dataHD.CurrentRow;
                int sohd = int.Parse(row.Cells[0].Value.ToString());
                string hd = row.Cells[1].Value.ToString();
                if (BLL.HoaDonBLL.XoaHoaDon(sohd))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    string str = "\tĐã xóa hóa đơn: " + hd;
                    GhiThongBao(str);
                    LoadDanhSachHoaDon();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    MessageBox.Show("Phải xóa hết CTHD trước", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (statusHD == "ThêmHD")
            {                
                HoaDonDTO hd = new HoaDonDTO();
                hd.SoHD = int.Parse(txtSoHD.Text);
                hd.MaKH = txtMaKHHD.Text;
                hd.MaNV = txtMaNVHD.Text;
                hd.NgayHoaDon = dateHD.Value;
                hd.TriGia = 0;

                if (BLL.HoaDonBLL.ThemHoaDon(hd))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    string str = "\tĐã thêm hóa đơn: " + hd.SoHD;
                    GhiThongBao(str);
                    LockInsertHD();
                    LoadDanhSachHoaDon();
                    btnThemHD.Enabled = true;
                    btnSuaHD.Enabled = true;
                    btnXoaHD.Enabled = true;
                    btnLuuHD.Enabled = false;
                    btnHuyHD.Enabled = false;
                    statusHD = "";
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (statusHD == "SửaHD")
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SoHD = int.Parse(txtSoHD.Text);
                hd.MaKH = txtMaKHHD.Text;
                hd.MaNV = txtMaNVHD.Text;
                hd.NgayHoaDon = dateHD.Value;
                hd.TriGia =int.Parse(txtTriGiaHD.Text);
                //hd.TriGia = Decimal.Parse(txtTriGiaHD.Text);

                if (BLL.HoaDonBLL.SuaHoaDon(hd))
                {
                    MessageBox.Show("Chỉnh sửa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                    string str = "\tCập nhật hóa đơn " + hd.SoHD + " thành công";
                    GhiThongBao(str);
                    LockInsertHD();
                    LoadDanhSachHoaDon();
                    btnThemHD.Enabled = true;
                    btnSuaHD.Enabled = true;
                    btnXoaHD.Enabled = true;
                    btnLuuHD.Enabled = false;
                    btnHuyHD.Enabled = false;
                    statusHD = "";
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LockInsertHD();

                btnThemHD.Enabled = true;
                btnSuaHD.Enabled = true;
                btnXoaHD.Enabled = true;
                btnLuuHD.Enabled = false;
                btnHuyHD.Enabled = false;

            }
        }

        
        private void btnXemChiTietHD_Click(object sender, EventArgs e)
        {
            frmCTHD cthd = new frmCTHD();
            cthd.Text = "Chi tiết hóa đơn: " + txtSoHD.Text;
            //cthd.Controls["txtMaKH_CTHD"].Text = txtMaKHHD.Text;
            //cthd.Controls["txtMaNV_CTHD"].Text = txtMaNVHD.Text;
            
            cthd.LoadCTHD(BLL.CTHD_BLL.LayCTHD(int.Parse(txtSoHD.Text)));
            cthd.LoadTT(txtSoHD.Text, txtMaKHHD.Text, txtMaNVHD.Text,(DateTime)dateHD.Value);

            cthd.StartPosition = FormStartPosition.CenterScreen;
            cthd.MyStatus = new frmCTHD.LOADDATA(CapNhatSPHD);            
            cthd.ShowDialog();
           
        }

        public void CapNhatSPHD(string sohd)
        {
            string str = "\tCập nhật chi tiết hóa đơn: " + sohd;
            GhiThongBao(str);
            this.LoadSP();
            this.LoadDanhSachHoaDon();
        }
        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            if (txtTuKhoaHD.Text.Trim() != "")
            {
                List<HoaDonDTO> lhd = BLL.HoaDonBLL.LayHoaDonTheoTuKhoa(txtTuKhoaHD.Text);
                dataHD.DataSource = lhd;
            }
            else
            {
                LoadDanhSachHoaDon();
            }
        }

        private void dataHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                HoaDonDTO hd = new HoaDonDTO();
                DataGridViewRow row = dataHD.CurrentRow;
                hd.SoHD = int.Parse(row.Cells[0].Value.ToString());
                hd.MaKH = row.Cells[1].Value.ToString();
                hd.MaNV = row.Cells[2].Value.ToString();
                hd.NgayHoaDon = (DateTime)row.Cells[3].Value;
                hd.TriGia = Convert.ToInt32(row.Cells[4].Value.ToString());


                if (BLL.HoaDonBLL.SuaHoaDon(hd))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    string str = "\tCập nhật hóa đơn " + hd.SoHD + " thành công";
                    GhiThongBao(str);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK);                    
                }                               
            }
            catch
            {

            }
            LoadDanhSachHoaDon();
        }

// KHÁCH HÀNG  code ở đây

        private void LoadDanhSachKhachHang()
        {
            dataKhachHang.DataSource= BLL.KhachHangBLL.LayDanhSachKhachHang();
            try {
                DataGridViewRow row = dataKhachHang.CurrentRow;
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTenKH.Text = row.Cells[1].Value.ToString();
                dateNgSinhKH.Value = (DateTime)row.Cells[2].Value;
                txtCmndKH.Text = row.Cells[3].Value.ToString();
                txtSdtKH.Text = row.Cells[4].Value.ToString();
                txtDiaChiKH.Text = row.Cells[5].Value.ToString();
                dateNgDKKH.Value = (DateTime)row.Cells[6].Value;
                cbbLoaiKH.Text = row.Cells[7].Value.ToString();
                txtDoanhSoKH.Text = row.Cells[8].Value.ToString();
            }
            catch { }
        }

        private void LockInsertKH()
        {
            txtMaKH.Enabled = false;
            txtHoTenKH.Enabled = false;
            dateNgSinhKH.Enabled = false;
            dateNgDKKH.Enabled = false;
            txtDiaChiKH.Enabled = false;
            txtCmndKH.Enabled = false;
            txtSdtKH.Enabled = false;
            txtDoanhSoKH.Enabled = false;
            cbbLoaiKH.Enabled = false;

            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = true;

            btnLuuKH.Enabled = false;
            btnHuyKH.Enabled = false;
        }

        private void AllowInsertKH()
        {
            txtHoTenKH.Enabled = true;
            dateNgSinhKH.Enabled = true;
            dateNgDKKH.Enabled = true;
            txtDiaChiKH.Enabled = true;
            txtCmndKH.Enabled = true;
            txtSdtKH.Enabled = true;

            btnThemKH.Enabled = false;
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;

            btnLuuKH.Enabled = true;
            btnHuyKH.Enabled = true;
        }

        private void txtCmndKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSdtKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (btnLuuKH.Enabled == false)
            {
                DataGridViewRow row = dataKhachHang.CurrentRow;
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTenKH.Text = row.Cells[1].Value.ToString();
                dateNgSinhKH.Value = (DateTime)row.Cells[2].Value;
                txtCmndKH.Text = row.Cells[3].Value.ToString();
                txtSdtKH.Text = row.Cells[4].Value.ToString();
                txtDiaChiKH.Text = row.Cells[5].Value.ToString();
                dateNgDKKH.Value = (DateTime)row.Cells[6].Value;
                cbbLoaiKH.Text = row.Cells[7].Value.ToString();
                txtDoanhSoKH.Text = row.Cells[8].Value.ToString();
            }
            
        }
        private string StatusKH;
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            AllowInsertKH();
            txtHoTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtCmndKH.Text = "";
            txtSdtKH.Text = "";
            txtDoanhSoKH.Text = "0";

            StatusKH = "Thêm";
            dateNgDKKH.Value = DateTime.Now;
            
            for (int i =1; i < 10000; i++)
            {
                string makh = "KH" + i;
                //MessageBox.Show("KH" + i.ToString());
                txtMaKH.Text = "KH" + i;
                if (KiemTraTrungMaKH(makh.Trim()))
                {
                   
                    return;
                }
            }
        }

        private bool KiemTraInsertKH()
        {
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtHoTenKH.Focus();
                return false;
            }
            if (txtDiaChiKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDiaChiKH.Focus();
                return false;
            }
            if (txtCmndKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập CMND", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtCmndKH.Focus();
                return false;
            }
            if (txtSdtKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập SĐT", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSdtKH.Focus();
                return false;
            }
            return true;
        }

        private bool KiemTraTrungMaKH(string makh)
        {
            foreach (KhachHangDTO kh in BLL.KhachHangBLL.LayDanhSachKhachHang().ToList())
            {
               
                if (makh == kh.MaKH.Trim())
                {                  
                    return false;
                }
            }
            return true;
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            AllowInsertKH();
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Phải chọn duy nhất 1 khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            StatusKH = "Sửa";
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dataKhachHang.SelectedCells.Count != 1 && dataKhachHang.SelectedRows.Count != 1)
            {
                MessageBox.Show("Phải chọn duy nhất 1 khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string ten = txtHoTenKH.Text;
                if (BLL.KhachHangBLL.XoaKhachHang(txtMaKH.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadDanhSachKhachHang();

                    string str = "\tĐã xóa khách hàng: " + ten;
                    GhiThongBao(str);
                }
                else
                {
                    MessageBox.Show("Bản phải xóa hóa đơn trước khi xóa khách hàng", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (KiemTraInsertKH())
                {
                    if (StatusKH == "Thêm")
                    {
                        KhachHangDTO kh = new KhachHangDTO();
                        kh.MaKH = txtMaKH.Text;
                        kh.HoTen = Ten(txtHoTenKH.Text);
                        kh.NgaySinh = (DateTime)dateNgSinhKH.Value;
                        kh.Cmnd = txtCmndKH.Text;
                        kh.Sdt = txtSdtKH.Text;
                        kh.DiaChi = txtDiaChiKH.Text;
                        kh.NgayDK = (DateTime)dateNgDKKH.Value;
                        kh.Loai = "Thường";
                        kh.DoanhSo = 0;
                        
                        if (BLL.KhachHangBLL.ThemKhachHang(kh))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            string str = "\tĐã thêm khách hàng: " + kh.HoTen;
                            GhiThongBao(str);
                            LockInsertKH();
                            LoadDanhSachKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else if (StatusKH == "Sửa")
                    {
                        KhachHangDTO kh = new KhachHangDTO();
                        kh.MaKH = txtMaKH.Text;
                        kh.HoTen = Ten(txtHoTenKH.Text);
                        kh.NgaySinh = dateNgSinhKH.Value;
                        kh.Cmnd = txtCmndKH.Text;
                        kh.Sdt = txtSdtKH.Text;
                        kh.DiaChi = txtDiaChiKH.Text;
                        kh.NgayDK = dateNgDKKH.Value;
                        kh.Loai = cbbLoaiKH.Text;
                        kh.DoanhSo = 0;

                        if (BLL.KhachHangBLL.SuaKhachHang(kh))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            string str = "\tCập nhất khách hàng: " + kh.HoTen + " thành công";
                            GhiThongBao(str);
                            LockInsertKH();
                            LoadDanhSachKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LockInsertKH();
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (cbbLoaiKHSearch.Text == "Tất cả" || cbbLoaiKHSearch.Text == "")
            {
                if (txtMaKHSearch.Text.Trim() == "")
                {
                    LoadDanhSachKhachHang();
                }
                else
                {
                    dataKhachHang.DataSource = BLL.KhachHangBLL.TimKhachHangTheoTuKhoa(txtMaKHSearch.Text);
                }
            }
            else
            {
                if (txtMaKHSearch.Text.Trim() == "")
                {
                    dataKhachHang.DataSource = BLL.KhachHangBLL.TimKhachHangTheoLoaiKH(cbbLoaiKHSearch.Text);
                }
                else
                {
                    dataKhachHang.DataSource = BLL.KhachHangBLL.TimKhachHangTheoTuKhoaLoai(txtMaKHSearch.Text, cbbLoaiKHSearch.Text);
                }
            }
        }

        private void dataKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                DataGridViewRow row = dataKhachHang.CurrentRow;
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = row.Cells[0].Value.ToString();
                kh.HoTen = row.Cells[1].Value.ToString();
                kh.NgaySinh = (DateTime)row.Cells[2].Value;
                kh.Cmnd = row.Cells[3].Value.ToString();
                kh.Sdt = row.Cells[4].Value.ToString();
                kh.DiaChi = row.Cells[5].Value.ToString();
                kh.NgayDK = (DateTime)row.Cells[6].Value;
                kh.Loai = row.Cells[7].Value.ToString();
                kh.DoanhSo = (uint)row.Cells[8].Value;

                if (BLL.KhachHangBLL.SuaKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    LockInsertKH();
                    LoadDanhSachKhachHang();

                    string str = "\tĐã cập nhật khách hàng: " + kh.HoTen;
                    GhiThongBao(str);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {

            }

        }

        // Thông báo

        private void btnXoaThongBao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                richThongBao.Clear();  
            }
        }

        private void btnLuuThongBao_Click(object sender, EventArgs e)
        {
            string namefile = "\\" + DateTime.Now.Day+ "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt";
            //MessageBox.Show(namefile);
            using (FileStream fs = new FileStream(Application.StartupPath + "\\" + namefile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                fs.Close();
                using (StreamWriter s = new StreamWriter(Application.StartupPath + "\\" + namefile, true))
                {
                    DialogResult result = MessageBox.Show("Ban chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        for (int i = 0; i < richThongBao.Lines.Count(); i++)
                        {
                            s.WriteLine(richThongBao.Lines[i]);
                        }

                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                        s.Close();
                    }                   
                }
               
            }

        }

        private void txtGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

// Thống kê

        private void KhoiTaoThongKe()
        {
           
            radSP.Checked = true;
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            KhoiTaoTime();
            List<string> lstr = new List<string> { "Số lượng bán ra", "Doanh thu" };
            KhoiTaoCBB(lstr);
            cbbThuocTinhThongKe.SelectedIndex = 0;
        }

        private void KhoiTaoCBB(List<string> lstr)
        {
            foreach (string s in lstr)
            {
                cbbThuocTinhThongKe.Items.Add(s);
            }
            cbbThuocTinhThongKe.SelectedIndex = 0;
        }

        private void KhoiTaoTime()
        {
            numericNam.Maximum = DateTime.Now.Year;
            numericNam.Value = DateTime.Now.Year;

            numericThang.Maximum = 12;
            numericThang.Value = DateTime.Now.Month;

            numericNgay.Value = DateTime.Now.Day;



            //if (numericNam.Value % 4 == 0 && numericNam.Value % 100 != 0 )
            //{
            //    if (numericThang.Value == 2)
            //    {
            //        numericNgay
            //    }
            //}
        }

        private void radNV_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            cbbThuocTinhThongKe.Items.Clear();
            List<string> lstr = new List<string> { "Số hóa đơn bán ra", "Doanh thu"};
            KhoiTaoCBB(lstr);
        }

        private void radSP_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            cbbThuocTinhThongKe.Items.Clear();
            List<string> lstr = new List<string> { "Số lượng bán ra", "Doanh thu"};
            KhoiTaoCBB(lstr);
        }

        private void radKH_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            cbbThuocTinhThongKe.Items.Clear();
            List<string> lstr = new List<string> { "Doanh số"};
            KhoiTaoCBB(lstr);
        }

        private void radHD_Click(object sender, EventArgs e)
        {
            label48.Visible = true;
            txtThongKeDT.Visible = true;
            cbbThuocTinhThongKe.Items.Clear();
            List<string> lstr = new List<string> { "Trị giá" };
            KhoiTaoCBB(lstr);
        }


        private void numericNgay_ValueChanged(object sender, EventArgs e)
        {
            if (numericNgay.Value > numericNgay.Maximum)
            {
                numericNgay.Value = numericNgay.Maximum;
            }
        }

        private void numericThang_ValueChanged(object sender, EventArgs e)
        {
            if (numericThang.Value > numericThang.Maximum)
            {
                numericThang.Value = numericThang.Maximum;
            }
            if (numericThang.Value == 4 && numericThang.Value == 6 && numericThang.Value == 9 && numericThang.Value == 11)
            {
                numericNgay.Maximum = 30;
            }
            else if (numericThang.Value == 2)
            {
                if (numericNam.Value % 4 == 0 && numericNam.Value % 100 != 0)
                {
                    numericNgay.Maximum = 29;
                }
                else
                {
                    numericNgay.Maximum = 28;
                }
            }
            else
            {
                numericNgay.Maximum = 31;
            }

        }

        private void numericNam_ValueChanged(object sender, EventArgs e)
        {
            if (numericNam.Value > numericNam.Maximum)
            {
                numericNam.Value = numericNam.Maximum;
            }
        }

        private void numericNam_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericNam.Value > numericNam.Maximum)
            {
                numericNam.Value = numericNam.Maximum;
            }
        }

        private void numericThang_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericThang.Value > numericThang.Maximum)
            {
                numericThang.Value = numericThang.Maximum;
            }
            if (numericThang.Value == 4 && numericThang.Value == 6 && numericThang.Value == 9 && numericThang.Value == 11)
            {
                numericNgay.Maximum = 30;
            }
            else if (numericThang.Value == 2)
            {
                if (numericNam.Value % 4 == 0 && numericNam.Value % 100 != 0)
                {
                    numericNgay.Maximum = 29;
                }
                else
                {
                    numericNgay.Maximum = 28;
                }
            }
            else
            {
                numericNgay.Maximum = 31;
            }
        }

        private void numericNgay_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericNgay.Value > numericNgay.Maximum)
            {
                numericNgay.Value = numericNgay.Maximum;
            }
        }

        private void btnThongKeSP_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            //radSP.Checked = true;
            radSP.PerformClick();
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            //radNV.Checked = true;
            radNV.PerformClick();
        }

        private void btnThongKeKH_Click(object sender, EventArgs e)
        {
            label48.Visible = false;
            txtThongKeDT.Visible = false;
            //radKH.Checked = true;
            radKH.PerformClick();
        }

        private void btnThongKeHD_Click(object sender, EventArgs e)
        {
            label48.Visible = true;
            txtThongKeDT.Visible = true;
            //radHD.Checked = true;
            radHD.PerformClick();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (radSP.Checked == true)
                {
                    if (cbbThuocTinhThongKe.Text == "Số lượng bán ra")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeSPBanRaTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeSPBanRaTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeSPBanRaTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Tên sản phẩm";
                        dataThongKe.Columns[1].HeaderText = "Số lượng bạn ra";
                    }
                    else if (cbbThuocTinhThongKe.Text == "Doanh thu")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeDTSPTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeDTSPTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_SP.ThongKeDTSPTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Tên sản phẩm";
                        dataThongKe.Columns[1].HeaderText = "Doanh thu";
                    }
                }

                if (radNV.Checked == true)
                {
                    if (cbbThuocTinhThongKe.Text == "Số hóa đơn bán ra")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeNVTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeNVTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeNVTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Mã nhân viên";
                        dataThongKe.Columns[1].HeaderText = "Họ tên";
                        dataThongKe.Columns[2].HeaderText = "Số lượng hóa đơn";

                    }
                    else if (cbbThuocTinhThongKe.Text == "Doanh thu")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeDTNVTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeDTNVTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_NV.ThongKeDTNVTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Mã nhân viên";
                        dataThongKe.Columns[1].HeaderText = "Họ tên";
                        dataThongKe.Columns[2].HeaderText = "Doanh thu";
                    }
                }
                if (radKH.Checked == true)
                {
                    if (cbbThuocTinhThongKe.Text == "Doanh số")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_KH.ThongKeDSKHTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_KH.ThongKeDSKHTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_KH.ThongKeDSKHTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Mã khách hàng";
                        dataThongKe.Columns[1].HeaderText = "Họ tên";
                        dataThongKe.Columns[2].HeaderText = "Doanh thu";
                    }
                }
                if (radHD.Checked == true)
                {
                    if (cbbThuocTinhThongKe.Text == "Trị giá")
                    {
                        if (numericNgay.Value != 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_HD.ThongKeTGHDTheoNgay(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value != 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_HD.ThongKeTGHDTheoThang(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        if (numericNgay.Value == 0 && numericThang.Value == 0)
                        {
                            dataThongKe.DataSource = BLL.ThongKeBLL.TK_HD.ThongKeTGHDTheoNam(int.Parse(numericNgay.Value.ToString()), int.Parse(numericThang.Value.ToString()), int.Parse(numericNam.Value.ToString()));
                        }
                        dataThongKe.Columns[0].HeaderText = "Số hóa đơn";
                        dataThongKe.Columns[1].HeaderText = "Ngày hóa đơn";
                        dataThongKe.Columns[2].HeaderText = "Trị giá";

                        if (dataThongKe.DataSource != null)
                        {
                            int s = 0;
                            for (int i = 0; i < dataThongKe.Rows.Count; i++)
                            {
                                s += int.Parse(dataThongKe.Rows[i].Cells[2].Value.ToString());
                            }
                            txtThongKeDT.Text = s.ToString();
                        }
                        else
                        {
                            txtThongKeDT.Text = "0";
                        }
                    }
                }
            }
            catch
            {

            }

        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng suất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Close();
            }
        }

        private void toolThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDangKiTK frm = new frmDangKiTK();
            frm.ShowDialog();
        }


        public static List<string> lmanv = new List<string>() {};
        private void toolDoiMatKhau_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayDanhSachTaiKhoan();
            lmanv.Clear();
            if (chucvu == "Admin")
            {
                foreach (TaiKhoanDTO t in ltk)
                {
                    lmanv.Add(t.id);

                }
            }
            else
            {
                lmanv.Add(id);
            }


            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

// Facebook
        private FacebookClient fb = new FacebookClient();
        private string image;
        public void LoadFacebook()
        {
            
            fb.AppId = "547054419104428";
            fb.AppSecret = "34ed38fd4e217bf781c0f25ef44ae4fc";
            fb.AccessToken = "547054419104428|K_yDjGjgo01T8mUtLZAEmYG2P5E";
        }

        private void btnPostFB_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic parameters = new ExpandoObject();

                var mediaObject = new FacebookMediaObject
                {
                    FileName = image,
                    ContentType = "image/jpeg",
                }.SetValue(File.ReadAllBytes(image));
                parameters.message = richFB.Text;
                parameters.caption = string.Empty;
                parameters.description = string.Empty;
                parameters.req_perms = "publish_stream";
                parameters.scope = "publish_stream";
                parameters.source = mediaObject;
                parameters.type = "normal";
                parameters.access_token = "547054419104428 |K_yDjGjgo01T8mUtLZAEmYG2P5E";

                var result = fb.Post("https://www.facebook.com/profile.php?id=100022036176736", parameters);
            }
            catch
            {

            }

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Images|*.jpg|PNG Images|*.png";

            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                image = file.FileName;
                picFB.BackgroundImage = Image.FromFile(file.FileName);
            }
        }
    }
}

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

namespace DuAnQuanLiNhaSach
{
    public partial class frmDangKiTK : MetroFramework.Forms.MetroForm
    {
        public frmDangKiTK()
        {
            InitializeComponent();
        }
        private void frmDangKiTK_Load(object sender, EventArgs e)
        {
            LayMaNVChuaTaoTK();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool KiemTra()
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return false;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }
            if (txtMatKhau.Text.Length < 6 || txtMatKhau.Text.Length > 32)
            {
                MessageBox.Show("Mật khảu phải có từ 6-32 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }
            if (txtMatKhau2.Text != txtMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau2.Focus();
                return false;
            }
            if (cbbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbMaNV.Focus();
                return false;
            }
            List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayDanhSachTaiKhoan();
            foreach (TaiKhoanDTO tk in ltk)
            {
                if (txtTaiKhoan.Text == tk.id)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LayMaNVChuaTaoTK()
        {
            if (cbbMaNV.Items.Count > 0)
            {
                cbbMaNV.Items.Clear();
            }
            List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayMaNVChuaTaoTK();
            if (ltk.Count > 0)
            {
                foreach (TaiKhoanDTO tk in ltk)
                {
                    cbbMaNV.Items.Add(tk.manv);
                }
                cbbMaNV.SelectedIndex = 0;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (KiemTra())
                {
                    TaiKhoanDTO tk = new TaiKhoanDTO();
                    List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayMaNVChuaTaoTK();
                    tk.id = txtTaiKhoan.Text;
                    tk.pass = txtMatKhau.Text;
                    tk.manv = cbbMaNV.Text;
                    foreach (TaiKhoanDTO t in ltk)
                    {
                        if (t.manv == tk.manv)
                        {
                            tk.chucvu = t.chucvu;
                        }
                    }
                    if (BLL.TaiKhoanBLL.ThemTaiKhoan(tk))
                    {
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                        txtTaiKhoan.Text = "";
                        txtMatKhau.Text = "";
                        txtMatKhau2.Text = "";                       
                        LayMaNVChuaTaoTK();
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }

        }
    }
}

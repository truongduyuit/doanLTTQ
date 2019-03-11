using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DuAnQuanLiNhaSach
{
    public partial class frmDoiMatKhau : MetroFramework.Forms.MetroForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            //frmMain frm = new frmMain();
            //frm.GetTT = new frmMain.TT(LoadTT);
            LoadTT(frmMain.lmanv);

            
        }

        private void LoadTT(List<string> lmanv)
        {
            foreach (string s in lmanv)
            {
                cbbMaNV.Items.Add(s);
            }
            if (cbbMaNV.Items.Count >0)
                cbbMaNV.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cbbMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaNV.Text != "admin" && cbbMaNV.Items.Count > 1)
            {
                txtMatKhauhienTai.Text = "";
                txtMatKhauhienTai.Enabled = false;
                btnXoaTK.Visible = true;
            }
            else
            {
                txtMatKhauhienTai.Enabled = true;
            }
            if (cbbMaNV.Text == "admin" && cbbMaNV.Items.Count > 1)
            {
                btnXoaTK.Visible = false;
            }
        }

        private bool KiemTra()
        {
            if (txtMatKhauhienTai.Enabled == false)
            {
                if (txtMatKhau1.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau1.Focus();
                    return false;
                }
                if (txtMatKhau1.Text.Length < 6 || txtMatKhau1.Text.Length > 32)
                {
                    MessageBox.Show("Mật khảu phải có từ 6-32 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau1.Focus();
                    return false;
                }
                if (txtMatKhau2.Text != txtMatKhau1.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau2.Focus();
                    return false;
                }
            }
            else
            {
                if (txtMatKhauhienTai.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu hiện tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauhienTai.Focus();
                    return false;
                }
                if (txtMatKhauhienTai.Text.Length < 6 || txtMatKhauhienTai.Text.Length > 32)
                {
                    MessageBox.Show("Mật khảu phải có từ 6-32 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauhienTai.Focus();
                    return false;
                }
                if (txtMatKhau1.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau1.Focus();
                    return false;
                }
                if (txtMatKhau1.Text.Length < 6 || txtMatKhau1.Text.Length > 32)
                {
                    MessageBox.Show("Mật khảu phải có từ 6-32 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau1.Focus();
                    return false;
                }
                if (txtMatKhau2.Text != txtMatKhau1.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau2.Focus();
                    return false;
                }

                List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayDanhSachTaiKhoan();
                foreach (TaiKhoanDTO tk in ltk)
                {
                    if (tk.id == cbbMaNV.Text)
                    {
                        if (txtMatKhauhienTai.Text != tk.pass)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (BLL.TaiKhoanBLL.SuaMatKhau(cbbMaNV.Text, txtMatKhau1.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    txtMatKhauhienTai.Text = "";
                    txtMatKhau1.Text = "";
                    txtMatKhau2.Text = "";
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string t = cbbMaNV.Text;
                if (BLL.TaiKhoanBLL.XoaTK(cbbMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    cbbMaNV.Items.Remove(t);
                    cbbMaNV.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}

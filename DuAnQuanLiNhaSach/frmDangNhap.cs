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
    public partial class frmDangNhap : MetroFramework.Forms.MetroForm
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
        }

        private void KiemTraDangNhap(string tk, string mk)
        {
            List<TaiKhoanDTO> ltk = BLL.TaiKhoanBLL.LayDanhSachTaiKhoan();
            
            foreach (TaiKhoanDTO t in ltk)
            {
                if (t.id.Trim() == tk && t.pass.Trim() == mk)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    frmMain frm = new frmMain();
                    frm.manv = t.manv;
                    frm.chucvu = t.chucvu;
                    frm.id = t.id;
                    frm.ShowDialog();             
                    
                    this.Hide();
                    
                }
            }
           
           // MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK);


        }
    }
}

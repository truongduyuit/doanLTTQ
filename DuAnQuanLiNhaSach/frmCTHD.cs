using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DuAnQuanLiNhaSach
{
    public partial class frmCTHD : Form
    {
        public frmCTHD()
        {
            InitializeComponent();
        }

        public delegate void LOADDATA(string sohd);
        public LOADDATA MyStatus;
            
        private void frmCTHD_Load(object sender, EventArgs e)
        {
            dataCTHD.DataError += DataCTHD_DataError;
        }

        private void DataCTHD_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //List<int> l = new List<int>();
            //for (int i =0; i < dataCTHD.Rows.Count; i++)
            //{
            //    if (dataCTHD.Rows[i].Cells[1].Value == null)
            //    {
            //        l.Add(i);
            //    }
            //}
            //if (l.Count > 0)
            //{
            //    for (int i = 0; i < l.Count; i++)
            //    {
            //        dataCTHD.Rows.RemoveAt(l[i]);
            //    }
            //}
        }

        public void LoadCTHD(List<CTHD_DTO> cthd)
        {
            List<HoaDonDTO> lhd = BLL.HoaDonBLL.LayDanhSachHoaDon();
            foreach (HoaDonDTO hd in lhd)
            {
                cbbSoHD_CTHD.Items.Add(hd.SoHD.ToString());
            }

            List<SanPhamDTO> lsp = BLL.SanPhamBLL.LayDanhSachSanPham();
            if (cbbTenSP_CTHD.Items.Count > 0)
            {
                cbbTenSP_CTHD.Items.Clear();
            }
            foreach (SanPhamDTO sp in lsp)
            {
                cbbTenSP_CTHD.Items.Add(sp.TenSP);
            }

            List<DanhMucDTO> ldm = BLL.DanhMucBLL.LayDanhMuc();
            foreach (DanhMucDTO dm in ldm)
            {
                cbbDanhMucCTHD.Items.Add(dm.TenDanhMuc);
            }

            LockInsertCTHD();
            dataCTHD.DataSource = cthd;
            txtGiaCTHD.Text = "0";
            if (cthd != null)
            {
                Decimal s = 0;
                foreach (CTHD_DTO t in cthd)
                {                    
                    s += t.TriGia;
                }
                txtGiaCTHD.Text = s.ToString();
            }
        }

        public void LoadTT(string sohd, string makh, string manv, DateTime date)
        {
            txtMaKH_CTHD.Text = makh;
            txtMaNV_CTHD.Text = manv;
            dateHoaDon_CTHD.Value = date;
            cbbSoHD_CTHD.SelectedItem = sohd;
        }

        public void LoadCTHDTheoSoHD(int sohd)
        {
            List<CTHD_DTO> lct = BLL.CTHD_BLL.LayCTHD(sohd);
            dataCTHD.DataSource = lct;
            
        }

        public void UpdateCTHD()
        {
            if (dataCTHD.Rows.Count > 0)
            {
                Decimal s = 0;
                foreach (DataGridViewRow row in dataCTHD.Rows)
                {
                    s += (int)row.Cells[3].Value;
                }
                txtGiaCTHD.Text = s.ToString();
            }
            else
            {
                txtGiaCTHD.Text = "0";
            }
            
        }

        private void dataCTHD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataCTHD.CurrentRow;
                txtSoLuong_CTHD.Text = row.Cells[2].Value.ToString();
                cbbTenSP_CTHD.SelectedItem = row.Cells[1].Value.ToString();
                cbbSoHD_CTHD.SelectedItem = row.Cells[0].Value.ToString();
                List<SanPhamDTO> lsp = BLL.SanPhamBLL.LayDanhSachSanPham();
                foreach (SanPhamDTO sp in lsp)
                {
                    if (sp.TenSP == cbbTenSP_CTHD.Text)
                    {
                        cbbDanhMucCTHD.SelectedItem = sp.TenDanhMuc;
                    }
                }
                if (cbbTenSP_CTHD.Items.Count > 0)
                {
                    cbbTenSP_CTHD.Items.Clear();
                }
                foreach (SanPhamDTO sp in lsp)
                {
                    cbbTenSP_CTHD.Items.Add(sp.TenSP);
                }
            }
            catch
            {
                
            }
        }

        private void LockInsertCTHD()
        {
            cbbSoHD_CTHD.Enabled = true;
            cbbDanhMucCTHD.Enabled = false;
            cbbTenSP_CTHD.Enabled = false;
            txtSoLuong_CTHD.Enabled = false;

            btnThemCTHD.Enabled = true;
            btnSuaCTHD.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnInCTHD.Enabled = true;

            btnLuuCTHD.Enabled = false;
            btnHuyCTHD.Enabled = false;
        }

        private void AllowInsert()
        {
            cbbSoHD_CTHD.Enabled = false;
            cbbDanhMucCTHD.Enabled = true;
            cbbTenSP_CTHD.Enabled = true;
            txtSoLuong_CTHD.Enabled = true;           

            btnThemCTHD.Enabled = false;
            btnSuaCTHD.Enabled = false;
            btnXoaCTHD.Enabled = false;
            btnInCTHD.Enabled = false;

            btnLuuCTHD.Enabled = true;
            btnHuyCTHD.Enabled = true;

        }

        string status;
        private void LoadDanhMuc()
        {
            List<DanhMucDTO> danhmuc = BLL.DanhMucBLL.LayDanhMuc();
            if (danhmuc.Count > 0)
            {
                foreach (DanhMucDTO d in danhmuc)
                {
                    cbbDanhMucCTHD.Items.Add(d.TenDanhMuc);
                }
            }
        }

        private void LoadTenSP()
        {
            List<SanPhamDTO> lsp = BLL.SanPhamBLL.LaySanPhamTheoDanhMuc(cbbDanhMucCTHD.SelectedItem.ToString());
            foreach (SanPhamDTO sp in lsp)
            {
                cbbTenSP_CTHD.Items.Add(sp.TenSP);
            }
        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            //LoadDanhMuc();
            //LoadTenSP();

            status = "ThêmCTHD";
            AllowInsert();
            txtSoLuong_CTHD.Text = "1";
        }
        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            status = "SửaCTHD";
            AllowInsert();
        }

        private void btnInCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("UITer BookStore", new Font("Courier New", 28), new SolidBrush(Color.Black), startX, startY);
            string top = "Sản phẩm".PadRight(30)+ "Số lượng".PadRight(20)  + "Giá";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            foreach (DataGridViewRow row  in dataCTHD.Rows)
            {
                graphic.DrawString(row.Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(row.Cells[2].Value.ToString(), font, new SolidBrush(Color.Black), startX + 320, startY + offset);
                graphic.DrawString(row.Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("--------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Tổng:  ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX+ 300, startY + offset);
            graphic.DrawString(txtGiaCTHD.Text, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 500, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Khách hàng: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtMaKH_CTHD.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Nhân viên: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtMaNV_CTHD.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Ngày (mm/dd/yyyy):  ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(dateHoaDon_CTHD.Value.ToShortDateString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);


            offset = offset + (int)FontHeight + 25; //make the spacing consistent              
            graphic.DrawString("Trân thành cảm ơn quý khách hàng!", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Xin hẹn gặp lại !", font, new SolidBrush(Color.Black), startX, startY + offset);
        }


        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (dataCTHD.SelectedRows.Count != 1 && dataCTHD.SelectedCells.Count != 1)
                {
                    MessageBox.Show("Chọn 1 CTHD để xóa", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {                  
                    DataGridViewRow row = dataCTHD.CurrentRow;
                    string sohd = row.Cells[0].Value.ToString();
                    if (BLL.CTHD_BLL.XoaCTHD(int.Parse(row.Cells[0].Value.ToString().Trim()), row.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadCTHDTheoSoHD(int.Parse(row.Cells[0].Value.ToString()));
                        UpdateCTHD();

                        MyStatus(sohd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                   
                }

                
            }
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            if (status == "ThêmCTHD")
            {
                CTHD_DTO cthd = new CTHD_DTO();
                cthd.SoHD = int.Parse(cbbSoHD_CTHD.Text.Trim());
                //MessageBox.Show(cbbSoHD_CTHD.Text);
                cthd.TenSP = cbbTenSP_CTHD.Text;
                if (txtSoLuong_CTHD.Text.Trim() == "")
                {
                    MessageBox.Show("Phải nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong_CTHD.Focus();
                    return;
                }
                cthd.SoLuong = int.Parse(txtSoLuong_CTHD.Text);
                cthd.TriGia = 0;
                if (cthd.SoLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (BLL.CTHD_BLL.ThemCTHD(cthd))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadCTHDTheoSoHD(cthd.SoHD);
                    UpdateCTHD();

                    MyStatus(cthd.SoHD.ToString());
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, CTHD đã tồn tại hoặc số lượng quá mức", "Thông báo", MessageBoxButtons.OK);
                }
                LockInsertCTHD();

            }
            else if (status == "SửaCTHD")
            {
                try
                {
                    //DataGridViewRow row = dataCTHD.CurrentRow;
                    CTHD_DTO cthd = new CTHD_DTO();
                    cthd.SoHD = int.Parse(cbbSoHD_CTHD.Text);
                    cthd.TenSP = cbbTenSP_CTHD.Text;
                    cthd.SoLuong = int.Parse(txtSoLuong_CTHD.Text);
                    cthd.TriGia = int.Parse(txtGiaCTHD.Text);
                    
                    if (BLL.CTHD_BLL.SuaCTHD(cthd))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        LockInsertCTHD();

                        MyStatus(cthd.SoHD.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    LoadCTHDTheoSoHD(cthd.SoHD);
                    LockInsertCTHD();

                }
                catch
                {

                }
                UpdateCTHD();
            }
        }

        private void btnHuyCTHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LockInsertCTHD();
            }
        }

        private void cbbDanhMucCTHD_SelectedValueChanged(object sender, EventArgs e)
        {
            List<SanPhamDTO> lsp = BLL.SanPhamBLL.LaySanPhamTheoDanhMuc(cbbDanhMucCTHD.Text);
            if (cbbTenSP_CTHD.Items.Count > 0)
            {
                cbbTenSP_CTHD.Items.Clear();
            }
            foreach (SanPhamDTO sp in lsp)
            {
                cbbTenSP_CTHD.Items.Add(sp.TenSP);
            }
            cbbTenSP_CTHD.SelectedIndex = 0;
        }


        private void txtSoLuong_CTHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataCTHD.CurrentRow;
                CTHD_DTO cthd = new CTHD_DTO();
                cthd.SoHD = int.Parse(row.Cells[0].Value.ToString());
                cthd.TenSP = row.Cells[1].Value.ToString();
                cthd.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                cthd.TriGia = int.Parse(row.Cells[3].Value.ToString());

                if (BLL.CTHD_BLL.SuaCTHD(cthd))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    MyStatus(cthd.SoHD.ToString());
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                LoadCTHDTheoSoHD(cthd.SoHD);
            }
            catch
            {

            }
            UpdateCTHD();
        }

        private void cbbSoHD_CTHD_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCTHDTheoSoHD(int.Parse(cbbSoHD_CTHD.Text));
            this.Text = "Chi tiết hóa đơn: " + cbbSoHD_CTHD.Text;
            try
            {
                HoaDonDTO hd = BLL.HoaDonBLL.TimHoaDonTheoSoHD(int.Parse(cbbSoHD_CTHD.Text));
                txtMaKH_CTHD.Text = hd.MaKH;
                txtMaNV_CTHD.Text = hd.MaNV;
                dateHoaDon_CTHD.Value = (DateTime)hd.NgayHoaDon;
                txtGiaCTHD.Text = hd.TriGia.ToString();
            }
            catch
            {

            }
        }
    }

}

namespace DuAnQuanLiNhaSach
{
    partial class frmCTHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbDanhMucCTHD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuyCTHD = new System.Windows.Forms.Button();
            this.btnLuuCTHD = new System.Windows.Forms.Button();
            this.cbbTenSP_CTHD = new System.Windows.Forms.ComboBox();
            this.txtSoLuong_CTHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSoHD_CTHD = new System.Windows.Forms.ComboBox();
            this.btnXoaCTHD = new System.Windows.Forms.Button();
            this.btnSuaCTHD = new System.Windows.Forms.Button();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.btnInCTHD = new System.Windows.Forms.Button();
            this.dateHoaDon_CTHD = new System.Windows.Forms.DateTimePicker();
            this.txtGiaCTHD = new System.Windows.Forms.TextBox();
            this.txtMaNV_CTHD = new System.Windows.Forms.TextBox();
            this.txtMaKH_CTHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbDanhMucCTHD);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnHuyCTHD);
            this.groupBox2.Controls.Add(this.btnLuuCTHD);
            this.groupBox2.Controls.Add(this.cbbTenSP_CTHD);
            this.groupBox2.Controls.Add(this.txtSoLuong_CTHD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbSoHD_CTHD);
            this.groupBox2.Controls.Add(this.btnXoaCTHD);
            this.groupBox2.Controls.Add(this.btnSuaCTHD);
            this.groupBox2.Controls.Add(this.btnThemCTHD);
            this.groupBox2.Controls.Add(this.btnInCTHD);
            this.groupBox2.Controls.Add(this.dateHoaDon_CTHD);
            this.groupBox2.Controls.Add(this.txtGiaCTHD);
            this.groupBox2.Controls.Add(this.txtMaNV_CTHD);
            this.groupBox2.Controls.Add(this.txtMaKH_CTHD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // cbbDanhMucCTHD
            // 
            this.cbbDanhMucCTHD.FormattingEnabled = true;
            this.cbbDanhMucCTHD.Location = new System.Drawing.Point(578, 80);
            this.cbbDanhMucCTHD.Name = "cbbDanhMucCTHD";
            this.cbbDanhMucCTHD.Size = new System.Drawing.Size(209, 28);
            this.cbbDanhMucCTHD.TabIndex = 24;
            this.cbbDanhMucCTHD.SelectedValueChanged += new System.EventHandler(this.cbbDanhMucCTHD_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(436, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Danh mục:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHuyCTHD
            // 
            this.btnHuyCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnHuyCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.Delete_icon;
            this.btnHuyCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCTHD.Location = new System.Drawing.Point(336, 265);
            this.btnHuyCTHD.Name = "btnHuyCTHD";
            this.btnHuyCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnHuyCTHD.TabIndex = 22;
            this.btnHuyCTHD.Text = "Hủy";
            this.btnHuyCTHD.UseVisualStyleBackColor = false;
            this.btnHuyCTHD.Click += new System.EventHandler(this.btnHuyCTHD_Click);
            // 
            // btnLuuCTHD
            // 
            this.btnLuuCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLuuCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.Save_icon;
            this.btnLuuCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCTHD.Location = new System.Drawing.Point(100, 265);
            this.btnLuuCTHD.Name = "btnLuuCTHD";
            this.btnLuuCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnLuuCTHD.TabIndex = 21;
            this.btnLuuCTHD.Text = "Lưu";
            this.btnLuuCTHD.UseVisualStyleBackColor = false;
            this.btnLuuCTHD.Click += new System.EventHandler(this.btnLuuCTHD_Click);
            // 
            // cbbTenSP_CTHD
            // 
            this.cbbTenSP_CTHD.FormattingEnabled = true;
            this.cbbTenSP_CTHD.Location = new System.Drawing.Point(578, 113);
            this.cbbTenSP_CTHD.Name = "cbbTenSP_CTHD";
            this.cbbTenSP_CTHD.Size = new System.Drawing.Size(209, 28);
            this.cbbTenSP_CTHD.TabIndex = 20;
            // 
            // txtSoLuong_CTHD
            // 
            this.txtSoLuong_CTHD.Location = new System.Drawing.Point(578, 155);
            this.txtSoLuong_CTHD.Name = "txtSoLuong_CTHD";
            this.txtSoLuong_CTHD.Size = new System.Drawing.Size(209, 26);
            this.txtSoLuong_CTHD.TabIndex = 19;
            this.txtSoLuong_CTHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_CTHD_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(436, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "SL:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(436, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên sản phẩm:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(436, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số HĐ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbSoHD_CTHD
            // 
            this.cbbSoHD_CTHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoHD_CTHD.FormattingEnabled = true;
            this.cbbSoHD_CTHD.Location = new System.Drawing.Point(578, 45);
            this.cbbSoHD_CTHD.Name = "cbbSoHD_CTHD";
            this.cbbSoHD_CTHD.Size = new System.Drawing.Size(91, 28);
            this.cbbSoHD_CTHD.TabIndex = 14;
            this.cbbSoHD_CTHD.SelectedValueChanged += new System.EventHandler(this.cbbSoHD_CTHD_SelectedValueChanged);
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.wastebasket_icon;
            this.btnXoaCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCTHD.Location = new System.Drawing.Point(578, 210);
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnXoaCTHD.TabIndex = 13;
            this.btnXoaCTHD.Text = "Xóa";
            this.btnXoaCTHD.UseVisualStyleBackColor = false;
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // btnSuaCTHD
            // 
            this.btnSuaCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSuaCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.edit;
            this.btnSuaCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCTHD.Location = new System.Drawing.Point(336, 210);
            this.btnSuaCTHD.Name = "btnSuaCTHD";
            this.btnSuaCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnSuaCTHD.TabIndex = 12;
            this.btnSuaCTHD.Text = "Sửa";
            this.btnSuaCTHD.UseVisualStyleBackColor = false;
            this.btnSuaCTHD.Click += new System.EventHandler(this.btnSuaCTHD_Click);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.new_file_icon;
            this.btnThemCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCTHD.Location = new System.Drawing.Point(100, 210);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnThemCTHD.TabIndex = 11;
            this.btnThemCTHD.Text = "Thêm";
            this.btnThemCTHD.UseVisualStyleBackColor = false;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // btnInCTHD
            // 
            this.btnInCTHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnInCTHD.Image = global::DuAnQuanLiNhaSach.Properties.Resources.print_icon;
            this.btnInCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCTHD.Location = new System.Drawing.Point(578, 265);
            this.btnInCTHD.Name = "btnInCTHD";
            this.btnInCTHD.Size = new System.Drawing.Size(160, 49);
            this.btnInCTHD.TabIndex = 10;
            this.btnInCTHD.Text = "In";
            this.btnInCTHD.UseVisualStyleBackColor = false;
            this.btnInCTHD.Click += new System.EventHandler(this.btnInCTHD_Click);
            // 
            // dateHoaDon_CTHD
            // 
            this.dateHoaDon_CTHD.Enabled = false;
            this.dateHoaDon_CTHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHoaDon_CTHD.Location = new System.Drawing.Point(201, 117);
            this.dateHoaDon_CTHD.Name = "dateHoaDon_CTHD";
            this.dateHoaDon_CTHD.Size = new System.Drawing.Size(209, 26);
            this.dateHoaDon_CTHD.TabIndex = 9;
            // 
            // txtGiaCTHD
            // 
            this.txtGiaCTHD.Enabled = false;
            this.txtGiaCTHD.Location = new System.Drawing.Point(201, 155);
            this.txtGiaCTHD.Name = "txtGiaCTHD";
            this.txtGiaCTHD.Size = new System.Drawing.Size(209, 26);
            this.txtGiaCTHD.TabIndex = 8;
            // 
            // txtMaNV_CTHD
            // 
            this.txtMaNV_CTHD.Enabled = false;
            this.txtMaNV_CTHD.Location = new System.Drawing.Point(201, 80);
            this.txtMaNV_CTHD.Name = "txtMaNV_CTHD";
            this.txtMaNV_CTHD.Size = new System.Drawing.Size(209, 26);
            this.txtMaNV_CTHD.TabIndex = 6;
            // 
            // txtMaKH_CTHD
            // 
            this.txtMaKH_CTHD.Enabled = false;
            this.txtMaKH_CTHD.Location = new System.Drawing.Point(201, 40);
            this.txtMaKH_CTHD.Name = "txtMaKH_CTHD";
            this.txtMaKH_CTHD.Size = new System.Drawing.Size(209, 26);
            this.txtMaKH_CTHD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày hóa đơn:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataCTHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn:";
            // 
            // dataCTHD
            // 
            this.dataCTHD.AllowUserToAddRows = false;
            this.dataCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.TenSP,
            this.SoLuong,
            this.Gia});
            this.dataCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCTHD.Location = new System.Drawing.Point(3, 22);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.RowTemplate.Height = 24;
            this.dataCTHD.Size = new System.Drawing.Size(826, 250);
            this.dataCTHD.TabIndex = 1;
            this.dataCTHD.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTHD_CellValueChanged);
            this.dataCTHD.SelectionChanged += new System.EventHandler(this.dataCTHD_SelectionChanged);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hóa đơn";
            this.SoHD.Name = "SoHD";
            this.SoHD.Visible = false;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "TriGia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCTHD";
            this.Text = "CTHD";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInCTHD;
        private System.Windows.Forms.DateTimePicker dateHoaDon_CTHD;
        private System.Windows.Forms.TextBox txtGiaCTHD;
        private System.Windows.Forms.TextBox txtMaNV_CTHD;
        private System.Windows.Forms.TextBox txtMaKH_CTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaCTHD;
        private System.Windows.Forms.Button btnSuaCTHD;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.TextBox txtSoLuong_CTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSoHD_CTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataCTHD;
        private System.Windows.Forms.ComboBox cbbTenSP_CTHD;
        private System.Windows.Forms.Button btnLuuCTHD;
        private System.Windows.Forms.Button btnHuyCTHD;
        private System.Windows.Forms.ComboBox cbbDanhMucCTHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}
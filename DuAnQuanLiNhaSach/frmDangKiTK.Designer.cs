namespace DuAnQuanLiNhaSach
{
    partial class frmDangKiTK
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
            this.lblName = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picID = new System.Windows.Forms.PictureBox();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(682, 50);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "UITer BookStore";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // group
            // 
            this.group.Controls.Add(this.cbbMaNV);
            this.group.Controls.Add(this.pictureBox2);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtMatKhau2);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtTaiKhoan);
            this.group.Controls.Add(this.btnThoat);
            this.group.Controls.Add(this.btnDangKi);
            this.group.Controls.Add(this.txtMatKhau);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.lblId);
            this.group.Controls.Add(this.picPass);
            this.group.Controls.Add(this.picID);
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(40, 127);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(640, 273);
            this.group.TabIndex = 2;
            this.group.TabStop = false;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(291, 168);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(139, 28);
            this.cbbMaNV.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.Policeman_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(43, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã nhân viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(291, 124);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(280, 26);
            this.txtMatKhau2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập lại mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(291, 34);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(280, 26);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::DuAnQuanLiNhaSach.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(449, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Image = global::DuAnQuanLiNhaSach.Properties.Resources.login;
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(291, 215);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(139, 36);
            this.btnDangKi.TabIndex = 8;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(291, 79);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(280, 26);
            this.txtMatKhau.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(96, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(164, 39);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Tài khoản:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPass
            // 
            this.picPass.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.passwordicon;
            this.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPass.Location = new System.Drawing.Point(43, 73);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(47, 39);
            this.picPass.TabIndex = 1;
            this.picPass.TabStop = false;
            // 
            // picID
            // 
            this.picID.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.usericon;
            this.picID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picID.Location = new System.Drawing.Point(43, 25);
            this.picID.Name = "picID";
            this.picID.Size = new System.Drawing.Size(47, 42);
            this.picID.TabIndex = 0;
            this.picID.TabStop = false;
            // 
            // frmDangKiTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 407);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.group);
            this.Name = "frmDangKiTK";
            this.Text = "ĐĂNG KÍ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmDangKiTK_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picID;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}
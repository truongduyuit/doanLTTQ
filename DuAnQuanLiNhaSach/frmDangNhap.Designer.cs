namespace DuAnQuanLiNhaSach
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picID = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.picPass);
            this.groupBox1.Controls.Add(this.picID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(301, 61);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(270, 26);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::DuAnQuanLiNhaSach.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(475, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 36);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = global::DuAnQuanLiNhaSach.Properties.Resources.login;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(301, 179);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 36);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(301, 118);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(270, 26);
            this.txtMatKhau.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(116, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(164, 39);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Tên đăng nhập:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPass
            // 
            this.picPass.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.passwordicon;
            this.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPass.Location = new System.Drawing.Point(63, 109);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(47, 39);
            this.picPass.TabIndex = 1;
            this.picPass.TabStop = false;
            // 
            // picID
            // 
            this.picID.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.usericon;
            this.picID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picID.Location = new System.Drawing.Point(63, 52);
            this.picID.Name = "picID";
            this.picID.Size = new System.Drawing.Size(47, 42);
            this.picID.TabIndex = 0;
            this.picID.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(700, 76);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "UITer BookStore";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picID;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTaiKhoan;
    }
}
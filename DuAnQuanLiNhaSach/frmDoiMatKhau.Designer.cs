namespace DuAnQuanLiNhaSach
{
    partial class frmDoiMatKhau
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhauhienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(760, 50);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "UITer BookStore";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // group
            // 
            this.group.Controls.Add(this.btnXoaTK);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.cbbMaNV);
            this.group.Controls.Add(this.pictureBox2);
            this.group.Controls.Add(this.txtMatKhau2);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtMatKhau1);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.btnThoat);
            this.group.Controls.Add(this.btnDoiMatKhau);
            this.group.Controls.Add(this.txtMatKhauhienTai);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.picPass);
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(70, 131);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(640, 273);
            this.group.TabIndex = 4;
            this.group.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(96, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu mới:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(291, 31);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(139, 28);
            this.cbbMaNV.TabIndex = 0;
            this.cbbMaNV.SelectedValueChanged += new System.EventHandler(this.cbbMaNV_SelectedValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.Policeman_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(43, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(291, 172);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(280, 26);
            this.txtMatKhau2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên user:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.Location = new System.Drawing.Point(291, 124);
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.PasswordChar = '*';
            this.txtMatKhau1.Size = new System.Drawing.Size(280, 26);
            this.txtMatKhau1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập lại mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DuAnQuanLiNhaSach.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(449, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Image = global::DuAnQuanLiNhaSach.Properties.Resources.login;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(291, 215);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(139, 36);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhauhienTai
            // 
            this.txtMatKhauhienTai.Location = new System.Drawing.Point(291, 79);
            this.txtMatKhauhienTai.Name = "txtMatKhauhienTai";
            this.txtMatKhauhienTai.PasswordChar = '*';
            this.txtMatKhauhienTai.Size = new System.Drawing.Size(280, 26);
            this.txtMatKhauhienTai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu hiện tại:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnXoaTK
            // 
            this.btnXoaTK.BackgroundImage = global::DuAnQuanLiNhaSach.Properties.Resources.wastebasket_icon;
            this.btnXoaTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaTK.Location = new System.Drawing.Point(516, 25);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(55, 39);
            this.btnXoaTK.TabIndex = 14;
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Visible = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.group);
            this.Name = "frmDoiMatKhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauhienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaTK;
    }
}
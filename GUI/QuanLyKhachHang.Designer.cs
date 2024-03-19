namespace QuanLyKhachSan
{
    partial class QuanLyKhachHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            bt_Tim = new Button();
            label1 = new Label();
            tb_HoVaTenTim = new TextBox();
            groupBox3 = new GroupBox();
            dtp_NgaySinh = new WebLayer.RJControls.RJDatePicker();
            tb_MaKhach = new TextBox();
            label2 = new Label();
            cb_GioiTinh = new ComboBox();
            label10 = new Label();
            cb_LoaiKhachHang = new ComboBox();
            label9 = new Label();
            cb_QuocTich = new ComboBox();
            label8 = new Label();
            tb_DiaChi = new TextBox();
            label7 = new Label();
            tb_CCCD = new TextBox();
            label6 = new Label();
            tb_SoDienThoai = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tb_HoVaTen = new TextBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            bt_CapNhat = new Button();
            groupBox2 = new GroupBox();
            dgv_DanhSachKhachHang = new DataGridView();
            bt_Them = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_Tim);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_HoVaTenTim);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(13, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(444, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // bt_Tim
            // 
            bt_Tim.Location = new Point(217, 21);
            bt_Tim.Name = "bt_Tim";
            bt_Tim.Size = new Size(179, 90);
            bt_Tim.TabIndex = 39;
            bt_Tim.Text = "Tìm kiếm";
            bt_Tim.UseVisualStyleBackColor = true;
            bt_Tim.Click += bt_Tim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 38;
            label1.Text = "Họ và tên: ";
            // 
            // tb_HoVaTenTim
            // 
            tb_HoVaTenTim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HoVaTenTim.Location = new Point(10, 60);
            tb_HoVaTenTim.Margin = new Padding(4, 5, 4, 5);
            tb_HoVaTenTim.Name = "tb_HoVaTenTim";
            tb_HoVaTenTim.Size = new Size(171, 30);
            tb_HoVaTenTim.TabIndex = 37;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtp_NgaySinh);
            groupBox3.Controls.Add(tb_MaKhach);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cb_GioiTinh);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cb_LoaiKhachHang);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cb_QuocTich);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(tb_DiaChi);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tb_CCCD);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tb_SoDienThoai);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(tb_HoVaTen);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Green;
            groupBox3.Location = new Point(13, 143);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(444, 381);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.BorderColor = Color.PaleVioletRed;
            dtp_NgaySinh.BorderSize = 0;
            dtp_NgaySinh.CustomFormat = "MM/dd/yyyy";
            dtp_NgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(217, 112);
            dtp_NgaySinh.MinimumSize = new Size(0, 35);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(179, 35);
            dtp_NgaySinh.SkinColor = Color.SeaGreen;
            dtp_NgaySinh.TabIndex = 29;
            dtp_NgaySinh.TextColor = Color.White;
            // 
            // tb_MaKhach
            // 
            tb_MaKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaKhach.Location = new Point(160, 38);
            tb_MaKhach.Name = "tb_MaKhach";
            tb_MaKhach.ReadOnly = true;
            tb_MaKhach.Size = new Size(151, 30);
            tb_MaKhach.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 38;
            label2.Text = "Mã khách:";
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FlatStyle = FlatStyle.System;
            cb_GioiTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(217, 175);
            cb_GioiTinh.Margin = new Padding(4, 5, 4, 5);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(179, 31);
            cb_GioiTinh.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(214, 150);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 35;
            label10.Text = "(*)Giới tính:";
            // 
            // cb_LoaiKhachHang
            // 
            cb_LoaiKhachHang.FlatStyle = FlatStyle.System;
            cb_LoaiKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiKhachHang.FormattingEnabled = true;
            cb_LoaiKhachHang.Items.AddRange(new object[] { "Khách địa phương", "Khách vãng lai", "Khách quốc tế" });
            cb_LoaiKhachHang.Location = new Point(8, 253);
            cb_LoaiKhachHang.Margin = new Padding(4, 5, 4, 5);
            cb_LoaiKhachHang.Name = "cb_LoaiKhachHang";
            cb_LoaiKhachHang.Size = new Size(173, 31);
            cb_LoaiKhachHang.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 225);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 33;
            label9.Text = "(*)Loại khách hàng:";
            // 
            // cb_QuocTich
            // 
            cb_QuocTich.FlatStyle = FlatStyle.System;
            cb_QuocTich.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_QuocTich.FormattingEnabled = true;
            cb_QuocTich.Items.AddRange(new object[] { "Anh", "Ai Cập", "Banana", "Việt Nam", "Trôn VN" });
            cb_QuocTich.Location = new Point(217, 336);
            cb_QuocTich.Margin = new Padding(4, 5, 4, 5);
            cb_QuocTich.Name = "cb_QuocTich";
            cb_QuocTich.Size = new Size(179, 31);
            cb_QuocTich.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(217, 308);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 31;
            label8.Text = "(*)Quốc tịch:";
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_DiaChi.Location = new Point(217, 253);
            tb_DiaChi.Margin = new Padding(4, 5, 4, 5);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(179, 30);
            tb_DiaChi.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(217, 225);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 29;
            label7.Text = "Địa chỉ:";
            // 
            // tb_CCCD
            // 
            tb_CCCD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CCCD.Location = new Point(8, 175);
            tb_CCCD.Margin = new Padding(4, 5, 4, 5);
            tb_CCCD.Name = "tb_CCCD";
            tb_CCCD.Size = new Size(173, 30);
            tb_CCCD.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 150);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 27;
            label6.Text = "CCCD:";
            // 
            // tb_SoDienThoai
            // 
            tb_SoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_SoDienThoai.Location = new Point(8, 336);
            tb_SoDienThoai.Margin = new Padding(4, 5, 4, 5);
            tb_SoDienThoai.Name = "tb_SoDienThoai";
            tb_SoDienThoai.Size = new Size(173, 30);
            tb_SoDienThoai.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 25;
            label5.Text = "(*)Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 84);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 24;
            label4.Text = "(*)Họ và tên: ";
            // 
            // tb_HoVaTen
            // 
            tb_HoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HoVaTen.Location = new Point(8, 112);
            tb_HoVaTen.Margin = new Padding(4, 5, 4, 5);
            tb_HoVaTen.Name = "tb_HoVaTen";
            tb_HoVaTen.Size = new Size(173, 30);
            tb_HoVaTen.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(214, 84);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 21;
            label11.Text = "(*)Ngày sinh:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(bt_Them);
            groupBox4.Controls.Add(bt_CapNhat);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Green;
            groupBox4.Location = new Point(13, 520);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(444, 172);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức Năng";
            // 
            // bt_CapNhat
            // 
            bt_CapNhat.Location = new Point(8, 56);
            bt_CapNhat.Margin = new Padding(4, 5, 4, 5);
            bt_CapNhat.Name = "bt_CapNhat";
            bt_CapNhat.Size = new Size(173, 79);
            bt_CapNhat.TabIndex = 3;
            bt_CapNhat.Text = "Cập nhật";
            bt_CapNhat.UseVisualStyleBackColor = true;
            bt_CapNhat.Click += bt_CapNhat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgv_DanhSachKhachHang);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Green;
            groupBox2.Location = new Point(465, 14);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(804, 725);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dgv_DanhSachKhachHang
            // 
            dgv_DanhSachKhachHang.AllowUserToAddRows = false;
            dgv_DanhSachKhachHang.AllowUserToDeleteRows = false;
            dgv_DanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachKhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachKhachHang.Location = new Point(7, 28);
            dgv_DanhSachKhachHang.MultiSelect = false;
            dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            dgv_DanhSachKhachHang.ReadOnly = true;
            dgv_DanhSachKhachHang.RowHeadersVisible = false;
            dgv_DanhSachKhachHang.RowHeadersWidth = 51;
            dgv_DanhSachKhachHang.RowTemplate.Height = 33;
            dgv_DanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachKhachHang.Size = new Size(790, 689);
            dgv_DanhSachKhachHang.TabIndex = 0;
            dgv_DanhSachKhachHang.CellClick += dgv_DanhSachKhachHang_CellClick;
            // 
            // bt_Them
            // 
            bt_Them.Location = new Point(214, 56);
            bt_Them.Margin = new Padding(4, 5, 4, 5);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(182, 79);
            bt_Them.TabIndex = 4;
            bt_Them.Text = "Thêm";
            bt_Them.UseVisualStyleBackColor = true;
            bt_Them.Click += bt_Them_Click;
            // 
            // QuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyKhachHang";
            Load += QuanLyKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private ComboBox cb_GioiTinh;
        private Label label10;
        private ComboBox cb_LoaiKhachHang;
        private Label label9;
        private ComboBox cb_QuocTich;
        private Label label8;
        private TextBox tb_DiaChi;
        private Label label7;
        private TextBox tb_CCCD;
        private Label label6;
        private TextBox tb_SoDienThoai;
        private Label label5;
        private Label label4;
        private TextBox tb_HoVaTen;
        private Label label11;
        private GroupBox groupBox4;
        private Button bt_CapNhat;
        private GroupBox groupBox2;
        private DataGridView dgv_DanhSachKhachHang;
        private Button bt_Tim;
        private Label label1;
        private TextBox tb_HoVaTenTim;
        private TextBox tb_MaKhach;
        private Label label2;
        private WebLayer.RJControls.RJDatePicker dtp_NgaySinh;
        private Button bt_Them;
    }
}
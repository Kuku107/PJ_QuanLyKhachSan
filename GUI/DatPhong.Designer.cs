namespace QuanLyKhachSan
{
    partial class DatPhong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gb_TimPhong = new GroupBox();
            bt_TimKiem = new Button();
            nup_SoNguoi = new NumericUpDown();
            cb_LoaiPhong = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            gb_ThongTinKhachHang = new GroupBox();
            dtp_NgaySinh = new WebLayer.RJControls.RJDatePicker();
            cb_QuocTich = new ComboBox();
            cb_GioiTinh = new ComboBox();
            tb_DiaChi = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tb_SoDienThoai = new TextBox();
            label8 = new Label();
            cb_LoaiKhachHang = new ComboBox();
            label7 = new Label();
            tb_CCCD = new TextBox();
            tb_HoVaTen = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label14 = new Label();
            label15 = new Label();
            gb_ChucNang = new GroupBox();
            bt_DatPhong = new Button();
            gb_DanhSachPhong = new GroupBox();
            dgv_DanhSachPhongTrong = new DataGridView();
            dtp_NgayNhan = new WebLayer.RJControls.RJDatePicker();
            dtp_NgayTra = new WebLayer.RJControls.RJDatePicker();
            gb_TimPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_SoNguoi).BeginInit();
            gb_ThongTinKhachHang.SuspendLayout();
            gb_ChucNang.SuspendLayout();
            gb_DanhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhongTrong).BeginInit();
            SuspendLayout();
            // 
            // gb_TimPhong
            // 
            gb_TimPhong.Controls.Add(bt_TimKiem);
            gb_TimPhong.Controls.Add(nup_SoNguoi);
            gb_TimPhong.Controls.Add(cb_LoaiPhong);
            gb_TimPhong.Controls.Add(label4);
            gb_TimPhong.Controls.Add(label3);
            gb_TimPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_TimPhong.ForeColor = Color.Green;
            gb_TimPhong.Location = new Point(12, 12);
            gb_TimPhong.Name = "gb_TimPhong";
            gb_TimPhong.Size = new Size(561, 161);
            gb_TimPhong.TabIndex = 3;
            gb_TimPhong.TabStop = false;
            gb_TimPhong.Text = "Tìm phòng";
            // 
            // bt_TimKiem
            // 
            bt_TimKiem.Location = new Point(398, 27);
            bt_TimKiem.Name = "bt_TimKiem";
            bt_TimKiem.Size = new Size(117, 72);
            bt_TimKiem.TabIndex = 5;
            bt_TimKiem.Text = "Tìm kiếm";
            bt_TimKiem.UseVisualStyleBackColor = true;
            bt_TimKiem.Click += bt_TimKiem_Click;
            // 
            // nup_SoNguoi
            // 
            nup_SoNguoi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nup_SoNguoi.Location = new Point(166, 69);
            nup_SoNguoi.Name = "nup_SoNguoi";
            nup_SoNguoi.Size = new Size(211, 30);
            nup_SoNguoi.TabIndex = 2;
            // 
            // cb_LoaiPhong
            // 
            cb_LoaiPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiPhong.FormattingEnabled = true;
            cb_LoaiPhong.Items.AddRange(new object[] { "VIP", "NM" });
            cb_LoaiPhong.Location = new Point(166, 27);
            cb_LoaiPhong.Name = "cb_LoaiPhong";
            cb_LoaiPhong.Size = new Size(211, 31);
            cb_LoaiPhong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 0;
            label4.Text = "Số người:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Loại phòng:";
            // 
            // gb_ThongTinKhachHang
            // 
            gb_ThongTinKhachHang.Controls.Add(dtp_NgaySinh);
            gb_ThongTinKhachHang.Controls.Add(cb_QuocTich);
            gb_ThongTinKhachHang.Controls.Add(cb_GioiTinh);
            gb_ThongTinKhachHang.Controls.Add(tb_DiaChi);
            gb_ThongTinKhachHang.Controls.Add(label12);
            gb_ThongTinKhachHang.Controls.Add(label11);
            gb_ThongTinKhachHang.Controls.Add(label10);
            gb_ThongTinKhachHang.Controls.Add(label9);
            gb_ThongTinKhachHang.Controls.Add(tb_SoDienThoai);
            gb_ThongTinKhachHang.Controls.Add(label8);
            gb_ThongTinKhachHang.Controls.Add(cb_LoaiKhachHang);
            gb_ThongTinKhachHang.Controls.Add(label7);
            gb_ThongTinKhachHang.Controls.Add(tb_CCCD);
            gb_ThongTinKhachHang.Controls.Add(tb_HoVaTen);
            gb_ThongTinKhachHang.Controls.Add(label5);
            gb_ThongTinKhachHang.Controls.Add(label6);
            gb_ThongTinKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_ThongTinKhachHang.ForeColor = Color.Green;
            gb_ThongTinKhachHang.Location = new Point(19, 306);
            gb_ThongTinKhachHang.Name = "gb_ThongTinKhachHang";
            gb_ThongTinKhachHang.Size = new Size(554, 435);
            gb_ThongTinKhachHang.TabIndex = 4;
            gb_ThongTinKhachHang.TabStop = false;
            gb_ThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.BorderColor = Color.PaleVioletRed;
            dtp_NgaySinh.BorderSize = 0;
            dtp_NgaySinh.CustomFormat = "MM/dd/yyyy";
            dtp_NgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(303, 64);
            dtp_NgaySinh.MinimumSize = new Size(0, 35);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(213, 35);
            dtp_NgaySinh.SkinColor = Color.SeaGreen;
            dtp_NgaySinh.TabIndex = 28;
            dtp_NgaySinh.TextColor = Color.White;
            // 
            // cb_QuocTich
            // 
            cb_QuocTich.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_QuocTich.FormattingEnabled = true;
            cb_QuocTich.Items.AddRange(new object[] { "Anh", "Ai Cập", "Banana", "Việt Nam", "Trôn VN" });
            cb_QuocTich.Location = new Point(303, 246);
            cb_QuocTich.Name = "cb_QuocTich";
            cb_QuocTich.Size = new Size(213, 31);
            cb_QuocTich.TabIndex = 20;
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(303, 187);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(213, 31);
            cb_GioiTinh.TabIndex = 19;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_DiaChi.Location = new Point(303, 128);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(213, 30);
            tb_DiaChi.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(303, 220);
            label12.Name = "label12";
            label12.Size = new Size(105, 23);
            label12.TabIndex = 16;
            label12.Text = "(*)Quốc tịch:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(303, 161);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 15;
            label11.Text = "(*)Giới tính:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(303, 102);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 14;
            label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(301, 38);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 13;
            label9.Text = "(*)Ngày sinh:";
            // 
            // tb_SoDienThoai
            // 
            tb_SoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_SoDienThoai.Location = new Point(6, 247);
            tb_SoDienThoai.Name = "tb_SoDienThoai";
            tb_SoDienThoai.Size = new Size(225, 30);
            tb_SoDienThoai.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 221);
            label8.Name = "label8";
            label8.Size = new Size(128, 23);
            label8.TabIndex = 11;
            label8.Text = "(*)Số điện thoại";
            // 
            // cb_LoaiKhachHang
            // 
            cb_LoaiKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiKhachHang.FormattingEnabled = true;
            cb_LoaiKhachHang.Items.AddRange(new object[] { "Khách địa phương", "Khách vãng lai", "Khách quốc tế" });
            cb_LoaiKhachHang.Location = new Point(7, 187);
            cb_LoaiKhachHang.Name = "cb_LoaiKhachHang";
            cb_LoaiKhachHang.Size = new Size(224, 31);
            cb_LoaiKhachHang.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 161);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 10;
            label7.Text = "(*)Loại khách hàng";
            // 
            // tb_CCCD
            // 
            tb_CCCD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CCCD.Location = new Point(6, 128);
            tb_CCCD.Name = "tb_CCCD";
            tb_CCCD.Size = new Size(225, 30);
            tb_CCCD.TabIndex = 9;
            // 
            // tb_HoVaTen
            // 
            tb_HoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HoVaTen.Location = new Point(7, 69);
            tb_HoVaTen.Name = "tb_HoVaTen";
            tb_HoVaTen.Size = new Size(224, 30);
            tb_HoVaTen.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 102);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 6;
            label5.Text = "CCCD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 38);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 7;
            label6.Text = "(*)Họ và tên:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Green;
            label14.Location = new Point(19, 176);
            label14.Name = "label14";
            label14.Size = new Size(94, 23);
            label14.TabIndex = 21;
            label14.Text = "Ngày nhận";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Green;
            label15.Location = new Point(19, 241);
            label15.Name = "label15";
            label15.Size = new Size(76, 23);
            label15.TabIndex = 23;
            label15.Text = "Ngày trả";
            // 
            // gb_ChucNang
            // 
            gb_ChucNang.Controls.Add(bt_DatPhong);
            gb_ChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_ChucNang.ForeColor = Color.Green;
            gb_ChucNang.Location = new Point(278, 176);
            gb_ChucNang.Name = "gb_ChucNang";
            gb_ChucNang.Size = new Size(295, 124);
            gb_ChucNang.TabIndex = 24;
            gb_ChucNang.TabStop = false;
            gb_ChucNang.Text = "Chức năng";
            // 
            // bt_DatPhong
            // 
            bt_DatPhong.Location = new Point(37, 33);
            bt_DatPhong.Name = "bt_DatPhong";
            bt_DatPhong.Size = new Size(213, 82);
            bt_DatPhong.TabIndex = 0;
            bt_DatPhong.Text = "Đặt phòng";
            bt_DatPhong.UseVisualStyleBackColor = true;
            bt_DatPhong.Click += bt_DatPhong_Click;
            // 
            // gb_DanhSachPhong
            // 
            gb_DanhSachPhong.Controls.Add(dgv_DanhSachPhongTrong);
            gb_DanhSachPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_DanhSachPhong.ForeColor = Color.Green;
            gb_DanhSachPhong.Location = new Point(573, 12);
            gb_DanhSachPhong.Name = "gb_DanhSachPhong";
            gb_DanhSachPhong.Size = new Size(697, 729);
            gb_DanhSachPhong.TabIndex = 25;
            gb_DanhSachPhong.TabStop = false;
            gb_DanhSachPhong.Text = "Danh sách phòng trống";
            // 
            // dgv_DanhSachPhongTrong
            // 
            dgv_DanhSachPhongTrong.AllowUserToAddRows = false;
            dgv_DanhSachPhongTrong.AllowUserToDeleteRows = false;
            dgv_DanhSachPhongTrong.AllowUserToResizeColumns = false;
            dgv_DanhSachPhongTrong.AllowUserToResizeRows = false;
            dgv_DanhSachPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachPhongTrong.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_DanhSachPhongTrong.Location = new Point(6, 30);
            dgv_DanhSachPhongTrong.MultiSelect = false;
            dgv_DanhSachPhongTrong.Name = "dgv_DanhSachPhongTrong";
            dgv_DanhSachPhongTrong.ReadOnly = true;
            dgv_DanhSachPhongTrong.RowHeadersVisible = false;
            dgv_DanhSachPhongTrong.RowHeadersWidth = 51;
            dgv_DanhSachPhongTrong.RowTemplate.Height = 33;
            dgv_DanhSachPhongTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachPhongTrong.Size = new Size(685, 693);
            dgv_DanhSachPhongTrong.TabIndex = 0;
            // 
            // dtp_NgayNhan
            // 
            dtp_NgayNhan.BorderColor = Color.PaleVioletRed;
            dtp_NgayNhan.BorderSize = 0;
            dtp_NgayNhan.CustomFormat = "MM/dd/yyyy";
            dtp_NgayNhan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgayNhan.Format = DateTimePickerFormat.Custom;
            dtp_NgayNhan.Location = new Point(25, 202);
            dtp_NgayNhan.MinimumSize = new Size(0, 35);
            dtp_NgayNhan.Name = "dtp_NgayNhan";
            dtp_NgayNhan.Size = new Size(225, 35);
            dtp_NgayNhan.SkinColor = Color.SeaGreen;
            dtp_NgayNhan.TabIndex = 26;
            dtp_NgayNhan.TextColor = Color.White;
            // 
            // dtp_NgayTra
            // 
            dtp_NgayTra.BorderColor = Color.PaleVioletRed;
            dtp_NgayTra.BorderSize = 0;
            dtp_NgayTra.CustomFormat = "MM/dd/yyyy";
            dtp_NgayTra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgayTra.Format = DateTimePickerFormat.Custom;
            dtp_NgayTra.Location = new Point(25, 265);
            dtp_NgayTra.MinimumSize = new Size(0, 35);
            dtp_NgayTra.Name = "dtp_NgayTra";
            dtp_NgayTra.Size = new Size(225, 35);
            dtp_NgayTra.SkinColor = Color.SeaGreen;
            dtp_NgayTra.TabIndex = 27;
            dtp_NgayTra.TextColor = Color.White;
            // 
            // DatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(dtp_NgayTra);
            Controls.Add(dtp_NgayNhan);
            Controls.Add(gb_DanhSachPhong);
            Controls.Add(gb_ChucNang);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(gb_ThongTinKhachHang);
            Controls.Add(gb_TimPhong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatPhong";
            Load += Form1_Load;
            gb_TimPhong.ResumeLayout(false);
            gb_TimPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_SoNguoi).EndInit();
            gb_ThongTinKhachHang.ResumeLayout(false);
            gb_ThongTinKhachHang.PerformLayout();
            gb_ChucNang.ResumeLayout(false);
            gb_DanhSachPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhongTrong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gb_TimPhong;
        private GroupBox gb_ThongTinKhachHang;
        private Button bt_TimKiem;
        private NumericUpDown nup_SoNguoi;
        private ComboBox cb_LoaiPhong;
        private Label label4;
        private Label label3;
        private TextBox tb_SoDienThoai;
        private Label label8;
        private ComboBox cb_LoaiKhachHang;
        private Label label7;
        private TextBox tb_CCCD;
        private TextBox tb_HoVaTen;
        private Label label5;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cb_QuocTich;
        private ComboBox cb_GioiTinh;
        private TextBox tb_DiaChi;
        private Label label14;
        private Label label15;
        private GroupBox gb_ChucNang;
        private Button bt_DatPhong;
        private GroupBox gb_DanhSachPhong;
        private DataGridView dataGridView1;
        private DataGridView dgv_DanhSachPhongTrong;
        private WebLayer.RJControls.RJDatePicker dtp_NgayNhan;
        private WebLayer.RJControls.RJDatePicker dtp_NgaySinh;
        private WebLayer.RJControls.RJDatePicker dtp_NgayTra;
    }
}

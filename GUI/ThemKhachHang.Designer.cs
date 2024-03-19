namespace QuanLyKhachSan
{
    partial class ThemKhachHang
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
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtp_NgaySinh = new WebLayer.RJControls.RJDatePicker();
            tb_SoDienThoai = new TextBox();
            label5 = new Label();
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
            label4 = new Label();
            tb_HoVaTen = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            bt_ThemKhachHang = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(24, 55);
            label2.MinimumSize = new Size(0, 1);
            label2.Name = "label2";
            label2.Size = new Size(780, 1);
            label2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 4;
            label1.Text = "Thêm khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_NgaySinh);
            groupBox1.Controls.Add(tb_SoDienThoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cb_GioiTinh);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cb_LoaiKhachHang);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cb_QuocTich);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tb_DiaChi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_CCCD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_HoVaTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(24, 61);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(439, 299);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.BorderColor = Color.PaleVioletRed;
            dtp_NgaySinh.BorderSize = 0;
            dtp_NgaySinh.CustomFormat = "MM/dd/yyyy";
            dtp_NgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(204, 41);
            dtp_NgaySinh.MinimumSize = new Size(0, 35);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(166, 35);
            dtp_NgaySinh.SkinColor = Color.SeaGreen;
            dtp_NgaySinh.TabIndex = 27;
            dtp_NgaySinh.TextColor = Color.White;
            // 
            // tb_SoDienThoai
            // 
            tb_SoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_SoDienThoai.Location = new Point(10, 229);
            tb_SoDienThoai.Margin = new Padding(4, 5, 4, 5);
            tb_SoDienThoai.Name = "tb_SoDienThoai";
            tb_SoDienThoai.Size = new Size(170, 30);
            tb_SoDienThoai.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 207);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 35;
            label5.Text = "Số điện thoại(*):";
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FlatStyle = FlatStyle.System;
            cb_GioiTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(204, 111);
            cb_GioiTinh.Margin = new Padding(4, 5, 4, 5);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(166, 31);
            cb_GioiTinh.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(208, 85);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 33;
            label10.Text = "Giới tính(*):";
            // 
            // cb_LoaiKhachHang
            // 
            cb_LoaiKhachHang.FlatStyle = FlatStyle.System;
            cb_LoaiKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiKhachHang.FormattingEnabled = true;
            cb_LoaiKhachHang.Items.AddRange(new object[] { "Khách địa phương", "Khách vãng lai", "Khách quốc tế" });
            cb_LoaiKhachHang.Location = new Point(18, 166);
            cb_LoaiKhachHang.Margin = new Padding(4, 5, 4, 5);
            cb_LoaiKhachHang.Name = "cb_LoaiKhachHang";
            cb_LoaiKhachHang.Size = new Size(162, 31);
            cb_LoaiKhachHang.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(21, 144);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 31;
            label9.Text = "Loại khách hàng(*):";
            // 
            // cb_QuocTich
            // 
            cb_QuocTich.FlatStyle = FlatStyle.System;
            cb_QuocTich.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_QuocTich.FormattingEnabled = true;
            cb_QuocTich.Items.AddRange(new object[] { "Anh", "Ai Cập", "Banana", "Việt Nam", "Trôn VN" });
            cb_QuocTich.Location = new Point(204, 228);
            cb_QuocTich.Margin = new Padding(4, 5, 4, 5);
            cb_QuocTich.Name = "cb_QuocTich";
            cb_QuocTich.Size = new Size(166, 31);
            cb_QuocTich.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(203, 207);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 29;
            label8.Text = "Quốc tịch(*):";
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_DiaChi.Location = new Point(203, 167);
            tb_DiaChi.Margin = new Padding(4, 5, 4, 5);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(167, 30);
            tb_DiaChi.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(203, 147);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 27;
            label7.Text = "Địa chỉ:";
            // 
            // tb_CCCD
            // 
            tb_CCCD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CCCD.Location = new Point(18, 106);
            tb_CCCD.Margin = new Padding(4, 5, 4, 5);
            tb_CCCD.Name = "tb_CCCD";
            tb_CCCD.Size = new Size(162, 30);
            tb_CCCD.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 84);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 25;
            label6.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 24;
            label4.Text = "Họ và tên(*): ";
            // 
            // tb_HoVaTen
            // 
            tb_HoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_HoVaTen.Location = new Point(18, 46);
            tb_HoVaTen.Margin = new Padding(4, 5, 4, 5);
            tb_HoVaTen.Name = "tb_HoVaTen";
            tb_HoVaTen.Size = new Size(162, 30);
            tb_HoVaTen.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(203, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 21;
            label3.Text = "Ngày sinh(*):";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(bt_ThemKhachHang);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Green;
            groupBox4.Location = new Point(471, 67);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(285, 293);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức Năng";
            // 
            // bt_ThemKhachHang
            // 
            bt_ThemKhachHang.Location = new Point(35, 85);
            bt_ThemKhachHang.Margin = new Padding(4, 5, 4, 5);
            bt_ThemKhachHang.Name = "bt_ThemKhachHang";
            bt_ThemKhachHang.Size = new Size(225, 131);
            bt_ThemKhachHang.TabIndex = 4;
            bt_ThemKhachHang.Text = "Thêm khách hàng";
            bt_ThemKhachHang.UseVisualStyleBackColor = true;
            bt_ThemKhachHang.Click += bt_ThemKhachHang_Click;
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ThemKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Load += ThemKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_SoDienThoai;
        private Label label5;
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
        private Label label4;
        private TextBox tb_HoVaTen;
        private Label label3;
        private GroupBox groupBox4;
        private Button bt_ThemKhachHang;
        private WebLayer.RJControls.RJDatePicker dtp_NgaySinh;
    }
}
namespace QuanLyKhachSan
{
    partial class QuanLyPhong
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
            groupTimKiem = new GroupBox();
            bt_TimKiem = new Button();
            tb_TenPhongTim = new TextBox();
            lbMaP = new Label();
            groupTTinP = new GroupBox();
            nup_SoNguoiToiDa = new NumericUpDown();
            tb_MaPhong = new TextBox();
            tb_GiaPhong = new TextBox();
            lbSoNguoi = new Label();
            lbGiaP = new Label();
            cb_LoaiPhong = new ComboBox();
            lbLoaiP = new Label();
            cb_TrangThai = new ComboBox();
            tb_TenPhong = new TextBox();
            lbTrangThai = new Label();
            lbTenP = new Label();
            lbMaP2 = new Label();
            groupChucNang = new GroupBox();
            bt_CapNhat = new Button();
            bt_ThemPhong = new Button();
            groupDSP = new GroupBox();
            dgv_DanhSachPhong = new DataGridView();
            groupTimKiem.SuspendLayout();
            groupTTinP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_SoNguoiToiDa).BeginInit();
            groupChucNang.SuspendLayout();
            groupDSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhong).BeginInit();
            SuspendLayout();
            // 
            // groupTimKiem
            // 
            groupTimKiem.Controls.Add(bt_TimKiem);
            groupTimKiem.Controls.Add(tb_TenPhongTim);
            groupTimKiem.Controls.Add(lbMaP);
            groupTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupTimKiem.ForeColor = Color.Green;
            groupTimKiem.Location = new Point(12, 13);
            groupTimKiem.Margin = new Padding(3, 4, 3, 4);
            groupTimKiem.Name = "groupTimKiem";
            groupTimKiem.Padding = new Padding(3, 4, 3, 4);
            groupTimKiem.Size = new Size(342, 133);
            groupTimKiem.TabIndex = 4;
            groupTimKiem.TabStop = false;
            groupTimKiem.Text = "Tìm kiếm ";
            // 
            // bt_TimKiem
            // 
            bt_TimKiem.Location = new Point(202, 57);
            bt_TimKiem.Margin = new Padding(3, 4, 3, 4);
            bt_TimKiem.Name = "bt_TimKiem";
            bt_TimKiem.Size = new Size(108, 40);
            bt_TimKiem.TabIndex = 2;
            bt_TimKiem.Text = "Tìm kiếm ";
            bt_TimKiem.UseVisualStyleBackColor = true;
            bt_TimKiem.Click += bt_TimKiem_Click;
            // 
            // tb_TenPhongTim
            // 
            tb_TenPhongTim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TenPhongTim.Location = new Point(6, 65);
            tb_TenPhongTim.Margin = new Padding(3, 4, 3, 4);
            tb_TenPhongTim.Name = "tb_TenPhongTim";
            tb_TenPhongTim.Size = new Size(153, 30);
            tb_TenPhongTim.TabIndex = 1;
            // 
            // lbMaP
            // 
            lbMaP.AutoSize = true;
            lbMaP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaP.Location = new Point(6, 31);
            lbMaP.Name = "lbMaP";
            lbMaP.Size = new Size(95, 23);
            lbMaP.TabIndex = 0;
            lbMaP.Text = "Tên phòng:";
            // 
            // groupTTinP
            // 
            groupTTinP.Controls.Add(nup_SoNguoiToiDa);
            groupTTinP.Controls.Add(tb_MaPhong);
            groupTTinP.Controls.Add(tb_GiaPhong);
            groupTTinP.Controls.Add(lbSoNguoi);
            groupTTinP.Controls.Add(lbGiaP);
            groupTTinP.Controls.Add(cb_LoaiPhong);
            groupTTinP.Controls.Add(lbLoaiP);
            groupTTinP.Controls.Add(cb_TrangThai);
            groupTTinP.Controls.Add(tb_TenPhong);
            groupTTinP.Controls.Add(lbTrangThai);
            groupTTinP.Controls.Add(lbTenP);
            groupTTinP.Controls.Add(lbMaP2);
            groupTTinP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupTTinP.ForeColor = Color.Green;
            groupTTinP.Location = new Point(12, 154);
            groupTTinP.Margin = new Padding(3, 4, 3, 4);
            groupTTinP.Name = "groupTTinP";
            groupTTinP.Padding = new Padding(3, 4, 3, 4);
            groupTTinP.Size = new Size(343, 256);
            groupTTinP.TabIndex = 5;
            groupTTinP.TabStop = false;
            groupTTinP.Text = "Thông tin phòng ";
            // 
            // nup_SoNguoiToiDa
            // 
            nup_SoNguoiToiDa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nup_SoNguoiToiDa.Location = new Point(179, 200);
            nup_SoNguoiToiDa.Name = "nup_SoNguoiToiDa";
            nup_SoNguoiToiDa.Size = new Size(140, 30);
            nup_SoNguoiToiDa.TabIndex = 13;
            // 
            // tb_MaPhong
            // 
            tb_MaPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaPhong.Location = new Point(11, 55);
            tb_MaPhong.Margin = new Padding(3, 4, 3, 4);
            tb_MaPhong.Name = "tb_MaPhong";
            tb_MaPhong.ReadOnly = true;
            tb_MaPhong.Size = new Size(148, 30);
            tb_MaPhong.TabIndex = 12;
            // 
            // tb_GiaPhong
            // 
            tb_GiaPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_GiaPhong.Location = new Point(178, 131);
            tb_GiaPhong.Margin = new Padding(3, 4, 3, 4);
            tb_GiaPhong.Name = "tb_GiaPhong";
            tb_GiaPhong.Size = new Size(141, 30);
            tb_GiaPhong.TabIndex = 11;
            // 
            // lbSoNguoi
            // 
            lbSoNguoi.AutoSize = true;
            lbSoNguoi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbSoNguoi.Location = new Point(179, 172);
            lbSoNguoi.Name = "lbSoNguoi";
            lbSoNguoi.Size = new Size(131, 23);
            lbSoNguoi.TabIndex = 10;
            lbSoNguoi.Text = "Số người tối đa:";
            // 
            // lbGiaP
            // 
            lbGiaP.AutoSize = true;
            lbGiaP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbGiaP.Location = new Point(179, 104);
            lbGiaP.Name = "lbGiaP";
            lbGiaP.Size = new Size(94, 23);
            lbGiaP.TabIndex = 8;
            lbGiaP.Text = "Giá phòng:";
            // 
            // cb_LoaiPhong
            // 
            cb_LoaiPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiPhong.FormattingEnabled = true;
            cb_LoaiPhong.Items.AddRange(new object[] { "VIP", "NM" });
            cb_LoaiPhong.Location = new Point(179, 55);
            cb_LoaiPhong.Margin = new Padding(3, 4, 3, 4);
            cb_LoaiPhong.Name = "cb_LoaiPhong";
            cb_LoaiPhong.Size = new Size(140, 31);
            cb_LoaiPhong.TabIndex = 7;
            // 
            // lbLoaiP
            // 
            lbLoaiP.AutoSize = true;
            lbLoaiP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbLoaiP.Location = new Point(179, 28);
            lbLoaiP.Name = "lbLoaiP";
            lbLoaiP.Size = new Size(100, 23);
            lbLoaiP.TabIndex = 6;
            lbLoaiP.Text = "Loại phòng:";
            // 
            // cb_TrangThai
            // 
            cb_TrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TrangThai.FormattingEnabled = true;
            cb_TrangThai.Items.AddRange(new object[] { "Trống", "Kín" });
            cb_TrangThai.Location = new Point(11, 199);
            cb_TrangThai.Margin = new Padding(3, 4, 3, 4);
            cb_TrangThai.Name = "cb_TrangThai";
            cb_TrangThai.Size = new Size(148, 31);
            cb_TrangThai.TabIndex = 5;
            // 
            // tb_TenPhong
            // 
            tb_TenPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TenPhong.Location = new Point(11, 131);
            tb_TenPhong.Margin = new Padding(3, 4, 3, 4);
            tb_TenPhong.Name = "tb_TenPhong";
            tb_TenPhong.Size = new Size(148, 30);
            tb_TenPhong.TabIndex = 3;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTrangThai.Location = new Point(11, 172);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(87, 23);
            lbTrangThai.TabIndex = 2;
            lbTrangThai.Text = "Trạng thái";
            // 
            // lbTenP
            // 
            lbTenP.AutoSize = true;
            lbTenP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenP.Location = new Point(11, 104);
            lbTenP.Name = "lbTenP";
            lbTenP.Size = new Size(95, 23);
            lbTenP.TabIndex = 1;
            lbTenP.Text = "Tên phòng:";
            // 
            // lbMaP2
            // 
            lbMaP2.AutoSize = true;
            lbMaP2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaP2.Location = new Point(11, 28);
            lbMaP2.Name = "lbMaP2";
            lbMaP2.Size = new Size(93, 23);
            lbMaP2.TabIndex = 0;
            lbMaP2.Text = "Mã phòng:";
            // 
            // groupChucNang
            // 
            groupChucNang.Controls.Add(bt_CapNhat);
            groupChucNang.Controls.Add(bt_ThemPhong);
            groupChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupChucNang.ForeColor = Color.Green;
            groupChucNang.Location = new Point(7, 418);
            groupChucNang.Margin = new Padding(3, 4, 3, 4);
            groupChucNang.Name = "groupChucNang";
            groupChucNang.Padding = new Padding(3, 4, 3, 4);
            groupChucNang.Size = new Size(347, 201);
            groupChucNang.TabIndex = 6;
            groupChucNang.TabStop = false;
            groupChucNang.Text = "Chức năng";
            // 
            // bt_CapNhat
            // 
            bt_CapNhat.Location = new Point(183, 35);
            bt_CapNhat.Margin = new Padding(3, 4, 3, 4);
            bt_CapNhat.Name = "bt_CapNhat";
            bt_CapNhat.Size = new Size(141, 67);
            bt_CapNhat.TabIndex = 2;
            bt_CapNhat.Text = "Cập nhật";
            bt_CapNhat.UseVisualStyleBackColor = true;
            bt_CapNhat.Click += bt_CapNhat_Click;
            // 
            // bt_ThemPhong
            // 
            bt_ThemPhong.Location = new Point(16, 35);
            bt_ThemPhong.Margin = new Padding(3, 4, 3, 4);
            bt_ThemPhong.Name = "bt_ThemPhong";
            bt_ThemPhong.Size = new Size(148, 67);
            bt_ThemPhong.TabIndex = 0;
            bt_ThemPhong.Text = "Thêm phòng ";
            bt_ThemPhong.UseVisualStyleBackColor = true;
            bt_ThemPhong.Click += btThemP_Click;
            // 
            // groupDSP
            // 
            groupDSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupDSP.Controls.Add(dgv_DanhSachPhong);
            groupDSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupDSP.ForeColor = Color.Green;
            groupDSP.Location = new Point(361, 13);
            groupDSP.Margin = new Padding(3, 4, 3, 4);
            groupDSP.Name = "groupDSP";
            groupDSP.Padding = new Padding(3, 4, 3, 4);
            groupDSP.Size = new Size(909, 727);
            groupDSP.TabIndex = 7;
            groupDSP.TabStop = false;
            groupDSP.Text = "Danh sách phòng ";
            // 
            // dgv_DanhSachPhong
            // 
            dgv_DanhSachPhong.AllowUserToAddRows = false;
            dgv_DanhSachPhong.AllowUserToDeleteRows = false;
            dgv_DanhSachPhong.AllowUserToResizeColumns = false;
            dgv_DanhSachPhong.AllowUserToResizeRows = false;
            dgv_DanhSachPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachPhong.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachPhong.Location = new Point(6, 27);
            dgv_DanhSachPhong.MultiSelect = false;
            dgv_DanhSachPhong.Name = "dgv_DanhSachPhong";
            dgv_DanhSachPhong.ReadOnly = true;
            dgv_DanhSachPhong.RowHeadersVisible = false;
            dgv_DanhSachPhong.RowHeadersWidth = 51;
            dgv_DanhSachPhong.RowTemplate.Height = 33;
            dgv_DanhSachPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachPhong.Size = new Size(897, 693);
            dgv_DanhSachPhong.TabIndex = 0;
            dgv_DanhSachPhong.CellClick += dgv_DanhSachPhong_CellClick;
            // 
            // QuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(groupDSP);
            Controls.Add(groupChucNang);
            Controls.Add(groupTTinP);
            Controls.Add(groupTimKiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyPhong";
            Load += QuanLyPhong_Load;
            groupTimKiem.ResumeLayout(false);
            groupTimKiem.PerformLayout();
            groupTTinP.ResumeLayout(false);
            groupTTinP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_SoNguoiToiDa).EndInit();
            groupChucNang.ResumeLayout(false);
            groupDSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupTimKiem;
        private Button bt_TimKiem;
        private TextBox tb_TenPhongTim;
        private Label lbMaP;
        private GroupBox groupTTinP;
        private TextBox tb_GiaPhong;
        private Label lbSoNguoi;
        private Label lbGiaP;
        private ComboBox cb_LoaiPhong;
        private Label lbLoaiP;
        private ComboBox cb_TrangThai;
        private TextBox tb_TenPhong;
        private Label lbTrangThai;
        private Label lbTenP;
        private Label lbMaP2;
        private GroupBox groupChucNang;
        private Button bt_CapNhat;
        private Button bt_ThemPhong;
        private GroupBox groupDSP;
        private DataGridView dgv_DanhSachPhong;
        private TextBox tb_MaPhong;
        private NumericUpDown nup_SoNguoiToiDa;
    }
}
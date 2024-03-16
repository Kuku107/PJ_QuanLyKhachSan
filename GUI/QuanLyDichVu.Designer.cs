namespace QuanLyKhachSan
{
    partial class QuanLyDichVu
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
            groupBox3 = new GroupBox();
            bt_Xoa = new Button();
            bt_CapNhat = new Button();
            bt_Them = new Button();
            gb_TimKiem = new GroupBox();
            cb_LoaiDichVuTim = new ComboBox();
            lb_LoaiDichVu = new Label();
            bt_TimKiem = new Button();
            gb_ThongTinDichVu = new GroupBox();
            tb_MaDichVu = new TextBox();
            tb_TenDichVu = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tb_Gia = new TextBox();
            label4 = new Label();
            cb_LoaiDichVu = new ComboBox();
            label5 = new Label();
            groupBox5 = new GroupBox();
            dgv_DanhSachDichVu = new DataGridView();
            groupBox3.SuspendLayout();
            gb_TimKiem.SuspendLayout();
            gb_ThongTinDichVu.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_Xoa);
            groupBox3.Controls.Add(bt_CapNhat);
            groupBox3.Controls.Add(bt_Them);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Green;
            groupBox3.Location = new Point(320, 216);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(255, 372);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng ";
            // 
            // bt_Xoa
            // 
            bt_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Xoa.ForeColor = Color.Green;
            bt_Xoa.Location = new Point(8, 269);
            bt_Xoa.Margin = new Padding(4, 3, 4, 3);
            bt_Xoa.Name = "bt_Xoa";
            bt_Xoa.Size = new Size(239, 38);
            bt_Xoa.TabIndex = 7;
            bt_Xoa.Text = "Xóa";
            bt_Xoa.UseVisualStyleBackColor = true;
            bt_Xoa.Click += bt_Xoa_Click;
            // 
            // bt_CapNhat
            // 
            bt_CapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_CapNhat.ForeColor = Color.Green;
            bt_CapNhat.Location = new Point(8, 176);
            bt_CapNhat.Margin = new Padding(4, 3, 4, 3);
            bt_CapNhat.Name = "bt_CapNhat";
            bt_CapNhat.Size = new Size(239, 38);
            bt_CapNhat.TabIndex = 5;
            bt_CapNhat.Text = "Cập nhật";
            bt_CapNhat.UseVisualStyleBackColor = true;
            bt_CapNhat.Click += bt_CapNhat_Click;
            // 
            // bt_Them
            // 
            bt_Them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Them.ForeColor = Color.Green;
            bt_Them.Location = new Point(8, 89);
            bt_Them.Margin = new Padding(4, 3, 4, 3);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(239, 38);
            bt_Them.TabIndex = 3;
            bt_Them.Text = "Thêm";
            bt_Them.UseVisualStyleBackColor = true;
            bt_Them.Click += bt_Them_Click;
            // 
            // gb_TimKiem
            // 
            gb_TimKiem.Controls.Add(cb_LoaiDichVuTim);
            gb_TimKiem.Controls.Add(lb_LoaiDichVu);
            gb_TimKiem.Controls.Add(bt_TimKiem);
            gb_TimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_TimKiem.ForeColor = Color.Green;
            gb_TimKiem.Location = new Point(16, 12);
            gb_TimKiem.Margin = new Padding(4, 3, 4, 3);
            gb_TimKiem.Name = "gb_TimKiem";
            gb_TimKiem.Padding = new Padding(4, 3, 4, 3);
            gb_TimKiem.Size = new Size(559, 151);
            gb_TimKiem.TabIndex = 11;
            gb_TimKiem.TabStop = false;
            gb_TimKiem.Text = "Tìm kiếm";
            // 
            // cb_LoaiDichVuTim
            // 
            cb_LoaiDichVuTim.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiDichVuTim.FormattingEnabled = true;
            cb_LoaiDichVuTim.Items.AddRange(new object[] { "Nước uống", "Đồ ăn", "Giặt là", "Vệ sinh" });
            cb_LoaiDichVuTim.Location = new Point(8, 81);
            cb_LoaiDichVuTim.Margin = new Padding(4, 3, 4, 3);
            cb_LoaiDichVuTim.Name = "cb_LoaiDichVuTim";
            cb_LoaiDichVuTim.Size = new Size(235, 28);
            cb_LoaiDichVuTim.TabIndex = 8;
            // 
            // lb_LoaiDichVu
            // 
            lb_LoaiDichVu.AutoSize = true;
            lb_LoaiDichVu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_LoaiDichVu.ForeColor = Color.Green;
            lb_LoaiDichVu.Location = new Point(8, 47);
            lb_LoaiDichVu.Margin = new Padding(4, 0, 4, 0);
            lb_LoaiDichVu.Name = "lb_LoaiDichVu";
            lb_LoaiDichVu.Size = new Size(104, 20);
            lb_LoaiDichVu.TabIndex = 2;
            lb_LoaiDichVu.Text = "Loại dịch vụ:";
            // 
            // bt_TimKiem
            // 
            bt_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_TimKiem.ForeColor = Color.Green;
            bt_TimKiem.Location = new Point(312, 72);
            bt_TimKiem.Margin = new Padding(4, 3, 4, 3);
            bt_TimKiem.Name = "bt_TimKiem";
            bt_TimKiem.Size = new Size(239, 38);
            bt_TimKiem.TabIndex = 2;
            bt_TimKiem.Text = "Tìm kiếm ";
            bt_TimKiem.UseVisualStyleBackColor = true;
            bt_TimKiem.Click += bt_TimKiem_Click;
            // 
            // gb_ThongTinDichVu
            // 
            gb_ThongTinDichVu.Controls.Add(tb_MaDichVu);
            gb_ThongTinDichVu.Controls.Add(tb_TenDichVu);
            gb_ThongTinDichVu.Controls.Add(label1);
            gb_ThongTinDichVu.Controls.Add(label3);
            gb_ThongTinDichVu.Controls.Add(tb_Gia);
            gb_ThongTinDichVu.Controls.Add(label4);
            gb_ThongTinDichVu.Controls.Add(cb_LoaiDichVu);
            gb_ThongTinDichVu.Controls.Add(label5);
            gb_ThongTinDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_ThongTinDichVu.ForeColor = Color.Green;
            gb_ThongTinDichVu.Location = new Point(15, 216);
            gb_ThongTinDichVu.Margin = new Padding(4, 3, 4, 3);
            gb_ThongTinDichVu.Name = "gb_ThongTinDichVu";
            gb_ThongTinDichVu.Padding = new Padding(4, 3, 4, 3);
            gb_ThongTinDichVu.Size = new Size(298, 372);
            gb_ThongTinDichVu.TabIndex = 12;
            gb_ThongTinDichVu.TabStop = false;
            gb_ThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // tb_MaDichVu
            // 
            tb_MaDichVu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaDichVu.Location = new Point(9, 70);
            tb_MaDichVu.Name = "tb_MaDichVu";
            tb_MaDichVu.ReadOnly = true;
            tb_MaDichVu.Size = new Size(234, 30);
            tb_MaDichVu.TabIndex = 16;
            // 
            // tb_TenDichVu
            // 
            tb_TenDichVu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TenDichVu.Location = new Point(9, 147);
            tb_TenDichVu.Margin = new Padding(4, 3, 4, 3);
            tb_TenDichVu.Name = "tb_TenDichVu";
            tb_TenDichVu.Size = new Size(234, 27);
            tb_TenDichVu.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 44);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 15;
            label1.Text = "Mã dịch vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 6;
            label3.Text = "(*)Tên dịch vụ:";
            // 
            // tb_Gia
            // 
            tb_Gia.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Gia.Location = new Point(9, 320);
            tb_Gia.Margin = new Padding(4, 3, 4, 3);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(241, 27);
            tb_Gia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá:";
            // 
            // cb_LoaiDichVu
            // 
            cb_LoaiDichVu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiDichVu.FormattingEnabled = true;
            cb_LoaiDichVu.Items.AddRange(new object[] { "Nước uống", "Đồ ăn", "Giặt là", "Vệ sinh" });
            cb_LoaiDichVu.Location = new Point(9, 235);
            cb_LoaiDichVu.Margin = new Padding(4, 3, 4, 3);
            cb_LoaiDichVu.Name = "cb_LoaiDichVu";
            cb_LoaiDichVu.Size = new Size(234, 28);
            cb_LoaiDichVu.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 212);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 2;
            label5.Text = "(*)Loại dịch vụ:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_DanhSachDichVu);
            groupBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.Green;
            groupBox5.Location = new Point(595, 12);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(674, 729);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách dịch vụ:";
            // 
            // dgv_DanhSachDichVu
            // 
            dgv_DanhSachDichVu.AllowUserToAddRows = false;
            dgv_DanhSachDichVu.AllowUserToDeleteRows = false;
            dgv_DanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachDichVu.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachDichVu.Location = new Point(8, 29);
            dgv_DanhSachDichVu.Margin = new Padding(4, 3, 4, 3);
            dgv_DanhSachDichVu.MultiSelect = false;
            dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            dgv_DanhSachDichVu.ReadOnly = true;
            dgv_DanhSachDichVu.RowHeadersVisible = false;
            dgv_DanhSachDichVu.RowHeadersWidth = 62;
            dgv_DanhSachDichVu.RowTemplate.Height = 33;
            dgv_DanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachDichVu.Size = new Size(658, 694);
            dgv_DanhSachDichVu.TabIndex = 0;
            dgv_DanhSachDichVu.CellClick += dgv_DanhSachDichVu_CellClick;
            // 
            // QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(groupBox3);
            Controls.Add(gb_TimKiem);
            Controls.Add(gb_ThongTinDichVu);
            Controls.Add(groupBox5);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyDichVu";
            Load += QuanLyDichVu_Load;
            groupBox3.ResumeLayout(false);
            gb_TimKiem.ResumeLayout(false);
            gb_TimKiem.PerformLayout();
            gb_ThongTinDichVu.ResumeLayout(false);
            gb_ThongTinDichVu.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private Button bt_Xoa;
        private Button bt_Dong;
        private Button bt_CapNhat;
        private Button bt_Them;
        private GroupBox gb_TimKiem;
        private TextBox tb_TenDichVu_Tim;
        private Label lb_TenDichVu;
        private Button bt_TimKiem;
        private GroupBox gb_ThongTinDichVu;
        private TextBox tb_TenDichVu;
        private Label label3;
        private TextBox tb_Gia;
        private Label label4;
        private ComboBox cb_LoaiDichVu;
        private Label label5;
        private GroupBox groupBox5;
        private DataGridView dataGridView1;
        private ComboBox cb_LoaiDichVuTim;
        private Label lb_LoaiDichVu;
        private DataGridView dgv_DanhSachDichVu;
        private Label label1;
        private TextBox tb_MaDichVu;
    }
}
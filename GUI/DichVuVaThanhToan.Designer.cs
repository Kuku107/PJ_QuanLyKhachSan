namespace QuanLyKhachSan
{
    partial class DichVuVaThanhToan
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
            groupBox2 = new GroupBox();
            dgv_DanhSachPhongKin = new DataGridView();
            bt_ThanhToan = new Button();
            groupBox1 = new GroupBox();
            bt_TimKiem = new Button();
            cb_LoaiPhong = new ComboBox();
            tb_TenPhong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            bt_DichVu = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhongKin).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_DanhSachPhongKin);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Green;
            groupBox2.Location = new Point(13, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1257, 567);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng kín";
            // 
            // dgv_DanhSachPhongKin
            // 
            dgv_DanhSachPhongKin.AllowUserToAddRows = false;
            dgv_DanhSachPhongKin.AllowUserToDeleteRows = false;
            dgv_DanhSachPhongKin.AllowUserToResizeColumns = false;
            dgv_DanhSachPhongKin.AllowUserToResizeRows = false;
            dgv_DanhSachPhongKin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachPhongKin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachPhongKin.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachPhongKin.Location = new Point(6, 33);
            dgv_DanhSachPhongKin.MultiSelect = false;
            dgv_DanhSachPhongKin.Name = "dgv_DanhSachPhongKin";
            dgv_DanhSachPhongKin.ReadOnly = true;
            dgv_DanhSachPhongKin.RowHeadersVisible = false;
            dgv_DanhSachPhongKin.RowHeadersWidth = 51;
            dgv_DanhSachPhongKin.RowTemplate.Height = 33;
            dgv_DanhSachPhongKin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachPhongKin.Size = new Size(1245, 528);
            dgv_DanhSachPhongKin.TabIndex = 0;
            // 
            // bt_ThanhToan
            // 
            bt_ThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_ThanhToan.ForeColor = Color.Green;
            bt_ThanhToan.Location = new Point(988, 585);
            bt_ThanhToan.Name = "bt_ThanhToan";
            bt_ThanhToan.Size = new Size(183, 156);
            bt_ThanhToan.TabIndex = 21;
            bt_ThanhToan.Text = "Thanh toán";
            bt_ThanhToan.UseVisualStyleBackColor = true;
            bt_ThanhToan.Click += bt_ThanhToan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_TimKiem);
            groupBox1.Controls.Add(cb_LoaiPhong);
            groupBox1.Controls.Add(tb_TenPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(19, 585);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 156);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm phòng";
            // 
            // bt_TimKiem
            // 
            bt_TimKiem.Location = new Point(380, 39);
            bt_TimKiem.Name = "bt_TimKiem";
            bt_TimKiem.Size = new Size(99, 96);
            bt_TimKiem.TabIndex = 3;
            bt_TimKiem.Text = "Tìm kiếm";
            bt_TimKiem.UseVisualStyleBackColor = true;
            bt_TimKiem.Click += bt_TimKiem_Click;
            // 
            // cb_LoaiPhong
            // 
            cb_LoaiPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LoaiPhong.FormattingEnabled = true;
            cb_LoaiPhong.Items.AddRange(new object[] { "VIP", "NM" });
            cb_LoaiPhong.Location = new Point(134, 104);
            cb_LoaiPhong.Name = "cb_LoaiPhong";
            cb_LoaiPhong.Size = new Size(220, 31);
            cb_LoaiPhong.TabIndex = 2;
            // 
            // tb_TenPhong
            // 
            tb_TenPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TenPhong.Location = new Point(134, 39);
            tb_TenPhong.Name = "tb_TenPhong";
            tb_TenPhong.Size = new Size(220, 30);
            tb_TenPhong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 0;
            label4.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên phòng";
            // 
            // bt_DichVu
            // 
            bt_DichVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_DichVu.ForeColor = Color.Green;
            bt_DichVu.Location = new Point(719, 585);
            bt_DichVu.Name = "bt_DichVu";
            bt_DichVu.Size = new Size(183, 156);
            bt_DichVu.TabIndex = 23;
            bt_DichVu.Text = "Dịch vụ";
            bt_DichVu.UseVisualStyleBackColor = true;
            bt_DichVu.Click += bt_DichVu_Click;
            // 
            // DichVuVaThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(bt_DichVu);
            Controls.Add(groupBox1);
            Controls.Add(bt_ThanhToan);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DichVuVaThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += DichVuVaThanhToan_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhongKin).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button bt_ThanhToan;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox tb_TenPhong;
        private ComboBox cb_LoaiPhong;
        private Label label4;
        private Button bt_TimKiem;
        private Button bt_DichVu;
        private DataGridView dgv_DanhSachPhong;
        private DataGridView dgv_DanhSachPhongKin;
    }
}
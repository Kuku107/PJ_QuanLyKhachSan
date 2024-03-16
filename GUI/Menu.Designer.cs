namespace QuanLyKhachSan
{
    partial class Menu
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
            pn_Left = new Panel();
            bt_QuanLyPhong = new Button();
            bt_QuanLyKhachHang = new Button();
            bt_QuanLyDichVu = new Button();
            bt_DichVuVaThanhToan = new Button();
            bt_DatPhong = new Button();
            pictureBox1 = new PictureBox();
            pn_Top = new Panel();
            lb_Header = new Label();
            pn_Body = new Panel();
            pictureBox2 = new PictureBox();
            pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn_Top.SuspendLayout();
            pn_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pn_Left
            // 
            pn_Left.BackColor = Color.SeaGreen;
            pn_Left.Controls.Add(bt_QuanLyPhong);
            pn_Left.Controls.Add(bt_QuanLyKhachHang);
            pn_Left.Controls.Add(bt_QuanLyDichVu);
            pn_Left.Controls.Add(bt_DichVuVaThanhToan);
            pn_Left.Controls.Add(bt_DatPhong);
            pn_Left.Controls.Add(pictureBox1);
            pn_Left.Dock = DockStyle.Left;
            pn_Left.Location = new Point(0, 0);
            pn_Left.Name = "pn_Left";
            pn_Left.Size = new Size(226, 860);
            pn_Left.TabIndex = 0;
            // 
            // bt_QuanLyPhong
            // 
            bt_QuanLyPhong.Dock = DockStyle.Top;
            bt_QuanLyPhong.FlatAppearance.BorderSize = 0;
            bt_QuanLyPhong.FlatStyle = FlatStyle.Flat;
            bt_QuanLyPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bt_QuanLyPhong.ForeColor = Color.White;
            bt_QuanLyPhong.Location = new Point(0, 404);
            bt_QuanLyPhong.Name = "bt_QuanLyPhong";
            bt_QuanLyPhong.Size = new Size(226, 61);
            bt_QuanLyPhong.TabIndex = 5;
            bt_QuanLyPhong.Text = "Quản Lý Phòng";
            bt_QuanLyPhong.UseVisualStyleBackColor = true;
            bt_QuanLyPhong.Click += bt_QuanLyPhong_Click;
            // 
            // bt_QuanLyKhachHang
            // 
            bt_QuanLyKhachHang.Dock = DockStyle.Top;
            bt_QuanLyKhachHang.FlatAppearance.BorderSize = 0;
            bt_QuanLyKhachHang.FlatStyle = FlatStyle.Flat;
            bt_QuanLyKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bt_QuanLyKhachHang.ForeColor = Color.White;
            bt_QuanLyKhachHang.Location = new Point(0, 343);
            bt_QuanLyKhachHang.Name = "bt_QuanLyKhachHang";
            bt_QuanLyKhachHang.Size = new Size(226, 61);
            bt_QuanLyKhachHang.TabIndex = 4;
            bt_QuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            bt_QuanLyKhachHang.UseVisualStyleBackColor = true;
            bt_QuanLyKhachHang.Click += bt_QuanLyKhachHang_Click;
            // 
            // bt_QuanLyDichVu
            // 
            bt_QuanLyDichVu.Dock = DockStyle.Top;
            bt_QuanLyDichVu.FlatAppearance.BorderSize = 0;
            bt_QuanLyDichVu.FlatStyle = FlatStyle.Flat;
            bt_QuanLyDichVu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bt_QuanLyDichVu.ForeColor = Color.White;
            bt_QuanLyDichVu.Location = new Point(0, 282);
            bt_QuanLyDichVu.Name = "bt_QuanLyDichVu";
            bt_QuanLyDichVu.Size = new Size(226, 61);
            bt_QuanLyDichVu.TabIndex = 3;
            bt_QuanLyDichVu.Text = "Quản Lý Dịch Vụ";
            bt_QuanLyDichVu.UseVisualStyleBackColor = true;
            bt_QuanLyDichVu.Click += bt_QuanLyDichVu_Click;
            // 
            // bt_DichVuVaThanhToan
            // 
            bt_DichVuVaThanhToan.Dock = DockStyle.Top;
            bt_DichVuVaThanhToan.FlatAppearance.BorderSize = 0;
            bt_DichVuVaThanhToan.FlatStyle = FlatStyle.Flat;
            bt_DichVuVaThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bt_DichVuVaThanhToan.ForeColor = Color.White;
            bt_DichVuVaThanhToan.Location = new Point(0, 221);
            bt_DichVuVaThanhToan.Name = "bt_DichVuVaThanhToan";
            bt_DichVuVaThanhToan.Size = new Size(226, 61);
            bt_DichVuVaThanhToan.TabIndex = 2;
            bt_DichVuVaThanhToan.Text = "Dịch Vụ Và Thanh Toán";
            bt_DichVuVaThanhToan.UseVisualStyleBackColor = true;
            bt_DichVuVaThanhToan.Click += bt_DichVuVaThanhToan_Click;
            // 
            // bt_DatPhong
            // 
            bt_DatPhong.Dock = DockStyle.Top;
            bt_DatPhong.FlatAppearance.BorderSize = 0;
            bt_DatPhong.FlatStyle = FlatStyle.Flat;
            bt_DatPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bt_DatPhong.ForeColor = Color.White;
            bt_DatPhong.Location = new Point(0, 160);
            bt_DatPhong.Name = "bt_DatPhong";
            bt_DatPhong.Size = new Size(226, 61);
            bt_DatPhong.TabIndex = 1;
            bt_DatPhong.Text = "Đặt Phòng";
            bt_DatPhong.UseVisualStyleBackColor = true;
            bt_DatPhong.Click += bt_DatPhong_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = WebLayer.Properties.Resources.icon_khachsan;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pn_Top
            // 
            pn_Top.BackColor = Color.SeaGreen;
            pn_Top.Controls.Add(lb_Header);
            pn_Top.Dock = DockStyle.Top;
            pn_Top.Location = new Point(226, 0);
            pn_Top.Name = "pn_Top";
            pn_Top.Size = new Size(1282, 107);
            pn_Top.TabIndex = 1;
            // 
            // lb_Header
            // 
            lb_Header.Dock = DockStyle.Fill;
            lb_Header.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Header.ForeColor = Color.White;
            lb_Header.Location = new Point(0, 0);
            lb_Header.Name = "lb_Header";
            lb_Header.Size = new Size(1282, 107);
            lb_Header.TabIndex = 0;
            lb_Header.Text = "Home";
            lb_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_Body
            // 
            pn_Body.BackColor = Color.White;
            pn_Body.Controls.Add(pictureBox2);
            pn_Body.Dock = DockStyle.Fill;
            pn_Body.Location = new Point(226, 107);
            pn_Body.Name = "pn_Body";
            pn_Body.Size = new Size(1282, 753);
            pn_Body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = WebLayer.Properties.Resources.R;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1282, 753);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 860);
            Controls.Add(pn_Body);
            Controls.Add(pn_Top);
            Controls.Add(pn_Left);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Sạn";
            FormClosed += Menu_FormClosed;
            pn_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn_Top.ResumeLayout(false);
            pn_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Left;
        private PictureBox pictureBox1;
        private Button bt_QuanLyPhong;
        private Button bt_QuanLyKhachHang;
        private Button bt_QuanLyDichVu;
        private Button bt_DichVuVaThanhToan;
        private Button bt_DatPhong;
        private Panel pn_Top;
        private Label lb_Header;
        private Panel pn_Body;
        private PictureBox pictureBox2;
    }
}
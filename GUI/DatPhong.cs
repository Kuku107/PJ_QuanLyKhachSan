using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DataLayer;
using DataTransferObject;
using ServiceLayer;
namespace QuanLyKhachSan
{
    public partial class DatPhong : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        HoaDonBLL hoaDonBLL= new HoaDonBLL();
        PhongBLL phongBLL = new PhongBLL();
        public DatPhong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_DanhSachPhongTrong.DataSource = phongBLL.getDanhSachPhongTrong();
            tb_CCCD.Text = "";
            tb_DiaChi.Text = "";
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_DanhSachPhongTrong.DataSource =
                phongBLL.findPhongTrong(cb_LoaiPhong.Text, int.Parse(nup_SoNguoi.Text));
        }

        

        private KhachHang addKhachHang()
        {
            KhachHang khachHang = new KhachHang("KH", tb_HoVaTen.Text, tb_CCCD.Text,
                tb_SoDienThoai.Text, dtp_NgaySinh.Value, tb_DiaChi.Text, cb_LoaiKhachHang.Text, cb_GioiTinh.Text, cb_QuocTich.Text);
            if (!QuanLyKhachHang.checkKhachHang(khachHang))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng");
                return null;
            }
            khachHangBLL.addKhachHang(khachHang);
            return khachHang;
        }

        private void addHoaDon(int giaPhong, string maKh, string maPhong)
        {
            long tongTien = ((dtp_NgayTra.Value - dtp_NgayNhan.Value).Days + 1) * giaPhong;
            HoaDon hoaDon = new HoaDon(maKh, maPhong, dtp_NgayNhan.Value, dtp_NgayTra.Value, tongTien);
            hoaDonBLL.addHoaDon(hoaDon);
        }

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {
            // Thêm khách hàng
            KhachHang khachHang = addKhachHang();
            if (khachHang == null)
            {
                return;
            }

            // lấy mã khách vừa thêm, lấy mã phòng và giá phòng muốn đặt
            string maKh = khachHang.getMaKhach();
            DataGridViewRow selectedRow = dgv_DanhSachPhongTrong.SelectedRows[0];
            string? maPhong = selectedRow.Cells["Mã phòng"].Value.ToString();
            int giaPhong = int.Parse(selectedRow.Cells["Giá phòng"].Value.ToString());
            
            // Thêm hóa đơn và cập nhật trạng thái phòng
            addHoaDon(giaPhong, maKh, maPhong);
            phongBLL.setTrangThaiPhong(maPhong, "Kín");

            // Xác nhận đặt phòng thành công
            MessageBox.Show("Đặt phòng thành công");
            dgv_DanhSachPhongTrong.DataSource = phongBLL.getDanhSachPhongTrong();
        }
    }
}

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

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang("KH", tb_HoVaTen.Text, tb_CCCD.Text, 
                tb_SoDienThoai.Text, dtp_NgaySinh.Value, tb_DiaChi.Text, cb_LoaiKhachHang.Text, cb_GioiTinh.Text, cb_QuocTich.Text);
            switch (khachHangBLL.addKhachHang(khachHang))
            {
                case "khong du thong tin":
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                    return;
                case "them thanh cong":
                    break;
            }
            string maKh = khachHang.getMaKhach();
            DataGridViewRow selectedRow = dgv_DanhSachPhongTrong.SelectedRows[0];
            string? maPhong = selectedRow.Cells["Mã phòng"].Value.ToString();
            int giaPhong = int.Parse(selectedRow.Cells["Giá phòng"].Value.ToString());
            long tongTien = (dtp_NgayTra.Value - dtp_NgayNhan.Value).Days * giaPhong;
            HoaDon hoaDon = new HoaDon(maKh, maPhong, dtp_NgayNhan.Value, dtp_NgayTra.Value, tongTien);
            hoaDonBLL.addHoaDon(hoaDon);
            phongBLL.setTrangThaiPhong(maPhong, "Kín");
            MessageBox.Show("Đặt phòng thành công");
            dgv_DanhSachPhongTrong.DataSource = phongBLL.getDanhSachPhongTrong();
        }
    }
}

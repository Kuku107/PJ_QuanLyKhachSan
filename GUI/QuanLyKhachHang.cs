using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using ServiceLayer;
using DataTransferObject;


namespace QuanLyKhachSan
{
    public partial class QuanLyKhachHang : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgv_DanhSachKhachHang.DataSource = khachHangBLL.getDanhSachKhachHang();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            dgv_DanhSachKhachHang.DataSource = khachHangBLL.findKhachHang(tb_HoVaTenTim.Text);
        }

        private void dgv_DanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_DanhSachKhachHang.Rows[e.RowIndex];
                tb_MaKhach.Text = selectedRow.Cells["Mã khách"].Value.ToString();
                tb_HoVaTen.Text = selectedRow.Cells["Họ và tên"].Value.ToString();
                tb_CCCD.Text = selectedRow.Cells["CCCD"].Value.ToString();
                cb_LoaiKhachHang.Text = selectedRow.Cells["Loại khách hàng"].Value.ToString();
                tb_SoDienThoai.Text = selectedRow.Cells["Số điện thoại"].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["Ngày sinh"].Value.ToString());
                cb_GioiTinh.Text = selectedRow.Cells["Giới tính"].Value.ToString();
                tb_DiaChi.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                cb_QuocTich.Text = selectedRow.Cells["Quốc tịch"].Value.ToString();
            }
        }

        public static bool checkKhachHang(KhachHang khachHang)
        {
            if (khachHang.getMaKhach() == "" || khachHang.getLoaiKhachHang() == "" || khachHang.getHoVaTen() == "" ||
                khachHang.getSoDienThoai() == "" || khachHang.getQuocTich() == "")
            {
                return false;
            }
            return true;
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang(tb_MaKhach.Text, tb_HoVaTen.Text, tb_CCCD.Text, tb_SoDienThoai.Text, dtp_NgaySinh.Value, 
                                                tb_DiaChi.Text, cb_LoaiKhachHang.Text, cb_GioiTinh.Text, cb_QuocTich.Text);
            if (!checkKhachHang(khachHang))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng");
                return;
            }

            khachHangBLL.updateKhachHang(khachHang);
            dgv_DanhSachKhachHang.DataSource = khachHangBLL.getDanhSachKhachHang();
            MessageBox.Show("Cập nhật thông tin thành công");
        }
    }
}

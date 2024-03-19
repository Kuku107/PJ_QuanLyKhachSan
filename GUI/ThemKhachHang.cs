using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using ServiceLayer;

namespace QuanLyKhachSan
{
    public partial class ThemKhachHang : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void bt_ThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang("KH", tb_HoVaTen.Text, tb_CCCD.Text,
                tb_SoDienThoai.Text, dtp_NgaySinh.Value, tb_DiaChi.Text, cb_LoaiKhachHang.Text, cb_GioiTinh.Text, cb_QuocTich.Text);
            if (!QuanLyKhachHang.checkKhachHang(khachHang))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng");
                return;
            }
            khachHangBLL.addKhachHang(khachHang);
            MessageBox.Show("Thêm khách hàng thành công");
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            tb_CCCD.Text = "";
            tb_DiaChi.Text = "";
        }
    }
}

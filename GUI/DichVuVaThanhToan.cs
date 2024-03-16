using DataLayer;
using ServiceLayer;
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

namespace QuanLyKhachSan
{
    public partial class DichVuVaThanhToan : Form
    {
        private PhongBLL phongBLL = new PhongBLL();
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public DichVuVaThanhToan()
        {
            InitializeComponent();
        }

        private void bt_DichVu_Click(object sender, EventArgs e)
        {
            string maPhong = dgv_DanhSachPhongKin.SelectedRows[0].Cells["Mã Phòng"].Value.ToString();
            SuDungDichVu suDungDichVu = new SuDungDichVu(maPhong);
            suDungDichVu.ShowDialog();
        }

        private void DichVuVaThanhToan_Load(object sender, EventArgs e)
        {
            dgv_DanhSachPhongKin.DataSource = phongBLL.getDanhSachPhongKin();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_DanhSachPhongKin.DataSource = phongBLL.findPhongKin(tb_TenPhong.Text, cb_LoaiPhong.Text);
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            string maPhong = dgv_DanhSachPhongKin.SelectedRows[0].Cells["Mã Phòng"].Value.ToString();
            phongBLL.setTrangThaiPhong(maPhong, "Trống");
            MessageBox.Show("Tiền phòng: " + hoaDonBLL.getTienPhong(maPhong).ToString());
            dgv_DanhSachPhongKin.DataSource = phongBLL.getDanhSachPhongKin();
        }
    }
}

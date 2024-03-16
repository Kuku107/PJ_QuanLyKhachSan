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

namespace QuanLyKhachSan
{
    public partial class SuDungDichVu : Form
    {
        private string maPhong;
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private DichVuBLL dichVuBLL = new DichVuBLL();
        public SuDungDichVu(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            dgv_DanhSachDichVu.DataSource = dichVuBLL.getDanhSachDichVu();
        }

        private void cb_LoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_DanhSachDichVu.DataSource = dichVuBLL.findDichVu(cb_LoaiDichVu.Text);
        }

        private void bt_SuDung_Click(object sender, EventArgs e)
        {
            long giaDichVuSelected = Convert.ToInt64(dgv_DanhSachDichVu.SelectedRows[0].Cells["Giá"].Value.ToString());
            long tongTien = giaDichVuSelected * Convert.ToInt64(nud_SoLuong.Value);
            hoaDonBLL.addTien(maPhong, tongTien);
            MessageBox.Show("Sử dụng dịch vụ thành công");
        }
    }
}

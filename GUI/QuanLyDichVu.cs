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
using DataTransferObject;
using ServiceLayer;

namespace QuanLyKhachSan
{
    public partial class QuanLyDichVu : Form
    {
        private DichVuBLL dichVuBLL = new DichVuBLL();

        public QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
            var result = themDichVu.DialogResult;
            if (result == DialogResult.Cancel)
            {
                dgv_DanhSachDichVu.DataSource = dichVuBLL.getDanhSachDichVu();
            }
        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            dgv_DanhSachDichVu.DataSource = dichVuBLL.getDanhSachDichVu();
            tb_Gia.Text = "0";
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_DanhSachDichVu.DataSource = dichVuBLL.findDichVu(cb_LoaiDichVuTim.Text);
        }

        private void dgv_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_DanhSachDichVu.Rows[e.RowIndex];
                tb_MaDichVu.Text = row.Cells["Mã dịch vụ"].Value.ToString();
                tb_TenDichVu.Text = row.Cells["Tên dịch vụ"].Value.ToString();
                cb_LoaiDichVu.Text = row.Cells["Loại dịch vụ"].Value.ToString();
                tb_Gia.Text = row.Cells["Giá"].Value.ToString();
            }
        }

        public static bool checkDichVu(DichVu dichVu)
        {
            if (dichVu.getTenDichVu() == "" || dichVu.getLoaiDichVu() == "")
            {
                return false;
            }
            return true;
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu(tb_MaDichVu.Text, tb_TenDichVu.Text, cb_LoaiDichVu.Text, int.Parse(tb_Gia.Text));
            if (!checkDichVu(dichVu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin dịch vụ");
                return;
            }
            dichVuBLL.updateDichvu(dichVu);
            dgv_DanhSachDichVu.DataSource = dichVuBLL.getDanhSachDichVu();
            MessageBox.Show("Cập nhật dịch vụ thành công");
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            string maDichVu = tb_MaDichVu.Text;
            if (maDichVu == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa");
                return;
            }
            dichVuBLL.removeDichVu(maDichVu);
            dgv_DanhSachDichVu.DataSource = dichVuBLL.getDanhSachDichVu();
            MessageBox.Show("Xóa dịch vụ thành công");
        }
    }
}

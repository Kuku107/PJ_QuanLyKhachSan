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
    public partial class QuanLyPhong : Form
    {
        private PhongBLL phongBLL = new PhongBLL();
        public QuanLyPhong()
        {
            InitializeComponent();
        }
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            dgv_DanhSachPhong.DataSource = phongBLL.getDanhSachPhong();
        }

        private void btThemP_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            var result = themPhong.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                dgv_DanhSachPhong.DataSource = phongBLL.getDanhSachPhong();
            }
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_DanhSachPhong.DataSource = phongBLL.findPhongByTen(tb_TenPhongTim.Text);
        }

        private void dgv_DanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_DanhSachPhong.Rows[e.RowIndex];
                tb_MaPhong.Text = selectedRow.Cells[0].Value.ToString();
                tb_TenPhong.Text = selectedRow.Cells[1].Value.ToString();
                cb_LoaiPhong.Text = selectedRow.Cells[2].Value.ToString();
                tb_GiaPhong.Text = selectedRow.Cells[3].Value.ToString();
                cb_TrangThai.Text = selectedRow.Cells[4].Value.ToString();
                nup_SoNguoiToiDa.Value = Convert.ToInt32(selectedRow.Cells[5].Value);
            }

        }

        public static bool checkPhong(Phong phong)
        {
            if (phong.getMaPhong() == "" || phong.getTenPhong() == "" || phong.getLoaiPhong() == "" || phong.getTrangThai() == "" 
                || phong.getSoNguoiToiDa() == 0)
                return false;
            return true;
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong(tb_MaPhong.Text,
                                    tb_TenPhong.Text,
                                    cb_LoaiPhong.Text,
                                    Convert.ToInt32(tb_GiaPhong.Text),
                                    cb_TrangThai.Text,
                                    Convert.ToInt32(nup_SoNguoiToiDa.Value)
                                    );

            if (!checkPhong(phong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (!phongBLL.updatePhong(phong))
            {
                MessageBox.Show("Phòng đã tồn tại");
                return;
            }

            dgv_DanhSachPhong.DataSource = phongBLL.getDanhSachPhong();
            MessageBox.Show("Cập nhật thành công");
        }
    }
}

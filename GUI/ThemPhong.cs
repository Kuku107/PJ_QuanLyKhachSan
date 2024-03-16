using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using DataTransferObject;

namespace QuanLyKhachSan
{
    public partial class ThemPhong : Form
    {
        private PhongBLL phongBLL = new PhongBLL();
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            cb_LoaiPhong.Text = "";
            tb_TenPhong.Text = "";
            tb_GiaPhong.Text = "0";
            nud_SoNguoiToiDa.Value = 0;
        }

        private void bt_ThemPhong_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong(cb_LoaiPhong.Text, tb_TenPhong.Text, int.Parse(tb_GiaPhong.Text), Convert.ToInt32(nud_SoNguoiToiDa.Value));
            switch (phongBLL.addPhong(phong))
            {
                case "Khong du thong tin phong":
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng");
                    return;
                case "Ten phong da ton tai":
                    MessageBox.Show("Tên phòng đã tồn tại");
                    return;
                case "Them phong thanh cong":
                    MessageBox.Show("Thêm phòng thành công");
                    return;
            }
        }

    }
}

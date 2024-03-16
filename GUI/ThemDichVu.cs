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
    public partial class ThemDichVu : Form
    {
        private DichVuBLL dichVuBLL = new DichVuBLL();
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void ThemDichVu_Load(object sender, EventArgs e)
        {
            tb_Gia.Text = "0";
        }

        private void bt_ThemDichVu_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu("DV", tb_TenDichVu.Text, cb_LoaiDichVu.Text, int.Parse(tb_Gia.Text));
            switch (dichVuBLL.addDichVu(dichVu))
            {
                case "khong du thong tin":
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin dịch vụ");
                    return;
                case "them thanh cong":
                    MessageBox.Show("Thêm dịch vụ thành công");
                    return;
            }
        }
    }
}

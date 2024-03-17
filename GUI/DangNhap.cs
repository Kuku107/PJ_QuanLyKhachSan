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
using QuanLyKhachSan;

namespace WebLayer
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private TaiKhoan createTaiKhoan()
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.sTaiKhoan = tb_username.Text;
            taikhoan.sMatKhau = tb_password.Text;
            return taikhoan;
        }

        private bool checkTaiKhoan(TaiKhoan taiKhoan)
        {
            if (taiKhoan.sTaiKhoan == "" || taiKhoan.sMatKhau == "")
                return false;
            return true;
        }

        private void showMenu()
        {
            Menu menuform = new Menu();
            menuform.Show();
            this.Hide();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = createTaiKhoan();
            if (!checkTaiKhoan(taikhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
                return;
            }

            TaiKhoanBLL tkBLL = new TaiKhoanBLL();

            if (tkBLL.login(taikhoan))
            {
                showMenu();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
    }
}

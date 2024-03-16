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

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.sTaiKhoan = tb_username.Text;
            taikhoan.sMatKhau = tb_password.Text;
            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            string message = tkBLL.checkLogin(taikhoan);
            switch (message)
            {
                case "trong username":
                    MessageBox.Show("Vui lòng điền username");
                    return;
                case "trong password": 
                    MessageBox.Show("Vui lòng điền password");
                    return;
                case "Khong tim thay tai khoan hoac mat khau":
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    return;
            }
            Menu menuform = new Menu();
            menuform.Show();
            this.Hide();
        }
    }
}

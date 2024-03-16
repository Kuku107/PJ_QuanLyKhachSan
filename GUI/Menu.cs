using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Body.Controls.Add(childForm);
            pn_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DatPhong());
            lb_Header.Text = bt_DatPhong.Text;
        }

        private void bt_DichVuVaThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DichVuVaThanhToan());
            lb_Header.Text = bt_DichVuVaThanhToan.Text;
        }

        private void bt_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
            lb_Header.Text = bt_QuanLyKhachHang.Text;
        }

        private void bt_QuanLyDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDichVu());
            lb_Header.Text = bt_QuanLyDichVu.Text;
        }

        private void bt_QuanLyPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhong());
            lb_Header.Text = bt_QuanLyPhong.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lb_Header.Text = "Home";
            pictureBox2.Image = WebLayer.Properties.Resources._10_diem_meme;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

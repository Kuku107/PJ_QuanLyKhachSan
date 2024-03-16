using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Phong
    {
        private string maPhong;
        private string tenPhong;
        private string loaiPhong;
        private int giaPhong;
        private string trangThai;
        private int soNguoiToiDa;

        public Phong()
        {

        }
        public Phong(string maPhong, string tenPhong, string loaiPhong, int giaPhong, string trangThai, int soNguoiToiDa)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.loaiPhong = loaiPhong;
            this.giaPhong = giaPhong;
            this.trangThai = trangThai;
            this.soNguoiToiDa = soNguoiToiDa;
        }

        public Phong(string loaiPhong, string tenPhong, int giaPhong, int soNguoiToiDa)
        {
            this.maPhong = "P";
            this.tenPhong = tenPhong;
            this.loaiPhong = loaiPhong;
            this.giaPhong = giaPhong;
            this.trangThai = "Trống";
            this.soNguoiToiDa = soNguoiToiDa;
        }

        public string getMaPhong()
        {
            return maPhong;
        }

        public string getTenPhong()
        {
            return tenPhong;
        }
        public string getLoaiPhong()
        {
            return loaiPhong;
        }

        public int getGiaPhong()
        {
            return giaPhong;
        }

        public string getTrangThai()
        {
            return trangThai;
        }

        public int getSoNguoiToiDa()
        {
            return soNguoiToiDa;
        }

        public void setMaPhong(string maPhong)
        {
            this.maPhong = maPhong;
        }

        public void setTrangThai(string trangThai)
        {
            this.trangThai = trangThai;
        }
    }
}

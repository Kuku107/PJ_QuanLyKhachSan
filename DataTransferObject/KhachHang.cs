using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class KhachHang
    {
        private string maKhach;
        private string hoVaTen;
        private string CCCD;
        private string soDienThoai;
        private DateTime ngaySinh;
        private string diaChi;
        private string loaiKhachHang;
        private string gioiTinh;
        private string quocTich;

        public KhachHang()
        {

        }

        public KhachHang(string maKhach, string hoVaTen, string CCCD, string soDienThoai, DateTime ngaySinh, string diaChi, string loaiKhachHang, string gioiTinh, string quocTich)
        {
            this.maKhach = maKhach;
            this.hoVaTen = hoVaTen;
            this.CCCD = CCCD;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.loaiKhachHang = loaiKhachHang;
            this.gioiTinh = gioiTinh;
            this.quocTich = quocTich;
        }

        public string getMaKhach()
        {
            return maKhach;
        }
    
        public string getHoVaTen()
        {
            return hoVaTen;
        }

        public string getCCCD()
        {
            return CCCD;
        }

        public string getSoDienThoai()
        {
            return soDienThoai;
        }

        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }

        public string getDiaChi()
        {
            return diaChi;
        }

        public string getLoaiKhachHang()
        {
            return loaiKhachHang;
        }

        public string getGioiTinh()
        {
            return gioiTinh;
        }
        public string getQuocTich()
        {
            return quocTich;
        }

        public void setMaKhachHang(string maKhach)
        {
            this.maKhach = maKhach;
        }
    }
}

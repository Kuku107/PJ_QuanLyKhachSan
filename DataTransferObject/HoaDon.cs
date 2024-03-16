using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDon
    {
        private string maKhach;
        private string maPhong;
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private long tongTien;

        public HoaDon()
        {

        }

        public HoaDon(string maKhach, string maPhong, DateTime ngayNhan, DateTime ngayTra, long tongTien)
        {
            this.maKhach = maKhach;
            this.maPhong = maPhong;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.tongTien = tongTien;
        }

        public string getMaKhach()
        {
            return maKhach;
        }

        public string getMaPhong()
        {
            return maPhong;
        }

        public DateTime getNgayNhan()
        {
            return ngayNhan;
        }

        public DateTime getNgayTra()
        {
            return ngayTra;
        }

        public long getTongTien()
        {
            return tongTien;
        }
    }
}

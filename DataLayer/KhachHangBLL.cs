using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataLayer;
using System.Data;

namespace ServiceLayer
{
    public class KhachHangBLL
    {
        private DanhSachKhachHangAccess danhSachKhachHangAccess = new DanhSachKhachHangAccess();

        public DataTable getDanhSachKhachHang()
        {
            return danhSachKhachHangAccess.getDanhSachKhachHang();
        }

        public DataTable findKhachHang(string hoVaTen)
        {
            return danhSachKhachHangAccess.findKhachHang(hoVaTen);
        }

        public bool checkKhachHang(KhachHang khachHang)
        {
            if (khachHang.getMaKhach() == "" || khachHang.getLoaiKhachHang() == "" || khachHang.getHoVaTen() == "" || khachHang.getSoDienThoai() == "" || khachHang.getQuocTich() == "")
            {
                return false;
            }
            return true;
        }

        public string updateKhachHang(KhachHang khachHang)
        {
            if (checkKhachHang(khachHang) == false)
                return "khong du thong tin khach hang";
            string message = danhSachKhachHangAccess.updateKhachHang(khachHang);
            return message;
        }

        public string addKhachHang(KhachHang khachHang)
        {
            if (checkKhachHang(khachHang) == false)
                return "khong du thong tin";
            string message = danhSachKhachHangAccess.addKhachHang(khachHang);
            return message;
        }
    }
}

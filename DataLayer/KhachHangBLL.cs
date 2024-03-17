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

        public bool updateKhachHang(KhachHang khachHang)
        {
            return danhSachKhachHangAccess.updateKhachHang(khachHang);

        }

        public bool addKhachHang(KhachHang khachHang)
        {
            return danhSachKhachHangAccess.addKhachHang(khachHang);

        }
    }
}

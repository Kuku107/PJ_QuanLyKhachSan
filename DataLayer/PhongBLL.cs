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
    public class PhongBLL
    {
        private DanhSachPhongAccess dspAccess = new DanhSachPhongAccess();

        public DataTable getDanhSachPhong()
        {
            return dspAccess.getDanhSachPhong();
        }

        public DataTable getDanhSachPhongTrong()
        {
            return dspAccess.getDanhSachPhongTrong();
        }

        public DataTable getDanhSachPhongKin()
        {
            return dspAccess.getDanhSachPhongKin();
        }

        public DataTable findPhongTrong(string loaiPhong, int soNguoiToiDa)
        {
            return dspAccess.findPhongTrong(loaiPhong, soNguoiToiDa);
        }

        public DataTable findPhongKin(string tenPhong, string loaiPhong)
        {
            return dspAccess.findPhongKin(tenPhong, loaiPhong);
        }

        public DataTable findPhongByTen(string tenPhong)
        {
            return dspAccess.findPhongByTen(tenPhong);
        }

        
        public bool updatePhong(Phong phong)
        {
            return dspAccess.updatePhong(phong);
        }

        public bool addPhong(Phong phong)
        {
            return dspAccess.addPhong(phong);
        }

        public void setTrangThaiPhong(string maPhong, string value)
        {
            dspAccess.setTrangThaiPhong(maPhong, value);
        }
    }
}

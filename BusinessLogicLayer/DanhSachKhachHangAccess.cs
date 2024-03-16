using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTransferObject;

namespace DataLayer
{
    public class DanhSachKhachHangAccess
    {
        private DatabaseAccess databaseAccess = new DatabaseAccess();

        public DataTable getDanhSachKhachHang()
        {
            string query = "SELECT * from DanhSachKhachHang";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public DataTable findKhachHang(string hoVaTen)
        {
            string query = "SELECT * from DanhSachKhachHang WHERE [Họ và tên] = N'" + hoVaTen + "'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public string updateKhachHang(KhachHang khachHang)
        {
            string query = "UPDATE DanhSachKhachHang SET [Họ và tên] = N'" + khachHang.getHoVaTen() + 
                            "', CCCD = '" + khachHang.getCCCD() + "', [Loại khách hàng] = N'" + khachHang.getLoaiKhachHang() +
                            "', [Số điện thoại] = '" + khachHang.getSoDienThoai() + "', [Ngày sinh] = '" + khachHang.getNgaySinh() + 
                            "', [Giới tính] = N'" + khachHang.getGioiTinh() + "', [Địa chỉ] = N'" + khachHang.getDiaChi() + 
                            "', [Quốc tịch] = N'" + khachHang.getQuocTich() + "' WHERE [Mã khách] = '" + khachHang.getMaKhach() + "'";
            databaseAccess.executeQuery(query);
            return "cap nhat thanh cong";
        }

        public int getSoLuongKhachHang()
        {
            string query = "select * from DanhSachKhachHang";
            return databaseAccess.getDataGridViewWithQuery(query).Rows.Count;
        }

        public string addKhachHang(KhachHang khachHang)
        {
            string query = "Select * from DanhSachKhachHang where [Họ và tên] = N'" + khachHang.getHoVaTen() + 
                            "' and [Số điện thoại] = N'" + khachHang.getSoDienThoai() + 
                            "' and [Ngày sinh] = '" + khachHang.getNgaySinh() +
                            "' and [Loại khách hàng] = N'" + khachHang.getLoaiKhachHang() + 
                            "' and [Giới tính] = N'" + khachHang.getGioiTinh() +
                            "' and [Quốc tịch] = N'" + khachHang.getQuocTich() + "'";
            if (databaseAccess.getDataGridViewWithQuery(query).Rows.Count == 0)
            {
                khachHang.setMaKhachHang("KH" + (getSoLuongKhachHang() + 1).ToString());
                string queryInsert = "INSERT INTO DanhSachKhachHang VALUES ('" + khachHang.getMaKhach() + "', N'" + khachHang.getHoVaTen() + 
                                "', '" + khachHang.getCCCD() + "', '" + khachHang.getSoDienThoai() + "', '" + khachHang.getNgaySinh() + 
                                "', N'" + khachHang.getDiaChi() + "', N'" + khachHang.getLoaiKhachHang() + "', N'" + khachHang.getGioiTinh() + 
                                "', N'" + khachHang.getQuocTich() + "')";
                databaseAccess.executeQuery(queryInsert);
            }
            return "them thanh cong";
        }
    }
}

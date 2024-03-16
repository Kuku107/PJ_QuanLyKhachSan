using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DanhSachPhongAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public DataTable getDanhSachPhong()
        {
            string query = "SELECT * from DANHSACHPHONG";
            return databaseAccess.getDataGridViewWithQuery(query);
        }
        public DataTable getDanhSachPhongTrong()
        {
            string query = "SELECT * from DANHSACHPHONG where [Trạng thái] = N'Trống'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public DataTable getDanhSachPhongKin()
        {
            string query = "SELECT * from DANHSACHPHONG where [Trạng thái] = N'Kín'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public DataTable findPhongTrong(string loaiPhong, int soNguoiToiDa)
        {
            string query = "SELECT * from DANHSACHPHONG where [Trạng thái] = N'Trống' and [Loại phòng] = N'" + loaiPhong
                + "' and [Số người tối đa] >= " + soNguoiToiDa + "";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public DataTable findPhongKin(string tenPhong, string loaiPhong)
        {
            string query = "SELECT * FROM DanhSachPhong WHERE [Trạng thái] = N'Kín' AND [Tên phòng] = N'" + tenPhong
                + "' AND [Loại phòng] = N'" + loaiPhong + "'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }   

        public DataTable findPhongByTen(string tenPhong)
        {
            string query = "SELECT * FROM DanhSachPhong WHERE [Tên phòng] = N'" + tenPhong + "'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public string updatePhong(Phong phong)
        {
            string query = "UPDATE DanhSachPhong SET [Tên phòng] = N'" + phong.getTenPhong() + "', [Loại phòng] = N'" + phong.getLoaiPhong()
                + "', [Giá phòng] = " + phong.getGiaPhong() + ", [Trạng thái] = N'" + phong.getTrangThai() + "', [Số người tối đa] = " + phong.getSoNguoiToiDa()
                + " WHERE [Mã phòng] = '" + phong.getMaPhong() + "'";
            databaseAccess.executeQuery(query);
            return "Cap nhat thanh cong";
        }

        public int getSoPhong()
        {
            string query = "Select * from DanhSachPhong";
            DataTable table = databaseAccess.getDataGridViewWithQuery(query);
            return table.Rows.Count;
        }

        public string addPhong(Phong phong)
        {
            if (findPhongByTen(phong.getTenPhong()).Rows.Count > 0)
                return "Ten phong da ton tai";
            phong.setMaPhong("P" + (getSoPhong() + 1).ToString());
            string query = "INSERT INTO DanhSachPhong VALUES ('" + phong.getMaPhong() + "', N'" + phong.getTenPhong() + "', N'" + phong.getLoaiPhong()
                + "', " + phong.getGiaPhong() + ", N'" + phong.getTrangThai() + "', " + phong.getSoNguoiToiDa() + ")";
            databaseAccess.executeQuery(query);
            return "Them phong thanh cong";
        }

        public void setTrangThaiPhong(string maPhong, string value)
        {
            string query = "update DanhSachPhong set [Trạng thái] = N'" + value + "' where [Mã phòng] = '" + maPhong + "'";
            databaseAccess.executeQuery(query);
        }
    }
}

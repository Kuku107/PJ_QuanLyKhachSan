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
    public class DanhSachDichVuAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public DataTable findDichVu(string loaiDichVu)
        {
            string query = "SELECT * FROM DanhSachDichVu where [Loại dịch vụ] = N'" + loaiDichVu + "'";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public DataTable getDanhSachDichVu()
        {
            string query = "SELECT * from DanhSachDichVu";
            return databaseAccess.getDataGridViewWithQuery(query);
        }

        public string updateDichVu(DichVu dichVu)
        {
            string query = "UPDATE DanhSachDichVu SET [Tên dịch vụ] = N'" + dichVu.getTenDichVu() + "', [Giá] = " + dichVu.getGia() + ", [Loại dịch vụ] = N'" + dichVu.getLoaiDichVu() + "' WHERE [Mã dịch vụ] = '" + dichVu.getMaDichVu() + "'";
            databaseAccess.executeQuery(query);
            return "cap nhat thanh cong";
        }

        public void removeDichVu(string maDichVu)
        {
            string query = "DELETE FROM DanhSachDichVu WHERE [Mã dịch vụ] = '" + maDichVu + "'";
            databaseAccess.executeQuery(query);
        }

        public int getSoDichVu()
        {
            string query = "SELECT * FROM DanhSachDichVu";
            DataTable table = databaseAccess.getDataGridViewWithQuery(query);
            return table.Rows.Count;
        }

        public string addDichVu(DichVu dichVu)
        {
            dichVu.setMaDichVu("DV" + (getSoDichVu() + 1).ToString());
            string query = "INSERT INTO DanhSachDichVu VALUES ('" + dichVu.getMaDichVu() + "', N'" + dichVu.getTenDichVu() + "', N'" + dichVu.getLoaiDichVu() + "', " + dichVu.getGia() + ")";
            databaseAccess.executeQuery(query);
            return "them thanh cong";
        }
    }
}

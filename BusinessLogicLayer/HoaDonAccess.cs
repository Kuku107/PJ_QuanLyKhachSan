using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class HoaDonAccess
    {
        private DatabaseAccess databaseAccess = new DatabaseAccess();
        public void addHoaDon(HoaDon hoaDon)
        {
            string query = "insert into HoaDon values('" + hoaDon.getMaKhach() + 
                           "', '" + hoaDon.getMaPhong() + 
                           "', '" + hoaDon.getNgayNhan() +
                           "', '" + hoaDon.getNgayTra() +
                           "', " + hoaDon.getTongTien() + ")";
            databaseAccess.executeQuery(query);
        }

        public long getTienPhong(string maPhong)
        {
            string query = "select * from HoaDon where [Mã phòng] = '" + maPhong + "'";
            DataTable table = databaseAccess.getDataGridViewWithQuery(query);
            if (table.Rows.Count == 0)
            {
                return 0;
            }
            return long.Parse(table.Rows[0][4].ToString());
        }
        public void addTien(string maPhong, long tien)
        {
            long newTongTien = getTienPhong(maPhong) + tien;
            string query = "update HoaDon set [Tổng tiền] = " + newTongTien + " where [Mã phòng] = '" + maPhong + "'";
            databaseAccess.executeQuery(query);
        }
    }
}

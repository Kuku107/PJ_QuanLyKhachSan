using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class TaiKhoanAccess
    {
        DatabaseAccess dbAccess = new DatabaseAccess();
        public bool login(TaiKhoan taikhoan)
        {
            string query = "SELECT * FROM DanhSachTaiKhoan WHERE sTaiKhoan = '" + taikhoan.sTaiKhoan
                        + "' AND sMatKhau = '" + taikhoan.sMatKhau + "'";
            DataTable table = dbAccess.getDataGridViewWithQuery(query);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
    }
}

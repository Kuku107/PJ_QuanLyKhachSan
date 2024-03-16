using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class TaiKhoanAccess
    {
        DatabaseAccess dbAccess = new DatabaseAccess();
        public string checkLogin(TaiKhoan taikhoan)
        {
            string message = dbAccess.checkLogin(taikhoan);
            return message;
        }
    }
}

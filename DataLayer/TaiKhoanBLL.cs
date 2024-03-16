using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataLayer;

namespace ServiceLayer
{
    public class TaiKhoanBLL
    {

        public string checkLogin(TaiKhoan taikhoan)
        {
            if (taikhoan.sTaiKhoan == "")
                return "trong username";
            if (taikhoan.sMatKhau == "")
                return "trong password";
            TaiKhoanAccess tkAccess = new TaiKhoanAccess();
            return tkAccess.checkLogin(taikhoan);
    }
    }
}

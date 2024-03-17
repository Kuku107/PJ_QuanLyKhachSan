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
        private TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        public bool login(TaiKhoan taikhoan)
        {
            return tkAccess.login(taikhoan);
        }
    }
}

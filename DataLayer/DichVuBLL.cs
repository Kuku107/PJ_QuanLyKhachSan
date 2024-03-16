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
    public class DichVuBLL
    {
        private DanhSachDichVuAccess danhSachDichVuAccess = new DanhSachDichVuAccess();

        public DataTable getDanhSachDichVu()
        {
            return danhSachDichVuAccess.getDanhSachDichVu();
        }

        public DataTable findDichVu(string loaiDichVu)
        {
            return danhSachDichVuAccess.findDichVu(loaiDichVu);
        }
        public bool checkDichVu(DichVu dichVu)
        {
            if (dichVu.getTenDichVu() == "" || dichVu.getLoaiDichVu() == "")
            {
                return false;
            }
            return true;
        }

        public string updateDichvu(DichVu dichVu)
        {
            if (checkDichVu(dichVu) == false)
                return "khong du thong tin";
            return danhSachDichVuAccess.updateDichVu(dichVu);
        }

        public void removeDichVu(string maDichVu)
        {
            danhSachDichVuAccess.removeDichVu(maDichVu);
        }

        public string addDichVu(DichVu dichVu)
        {
            if (checkDichVu(dichVu) == false)
                return "khong du thong tin";
            return danhSachDichVuAccess.addDichVu(dichVu);
        }
    }
}

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
        

        public bool updateDichvu(DichVu dichVu)
        {
            return danhSachDichVuAccess.updateDichVu(dichVu);
        }

        public void removeDichVu(string maDichVu)
        {
            danhSachDichVuAccess.removeDichVu(maDichVu);
        }

        public bool addDichVu(DichVu dichVu)
        {
            return danhSachDichVuAccess.addDichVu(dichVu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTransferObject;

namespace ServiceLayer
{
    public class HoaDonBLL
    {
        private HoaDonAccess hoaDonAccess = new HoaDonAccess();

        public void addHoaDon(HoaDon hoaDon)
        {
            hoaDonAccess.addHoaDon(hoaDon);
        }

        public void addTien(string maPhong, long tien)
        {
            hoaDonAccess.addTien(maPhong, tien);
        }

        public long getTienPhong(string maPhong)
        {
            return hoaDonAccess.getTienPhong(maPhong);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DichVu
    {
        private string maDichVu;
        private string tenDichVu;
        private string loaiDichVu;
        private int gia;

        public DichVu()
        {

        }

        public DichVu(string maDichVu, string tenDichVu, string loaiDichVu, int gia)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.loaiDichVu = loaiDichVu;
            this.gia = gia;
        }

        public string getMaDichVu()
        {
            return maDichVu;
        }

        public string getTenDichVu()
        {
            return tenDichVu;
        }

        public string getLoaiDichVu()
        {
            return loaiDichVu;
        }

        public int getGia()
        {
            return gia;
        }

        public void setMaDichVu(string maDichVu)
        {
            this.maDichVu = maDichVu;
        }
    }
}

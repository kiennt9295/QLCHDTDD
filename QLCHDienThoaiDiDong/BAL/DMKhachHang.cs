using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMKhachHang
    {
        DIDONGDataContext KhachHang = new DIDONGDataContext();
        public IQueryable<LAYKHACHHANGResult> LayKhachHang()
        {
            return KhachHang.LAYKHACHHANG();
        }
        public int ThemKhachHang(int MAKH,string HOTEN,string DIACHI,bool GIOITINH,string SDT)
        {
            return KhachHang.spTHEMKHACHHANG(MAKH, HOTEN, DIACHI, GIOITINH, SDT);
        }
        public int CapNhatKhachHang(int MAKH, string HOTEN, string DIACHI, bool GIOITINH, string SDT)
        {
            return KhachHang.spCAPNHATKHACHHANG(MAKH, HOTEN, DIACHI, GIOITINH, SDT);
        }
        public int XoaKhachHang(int MAKH)
        {
            return KhachHang.spXOAKHACHHANG(MAKH);
        }
    }
}

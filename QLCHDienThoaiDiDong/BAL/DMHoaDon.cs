using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMHoaDon
    {
        DIDONGDataContext HoaDon = new DIDONGDataContext();
        public IQueryable<LAYHOADONResult> LayHoaDon()
        {
            return HoaDon.LAYHOADON();
        }
        public int ThemHoaDon(int MAHD,string SOLUONG,int MAKH,DateTime NGAYLAP,int MANV,string TONGTIEN)
        {
            return HoaDon.spTHEMHOADON(MAHD, SOLUONG, MAKH, NGAYLAP, MANV, TONGTIEN);
        }
        public int CapNhatHoaDon(int MAHD, int SOLUONG, int MAKH, DateTime NGAYLAP, int MANV, float TONGTIEN)
        {
            return HoaDon.spCAPNHATHOADON(MAHD, SOLUONG, MAKH, NGAYLAP, MANV, TONGTIEN);
        }
        public int XoaHoaDon(int MAHD)
        {
            return HoaDon.spXOAHOADON(MAHD);
        }
    }
}

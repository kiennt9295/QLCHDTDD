using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMChiTietHoaDon
    {
        DIDONGDataContext CTHD = new DIDONGDataContext();
        public IQueryable<LAYCHITIETHOADONResult> LayCTHD()
        {
            return CTHD.LAYCHITIETHOADON();
        }
        public int ThemCTHD(int MACTHD, int MAHD, int MAMH, int MANV, int MAKH, int SOLUONG, string DONVITINH, float THANHTIEN)
        {
            return CTHD.spTHEMCTHOADON(MACTHD, MAHD, MAMH, MANV, MAKH, SOLUONG, DONVITINH, THANHTIEN);
        }
        public int CapNhatCTHD(int MACTHD,int MAHD,int MAMH,int MANV,int MAKH,int SOLUONG,string DONVITINH,float THANHTIEN)
        {
            return CTHD.spCAPNHATCTHOADON(MACTHD,MAHD,MAMH,MANV,MAKH,SOLUONG,DONVITINH,THANHTIEN);
        }
        public int XoaCTHD(int MACTHD)
        {
            return CTHD.spXOACTHOADON(MACTHD);
        }
    }
}

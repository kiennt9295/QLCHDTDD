using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMMatHang
    {
        DIDONGDataContext MatHang = new DIDONGDataContext();
        public IQueryable<LAYMATHANGResult>Laymathang()
        {
            return MatHang.LAYMATHANG();
        }
        public IQueryable<LAYMATHANG1Result> Laymathang1()
        {
            return MatHang.LAYMATHANG1();
        }
        public int Themmathang(int MAMH,string TENMH,string HANGSX,double GIAMUA,double GIABAN,string DONVITINH,int BAOHANH,string MAKM,string DACDIEM,int SOLUONG,
                                byte[] HINH,string GHICHU,string lOAIMH)
        {
            return MatHang.spTHEMMATHANG(MAMH, TENMH, HANGSX, GIAMUA, GIABAN, DONVITINH, BAOHANH, MAKM, DACDIEM, SOLUONG, HINH, GHICHU, lOAIMH);
        }
        public int Capnhatmathang(int MAMH,string TENMH,string HANGSX,double GIAMUA,double GIABAN,string DONVITINH,int BAOHANH,string MAKM,string DACDIEM,int SOLUONG,
                                byte[] HINH,string GHICHU,string lOAIMH)
        {
            return MatHang.spCAPNHATMATHANG(MAMH, TENMH, HANGSX, GIAMUA, GIABAN, DONVITINH, BAOHANH, MAKM, DACDIEM, SOLUONG, HINH, GHICHU, lOAIMH);
        }
        public int XoaKhuyenMai(int MAMH)
        {
            return MatHang.spXOAMATHANG(MAMH);
        }
        public int Capnhatmathang1()
        {
            return MatHang.spCAPNHATMATHANG1();
        }
    }
}

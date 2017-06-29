using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMNhanVien
    {
        DIDONGDataContext NhanVien = new DIDONGDataContext();
        public IQueryable<LAYNHANVIENResult> LayNhanVien()
        {
            return NhanVien.LAYNHANVIEN();
        }
        public int ThemNhanVien(int MANV, string HOTEN, string DIACHI, string SDT, int MABP,byte[] HINH,bool GIOITINH)
        {
            return NhanVien.spTHEMNHANVIEN(MANV,HOTEN,DIACHI,SDT,MABP,HINH,GIOITINH);
        }
        public int CapNhatNhanVien(int MANV, string HOTEN, string DIACHI, string SDT, int MABP, byte[] HINH, bool GIOITINH)
        {
            return NhanVien.spCAPNHATNHANVIEN(MANV, HOTEN, DIACHI, SDT, MABP, HINH,GIOITINH);
        }
        public int XoaNhanVien(int MANV)
        {
            return NhanVien.spXOANHANVIEN(MANV);
        }
    }
}

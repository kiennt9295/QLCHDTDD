using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMThongke
    {
        DIDONGDataContext TK = new DIDONGDataContext();
        public List<THONGKECHI> LayThongkechi()
        {
            return TK.THONGKECHIs.ToList();
        }
        public List<THONGKETHU> LayThongkethu()
        {
            return TK.THONGKETHUs.ToList();
        }
        public List<THONGKEBANHANG> LayThongkebanhang()
        {
            return TK.THONGKEBANHANGs.ToList();
        }
        public List<THONGKEHANGBANCHAY> Layhangbanchay()
        {
            return TK.THONGKEHANGBANCHAYs.ToList();
        }
        public List<THONGTINBAOHANH> Laythongtinbaohanh()
        {
            return TK.THONGTINBAOHANHs.ToList();
        }
        public List<THONGKENHAPKHO> Laythongkenhapkho()
        {
            return TK.THONGKENHAPKHOs.ToList();
        }
        public List<THONGKEXUATKHO> Laythongkexuatkho()
        {
            return TK.THONGKEXUATKHOs.ToList();
        }
        public List<TONKHO> Laytonkho()
        {
            return TK.TONKHOs.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMPhieuTraGop
    {
        DIDONGDataContext PhieuTG = new DIDONGDataContext();
        public IQueryable<LAYPHIEUTRAGOPResult> LayPhieuTG()
        {
            return PhieuTG.LAYPHIEUTRAGOP();
        }
        public int ThemPhieuTG(int MAPTG, int MAKH,int CMND, int MANV, DateTime NGAYLAP,double TONGTIEN,int MAMH,int HANGTRA, int LAISUAT)
        {
            return PhieuTG.spTHEMPHIEUTRAGOP(MAPTG, MAKH,CMND,MANV, NGAYLAP, TONGTIEN,MAMH,HANGTRA,LAISUAT);
        }
        public int CapNhatPhieuTG(int MAPTG, int MAKH,int CMND, int MANV, DateTime NGAYLAP, float TONGTIEN, int MAMH, int HANGTRA, int LAISUAT)
        {
            return PhieuTG.spCAPNHATPHIEUTRAGOP(MAPTG, MAKH,CMND, MANV, NGAYLAP, TONGTIEN, MAMH, HANGTRA, LAISUAT);
        }
        public int XoaPhieuTG(int MAPTG)
        {
            return PhieuTG.spXOAPHIEUTRAGOP(MAPTG);
        }
    }
}

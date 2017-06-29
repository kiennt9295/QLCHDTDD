using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMBienLaiTraGop
    {
        DIDONGDataContext TraGop = new DIDONGDataContext();
        public IQueryable<LAYBIENLAITRAGOPResult> LayBienLaiTraGop()
        {
            return TraGop.LAYBIENLAITRAGOP();
        }
        public IQueryable<LAYTHONGBAOTRAGOPResult> Laythongbaotragop()
        {
            return TraGop.LAYTHONGBAOTRAGOP();
        }
        public int ThemBienLaiTraGop(int MABL,int MANV,DateTime NGAYLAP,int MAKH,float SOTIEN,string GHICHU)
        {
            return TraGop.spTHEMBIENLAITRAGOP(MABL, MANV, NGAYLAP, MAKH, SOTIEN, GHICHU);
        }
        public int CapNhatBienLaiTraGop(int MABL,int MANV,DateTime NGAYLAP,int MAKH,float SOTIEN,string GHICHU)
        {
            return TraGop.spCAPNHATBIENLAITRAGOP(MABL, MANV, NGAYLAP, MAKH, SOTIEN, GHICHU);
        }
        public int XoaBienLaiTraGop(int MABL)
        {
            return TraGop.spXOABIENLAITRAGOP(MABL);
        }
    }
}

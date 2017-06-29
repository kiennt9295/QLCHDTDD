using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMNhaCungCap
    {
        DIDONGDataContext NhaCC = new DIDONGDataContext();
        public IQueryable<LAYNHACUNGCAPResult> LayNhaCC()
        {
            return NhaCC.LAYNHACUNGCAP();
        }
        public int ThemNhaCC(int MANCC,string TENNCC,string DIACHI,string SDT,string GHICHU)
        {
            return NhaCC.spTHEMNHACUNGCAP(MANCC,TENNCC,DIACHI,SDT,GHICHU);
        }
        public int CapNhatNhaCC(int MANCC, string TENNCC, string DIACHI, string SDT, string GHICHU)
        {
            return NhaCC.spCAPNHATNHACUNGCAP(MANCC, TENNCC, DIACHI, SDT, GHICHU);
        }
        public int XoaNhaCC(int MANCC)
        {
            return NhaCC.spXOANHACUNGCAP(MANCC);
        }
    }
}

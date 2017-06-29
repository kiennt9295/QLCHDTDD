using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMPhieuChi
    {
        DIDONGDataContext PhieuChi = new DIDONGDataContext();
        public IQueryable<LAYPHIEUCHIResult> LayPhieuChi()
        {
            return PhieuChi.LAYPHIEUCHI();
        }
        public int ThemPhieuChi(int MAPC, string LYDOCHI, int NGUOINHAN,float SOTIEN, DateTime NGAYCHI,string GHICHU)
        {
            return PhieuChi.spTHEMPHIEUCHI(MAPC,LYDOCHI,NGUOINHAN,SOTIEN,NGAYCHI,GHICHU);
        }
        public int CapNhatPhieuChi(int MAPC, string LYDOCHI, int NGUOINHAN, float SOTIEN, DateTime NGAYCHI, string GHICHU)
        {
            return PhieuChi.spCAPNHATPHIEUCHI(MAPC, LYDOCHI, NGUOINHAN, SOTIEN, NGAYCHI, GHICHU);
        }
        public int XoaPhieuChi(int MAPC)
        {
            return PhieuChi.spXOAPHIEUCHI(MAPC);
        }
    }
}

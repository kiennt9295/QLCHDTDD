using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMPhieuThu
    {
        DIDONGDataContext PhieuThu = new DIDONGDataContext();
        public IQueryable<LAYPHIEUTHUResult> LayPhieuThu()
        {
            return PhieuThu.LAYPHIEUTHU();
        }
        public int ThemPhieuThu(int MAPT, string LYDOTHU, int NGUOINOPTIEN, float SOTIEN, DateTime NGAYTHU, string GHICHU)
        {
            return PhieuThu.spTHEMPHIEUTHU(MAPT, LYDOTHU, NGUOINOPTIEN, SOTIEN, NGAYTHU, GHICHU);
        }
        public int CapNhatPhieuThu(int MAPT, string LYDOTHU, int NGUOINOPTIEN, float SOTIEN, DateTime NGAYTHU, string GHICHU)
        {
            return PhieuThu.spCAPNHATPHIEUTHU(MAPT, LYDOTHU, NGUOINOPTIEN, SOTIEN, NGAYTHU, GHICHU);
        }
        public int XoaPhieuThu(int MAPT)
        {
            return PhieuThu.spXOAPHIEUTHU(MAPT);
        }
    }
}

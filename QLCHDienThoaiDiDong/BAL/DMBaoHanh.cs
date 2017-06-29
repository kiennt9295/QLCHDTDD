using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMBaoHanh
    {
        DIDONGDataContext DiDong = new DIDONGDataContext();
        public IQueryable<LAYBAOHANHResult> LayBaoHanh()
        {
            return DiDong.LAYBAOHANH();
        }
        public IQueryable<LAYTHONGBAOBAOHANHResult> Laythongbaobaohanh()
        {
            return DiDong.LAYTHONGBAOBAOHANH();
        }
        public int ThemBaoHanh(int MABH,DateTime NGAYNHAN,string TENKH,string DIENTHOAI,int MAMH,int MANV,string YEUCAU,DateTime NGAYTRADK,string GHICHU,bool DATRA)
        {
            return DiDong.spTHEMBAOHANH(MABH,NGAYNHAN,TENKH,DIENTHOAI,MAMH,MANV,YEUCAU,NGAYTRADK,GHICHU,DATRA);
        }
        public int CapNhatBaoHanh(int MABH,DateTime NGAYNHAN,string TENKH,string DIENTHOAI,int MAMH,int MANV,string YEUCAU,DateTime NGAYTRADK,string GHICHU,bool DATRA)
        {
            return DiDong.spCAPNHATBAOHANH(MABH, NGAYNHAN, TENKH, DIENTHOAI, MAMH, MANV, YEUCAU, NGAYTRADK, GHICHU, DATRA);
        }
        public int XoaBaoHanh(int MABH)
        {
            return DiDong.spXOABAOHANH(MABH);
        }
    }
}

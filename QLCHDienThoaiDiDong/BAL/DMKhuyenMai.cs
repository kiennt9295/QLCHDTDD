using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMKhuyenMai
    {
        DIDONGDataContext KhuyenMai = new DIDONGDataContext();
        public IQueryable<LAYKHUYENMAIResult> LayKhuyenMai()
        {
            return KhuyenMai.LAYKHUYENMAI();
        }
        public int ThemKhuyenMai(int MAKM, string THONGTIN, float GIATRI, DateTime NGAYBATDAU, DateTime NGAYKETTHUC, string GHICHU)
        {
            return KhuyenMai.spTHEMKHUYENMAI(MAKM, THONGTIN, GIATRI, NGAYBATDAU, NGAYKETTHUC, GHICHU);
        }
        public int CapNhatKhuyenMai(int MAKM,string THONGTIN,float GIATRI,DateTime NGAYBATDAU,DateTime NGAYKETTHUC,string GHICHU)
        {
            return KhuyenMai.spCAPNHATKHUYENMAI(MAKM, THONGTIN, GIATRI, NGAYBATDAU, NGAYKETTHUC, GHICHU);
        }
        public int XoaKhuyenMai(int MAKM)
        {
            return KhuyenMai.spXOAKHUYENMAI(MAKM);
        }
    }
}

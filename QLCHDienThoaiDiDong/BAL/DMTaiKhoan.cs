using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMTaiKhoan
    {
        DIDONGDataContext TK = new DIDONGDataContext();
        public IQueryable<LAYTAIKHOANResult> Laytaikhoan()
        {
            return TK.LAYTAIKHOAN();
        }
        public int Themtaikhoan(string TAIKHOAN,string MATKHAU,int MAQUYEN)
        {
            return TK.spTHEMTAIKHOAN(TAIKHOAN, MATKHAU, MAQUYEN);
        }
        public int Xoataikhoan(string TAIKHOAN)
        {
            return TK.spXOATAIKHOAN(TAIKHOAN);
        }
    }
}

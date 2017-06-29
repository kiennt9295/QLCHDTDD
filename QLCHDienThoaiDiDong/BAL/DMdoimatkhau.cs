using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMdoimatkhau
    {
        DIDONGDataContext tk = new DIDONGDataContext();
        public IQueryable<LAYDANGNHAP1Result> LayDN(string taikhoan,string matkhau)
        {
            return tk.LAYDANGNHAP1(taikhoan,matkhau);
        }
        public int Capnhatmatkhau(string taikhoan,string matkhaucu,string matkhaumoi)
        {
            return tk.spDOIMATKHAU1(taikhoan, matkhaucu, matkhaumoi);
        }
    }
}

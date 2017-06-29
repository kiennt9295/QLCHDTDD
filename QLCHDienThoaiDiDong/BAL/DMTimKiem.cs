using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class DMTimKiem
    {
        DIDONGDataContext tk=new DIDONGDataContext();
        public IQueryable<TKBAOHANHResult> TKBH(string TENKH,bool DATRA)
        {
            return tk.TKBAOHANH(TENKH,DATRA);
        }
        public IQueryable<TKBAOHANH_TENKHResult> TKBH_TENKH(string TENKH)
        {
            return tk.TKBAOHANH_TENKH(TENKH);
        }
        public IQueryable<TKBAOHANH_DTResult> TKBHDT(bool M1)
        {
            return tk.TKBAOHANH_DT(M1);
        }
        public IQueryable<TKTTBAOHANHResult> TKTTBH(string M1, string M2)
        {
            return tk.TKTTBAOHANH(M1, M2);
        }
        public IQueryable<TKTTBAOHANH_MAKHResult> TKTTBH_KH(string MAKH)
        {
            return tk.TKTTBAOHANH_MAKH(MAKH);
        }
        public IQueryable<TKTTBAOHANH_MAMHResult> TKTTBH_MH(string MAMH)
        {
            return tk.TKTTBAOHANH_MAMH(MAMH);
        }
        public IQueryable<TKTHONGKEBANHANGResult> TKthongkebanhang_NGAY(DateTime NGAY1,DateTime NGAY2)
        {
            return tk.TKTHONGKEBANHANG(NGAY1,NGAY2);
        }
        public IQueryable<TKTHONGKEHANGBANCHAYResult> TKthongkehangbanchay(string MAMH, DateTime NGAY1,DateTime NGAY2)
        {
            return tk.TKTHONGKEHANGBANCHAY(MAMH,NGAY1,NGAY2);
        }
        public IQueryable<TKTHONGKEHANGBANCHAY_MAMHResult> TKthongkehangbanchay_MAMH(string MAMH)
        {
            return tk.TKTHONGKEHANGBANCHAY_MAMH(MAMH);
        }
        public IQueryable<TKTHONGKEHANGBANCHAY_NGAYResult> TKthongkehangbanchay_NGAY(DateTime NGAY1, DateTime NGAY2)
        {
            return tk.TKTHONGKEHANGBANCHAY_NGAY(NGAY1, NGAY2);
        }
        public IQueryable<TKTRAGOP_MHResult> TKtragop(string MAKH)
        {
            return tk.TKTRAGOP_MH(MAKH);
        }
        public IQueryable<TKBIENLAITRAGOPResult> TKbienlaitragop(string MAKH)
        {
            return tk.TKBIENLAITRAGOP(MAKH);
        }
        public IQueryable<TKPHIEUTHUResult> TKphieuthu(DateTime ngay1,DateTime ngay2)
        {
            return tk.TKPHIEUTHU(ngay1,ngay2);
        }
        public IQueryable<TKPHIEUCHIResult> TKphieuchi(DateTime ngay1,DateTime ngay2)
        {
            return tk.TKPHIEUCHI(ngay1,ngay2);
        }
        public IQueryable<TKNHACUNGCAPResult> TKnhacungcap(string TENNCC)
        {
            return tk.TKNHACUNGCAP(TENNCC);
        }
        public IQueryable<TKNHAPKHOResult> TKnhapkho(string MAMH, DateTime ngay1, DateTime ngay2)
        {
            return tk.TKNHAPKHO(MAMH, ngay1, ngay2);
        }
        public IQueryable<TKNHAPKHO_MAMHResult> TKnhapkho_mathang(string MAMH)
        {
            return tk.TKNHAPKHO_MAMH(MAMH);
        }
        public IQueryable<TKNHAPKHO_NGAYResult> TKnhapkho_ngay(DateTime ngay1, DateTime ngay2)
        {
            return tk.TKNHAPKHO_NGAY(ngay1, ngay2);
        }
        public IQueryable<TKPHIEUDATHANG_MANCCResult> TKphieudathang_nhacc(string MANCC)
        {
            return tk.TKPHIEUDATHANG_MANCC(MANCC);
        }
        public IQueryable<TKPHIEUDATHANG_CONNOResult> TKphieudathang_conno(string MANCC)
        {
            return tk.TKPHIEUDATHANG_CONNO(MANCC);
        }
        public IQueryable<TKPHIEUDATHANG_DATRAResult> TKphieudathang_datra(string MANCC)
        {
            return tk.TKPHIEUDATHANG_DATRA(MANCC);
        }
        public IQueryable<TKPHIEUDATHANG_DATRA1Result> TKphieudathangdatra()
        {
            return tk.TKPHIEUDATHANG_DATRA1();
        }
        public IQueryable<TKPHIEUDATHANG_CONNO1Result> TKphieudathangconno()
        {
            return tk.TKPHIEUDATHANG_CONNO1();
        }
        public IQueryable<TKKHACHHANG_TENKHTRAGOPResult> TKkhachhang_tenkhtragop(string TENKH)
        {
            return tk.TKKHACHHANG_TENKHTRAGOP(TENKH);
        }
        public IQueryable<TKKHACHHANG_TENKHKHONGTRAGOPResult> TKkhachhang_tenkhkhongtragop(string TENKH)
        {
            return tk.TKKHACHHANG_TENKHKHONGTRAGOP(TENKH);
        }
        public IQueryable<TKKHACHHANG_TENKHResult> TKkhachhang_tenkh(string TENKH)
        {
            return tk.TKKHACHHANG_TENKH(TENKH);
        }
        public IQueryable<TKTONKHOResult> TKtonkho(string MAMH)
        {
            return tk.TKTONKHO(MAMH);
        }
        public IQueryable<TKTONKHO_LOAIMHResult> TKtonkholoaiMH(string LOAIMH)
        {
            return tk.TKTONKHO_LOAIMH(LOAIMH);
        }
        public IQueryable<TKTONKHO_LOAIMHVAMAMHResult> TKtonkholoaiMHvaMaMH(string MAMH,string LOAIMH)
        {
            return tk.TKTONKHO_LOAIMHVAMAMH(MAMH, LOAIMH);
        }
        public IQueryable<TKTHONGKEDOANHTHU_PHIEUTHUResult> TKthongkedoanhthu_phieuthu(DateTime NGAY1,DateTime NGAY2)
        {
            return tk.TKTHONGKEDOANHTHU_PHIEUTHU(NGAY1,NGAY2);
        }
        public IQueryable<TKTHONGKEDOANHTHU_PHIEUCHIResult> TKthongkedoanhthu_phieuchi(DateTime NGAY1, DateTime NGAY2)
        {
            return tk.TKTHONGKEDOANHTHU_PHIEUCHI(NGAY1, NGAY2);
        }
        public IQueryable<TKTHONGKEKHO_NHAPKHOResult> TKThongkenhapkho(string MAMH, DateTime NGAY1,DateTime NGAY2)
        {
            return tk.TKTHONGKEKHO_NHAPKHO(MAMH,NGAY1, NGAY2);
        }
        public IQueryable<TKTHONGKEKHO_NHAPKHONGAYResult> TKThongkenhapkho_NGAY(DateTime NGAY1, DateTime NGAY2)
        {
            return tk.TKTHONGKEKHO_NHAPKHONGAY(NGAY1, NGAY2);
        }
        public IQueryable<TKTHONGKEKHO_NHAPKHOMAMHResult> TKThongkenhapkho_MAMH(string MAMH)
        {
            return tk.TKTHONGKEKHO_NHAPKHOMAMH(MAMH);
        }
        public IQueryable<TKTHONGKEKHO_XUATKHOResult> TKThongkexuatkho(string MAMH, DateTime NGAY1, DateTime NGAY2)
        {
            return tk.TKTHONGKEKHO_XUATKHO(MAMH,NGAY1, NGAY2);
        }
        public IQueryable<TKTHONGKEKHO_XUATKHONGAYResult> TKThongkexuatkho_NGAY(DateTime NGAY1, DateTime NGAY2)
        {
            return tk.TKTHONGKEKHO_XUATKHONGAY(NGAY1, NGAY2);
        }
        public IQueryable<TKTHONGKEKHO_XUATKHOMAMHResult> TKThongkexuatkho_MAMH(string MAMH)
        {
            return tk.TKTHONGKEKHO_XUATKHOMAMH(MAMH);
        }
        public IQueryable<TKNHANVIENResult> TKnhanvien(string TENNV, string BOPHAN)
        {
            return tk.TKNHANVIEN(TENNV, BOPHAN);
        }
        public IQueryable<TKNHANVIEN1Result> TKnhanvien1(string TENNV)
        {
            return tk.TKNHANVIEN1(TENNV);
        }
        public IQueryable<TKXUATKHOResult> TKxuatkho(int MAHD)
        {
            return tk.TKXUATKHO(MAHD);
        }
        public IQueryable<TKKHUYENMAINGAYResult> TKkhuyenmaingay(DateTime NGAY)
        {
            return tk.TKKHUYENMAINGAY(NGAY);
        }
        public IQueryable<TKMATHANGResult> TKmaThang(string TENMH,string LOAIMH)
        {
            return tk.TKMATHANG(TENMH,LOAIMH);
        }
        public IQueryable<TKMATHANG_LOAIMHResult> TKmaThangLoaiMH(string LOAIMH)
        {
            return tk.TKMATHANG_LOAIMH(LOAIMH);
        }
        public IQueryable<TKMATHANG_TENMHResult> TKmaThang_TenMH(string TENMH)
        {
            return tk.TKMATHANG_TENMH(TENMH);
        }
    }
}

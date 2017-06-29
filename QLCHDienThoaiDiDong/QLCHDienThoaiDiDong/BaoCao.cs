using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DAL;
using BAL;

namespace QLCHDienThoaiDiDong
{
    public partial class BaoCao : Form
    {
        DMChiTietHoaDon CTHD = new DMChiTietHoaDon();
        public BaoCao()
        {
            InitializeComponent();
        }
        public string PHANQUYEN { set; get; }
        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet11.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLCHDienThoaiDDDataSet11.HOADON);
            // TODO: This line of code loads data into the 'QLCHDienThoaiDDDataSet20.BAOHANH' table. You can move, or remove it, as needed.
            //this.BAOHANHTableAdapter.Fill(this.QLCHDienThoaiDDDataSet20.BAOHANH);
            // TODO: This line of code loads data into the 'QLCHDienThoaiDDDataSet18.CHITIETHOADON' table. You can move, or remove it, as needed.
            //this.CHITIETHOADONTableAdapter.Fill(this.QLCHDienThoaiDDDataSet18.CHITIETHOADON);
            //this.PHIEUNHAPTableAdapter.Fill(this.QLCHDienThoaiDDDataSet9.PHIEUNHAP);
           // this.TONKHOTableAdapter.Fill(this.QLCHDienThoaiDDDataSet19.TONKHO);
            //this.PHIEUTHUTableAdapter.Fill(this.QLCHDienThoaiDDDataSet21.PHIEUTHU);
            //this.PHIEUCHITableAdapter.Fill(this.QLCHDienThoaiDDDataSet21.PHIEUCHI);
            //this.PHIEUTRAGOPTableAdapter.Fill(this.QLCHDienThoaiDDDataSet22.PHIEUTRAGOP);
            //this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
            if(PHANQUYEN=="1")
            {
                pnBanHang.Visible = true;
                pnKyThuat.Visible = false;
                pnTraGop.Visible = false;
                panel3.Visible = false;
                rpvTragop.Visible = false;
                BanHang(dtpTungay.Value, dtpDenngay.Value);
                reportViewer1.RefreshReport();
                btnLoc.Visible = true;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
            }
            if(PHANQUYEN=="2")
            {
                pnKyThuat.Visible = true;
                pnTraGop.Visible = false;
                panel3.Visible = false;
                rpvTragop.Visible = false;
                KyThuat(dtpTungay.Value, dtpDenngay.Value);
                reportViewer2.RefreshReport();
                btnLoc.Visible = true;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
            }
            if(PHANQUYEN=="3")
            {
                pnTraGop.Visible = true;
                tooTragop.Visible = false;
                rpvTragop.Visible = true;
                btnLoc.Visible = true;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
            }
            if(PHANQUYEN=="4")
            {
                tsbchi.Visible = false;
                tsbthu.Visible = false;
                tsbNhapkho.Visible = true;
                tsbXuatkho.Visible = true;
                tsbTonkho.Visible = true;
                rpvTragop.Visible = false;
                btnLoc.Visible = true;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
            }
            if(PHANQUYEN=="6")
            {
                tsbchi.Visible = true;
                tsbthu.Visible = true;
                tsbNhapkho.Visible = false;
                tsbXuatkho.Visible = false;
                tsbTonkho.Visible = false;
                rpvTragop.Visible = false;
                btnLoc.Visible = true;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
                rpvChi.Visible = false;
                rpvNhapkho.Visible = false;
                rpvThu.Visible = true;
                rpvTonKho.Visible = false;
                rpvXuatKho.Visible = false;
                rpvNhapkho1.Visible = false;
                rpvTragop.Visible = false;
                btnloc1.Visible = false;
                btnloc2.Visible = false;
                btnLoc.Visible = true;
                QuyThu(dtpTungay.Value, dtpDenngay.Value);
                rpvThu.RefreshReport();
            }
            this.rpvXuatKho.RefreshReport();
            this.rpvXuatKho.RefreshReport();
            this.rpvXuatKho.RefreshReport();
            this.rpvTonKho.RefreshReport();
            this.rpvThu.RefreshReport();
            this.rpvChi.RefreshReport();
            this.rpvNhapkho1.RefreshReport();
            this.rpvTragop.RefreshReport();
            this.rpvTragop.RefreshReport();
        }
        private void BanHang(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[1] = new ReportParameter("DenNgay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void KyThuat(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("Tungay");
            rp[1] = new ReportParameter("Denngay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            reportViewer2.LocalReport.SetParameters(rp);
        }
        private void QuyThu(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[1] = new ReportParameter("DenNgay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            rpvThu.LocalReport.SetParameters(rp);
        }
        private void QuyChi(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[1] = new ReportParameter("DenNgay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            rpvChi.LocalReport.SetParameters(rp);
        }
        private void NhapKho(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[1] = new ReportParameter("DenNgay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            rpvNhapkho1.LocalReport.SetParameters(rp);
        }
        private void TonKho(int mamh)
        {
            ReportParameter[] rp = new ReportParameter[1];
            rp[0] = new ReportParameter("MaMH");
            rp[0].Values.Add(mamh.ToString());
            rpvTonKho.LocalReport.SetParameters(rp);
        }
        private void TraGop(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[1] = new ReportParameter("DenNgay");
            rp[0].Values.Add(tungay.ToString());
            rp[1].Values.Add(denngay.ToString());
            rpvNhapkho.LocalReport.SetParameters(rp);
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (PHANQUYEN == "1")
            {
                BanHang(dtpTungay.Value, dtpDenngay.Value);
                reportViewer1.RefreshReport();
            }
            if(PHANQUYEN=="2")
            {
                KyThuat(dtpTungay.Value, dtpDenngay.Value);
                reportViewer2.RefreshReport();
            }
            if(PHANQUYEN=="3")
            {

            }
            if(PHANQUYEN=="4")
            {
                NhapKho(dtpTungay.Value, dtpDenngay.Value);
                rpvNhapkho1.RefreshReport();
            }
            if(PHANQUYEN=="6")
            {
                QuyThu(dtpTungay.Value, dtpDenngay.Value);
                rpvThu.RefreshReport();
            }
        }

        private void tsbNhapkho_Click_1(object sender, EventArgs e)
        {
            rpvChi.Visible = false;
            rpvNhapkho.Visible = true;
            rpvThu.Visible = false;
            rpvTonKho.Visible = false;
            rpvXuatKho.Visible = false;
            rpvNhapkho1.Visible = true;
            rpvTragop.Visible = false;
            btnloc1.Visible = false;
            btnloc2.Visible = false;
            btnLoc.Visible = true;
            NhapKho(dtpTungay.Value, dtpDenngay.Value);
            rpvNhapkho1.RefreshReport();
        }

        private void tsbXuatkho_Click_1(object sender, EventArgs e)
        {
            rpvChi.Visible = false;
            rpvNhapkho.Visible = false;
            rpvThu.Visible = false;
            rpvTonKho.Visible = false;
            rpvXuatKho.Visible = true;
            rpvNhapkho1.Visible = false;
            rpvTragop.Visible = false;
            btnloc1.Visible = false;
            btnloc2.Visible = true ;
            btnLoc.Visible = false;
        }

        private void tsbTonkho_Click_1(object sender, EventArgs e)
        {
            rpvChi.Visible = false;
            rpvNhapkho.Visible = false;
            rpvThu.Visible = false;
            rpvTonKho.Visible = true;
            rpvXuatKho.Visible = false;
            rpvNhapkho1.Visible = false;
            rpvTragop.Visible = false;
            btnloc1.Visible = true;
            btnloc2.Visible = false;
            btnLoc.Visible = false;
           
        }

        private void tsbthu_Click_1(object sender, EventArgs e)
        {
            rpvChi.Visible = false;
            rpvNhapkho.Visible = false;
            rpvThu.Visible = true;
            rpvTonKho.Visible = false;
            rpvXuatKho.Visible = false;
            rpvNhapkho1.Visible = false;
            rpvTragop.Visible = false;
            btnloc1.Visible = false;
            btnloc2.Visible = false;
            btnLoc.Visible = true;
            QuyThu(dtpTungay.Value, dtpDenngay.Value);
            rpvThu.RefreshReport();
        }

        private void tsbchi_Click_1(object sender, EventArgs e)
        {
            rpvChi.Visible = true;
            rpvNhapkho.Visible = false;
            rpvThu.Visible = false;
            rpvTonKho.Visible = false;
            rpvXuatKho.Visible = false;
            rpvNhapkho1.Visible = false;
            rpvTragop.Visible = false;
            btnloc1.Visible = true;
            btnloc2.Visible = false;
            btnLoc.Visible = false;
            QuyChi(dtpTungay.Value, dtpDenngay.Value);
            rpvChi.RefreshReport();
        }

        private void btnloc1_Click(object sender, EventArgs e)
        {
            if (PHANQUYEN == "1")
            {
                BanHang(dtpTungay.Value, dtpDenngay.Value);
                reportViewer1.RefreshReport();
            }
            if (PHANQUYEN == "2")
            {
                KyThuat(dtpTungay.Value, dtpDenngay.Value);
                reportViewer2.RefreshReport();
            }
            if (PHANQUYEN == "3")
            {

            }
            if (PHANQUYEN == "4")
            {
                
            }
            if (PHANQUYEN == "6")
            {
                QuyChi(dtpTungay.Value, dtpDenngay.Value);
                rpvChi.RefreshReport();
            }
        }

        private void btnloc2_Click(object sender, EventArgs e)
        {

        }
    }
}

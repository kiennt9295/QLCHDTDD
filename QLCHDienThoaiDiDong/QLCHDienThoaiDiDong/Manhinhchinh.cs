using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace QLCHDienThoaiDiDong
{
    public partial class Manhinhchinh : Form
    {
        DMPhieuChi pc = new DMPhieuChi();
        DMPhieuThu pt = new DMPhieuThu();
        DMPhieuTraGop tg = new DMPhieuTraGop();
        DMBienLaiTraGop bl = new DMBienLaiTraGop();
        DMBaoHanh BH = new DMBaoHanh();
        public Manhinhchinh()
        {
            InitializeComponent();
        }
        private bool Existform(Form frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        public string MAQUYEN { set; get; }
        private void Manhinhchinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet10.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLCHDienThoaiDDDataSet10.HOADON);
                DangNhap fr = new DangNhap();
                fr.ShowDialog();
                tootaikhoan.Text = fr.TAIKHOAN;
                MAQUYEN = fr.MAQUYEN;
                if (MAQUYEN == "1")//ban hang
                {
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = true;
                    khoHàngToolStripMenuItem.Visible = false;
                    côngNợToolStripMenuItem.Visible = false;
                    quỹToolStripMenuItem.Visible = false;
                    nhânSựToolStripMenuItem.Visible = false;
                    quảnTrịToolStripMenuItem.Visible = false;
                    toolStripButtonTruycapnhanh.Visible = true;
                    mathangToolStripMenuItem.Visible = true;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = true;
                    kythuatToolStripMenuItem.Visible = false;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = false;
                    tsbmathang.Visible = true;
                    tsbKhachHang.Visible = true;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                }
                if (MAQUYEN == "2")//ky thuat
                {
                    Thongbaobaohanh();
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = false;
                    khoHàngToolStripMenuItem.Visible = false;
                    côngNợToolStripMenuItem.Visible = false;
                    quỹToolStripMenuItem.Visible = false;
                    nhânSựToolStripMenuItem.Visible = false;
                    quảnTrịToolStripMenuItem.Visible = false;
                    toolStripButtonTruycapnhanh.Visible = true;
                    mathangToolStripMenuItem.Visible = false;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = false;
                    kythuatToolStripMenuItem.Visible = true;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = false;
                    tsbmathang.Visible = false;
                    tsbKhachHang.Visible = false;
                    TSS1.Visible = false;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                    if (demthongbaobaohanh != 0)
                    {
                        Thongbaobaohanh frm = new Thongbaobaohanh();
                        frm.ShowDialog();
                    }
                }
                if (MAQUYEN == "3")//tra gop
                {
                    Thongbaotragop();
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = false;
                    khoHàngToolStripMenuItem.Visible = false;
                    côngNợToolStripMenuItem.Visible = true;
                    quỹToolStripMenuItem.Visible = false;
                    nhânSựToolStripMenuItem.Visible = false;
                    quảnTrịToolStripMenuItem.Visible = false;
                    toolStripButtonTruycapnhanh.Visible = true;
                    mathangToolStripMenuItem.Visible = true;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = false;
                    kythuatToolStripMenuItem.Visible = false;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = false;
                    tsbmathang.Visible = true;
                    tsbKhachHang.Visible = true;
                    TSS1.Visible = false;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                    if (demthongbaotragop != 0)
                    {
                        Thongbaotragop frm = new Thongbaotragop();
                        frm.ShowDialog();
                    }
                }
                if (MAQUYEN == "4")//kho
                {
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = false;
                    khoHàngToolStripMenuItem.Visible = true;
                    côngNợToolStripMenuItem.Visible = false;
                    quỹToolStripMenuItem.Visible = false;
                    nhânSựToolStripMenuItem.Visible = false;
                    quảnTrịToolStripMenuItem.Visible = false;
                    toolStripButtonTruycapnhanh.Visible = true;
                    mathangToolStripMenuItem.Visible = true;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = false;
                    kythuatToolStripMenuItem.Visible = false;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = false;
                    tsbmathang.Visible = true;
                    tsbKhachHang.Visible = false;
                    TSS2.Visible = false;
                    TSS1.Visible = false;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                }
                if (MAQUYEN == "5")//admin
                {
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = false;
                    khoHàngToolStripMenuItem.Visible = false;
                    côngNợToolStripMenuItem.Visible = false;
                    quỹToolStripMenuItem.Visible = false;
                    nhânSựToolStripMenuItem.Visible = true;
                    quảnTrịToolStripMenuItem.Visible = true;
                    toolStripButtonTruycapnhanh.Visible = true;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = false;
                    kythuatToolStripMenuItem.Visible = false;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = false;
                    tsbmathang.Visible = false;
                    tsbKhachHang.Visible = false;
                    TSS2.Visible = false;
                    TSS1.Visible = false;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                }
                if (MAQUYEN == "6")//admin
                {
                    hệThốngToolStripMenuItem.Visible = true;
                    banhangToolStripMenuItem.Visible = false;
                    khoHàngToolStripMenuItem.Visible = false;
                    côngNợToolStripMenuItem.Visible = false;
                    quỹToolStripMenuItem.Visible = true;
                    nhânSựToolStripMenuItem.Visible = false;
                    quảnTrịToolStripMenuItem.Visible = false;
                    toolStripButtonTruycapnhanh.Visible = true;
                    trợGiúpToolStripMenuItem.Visible = true;
                    tsbkhuyenmai.Visible = false;
                    kythuatToolStripMenuItem.Visible = false;
                    tsbbaocao.Visible = true;
                    tsbthongke.Visible = true;
                    tsbmathang.Visible = false;
                    tsbKhachHang.Visible = false;
                    TSS2.Visible = false;
                    TSS1.Visible = false;
                    TSS3.Visible = false;
                    TSS5.Visible = false;
                }
                Thu();
                Chi();
                Bienlai();
                Tragop();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            var frm = new Nhanvien2();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhacungcapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new NhaCungCap();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }
        private void lblnhacungcap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new NhaCungCap();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButtonTruycapnhanh_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbmathang_Click(object sender, EventArgs e)
        {
            var frm = new MatHang();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.QUYEN = MAQUYEN;
            frm.Show();
        }
        public string DEM { set; get; }
        private void ThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PhieuThuChi();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void taophieuthuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuThu1 frm = new PhieuThu1();
            frm.THEM = true;
            frm.MAPT = Demthu.ToString();
            frm.ShowDialog();
            Thu();
        }

        private void taophieuchiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuChi frm = new PhieuChi();
            frm.THEM1 = true;
            frm.MAPC = demchi.ToString();
            frm.ShowDialog();
            Chi();
        }
        private void BienlaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BienLaiTraGop();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbkhuyenmai_Click(object sender, EventArgs e)
        {
            var frm = new Khuyenmai();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchPhiếuTrảGópToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bienlaitragop2 frm = new Bienlaitragop2();
            frm.THEM = true;
            frm.MABL = dembienlai.ToString();
            frm.ShowDialog();
            Bienlai();
        }

        private void côngNợPhảiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieutragop1 frm = new Phieutragop1();
            frm.THEM = true;
            frm.MAPTG = demtragop.ToString();
            frm.ShowDialog();
            Tragop();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   this.panel1.Visible = false;
            var frm = new HoadonCTHD();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }
        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoPhan frm = new BoPhan();
            frm.ShowDialog();
        }
        private void nhapkhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.panel1.Visible = false;
            var frm = new Nhapkho();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.panel1.Visible = false;
            var frm = new Xuatkho();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tonkhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.panel1.Visible = false;
            var frm = new Tonkho();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void phieudathangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.panel1.Visible = false;
            var frm = new Phieudathang();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbthongke_Click(object sender, EventArgs e)
        {
            Thongke frm = new Thongke();
            frm.ShowDialog();
        }

        private void doimatkhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doimatkhau frm = new Doimatkhau();
            frm.ShowDialog();
        }
        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manhinhchinh frm = new Manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mathangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    this.panel1.Visible = false;
            var frm = new MatHang();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.QUYEN = MAQUYEN;
            frm.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlytaikhoan frm = new Quanlytaikhoan();
            frm.ShowDialog();
        }

        private void huongdanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huongdan frm = new Huongdan();
            frm.ShowDialog();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtinphanmem frm = new Thongtinphanmem();
            frm.ShowDialog();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.panel1.Visible = false;
            var frm = new Khachhang2();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void linkLabelkh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  this.panel1.Visible = false;
            var frm = new Khachhang2();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }
        public int Demthu { set; get; }
        void Thu()
        {
            gridPhieuthu.DataSource = pt.LayPhieuThu();
            int b = int.Parse(gridView3.RowCount.ToString());
            if (b == 0)
                Demthu = 1;
            else
                Demthu = int.Parse(gridView3.GetRowCellValue(b - 1, "MAPT").ToString())+1;
        }
        public int demchi { set; get; }
        void Chi()
        {
            gridPhieuchi.DataSource = pc.LayPhieuChi();
            int b = int.Parse(gridView1.RowCount.ToString());
            if (b == 0)
                demchi = 1;
            else
                demchi = int.Parse(gridView1.GetRowCellValue(b - 1, "MAPC").ToString()) + 1;
        }
        public int demtragop { set; get; }
        void Tragop()
        {
            gridTragop.DataSource = tg.LayPhieuTG();
            int b = int.Parse(gridView2.RowCount.ToString());
            if (b == 0)
                demtragop = 1;
            else
                demtragop = int.Parse(gridView2.GetRowCellValue(b - 1, "MAPTG").ToString()) + 1;
        }
        public int dembienlai { set; get; }
        void Bienlai()
        {
            gridBienlai.DataSource = bl.LayBienLaiTraGop();
            int b = int.Parse(gridView4.RowCount.ToString());
            if (b == 0)
                dembienlai = 1;
            else
                dembienlai = int.Parse(gridView4.GetRowCellValue(b - 1, "MABL").ToString()) + 1;
        }

        private void BaohanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Baohanh();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ThongbaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongbaobaohanh frm = new Thongbaobaohanh();
            frm.ShowDialog();
        }

        private void ThongbaotragopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thongbaotragop frm = new Thongbaotragop();
            frm.ShowDialog();
        }
        public int demthongbaobaohanh { set; get; }
        void Thongbaobaohanh()
        {
            gridthongbaobaohanh.DataSource = BH.Laythongbaobaohanh();
            demthongbaobaohanh = 0;
            demthongbaobaohanh = int.Parse(gVthongbaobaohanh.RowCount.ToString());
        }
        public int demthongbaotragop { set; get; }
        void Thongbaotragop()
        {
            gridthongbaotragop.DataSource = bl.Laythongbaotragop();
            demthongbaotragop = 0;
            demthongbaotragop = int.Parse(gvthongbaotragop.RowCount.ToString());
        }

        private void Manhinhchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát khỏi hệ thống.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (traloi == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void tsbKhachHang_Click(object sender, EventArgs e)
        {
            var frm = new Khachhang2();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbbaocao_Click(object sender, EventArgs e)
        {
            var frm = new BaoCao();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.PHANQUYEN = MAQUYEN;
            frm.Show();
        }
    }
}

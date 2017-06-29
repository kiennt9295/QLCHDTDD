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
using DevExpress.XtraGrid.Views.Grid;

namespace QLCHDienThoaiDiDong
{
    public partial class HoadonCTHD : Form
    {
        DMHoaDon HD = new DMHoaDon();
        DMChiTietHoaDon CTHD = new DMChiTietHoaDon();
        DMTimKiem timkiem = new DMTimKiem();
        DMKhachHang KH = new DMKhachHang();
        DMNhanVien NV = new DMNhanVien();
        DMMatHang MH = new DMMatHang();
        public int DEMHD1 { set; get; }
        public int DEMHD2 { set; get; }
        public int DEMCTHD1 { set; get; }
        public int DEMCTHD2 { set; get; }
        public HoadonCTHD()
        {
            InitializeComponent();
        }
        void LoadDataHD()
        {
            try
            {
                gridHD.DataSource = HD.LayHoaDon();
                DEMHD1 = int.Parse(gvhoadon.RowCount.ToString());
                if (DEMHD1 == 0)
                    DEMHD2 = 1;
                else
                    DEMHD2 = int.Parse(gvhoadon.GetRowCellValue(DEMHD1 - 1, "MAHD").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDataCTHD()
        {
            try
            {
                gridCTHD.DataSource = CTHD.LayCTHD();
                DEMCTHD1 = int.Parse(gvchitiethoadon.RowCount.ToString());
                if (DEMCTHD1 == 0)
                    DEMCTHD2 = 1;
                else
                    DEMCTHD2 = int.Parse(gvchitiethoadon.GetRowCellValue(DEMCTHD1 - 1, "MACTHD").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HoadonCTHD_Load(object sender, EventArgs e)
        {
            LoadDataHD();
            repositoryItemLookUpEdit1.DataSource = KH.LayKhachHang();
            repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
            repositoryItemLookUpEdit1.ValueMember = "MAKH";
            LoadDataCTHD();
            repositoryItemLookUpEdit4.DataSource = KH.LayKhachHang();
            repositoryItemLookUpEdit4.DisplayMember = "HOTEN";
            repositoryItemLookUpEdit4.ValueMember = "MAKH";
        }

        private void tsbxoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAHD = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString();
                    HD.XoaHoaDon(int.Parse(STRMAHD));
                    LoadDataHD();
                    MessageBox.Show("Hóa đơn đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa hóa đơn này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được hóa đơn này.", "Lỗi");
            }
        }

        private void tsbxoaCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa chi tiết hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMACTHD = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MACTHD").ToString();
                    CTHD.XoaCTHD(int.Parse(STRMACTHD));
                    LoadDataCTHD();
                    MessageBox.Show("Chi tiết hóa đơn đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa chi tiết hóa đơn này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được chi tiết hóa đơn này.", "Lỗi");
            }
        }

        private void tsbthemHD_Click(object sender, EventArgs e)
        {
            Hoadon frm = new Hoadon();
            frm.THEM = true;
            frm.MAHD = DEMHD2.ToString();
            frm.ShowDialog();
            LoadDataHD();
        }

        private void tsbsuaHD_Click(object sender, EventArgs e)
        {
            Hoadon frm = new Hoadon();
            frm.THEM = false;
            if (DEMHD1 == 0)
            {
                frm.MAHD = "";
                frm.ShowDialog();
            }
            else
            {
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD")!=null)
                    frm.MAHD = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString();
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "SOLUONG")!=null)
                    frm.SOLUONG =int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "SOLUONG").ToString());
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAKH")!=null)
                    frm.MAKH = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAKH").ToString();
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "NGAYLAP")!=null)
                    frm.NGAYLAP = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "NGAYLAP").ToString();
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MANV")!=null)
                    frm.MANV = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MANV").ToString();
                if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "TONGTIEN")!=null)
                    frm.TONGTIEN = float.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "TONGTIEN").ToString());
                frm.ShowDialog();
            }
            LoadDataHD();
        }

        private void tsbthemCTHD_Click(object sender, EventArgs e)
        {
            CTHD frm = new CTHD();
            frm.THEM = true;
            frm.MACTHD = DEMCTHD2.ToString();
            frm.SOLUONG = "1";
            frm.ShowDialog();
            LoadDataCTHD();
        }

        private void tsbsuaCTHD_Click(object sender, EventArgs e)
        {
            CTHD frm = new CTHD();
            frm.THEM = false;
            if (DEMCTHD1 == 0)
            {
                frm.MACTHD = "";
                frm.ShowDialog();
            }
            else
            {
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MACTHD")!=null)
                    frm.MACTHD = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MACTHD").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAHD") != null)
                    frm.MAHD = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAHD").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAMH") != null)
                    frm.MAMH = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAMH").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MANV") != null)
                    frm.MANV = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MANV").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "SOLUONG") != null)
                    frm.SOLUONG = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "SOLUONG").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "THANHTIEN") != null)
                    frm.THANHTIEN = float.Parse(gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "THANHTIEN").ToString());
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "DONVITINH") != null)
                    frm.DONVITINH = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "DONVITINH").ToString();
                if (gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAKH") != null)
                    frm.MAKH = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MAKH").ToString();
                frm.ShowDialog();
            }
            LoadDataCTHD();
        }

        private void tsbrefHD_Click(object sender, EventArgs e)
        {
            LoadDataHD();
        }

        private void tsbrefCTHD_Click(object sender, EventArgs e)
        {
            LoadDataCTHD();
        }

        private void gvchitiethoadon_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as GridView;

            string MACTHD;
            string MAHD;
            string MAMH;
            string MAKH;
            string MANV;
            string SOLUONG;
            string THANHTIEN;
            string DONVITINH;

            bool flagnew = false;
            bool flagold = false;
            if (view.IsNewItemRow(e.RowHandle))
            {
                MACTHD = view.GetRowCellValue(e.RowHandle, view.Columns[0]).ToString();
                MAHD = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
                MAMH = view.GetRowCellValue(e.RowHandle, view.Columns[2]).ToString();
                MAKH = view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString();
                MANV = view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString();
                SOLUONG = view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString();
                DONVITINH = view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString();
                THANHTIEN = view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString();
                flagnew = true;
            }
            else
            {
                MACTHD = view.GetRowCellValue(e.RowHandle, view.Columns[0]).ToString();
                MAHD = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
                MAMH = view.GetRowCellValue(e.RowHandle, view.Columns[2]).ToString();
                MAKH = view.GetRowCellValue(e.RowHandle, view.Columns[4]).ToString();
                MANV = view.GetRowCellValue(e.RowHandle, view.Columns[3]).ToString();
                SOLUONG = view.GetRowCellValue(e.RowHandle, view.Columns[5]).ToString();
                DONVITINH = view.GetRowCellValue(e.RowHandle, view.Columns[6]).ToString();
                THANHTIEN=view.GetRowCellValue(e.RowHandle, view.Columns[7]).ToString();
                flagold = true;

            }
            if (MessageBox.Show("Bạn thực sự lưu lại ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (flagnew == true)
                {
                    CTHD.ThemCTHD(int.Parse(MACTHD),int.Parse(MAHD),int.Parse(MAMH),int.Parse(MANV),int.Parse(MAKH),int.Parse(SOLUONG),DONVITINH,float.Parse(THANHTIEN));
                    MessageBox.Show("Thêm chi tiết hóa đơn mới thành công", "Thông báo");
                }
                if (flagold == true)
                {
                    CTHD.CapNhatCTHD(int.Parse(MACTHD), int.Parse(MAHD), int.Parse(MAMH), int.Parse(MANV), int.Parse(MAKH), int.Parse(SOLUONG), DONVITINH, float.Parse(THANHTIEN));
                    MessageBox.Show("Cập nhật chi tiết hóa đơn mới thành công", "Thông báo");
                }
                LoadDataCTHD();
            }
        }
    }
}

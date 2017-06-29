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
    public partial class Phieudathang : Form
    {
        DMPhieuDatHang PDH = new DMPhieuDatHang();
        DMTimKiem TK = new DMTimKiem();
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        public Phieudathang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridPhieuDH.DataSource = PDH.LayPhieuDH();
                DEM1=int.Parse(gridView1.RowCount.ToString());
                if (DEM1 == 0)
                    DEM2 = 1;
                else
                    DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MAPDH").ToString())+1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Phieudathang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet8.NHACUNGCAP' table. You can move, or remove it, as needed.
            //this.nHACUNGCAPTableAdapter.Fill(this.qLCHDienThoaiDDDataSet8.NHACUNGCAP);
            LoadData();
        }
        private void tsbThem_Click_1(object sender, EventArgs e)
        {
            Phieudathang1 frm = new Phieudathang1();
            frm.THEM = true;
            frm.MAPDH = DEM2.ToString();
            frm.CONNO = "0";
            frm.ShowDialog();
            LoadData();
        }

        private void tsbxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu đặt hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAPDH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPDH").ToString();
                    PDH.XoaPhieuDH(int.Parse(STRMAPDH));
                    LoadData();
                    MessageBox.Show("Phiếu đặt hàng đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu đặt hàng này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu đặt hàng này.", "Lỗi");
            }
        }

        private void tsbsua_Click_1(object sender, EventArgs e)
        {
            Phieudathang1 frm = new Phieudathang1();
            frm.THEM = false;
            if (DEM1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu đặt hàng để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPDH")!=null)
                    frm.MAPDH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPDH").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH") != null)
                    frm.MAMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANCC") != null)
                    frm.MANCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANCC").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV") != null)
                    frm.MANV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYDH") != null)
                    frm.NGAYDH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYDH").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG") != null)
                    frm.SOLUONG = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIANHAP") != null)
                    frm.GIANHAP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIANHAP").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DATRA") != null)
                    frm.DATRA = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DATRA").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CONNO") != null)
                    frm.CONNO = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CONNO").ToString();
                frm.ShowDialog();
            }
            LoadData();
        }

        private void tsbref_Click_1(object sender, EventArgs e)
        {
            LoadData();
            lueMaNCC.EditValue = null;
            lueMaNCC.Properties.NullText = "Chọn mã nhà cung cấp";
        }

        private void tsbIn_Click_1(object sender, EventArgs e)
        {
            gridPhieuDH.ShowRibbonPrintPreview();
        }

        private void trvtimkiem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                LoadData();
            }
            else if (thenode.Text == "Đã trả")
            {
                if (lueMaNCC.Text == "Chọn mã nhà cung cấp" || lueMaNCC.Text == "")
                    gridPhieuDH.DataSource = TK.TKphieudathangdatra();
                else
                    gridPhieuDH.DataSource = TK.TKphieudathang_datra(lueMaNCC.Text);
            }
            else
            {
                if (lueMaNCC.Text == "" || lueMaNCC.Text == "Chọn mã nhà cung cấp")
                    gridPhieuDH.DataSource = TK.TKphieudathangconno();
                else
                    gridPhieuDH.DataSource = TK.TKphieudathang_conno(lueMaNCC.Text);
            }
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }
        private void lueMaNCC_EditValueChanged_1(object sender, EventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (lueMaNCC.Text == "" || lueMaNCC.Text == "Chọn mã nhà cung cấp")
            {
                if (thenode.Text == "Tất cả")
                    LoadData();
                else if (thenode.Text == "Đã trả")
                    gridPhieuDH.DataSource = TK.TKphieudathangdatra();
                else
                    gridPhieuDH.DataSource = TK.TKphieudathangconno();
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridPhieuDH.DataSource = TK.TKphieudathang_nhacc(lueMaNCC.Text);
                else if (thenode.Text == "Đã trả")
                    gridPhieuDH.DataSource = TK.TKphieudathang_datra(lueMaNCC.Text);
                else
                    gridPhieuDH.DataSource = TK.TKphieudathang_conno(lueMaNCC.Text);
            }
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }

        private void lueMaNCC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueMaNCC.EditValue = null;
                lueMaNCC.Properties.NullText = "Chọn mã nhà cung cấp";
            }
        }
    }
}

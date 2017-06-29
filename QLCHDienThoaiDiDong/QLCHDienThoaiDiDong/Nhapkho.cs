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
    public partial class Nhapkho : Form
    {
        DMPhieuNhap NK = new DMPhieuNhap();
        DMTimKiem TK = new DMTimKiem();
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        public Nhapkho()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridNhapkho.DataSource = NK.LayPhieuChi();
                DEM1 = int.Parse(gridView1.RowCount.ToString());
                if (DEM1 == 0)
                    DEM2 = 1;
                else
                {
                    DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MAPN").ToString()) + 1;
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Nhapkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
           // this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            LoadData();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            Nhapkho1 frm = new Nhapkho1();
            frm.THEM = true;
            frm.MAPN = DEM2.ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            Nhapkho1 frm = new Nhapkho1();
            frm.THEM = false;
            if (DEM1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn Phiếu nhập để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPN")!=null)
                    frm.MAPN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPN").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH") != null)
                    frm.MAMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV") != null)
                    frm.MANV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYNHAP") != null)
                    frm.NGAYNHAP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYNHAP").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG") != null)
                    frm.SOLUONG = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
                frm.ShowDialog();
            }
            LoadData();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu nhập này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAPN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPN").ToString();
                    NK.XoaPhieuNhap(int.Parse(STRMAPN));
                    LoadData();
                    MessageBox.Show("Phiếu nhập đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu nhập này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu nhập này.", "Lỗi");
            }
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadData();
            luetimkiem.ResetText();
            txtNgaytu.Text="Chọn ngày";
            txtngayden.Text="Chọn ngày";
            LoadData();
        }

        private void dtptungay_ValueChanged(object sender, EventArgs e)
        {
            txtNgaytu.Text=dtptungay.Value.ToString("dd/MM/yyyy");
            if (txtNgaytu.Text == "Chọn ngày" || txtngayden.Text == "Chọn ngày")
            {
                if (luetimkiem.Text == "" || luetimkiem.Text == "Tìm kiếm")
                    LoadData();
                else
                    gridNhapkho.DataSource = TK.TKnhapkho_mathang(luetimkiem.Text);
            }
            else
            {
                if (luetimkiem.Text == "" || luetimkiem.Text == "Tìm kiếm")
                    gridNhapkho.DataSource = TK.TKnhapkho_ngay(DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
                else
                    gridNhapkho.DataSource = TK.TKnhapkho(luetimkiem.Text, DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
            }
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }

        private void dtpDenngay_ValueChanged(object sender, EventArgs e)
        {
            txtngayden.Text = dtpDenngay.Value.ToString("dd/MM/yyyy");
            if (txtNgaytu.Text == "Chọn ngày" || txtngayden.Text == "Chọn ngày")
            {
                if (luetimkiem.Text == "" || luetimkiem.Text == "Tìm kiếm")
                    LoadData();
                else
                    gridNhapkho.DataSource = TK.TKnhapkho_mathang(luetimkiem.Text);
            }
            else
            {
                if (luetimkiem.Text == "" || luetimkiem.Text == "Tìm kiếm")
                    gridNhapkho.DataSource = TK.TKnhapkho_ngay(DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
                else
                    gridNhapkho.DataSource = TK.TKnhapkho(luetimkiem.Text, DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
            }
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }
        private void tsbin_Click(object sender, EventArgs e)
        {
            gridNhapkho.ShowRibbonPrintPreview();
        }

        private void luetimkiem_EditValueChanged_1(object sender, EventArgs e)
        {
            if (luetimkiem.Text == ""||luetimkiem.Text=="Tìm kiếm")
            {
                if (txtNgaytu.Text == "Chọn ngày" && txtngayden.Text == "Chọn ngày")
                    gridNhapkho.DataSource = NK.LayPhieuChi();
                else
                    gridNhapkho.DataSource = TK.TKnhapkho(luetimkiem.Text, DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
            }
            else
            {
                if (txtNgaytu.Text == "Chọn ngày" && txtngayden.Text == "Chọn ngày")
                    gridNhapkho.DataSource = TK.TKnhapkho_mathang(luetimkiem.Text);
                else
                    gridNhapkho.DataSource = TK.TKnhapkho(luetimkiem.Text, DateTime.Parse(dtptungay.Text), DateTime.Parse(dtpDenngay.Text));
            }
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }

        private void luetimkiem_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luetimkiem.EditValue = null;
                luetimkiem.Properties.NullText = "Tìm Kiếm";
            }
        }
    }
}

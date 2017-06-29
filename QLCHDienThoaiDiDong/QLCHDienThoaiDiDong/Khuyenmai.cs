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
    public partial class Khuyenmai : Form
    {
        DMKhuyenMai km = new DMKhuyenMai();
        DMTimKiem timkiem = new DMTimKiem();
        public Khuyenmai()
        {
            InitializeComponent();
        }
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        void LoadData()
        {
            try
            {
                gridKhuyenmai.DataSource = km.LayKhuyenMai();
                DEM1 = int.Parse(gridView1.RowCount.ToString());
                if (DEM1 == 0)
                    DEM2 = 1;
                else
                    DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MAKM").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng khuyến mãi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Khuyenmai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            Khuyenmai1 frm = new Khuyenmai1();
            frm.THEM = true;
            frm.MAKM = DEM2.ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            Khuyenmai1 frm = new Khuyenmai1();
            frm.THEM = false;
            if (DEM1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khuyến mãi cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm.MAKM = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKM").ToString();
                frm.THONGTIN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "THONGTIN").ToString();
                frm.GIATRI = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIATRI").ToString();
                frm.NGAYBATDAU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYBATDAU").ToString();
                frm.NGAYKETTHUC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYKETTHUC").ToString();
                frm.GHICHU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GHICHU").ToString();
                frm.ShowDialog();
            }
            LoadData();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa khuyến mãi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAKM = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKM").ToString();
                    km.XoaKhuyenMai(int.Parse(STRMAKM));
                    LoadData();
                    MessageBox.Show("Khuyến mãi đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa khuyến mãi này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được khuyến mãi này.", "Lỗi");
            }
        }

        private void dtngay_ValueChanged(object sender, EventArgs e)
        {
            gridKhuyenmai.DataSource = timkiem.TKkhuyenmaingay(DateTime.Parse(dtngay.Text));
            DEM1 = int.Parse(gridView1.RowCount.ToString());
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

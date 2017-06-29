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
    public partial class PhieuThuChi : Form
    {
        DMPhieuChi pc = new DMPhieuChi();
        DMPhieuThu pt = new DMPhieuThu();
        DMNhanVien Nv = new DMNhanVien();
        DMTimKiem tk = new DMTimKiem();
        public int DEMPT1 { set; get; }
        public int DEMPT2 { set; get; }
        public int DEMPC1 { set; get; }
        public int DEMPC2 { set; get; }
        public string DEM1 { set; get; }
        public PhieuThuChi()
        {
            InitializeComponent();
        }
        public void LoadDataPT()
        {
            try
            {
                gridPhieuthu.DataSource = pt.LayPhieuThu();
                DEMPT1 = int.Parse(gridView1.RowCount.ToString());
                if (DEMPT1 == 0)
                    DEMPT2 = 1;
                else
                {
                    DEMPT2 = int.Parse(gridView1.GetRowCellValue(DEMPT1 - 1, "MAPT").ToString()) + 1;
                }
                repositoryItemLookUpEdit1.DataSource = Nv.LayNhanVien();
                repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit1.ValueMember = "MANV";
                DEM1 = DEMPT2.ToString();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu thừ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void LoadDataPC()
        {
            try
            {
                gridphieuchi.DataSource = pc.LayPhieuChi();
                DEMPC1 = int.Parse(gridView2.RowCount.ToString());
                if (DEMPC1 == 0)
                    DEMPC2 = 1;
                else
                {
                    DEMPC2 = int.Parse(gridView2.GetRowCellValue(DEMPC1 - 1, "MAPC").ToString()) + 1;
                }
                repositoryItemLookUpEdit2.DataSource = Nv.LayNhanVien();
                repositoryItemLookUpEdit2.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit2.ValueMember = "MANV";
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu tỪ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PhieuThuChi_Load(object sender, EventArgs e)
        {
            LoadDataPT();
            LoadDataPC();
        }

        private void tsbthem1_Click(object sender, EventArgs e)
        {
            PhieuThu1 frm = new PhieuThu1();
            frm.THEM = true;
            frm.MAPT = DEMPT2.ToString();
            frm.ShowDialog();
            LoadDataPT();
        }

        private void tsbsua1_Click(object sender, EventArgs e)
        {
            PhieuThu1 frm = new PhieuThu1();
            frm.THEM = false;
            if (DEMPT1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu thu để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPT")!=null)
                    frm.MAPT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPT").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LYDOTHU") != null)
                    frm.LYDOTHU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LYDOTHU").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGUOINOPTIEN") != null)
                    frm.NGUOINOPTIEN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGUOINOPTIEN").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIEN") != null)
                    frm.SOTIEN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIEN").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GHICHU") != null)
                    frm.GHICHU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GHICHU").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTHU") != null)
                    frm.NGAY = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTHU").ToString();
                frm.ShowDialog();
            }
            LoadDataPT();
        }

        private void tsbxoa1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu thu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAPT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPT").ToString();
                    pt.XoaPhieuThu(int.Parse(STRMAPT));
                    LoadDataPT();
                    MessageBox.Show("Phiếu thu đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu thu này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu thu này.", "Lỗi");
            }
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            PhieuChi frm = new PhieuChi();
            frm.THEM1 = true;
            frm.MAPC = DEMPC2.ToString();
            frm.ShowDialog();
            LoadDataPC();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            PhieuChi frm = new PhieuChi();
            frm.THEM1 = false;
            if (DEMPC1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu chi để cập nhật thông tin mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPC") != null)
                    frm.MAPC = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPC").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LYDOCHI") != null)
                    frm.LYDOCHI = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LYDOCHI").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGUOINHAN") != null)
                    frm.NGUOINHAN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGUOINHAN").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOTIEN") != null)
                    frm.SOTIEN1 = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOTIEN").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GHICHU") != null)
                    frm.GHICHU1 = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GHICHU").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYCHI") != null)
                    frm.NGAY1 = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYCHI").ToString();
                frm.ShowDialog();
            }
            LoadDataPC();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu CHI này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAPC = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPC").ToString();
                    pc.XoaPhieuChi(int.Parse(STRMAPC));
                    LoadDataPC();
                    MessageBox.Show("Phiếu chi đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu chi này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu chi này.", "Lỗi");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "")
            {
                gridPhieuthu.DataSource = tk.TKphieuthu(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
                gridphieuchi.DataSource = tk.TKphieuchi(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
            }
            else
            {
                gridPhieuthu.DataSource = tk.TKphieuthu(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
                gridphieuchi.DataSource = tk.TKphieuchi(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
            }
            DEMPT1 = int.Parse(gridView1.RowCount.ToString());
            DEMPC1 = int.Parse(gridView2.RowCount.ToString());
        }

        private void dtpNgayden_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayden.Text == "")
            {
                gridPhieuthu.DataSource = tk.TKphieuthu(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
                gridphieuchi.DataSource = tk.TKphieuchi(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
            }
            else
            {
                gridPhieuthu.DataSource = tk.TKphieuthu(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
                gridphieuchi.DataSource = tk.TKphieuchi(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dtpNgayden.Text));
            }
            DEMPT1 = int.Parse(gridView1.RowCount.ToString());
            DEMPC1 = int.Parse(gridView2.RowCount.ToString());
        }

        private void gridphieuchi_Click(object sender, EventArgs e)
        {

        }

        private void tsbrefphieuthu_Click(object sender, EventArgs e)
        {
            LoadDataPT();
        }

        private void tsbrefphieuchi_Click(object sender, EventArgs e)
        {
            LoadDataPC();
        }

        private void tsbinphieuthu_Click(object sender, EventArgs e)
        {
            gridPhieuthu.ShowRibbonPrintPreview();
        }

        private void tsbinphieuchi_Click(object sender, EventArgs e)
        {
            gridphieuchi.ShowRibbonPrintPreview();
        }
    }
}

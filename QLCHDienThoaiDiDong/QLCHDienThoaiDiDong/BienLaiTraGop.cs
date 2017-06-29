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
    public partial class BienLaiTraGop : Form
    {
        DMBienLaiTraGop bL = new DMBienLaiTraGop();
        DMPhieuTraGop ptg = new DMPhieuTraGop();
        DMMatHang mh = new DMMatHang();
        DMKhachHang kh = new DMKhachHang();
        DMTimKiem TK = new DMTimKiem();
        public BienLaiTraGop()
        {
            InitializeComponent();
        }
        public int DEMBL1 { set; get; }
        public int DEMBL2 { set; get; }
        public int DEMTG1 { set; get; }
        public int DEMTG2 { set; get; }
        private void tsbthem1_Click(object sender, EventArgs e)
        {
            Bienlaitragop2 frm = new Bienlaitragop2();
            frm.THEM = true;
            frm.MABL = DEMBL2.ToString();
            frm.ShowDialog();
            LoadDatabienlai();
        }
        public int c { set; get; }
        public int c1 { set; get; }
        void Tongtien()
        {
            int b = int.Parse(gvPhieutragop.RowCount.ToString());
            c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + int.Parse(gvPhieutragop.GetRowCellValue(i, "TONGTIEN").ToString());
            }
            lbltongtien.Text = c.ToString();
            int c2 = c - c1;
            lblconno.Text = c2.ToString();
        }
        void Datra()
        {
            int b1 = int.Parse(gvBienlai.RowCount.ToString());
            c1 = 0;
            for (int i = 0; i < b1; i++)
            {
                c1 = c1 + int.Parse(gvBienlai.GetRowCellValue(i, "SOTIEN").ToString());
            }
            lbldatra.Text = c1.ToString();
            int c2 = c - c1;
            lblconno.Text = c2.ToString();
        }
        void LoadDataphieu()
        {
            try
            {
                gridphieu.DataSource = ptg.LayPhieuTG();
                repositoryItemLookUpEdit4.DataSource = kh.LayKhachHang();
                repositoryItemLookUpEdit4.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit4.ValueMember = "MAKH";
                DEMTG1 = int.Parse(gvPhieutragop.RowCount.ToString());
                if (DEMTG1 == 0)
                    DEMTG2 = 1;
                else
                {
                    DEMTG2 = int.Parse(gvPhieutragop.GetRowCellValue(DEMTG1 - 1, "MAPTG").ToString()) + 1;
                }
                Tongtien();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDatabienlai()
        {
            try
            {
                gridbienlai.DataSource = bL.LayBienLaiTraGop();
                DEMBL1 = int.Parse(gvBienlai.RowCount.ToString());
                repositoryItemLookUpEdit1.DataSource = kh.LayKhachHang();
                repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit1.ValueMember = "MAKH";
                if (DEMBL1 == 0)
                    DEMBL2 = 1;
                else
                {
                    DEMBL2 = int.Parse(gvBienlai.GetRowCellValue(DEMBL1 - 1, "MABL").ToString()) + 1;
                }
                Datra();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbthem_Click_1(object sender, EventArgs e)
        {
            Phieutragop1 frm = new Phieutragop1();
            frm.THEM = true;
            frm.MAPTG = DEMTG2.ToString();
            frm.LAISUAT = "0";
            frm.ShowDialog();
            LoadDataphieu();
        }

        private void BienLaiTraGop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet6.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet6.KHACHHANG);
            LoadDataphieu();
            LoadDatabienlai();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu trả góp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAPTG = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG").ToString();
                    ptg.XoaPhieuTG(int.Parse(STRMAPTG));
                    LoadDataphieu();
                    MessageBox.Show("Phiếu trả góp đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu trả góp này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu trả góp này.", "Lỗi");
            }
        }

        private void tsbxoa1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa biên lai này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABL = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL").ToString();
                    bL.XoaBienLaiTraGop(int.Parse(STRMABL));
                    LoadDatabienlai();
                    MessageBox.Show("Biên lai đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa Biên lai này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được biên lai này.", "Lỗi");
            }
        }

        private void tsbref1_Click(object sender, EventArgs e)
        {
            LoadDatabienlai();
            luePTG.EditValue = null;
            luePTG.Properties.NullText = "Chọn mã khách hàng";
        }

        private void tsbsua1_Click(object sender, EventArgs e)
        {
            Bienlaitragop2 frm = new Bienlaitragop2();
            frm.THEM = false;
            if (DEMBL1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn Biên lai để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL") != null)
                    frm.MABL = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MANV") != null)
                    frm.MANV =int.Parse(gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MANV").ToString());
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "NGAYLAP") != null)
                    frm.NGAY = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "NGAYLAP").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MAKH") != null)
                    frm.MAKH = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MAKH").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "SOTIEN") != null)
                    frm.SOTIEN = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "SOTIEN").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "GHICHU") != null)
                    frm.GHICHU = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "GHICHU").ToString();
                frm.ShowDialog();
            }
            LoadDatabienlai();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            Phieutragop1 frm = new Phieutragop1();
            frm.THEM = false;
            if (DEMTG1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu trả góp để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG")!=null)
                    frm.MAPTG = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MANV") != null)
                    frm.MANV = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MANV").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH") != null)
                    frm.MAKH = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAMH") != null)
                    frm.MAMH = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAMH").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "CMND") != null)
                    frm.CMND = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "CMND").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "NGAYLAP") != null)
                    frm.NGAYLAP = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "NGAYLAP").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "TONGTIEN") != null)
                    frm.TONGTIEN = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "TONGTIEN").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "LAISUAT") != null)
                    frm.LAISUAT = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "LAISUAT").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "HANTRA") != null)
                    frm.HANTRA = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "HANTRA").ToString();
                frm.ShowDialog();
            }
            LoadDataphieu();
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadDataphieu();
            luePTG.EditValue = null;
            luePTG.Properties.NullText = "Chọn mã khách hàng";
        }
        private void tsbinBienlai_Click(object sender, EventArgs e)
        {
            gridbienlai.ShowRibbonPrintPreview();
        }

        private void tsbintragop_Click(object sender, EventArgs e)
        {
            gridphieu.ShowRibbonPrintPreview();
        }

        private void luePTG_EditValueChanged(object sender, EventArgs e)
        {
            if (luePTG.Text == "" || luePTG.Text == "Chọn mã khách hàng")
            {
                LoadDataphieu();
                LoadDatabienlai();
            }
            else
            {
                gridphieu.DataSource = TK.TKtragop(luePTG.Text.Trim());
                Tongtien();
                gridbienlai.DataSource = TK.TKbienlaitragop(luePTG.Text.Trim());
                Datra();
            }
            DEMTG1 = int.Parse(gvPhieutragop.RowCount.ToString());
            DEMBL1 = int.Parse(gvBienlai.RowCount.ToString());
        }

        private void luePTG_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luePTG.EditValue = null;
                luePTG.Properties.NullText = "Chọn mã khách hàng";
            }
        }

    }
}

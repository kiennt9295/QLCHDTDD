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
    public partial class Thongkekho : Form
    {
        DMThongke tk = new DMThongke();
        DMTimKiem timkiem = new DMTimKiem();
        public Thongkekho()
        {
            InitializeComponent();
        }
        void LoadDatanhap()
        {
            try
            {
                gridNhap.DataSource = tk.Laythongkenhapkho();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDataxuat()
        {
            try
            {
                gridXuat.DataSource = tk.Laythongkexuatkho();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void soluongnhap()
        {
            int b = int.Parse(gridView1.RowCount.ToString());
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + int.Parse(gridView1.GetRowCellValue(i, "SOLUONGNHAP").ToString());
            }
            lblslnhap.Text = c.ToString();
        }
        void soluongxuat()
        {
            int b1 = int.Parse(gridView2.RowCount.ToString());
            int c1 = 0;
            for (int i = 0; i < b1; i++)
            {
                c1 = c1 + int.Parse(gridView2.GetRowCellValue(i, "SOLUONGXUAT").ToString());
            }
            lblslxuat.Text = c1.ToString();
        }
        private void Thongkekho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            LoadDatanhap();
            soluongnhap();
            LoadDataxuat();
            soluongxuat();
        }

        private void tsbref1_Click(object sender, EventArgs e)
        {
            LoadDatanhap();
            soluongnhap();
            txtTungay.Text = "Chọn ngày";
            txtNgayden.Text = "Chọn ngày";
            lueMaMH.EditValue = null;
            lueMaMH.Properties.NullText = "Chọn mã mặt hàng";
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadDataxuat();
            soluongxuat();
            txtTungay.Text = "Chọn ngày";
            txtNgayden.Text = "Chọn ngày";
            lueMaMH.EditValue = null;
            lueMaMH.Properties.NullText = "Chọn mã mặt hàng";
        }

        private void dtpNgay1_ValueChanged(object sender, EventArgs e)
        {
            txtTungay.Text = dtpNgay1.Value.ToString("dd/MM/yyyy");
            if(txtTungay.Text=="Chọn ngày" || txtNgayden.Text=="Chọn ngày")
            {
                if(lueMaMH.Text=="Chọn mã mặt hàng")
                {
                    LoadDatanhap();
                    LoadDataxuat();
                }
                else
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho_MAMH(lueMaMH.Text);
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho_MAMH(lueMaMH.Text);
                    soluongxuat();
                }
            }
            else
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho_NGAY(DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho_NGAY(DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
                else
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho(lueMaMH.Text,DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho(lueMaMH.Text,DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
            }
        }
        private void dtpngay2_ValueChanged(object sender, EventArgs e)
        {
            txtNgayden.Text = dtpngay2.Value.ToString("dd/MM/yyyy");
            if(txtTungay.Text=="Chọn ngày" || txtNgayden.Text=="Chọn ngày")
            {
                if(lueMaMH.Text=="Chọn mã mặt hàng")
                {
                    LoadDatanhap();
                    LoadDataxuat();
                }
                else
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho_MAMH(lueMaMH.Text);
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho_MAMH(lueMaMH.Text);
                    soluongxuat();
                }
            }
            else
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho_NGAY(DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho_NGAY(DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
                else
                {
                    gridNhap.DataSource=timkiem.TKThongkenhapkho(lueMaMH.Text,DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource=timkiem.TKThongkexuatkho(lueMaMH.Text,DateTime.Parse(dtpNgay1.Text),DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
            }
        }

        private void lueMaMH_EditValueChanged(object sender, EventArgs e)
        {
            if(lueMaMH.Text=="Chọn mã mặt hàng")
            {
                if(txtTungay.Text=="Chọn ngày"||txtNgayden.Text=="Chọn ngày")
                {
                    LoadDatanhap();
                    LoadDataxuat();
                }
                else
                {
                    gridNhap.DataSource = timkiem.TKThongkenhapkho_NGAY(DateTime.Parse(dtpNgay1.Text), DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource = timkiem.TKThongkexuatkho_NGAY(DateTime.Parse(dtpNgay1.Text), DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
            }
            else
            {
                if(txtTungay.Text=="Chọn ngày"||txtNgayden.Text=="Chọn ngày")
                {
                    gridNhap.DataSource = timkiem.TKThongkenhapkho_MAMH(lueMaMH.Text);
                    soluongnhap();
                    gridXuat.DataSource = timkiem.TKThongkexuatkho_MAMH(lueMaMH.Text);
                    soluongxuat();
                }
                else
                {
                    gridNhap.DataSource = timkiem.TKThongkenhapkho(lueMaMH.Text, DateTime.Parse(dtpNgay1.Text), DateTime.Parse(dtpngay2.Text));
                    soluongnhap();
                    gridXuat.DataSource = timkiem.TKThongkexuatkho(lueMaMH.Text, DateTime.Parse(dtpNgay1.Text), DateTime.Parse(dtpngay2.Text));
                    soluongxuat();
                }
            }
        }

        private void lueMaMH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueMaMH.EditValue = null;
                lueMaMH.Properties.NullText = "Chọn mã mặt hàng";
            }
        }
    }
}

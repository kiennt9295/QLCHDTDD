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
    public partial class Thongkebanhang : Form
    {
        DMThongke tk = new DMThongke();
        DMTimKiem TimKiem = new DMTimKiem();
        public Thongkebanhang()
        {
            InitializeComponent();
        }

        void LoadDataNgay()
        {
            try
            {
                gridTheongay.DataSource = tk.LayThongkebanhang();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void LoadDataSP()
        {
            try
            {
                gridSanpham.DataSource = tk.Layhangbanchay();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Banhang()
        {
            int b = int.Parse(gridView1.RowCount.ToString());
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + int.Parse(gridView1.GetRowCellValue(i, "TONGTIENBAN").ToString());
            }
            lbltongtien.Text = c.ToString();
        }
        void Hangbanchay()
        {
            int b1 = int.Parse(gridView2.RowCount.ToString());
            int c1 = 0;
            for (int i = 0; i < b1; i++)
            {
                c1 = c1 + int.Parse(gridView2.GetRowCellValue(i, "SOLUONGBAN").ToString());
            }
            lbltongsl.Text = c1.ToString();
        }
        private void Thongkebanhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            LoadDataNgay();
            Banhang();
            LoadDataSP();
            Hangbanchay();
        }

        private void tsbref1_Click(object sender, EventArgs e)
        {
            LoadDataNgay();
            Banhang();
            txtNgaytu.Text = "Chọn ngày";
            txtngayden.Text = "Chọn ngày";
        }

        private void tsbref2_Click(object sender, EventArgs e)
        {
            LoadDataSP();
            Hangbanchay();
            lueMaMH.EditValue = null;
            lueMaMH.Properties.NullText = "Chọn mã mặt hàng";
        }
        private void dtpNGAY1_ValueChanged(object sender, EventArgs e)
        {
            txtNgaytu.Text = dtpNGAY1.Value.ToString("dd/MM/yyyy");
            if(txtNgaytu.Text=="Chọn ngày" || txtngayden.Text=="Chọn ngày")
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    LoadDataNgay();
                    Banhang();
                    LoadDataSP();
                    Hangbanchay();
                }
                else
                {
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_MAMH(lueMaMH.Text);
                    Hangbanchay();
                    LoadDataNgay();
                    Banhang();
                }
            }
            else
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    gridTheongay.DataSource = TimKiem.TKthongkebanhang_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Banhang();
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Hangbanchay();
                }
                else
                {
                    gridTheongay.DataSource = TimKiem.TKthongkebanhang_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Banhang();
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay(lueMaMH.Text, DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Hangbanchay();
                }
            }
        }

        private void dtpNGAY2_ValueChanged(object sender, EventArgs e)
        {
            txtngayden.Text = dtpNGAY2.Value.ToString("dd/MM/yyyy");
            if (txtNgaytu.Text == "Chọn ngày" || txtngayden.Text == "Chọn ngày")
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    LoadDataNgay();
                    Banhang();
                    LoadDataSP();
                    Hangbanchay();
                }
                else
                {
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_MAMH(lueMaMH.Text);
                    LoadDataNgay();
                    Banhang();
                    Hangbanchay();
                }
            }
            else
            {
                if (lueMaMH.Text == "Chọn mã mặt hàng")
                {
                    gridTheongay.DataSource = TimKiem.TKthongkebanhang_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Banhang();
                    Hangbanchay();
                }
                else
                {
                    gridTheongay.DataSource = TimKiem.TKthongkebanhang_NGAY(DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay(lueMaMH.Text, DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Banhang();
                    Hangbanchay();
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

        private void lueMaMH_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaMH.Text == "Chọn mã mặt hàng")
            {
                if (txtNgaytu.Text == "Chọn ngày" || txtngayden.Text == "Chọn ngày")
                {
                    LoadDataSP();
                    Hangbanchay();
                }
                else
                {
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_NGAY(DateTime.Parse(dtpNGAY1.Text),DateTime.Parse(dtpNGAY2.Text));
                    Hangbanchay();
                }
            }
            else
            {
                if (txtNgaytu.Text == "Chọn ngày" || txtngayden.Text == "Chọn ngày")
                {
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay_MAMH(lueMaMH.Text);
                    Hangbanchay();
                }
                else
                {
                    gridSanpham.DataSource = TimKiem.TKthongkehangbanchay(lueMaMH.Text, DateTime.Parse(dtpNGAY1.Text), DateTime.Parse(dtpNGAY2.Text));
                    Hangbanchay();
                }
            }
        }
    }
}
